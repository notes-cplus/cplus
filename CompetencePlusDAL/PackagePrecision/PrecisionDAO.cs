using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompetencePlus.Outils;
using CompetencePlus.PackageModules;
using System.Data.OleDb;
using System.Data.SqlClient;
using CompetencePlus.Tools;
namespace CompetencePlus.PackagePrecision
{
    public class PrecisionDAO  
    {


        public void Add(Precision o)
        {
            throw new NotImplementedException();
        }

        public void Update(Precision o)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Precision> Select()
        {

            List<Precision> p = new List<Precision>();
            string req = "Select * From [Precisions]";
            OleDbDataReader sqr = MyConnection.ExecuteReader(req);
            while (sqr.Read())
            {
                p.Add(new Precision(sqr.GetInt32(0), sqr.GetInt32(1), sqr.GetString(2), sqr.GetString(3), sqr.GetInt32(4), sqr.GetInt32(5)));
            }
            MyConnection.Close();
            return p;
        }


        public Precision FindById(int id)
        {
            List<Precision> p = new List<Precision>();
            string req = "Select * From [Precisions] where id =" + id;
            OleDbDataReader sqr = MyConnection.ExecuteReader(req);
            while (sqr.Read())
            {
                p.Add(new Precision(sqr.GetInt32(0), sqr.GetInt32(1), sqr.GetString(2), sqr.GetString(3), sqr.GetInt32(4), sqr.GetInt32(5)));
            }
            MyConnection.Close();
            return p.ElementAt(0);
        }
        public List<Precision> GetallPres(int id)
        {
            List<Precision> p = new List<Precision>();
            string req = "Select * From [Precisions] where id =" + id;
            OleDbDataReader sqr = MyConnection.ExecuteReader(req);
            while (sqr.Read())
            {
                p.Add(new Precision(sqr.GetInt32(0), sqr.GetInt32(1), sqr.GetString(2), sqr.GetString(3), sqr.GetInt32(4), sqr.GetInt32(5)));
            }
            MyConnection.Close();
            return p;
            
        }
    }
}
