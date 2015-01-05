using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompetencePlus.Tools;
using System.Data.OleDb;

namespace CompetencePlus.PackageNotes
{
    class NoteControleContinueDAO
    {

        public int Add(NoteControleContinue c)
        {
            string Requete = "Insert into NoteControleContinues(valeur,ControleContinue_id,Stagiaire_id) values ('" + c.Valeur + "','" + c.ControleContinue.Id + "','" + c.Stagiaire.Id + "')";
            return MyConnection.ExecuteNonQuery(Requete);
        }

        public int Update(NoteControleContinue c)
        {
            string Requete = "Update NoteControleContinues set valeur ='" + c.Valeur + "',ControleContinue_id ='" + c.ControleContinue.Id + "',Stagiaire_id='" + c.Stagiaire.Id + "' where id =" + c.Id;
            return MyConnection.ExecuteNonQuery(Requete);
        }

        public int Delete(int id)
        {
            string Requete = "Delete From NoteControleContinues where id=" + id;
            return MyConnection.ExecuteNonQuery(Requete);
        }

        public List<NoteControleContinue> Select()
        {
            string Requete = "Select * from NoteControleContinues ";
            List<NoteControleContinue> ListNoteControleContinues = new List<NoteControleContinue>();
            OleDbDataReader read = MyConnection.ExecuteReader(Requete);
            while (read.Read())
            {
                NoteControleContinue c = new NoteControleContinue();
                c.Id = read.GetInt32(0);
                c.Valeur = read.GetInt32(2);
                c.ControleContinue = new ControleContinueDAO().FindById(read.GetInt32(3));
                c.Stagiaire = new PackageStagiaires.StagiaireDAO().FindById(read.GetInt32(1));
                ListNoteControleContinues.Add(c);
            }
            MyConnection.Close();
            return ListNoteControleContinues;
        }


        public NoteControleContinue FindById(int id)
        {
            string Requete = "Select * from NoteControleContinues where id=" + id;
            OleDbDataReader read = MyConnection.ExecuteReader(Requete);
            read.Read();
            NoteControleContinue c = new NoteControleContinue();
            c.Id = read.GetInt32(0);
            c.Valeur = read.GetInt32(2);
            c.ControleContinue = new ControleContinueDAO().FindById(read.GetInt32(3));
            c.Stagiaire = new PackageStagiaires.StagiaireDAO().FindById(read.GetInt32(1));
            return c;
        }

        public NoteControleContinue FindByValue(int value)
        {
            string Requete = "Select * from NoteControleContinues where valeur=" + value;
            OleDbDataReader read = MyConnection.ExecuteReader(Requete);
            read.Read();
            NoteControleContinue c = new NoteControleContinue();
            c.Id = read.GetInt32(0);
            c.Valeur = read.GetInt32(2);
            c.ControleContinue = new ControleContinueDAO().FindById(read.GetInt32(3));
            c.Stagiaire = new PackageStagiaires.StagiaireDAO().FindById(read.GetInt32(1));
            return c;
        }
    }
}
