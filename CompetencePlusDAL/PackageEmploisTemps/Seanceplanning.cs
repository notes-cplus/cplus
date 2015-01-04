using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompetencePlus.PackageFormations;

namespace CompetencePlus.PackageEmploisTemps
{
  public class Seanceplanning
    {

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

      private int heuredebut;
     
        public int Heuredebut
        {
            get { return heuredebut; }
            set { heuredebut = value; }
        }
       
        private int heurefin;
        public int Heurefin
        {
            get { return heurefin; }
            set { heurefin = value; }
        }
        private string jour;
        public string Jour
        {
            get { return jour; }
            set { jour = value; }
        }
        Formation formation;

        public Formation Formation
        {
            get { return formation; }
            set { formation = value; }
        }

        public Seanceplanning(int id, string jour,int heuredebut, int heurefin, Formation formation)
        {
            this.id = id;
            this.heuredebut = heuredebut;
            this.heurefin = heurefin;
            this.jour = jour;
            this.formation = formation;
        }
        public Seanceplanning()
        {
          
        }
    }
}
