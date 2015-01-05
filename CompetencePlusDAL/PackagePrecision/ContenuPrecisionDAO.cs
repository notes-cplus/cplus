using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompetencePlus.Tools;
using System.Data.OleDb;

namespace CompetencePlus.PackagePrecision
{
    class ContenuPrecisionDAO
    {

        public int Add(ContenuPresicion c)
        {
            string Requete = "Insert into ContenuePrecisions(nom,description,duree,ordre) values ('" + c.Nom + "','" + c.Description + "','" + c.Duree + "','" + c.Ordre + "')";
            return MyConnection.ExecuteNonQuery(Requete);
        }

        public int Update(ContenuPresicion c)
        {
            string Requete = "Update ContenuePrecisions set nom ='" + c.Nom + "',description ='" + c.Description + "',duree='" + c.Duree + "',ordre='" + c.Ordre + "' where id =" + c.Id;
            return MyConnection.ExecuteNonQuery(Requete);
        }

        public int Delete(int id)
        {
            string Requete = "Delete From ContenuePrecisions where id=" + id;
            return MyConnection.ExecuteNonQuery(Requete);
        }

        public List<ContenuPresicion> Select()
        {
            string Requete = "Select * from ContenuePrecisions ";
            List<ContenuPresicion> ListContenuPresicion = new List<ContenuPresicion>();
            OleDbDataReader read = MyConnection.ExecuteReader(Requete);
            while (read.Read())
            {
                ContenuPresicion c = new ContenuPresicion();
                c.Id = read.GetInt32(0);
                c.Nom = read.GetString(1);
                c.Description = read.GetString(2);
                c.Duree = read.GetInt32(3);
                c.Ordre = read.GetInt32(4);
                ListContenuPresicion.Add(c);
            }
            MyConnection.Close();
            return ListContenuPresicion;
        }


        public ContenuPresicion FindById(int id)
        {
            string Requete = "Select * from ContenuePrecisions where id=" + id;
            OleDbDataReader read = MyConnection.ExecuteReader(Requete);
            read.Read();
            ContenuPresicion c = new ContenuPresicion();
            c.Id = read.GetInt32(0);
            c.Nom = read.GetString(1);
            c.Description = read.GetString(2);
            c.Duree = read.GetInt32(3);
            c.Ordre = read.GetInt32(4);
            return c;
        }
        public ContenuPresicion FindByName(string Name)
        {
            string Requete = "Select * from ContenuePrecisions where nom='" + Name + "'";
            OleDbDataReader read = MyConnection.ExecuteReader(Requete);
            read.Read();
            ContenuPresicion c = new ContenuPresicion();
            c.Id = read.GetInt32(0);
            c.Nom = read.GetString(1);
            c.Description = read.GetString(2);
            c.Duree = read.GetInt32(3);
            c.Ordre = read.GetInt32(4);
            return c;
        }



        /// <summary>
        /// Recherche par Code, Titre, et Commentaire
        /// </summary>
        /// <param name="filier"></param>
        /// <returns></returns>
        public List<ContenuPresicion> FindByContenuePrecisions(ContenuPresicion ContenuPresicion)
        {

            string Requete = "Select * from ContenuePrecisions ";
            if (ContenuPresicion.Nom != "" || ContenuPresicion.Description != "")
            {
                Requete += " where ";
            }
            bool and = false;
            if (ContenuPresicion.Nom != "")
            {
                Requete += " code like '%" + ContenuPresicion.Nom + "%'";
                and = true;
            }
            if (ContenuPresicion.Description != "")
            {
                if (and) Requete += " and ";
                Requete += " description like '%" + ContenuPresicion.Description + "%'";
                and = true;
            }



            List<ContenuPresicion> ListContenuPresicion = new List<ContenuPresicion>();
            OleDbDataReader read = MyConnection.ExecuteReader(Requete);
            while (read.Read())
            {
                ContenuPresicion c = new ContenuPresicion();
                c.Id = read.GetInt32(0);
                c.Nom = read.GetString(1);
                c.Description = read.GetString(2);
                c.Duree = read.GetInt32(3);
                c.Ordre = read.GetInt32(4);
                ListContenuPresicion.Add(c);
            }
            MyConnection.Close();
            return ListContenuPresicion;
        }
       
    }
}
