﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompetencePlus.Tools;
using System.Data.OleDb;

namespace CompetencePlus.PackageFormations
{
   public class FormationDAO
    {
       public List<Formation> select()
       {
           List<Formation> listformation = new List<Formation>();
           string reqeute = "select * from Formations";
           OleDbDataReader lire = MyConnection.ExecuteReader(reqeute);
           while (lire.Read())
           {
               listformation.Add(new Formation(1));
           }


       
           return listformation;
       }

       public Formation FindById(int id)
       {
           string Requete = "Select * from Formations where id=" + id;
           OleDbDataReader read = MyConnection.ExecuteReader(Requete);
           Formation g = new Formation();
           read.Read();
           g.Id = read.GetInt32(0);

           MyConnection.Close();
           return g;
       }
    }
}
