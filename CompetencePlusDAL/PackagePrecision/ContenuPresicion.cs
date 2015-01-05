using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompetencePlus.PackagePrecision
{
    public class ContenuPresicion
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
       private string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private double duree;

        public double Duree
        {
            get { return duree; }
            set { duree = value; }
        }
        private int ordre;

        public int Ordre
        {
            get { return ordre; }
            set { ordre = value; }
        }
        public ContenuPresicion() { }
        public ContenuPresicion(int id, string nom, string description, double duree, int ordre) 
        {
            this.Id = id;
            this.Nom = nom;
            this.Description = description;
            this.Duree = duree;
            this.Ordre = ordre;
        }
        public override string ToString()
        {
            return this.nom;
        }
    }
}
