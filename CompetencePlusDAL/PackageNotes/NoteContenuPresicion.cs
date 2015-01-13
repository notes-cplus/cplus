using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompetencePlus.PackageNotes
{
    public class NoteContenuPresicion
    {
             private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private PackageStagiaires.Stagiaire stagiaire;

        public PackageStagiaires.Stagiaire Stagiaire
        {
            get { return stagiaire; }
            set { stagiaire = value; }
        }
        private float valeur;

        public float Valeur
        {
            get { return valeur; }
            set { valeur = value; }
        }
        private PackagePrecision.ContenuPresicion contenuPresicion;

        public PackagePrecision.ContenuPresicion ContenuPresicion
        {
            get { return contenuPresicion; }
            set { contenuPresicion = value; }
        }

        
        public NoteContenuPresicion() { }
        public NoteContenuPresicion(int id, PackageStagiaires.Stagiaire stagiaire, float valeur, PackagePrecision.ContenuPresicion contenuPresicion)
        {

            this.Id = id;
            this.Stagiaire = stagiaire;
            this.Valeur = valeur;
            this.ContenuPresicion = contenuPresicion;
        
        }

    }
}
