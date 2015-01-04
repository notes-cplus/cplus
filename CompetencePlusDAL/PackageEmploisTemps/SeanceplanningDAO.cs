﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompetencePlus.Outils;
using CompetencePlus.Tools;
using System.Data.OleDb;

namespace CompetencePlus.PackageEmploisTemps
{
 public   class SeanceplanningDAO 
    {
      public  void Add(Seanceplanning s)
     {//EmploisTemp_id
            string Requete = "Insert into SeancePlannings(jour,heuredebut,heurefin,Formation_id) values ('"+s.Jour+"',"+s.Heuredebut+","+s.Heurefin+","+s.Formation.Id+")";
            MyConnection.ExecuteNonQuery(Requete);
        }

        public  void Update(Seanceplanning s )
        {
            string Requete = "Update  SeancePlannings set jour ='"+s.Jour+",heuredebut ="+s.Heuredebut+",heurefin="+s.Heurefin+" where id ="+s.Id;
            MyConnection.ExecuteNonQuery(Requete);
        }

        public  void Delete(int id)
        {
            string Requete = "Delete From SeancePlannings where id="+id;
            MyConnection.ExecuteNonQuery(Requete);
        }

        public  List<Seanceplanning> Select()
        {
            string Requete = "Select * from SeancePlannings";
            List<Seanceplanning> ListSeancePlannings = new List<Seanceplanning>();
            OleDbDataReader read = MyConnection.ExecuteReader(Requete);
            while (read.Read())
            {
               Seanceplanning f = new Seanceplanning();
                f.Id = read.GetInt32(1);
                f.Jour = read.GetString(2);
                f.Heuredebut= read.GetInt32(3);
                f.Heurefin = read.GetInt32(4);
                f.Formation = new PackageFormations.FormationDAO().FindById(read.GetInt32(5));
                ListSeancePlannings.Add(f);
            }
            MyConnection.Close();
            return ListSeancePlannings;
        }
      

        public Seanceplanning FindById(int id)
        {
            string Requete = "Select * from SeancePlannings where id="+id;
            OleDbDataReader read = MyConnection.ExecuteReader(Requete);
            read.Read();
              Seanceplanning f = new Seanceplanning();
          f.Id = read.GetInt32(0);
                f.Jour = read.GetString(1);
                f.Heuredebut= read.GetInt32(2);
                f.Heurefin = read.GetInt32(3);
            return f;
        }

       
    
    }
}
