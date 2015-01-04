using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using CompetencePlus.Outils;
using System.Data.SqlClient;
using CompetencePlus.Tools;

namespace CompetencePlus.PackageModules
{
  public  class ModuleDAO : IGestion<Module>
    {

      public Module getModulepre(int id)
      {
          List<Module> m = new List<Module>();
          string req = "Select * from [Module] where id = " + id;
          OleDbDataReader da = MyConnection.ExecuteReader(req);
          while (da.Read())
          {
              m.Add(new Module(da.GetInt32(0), new PackageFilieres.FiliereDAO().FindById(da.GetInt32(1)), new PackagePrecision.PrecisionDAO().FindById(da.GetInt32(2)), da.GetString(3), da.GetInt32(4), da.GetString(5), da.GetString(6), da.GetString(7), da.GetString(8), da.GetString(8), da.GetString(9), da.GetString(10), da.GetString(11)));
          }
          MyConnection.Close();
          return m.ElementAt(0);
      }

      public List<Module> Select()
      {
          List<Module> liste = new List<Module>();
          string req = "select * from Modules";
          OleDbDataReader da = MyConnection.ExecuteReader(req);
          while (da.Read())
          {
              
              liste.Add(new Module(da.GetInt32(0), new PackageFilieres.FiliereDAO().FindById(da.GetInt32(1)), new PackagePrecision.PrecisionDAO().FindById(da.GetInt32(2)), da.GetString(3), da.GetInt32(4), da.GetString(5), da.GetString(6), da.GetString(7), da.GetString(8), da.GetString(8), da.GetString(9), da.GetString(10), da.GetString(11)));
              
          }
        
          MyConnection.Close();
          return liste;
      }


      public int Add(Module o)
      {
          string req = "insert into [Modules](id,nom,duree,strategieEnseignement,apprentisage,evaluation,materiel,equipement,competence,presentation,description) values("+o.ID+",'"+o.Nom+"',"+o.Duree+",'"+o.StrategieEnseignement+"','"+o.Apprentisage+"','"+o.Evaluation+"','"+o.Materiel+"','"+o.Equipement+"','"+o.Competence+"','"+o.Presentation+"','"+o.Description+"')";
          return  MyConnection.ExecuteNonQuery(req);
      }
      
      public int Update(Module o)
      {
          throw new NotImplementedException();
      }

      public int Delete(int id)
      {
          string req = "delete from [Module] where id = " + id;
          return MyConnection.ExecuteNonQuery(req);
      }

      public Module FindById(int id)
      {
          throw new NotImplementedException();
      }

      public List<Module> findbyname(Module m)
      {
          string req = "select * from [module]";
          if (m.Nom != "" || m.Description != null || m.Duree != 0)
          {
              req += " where ";
          }
          bool and = false;
          if (m.Nom != null)
          {
              req += "nom like '%" + m.Nom + "%'";
              and=true;
          }
          if (m.Description != null)
          {
              if (and)
              {
                  req += " and description like '%" + m.Description + "%'";
              }
              and = true;
          }
          if (m.Duree != null)
          {
              if (and)
                  req += " and duree like " + m.Duree;
          }
        

          List<Module> liste = new List<Module>();
          OleDbDataReader da = MyConnection.ExecuteReader(req);
          while (da.Read())
          {

              liste.Add(new Module(da.GetInt32(0), new PackageFilieres.FiliereDAO().FindById(da.GetInt32(1)), new PackagePrecision.PrecisionDAO().FindById(da.GetInt32(2)), da.GetString(3), da.GetInt32(4), da.GetString(5), da.GetString(6), da.GetString(7), da.GetString(8), da.GetString(8), da.GetString(9), da.GetString(10), da.GetString(11)));
          }
          return liste;
      }
     
    }
}
