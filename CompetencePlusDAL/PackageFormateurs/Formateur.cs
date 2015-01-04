using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompetencePlus.PackageFormateurs
{
   public class Formateur
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
        private string prenom;

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        private string matricule;

        public string Matricule
        {
            get { return matricule; }
            set { matricule = value; }
        }
        private string adresse;

        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }
        private string tel;

        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public Formateur(int id,string nom,string prenom,string matricule,string adresse,string tel,string email)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.matricule = matricule;
            this.adresse = adresse;
            this.email = email;
            this.tel = tel;
        }
       public Formateur()
       {
       }



    }
}
