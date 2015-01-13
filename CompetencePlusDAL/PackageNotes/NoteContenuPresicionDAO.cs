using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using CompetencePlus.Tools;

namespace CompetencePlus.PackageNotes
{
   public  class NoteContenuPresicionDAO
    {


        public int Add(NoteContenuPresicion c)
        {
            string Requete = "Insert into NoteContenuePrecisions(valeur,ContenuePrecision_id,Stagiaire_id) values ('" + c.Valeur + "','" + c.ContenuPresicion.Id + "','" + c.Stagiaire.Id + "')";
            return MyConnection.ExecuteNonQuery(Requete);
        }

        public int Update(NoteContenuPresicion c)
        {
            string Requete = "Update NoteContenuePrecisions set valeur ='" + c.Valeur + "',ContenuePrecision_id ='" + c.ContenuPresicion.Id + "',Stagiaire_id='" + c.Stagiaire.Id + "' where id =" + c.Id;
            return MyConnection.ExecuteNonQuery(Requete);
        }

        public int Delete(int id)
        {
            string Requete = "Delete From NoteContenuePrecisions where id=" + id;
            return MyConnection.ExecuteNonQuery(Requete);
        }

        public List<NoteContenuPresicion> Select()
        {
            string Requete = "Select * from NoteContenuePrecisions ";
            List<NoteContenuPresicion> ListNoteContenuePrecisions = new List<NoteContenuPresicion>();
            OleDbDataReader read = MyConnection.ExecuteReader(Requete);
            while (read.Read())
            {
                NoteContenuPresicion c = new NoteContenuPresicion();
                c.Id = read.GetInt32(0);
                c.Valeur = read.GetInt32(1);
                c.ContenuPresicion = new PackagePrecision.ContenuPrecisionDAO().FindById(read.GetInt32(2));
                c.Stagiaire = new PackageStagiaires.StagiaireDAO().FindById(read.GetInt32(3));
                ListNoteContenuePrecisions.Add(c);
            }
            MyConnection.Close();
            return ListNoteContenuePrecisions;
        }


        public NoteContenuPresicion FindById(int id)
        {
            string Requete = "Select * from NoteContenuePrecisions where id=" + id;
            OleDbDataReader read = MyConnection.ExecuteReader(Requete);
            read.Read();
            NoteContenuPresicion c = new NoteContenuPresicion();
            c.Id = read.GetInt32(0);
            c.Valeur = read.GetInt32(1);
            c.ContenuPresicion = new PackagePrecision.ContenuPrecisionDAO().FindById(read.GetInt32(2));
            c.Stagiaire = new PackageStagiaires.StagiaireDAO().FindById(read.GetInt32(3));
            return c;
        }

        public NoteContenuPresicion FindByValue(int value)
        {
            string Requete = "Select * from NoteContenuePrecisions where valeur=" + value;
            OleDbDataReader read = MyConnection.ExecuteReader(Requete);
            read.Read();
            NoteContenuPresicion c = new NoteContenuPresicion();
            c.Id = read.GetInt32(0);
            c.Valeur = read.GetInt32(1);
            c.ContenuPresicion = new PackagePrecision.ContenuPrecisionDAO().FindById(read.GetInt32(2));
            c.Stagiaire = new PackageStagiaires.StagiaireDAO().FindById(read.GetInt32(3));
            return c;
        }

    }
}
