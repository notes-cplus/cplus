using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompetencePlus.Tools;
using System.Data.OleDb;

namespace CompetencePlus.PackageNotes
{
    public class ControleContinueDAO
    {
        public int Add(ControleContinue c)
        {
            string Requete = "Insert into ControleContinues(Formation_id,code,titre,commentaire,dateControle) values ('" + c.Formation.Id + "','" + c.Code + "','" + c.Titre + "','" + c.Commentaire + "','" + c.DateControle + "')";
            return MyConnection.ExecuteNonQuery(Requete);
        }

        public int Update(ControleContinue c)
        {
            string Requete = "Update ControleContinues set code ='" + c.Code + "',titre ='" + c.Titre + "',commentaire='" + c.Commentaire + "',dateControle='" + c.DateControle + "',Formation_id='" + c.Formation.Id + "' where id =" + c.Id;
            return MyConnection.ExecuteNonQuery(Requete);
        }

        public int Delete(int id)
        {
            string Requete = "Delete From ControleContinues where id=" + id;
            return MyConnection.ExecuteNonQuery(Requete);
        }

        public List<ControleContinue> Select()
        {
            string Requete = "Select * from ControleContinues ";
            List<ControleContinue> ListControleContinue = new List<ControleContinue>();
            OleDbDataReader read = MyConnection.ExecuteReader(Requete);
            while (read.Read())
            {
                ControleContinue c = new ControleContinue();
                c.Id = read.GetInt32(0);
                c.Formation = new PackageFormations.FormationDAO().FindById(read.GetInt32(1));
                c.Code = read.GetString(2);
                c.Titre = read.GetString(3);
                c.Commentaire = read.GetString(4);
                c.DateControle = read.GetDateTime(5);
                ListControleContinue.Add(c);
            }
            MyConnection.Close();
            return ListControleContinue;
        }


        public ControleContinue FindById(int id)
        {
            string Requete = "Select * from ControleContinues where id=" + id;
            OleDbDataReader read = MyConnection.ExecuteReader(Requete);
            read.Read();
            ControleContinue c = new ControleContinue();
            c.Id = read.GetInt32(0);
            c.Formation = new PackageFormations.FormationDAO().FindById(read.GetInt32(1));
            c.Code = read.GetString(2);
            c.Titre = read.GetString(3);
            c.Commentaire = read.GetString(4);
            c.DateControle = read.GetDateTime(5); 
            return c;
        }
        public ControleContinue FindByName(string Name)
        {
            string Requete = "Select * from ControleContinues where titre='" + Name + "'";
            OleDbDataReader read = MyConnection.ExecuteReader(Requete);
            read.Read();
             ControleContinue c = new ControleContinue();
            c.Id = read.GetInt32(0);
            c.Formation = new PackageFormations.FormationDAO().FindById(read.GetInt32(1));
            c.Code = read.GetString(2);
            c.Titre = read.GetString(3);
            c.Commentaire = read.GetString(4);
            c.DateControle = read.GetDateTime(5);
            return c;
        }



        /// <summary>
        /// Recherche par Code, Titre, et Commentaire
        /// </summary>
        /// <param name="filier"></param>
        /// <returns></returns>
        public List<ControleContinue> FindByControleContinue(ControleContinue ControleContinue)
        {

            string Requete = "Select * from ControleContinues ";
            if (ControleContinue.Code != "" || ControleContinue.Titre != "" || ControleContinue.Commentaire != "")
            {
                Requete += " where ";
            }
            bool and = false;
            if (ControleContinue.Code != "")
            {
                Requete += " code like '%" + ControleContinue.Code + "%'";
                and = true;
            }
            if (ControleContinue.Titre != "")
            {
                if (and) Requete += " and ";
                Requete += " titre like '%" + ControleContinue.Titre + "%'";
                and = true;
            }
            if (ControleContinue.Commentaire != "")
            {
                if (and) Requete += " and ";
                Requete += " commentaire like '%" + ControleContinue.Commentaire + "%'";
                and = true;
            }



            List<ControleContinue> ListControleContinue = new List<ControleContinue>();
            OleDbDataReader read = MyConnection.ExecuteReader(Requete);
            while (read.Read())
            {
                ControleContinue c = new ControleContinue();
                c.Id = read.GetInt32(0);
                c.Formation = new PackageFormations.FormationDAO().FindById(read.GetInt32(1));
                c.Code = read.GetString(2);
                c.Titre = read.GetString(3);
                c.Commentaire = read.GetString(4);
                c.DateControle = read.GetDateTime(5);
               ListControleContinue.Add(c);
            }
            MyConnection.Close();
            return ListControleContinue;
        }
       

    }
}
