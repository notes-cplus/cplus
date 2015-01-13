using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompetencePlus.PackageNotes
{
    public class NoteControleContinue
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
        private ControleContinue controleContinue;

        public  ControleContinue ControleContinue
        {
            get { return controleContinue; }
            set { controleContinue = value; }
        }
        public NoteControleContinue() { }
        public NoteControleContinue(int id, PackageStagiaires.Stagiaire stagiaire, float valeur, ControleContinue controleContinue) {

            this.Id = id;
            this.Stagiaire = stagiaire;
            this.Valeur = valeur;
            this.ControleContinue = controleContinue;
        
        }

    }
}
