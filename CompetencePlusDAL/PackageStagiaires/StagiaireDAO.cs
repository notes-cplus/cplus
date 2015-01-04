using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using CompetencePlus.Outils;
using CompetencePlus.PackageFilieres;
using CompetencePlus.Tools;

namespace CompetencePlus.PackageStagiaires
{
    public class StagiaireDAO : IGestion<Stagiaire>
    {
        public  int Add(Stagiaire s)
        {
            string Requete = "insert into stagiaires(Nom,Prenom,DateNaissance,sexe,Cin,Email,Telephone,Adress,ProfilImage,Etat,Filiere_id) values ('" +
                s.Nom + "','" + s.Prenom + "','" + s.DateNaissance + "'," + 1 + ",'" + s.Cin + "','" + s.Email + "','" + s.Telephone + "','" + s.Adresse + "','" +
                s.ProfilImage + "'," + s.Etat +","+s.Filiere.Id+")";
 
            return MyConnection.ExecuteNonQuery(Requete);
        }
        public int Update(Stagiaire s)
        {
            String Requete = "Update Stagiaires set Nom='"+s.Nom+"',Prenom='"+s.Prenom+"',DateNaissance='"+s.DateNaissance+"',Sexe="+s.Sexe+
                ",Cin='"+s.Cin+"',Email='"+s.Email+"',Telephone ='"+s.Telephone+"',Adresse='"+s.Adresse+"',Images = '"+s.ProfilImage+"',Filiere_id="+s.Filiere.Id+" where id="+s.Id;
            return MyConnection.ExecuteNonQuery(Requete);
        }

        public  void UpdateStat(int id)
        {
            String Requete = "Update Stagiaires set Etat= 1 where id =" + id;
            MyConnection.ExecuteNonQuery(Requete);
        }

        public  int Delete(int id)
        {
            String Requete = "Delete from Stagiaires where id =" + id;
            return MyConnection.ExecuteNonQuery(Requete);
        }

        public  List<Stagiaire> Select()
        {
            List<Stagiaire> ListStagiaires = new List<Stagiaire>();
            String Requete = "Select * from Stagiaires where etat =1";
            OleDbDataReader read = MyConnection.ExecuteReader(Requete);
            while (read.Read())
            {
                Stagiaire s = new Stagiaire();
                s.Id = read.GetInt32(0);
                s.Filiere = new FiliereDAO().FindById(read.GetInt32(1));
                s.Nom = (string) read["Nom"];
                s.Prenom = (string)read["Prenom"];
                s.DateNaissance = (DateTime)read["DateNaissance"];
                s.Sexe = read.GetBoolean(5);
                s.Cin = read.GetString(6);
                s.Email = read.GetString(7);
                s.Telephone = read.GetString(8);
                s.Adresse = read.GetString(9);
                s.ProfilImage = read.GetString(10);
                s.Etat = read.GetInt32(11);
                ListStagiaires.Add(s);


            }


            return ListStagiaires;
        }

        public  List<Stagiaire> SelectNotConfirm()
        {
            List<Stagiaire> ListStagiaires = new List<Stagiaire>();
            String Requete = "Select * from Stagiaires where etat =0";
            OleDbDataReader read = MyConnection.ExecuteReader(Requete);
            while (read.Read())
            {
                Stagiaire s = new Stagiaire();
                s.Id = read.GetInt32(0);
                s.Filiere = new FiliereDAO().FindById(read.GetInt32(1));
                s.Nom = (string)read["Nom"];
                s.Prenom = (string)read["Prenom"];
                s.DateNaissance = (DateTime)read["DateNaissance"];
                s.Sexe = read.GetBoolean(5);
                s.Cin = read.GetString(6);
                s.Email = read.GetString(7);
                s.Telephone = read.GetString(8);
                s.Adresse = read.GetString(9);
                s.ProfilImage = read.GetString(10);
                s.Etat = read.GetInt32(11);
                ListStagiaires.Add(s);


            }


            return ListStagiaires;

        }

        public Stagiaire FindById(int id)
        {
            throw new NotImplementedException();
        }


       
    }
}
