using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompetencePlus.PackageNotes
{
    public class ControleContinue
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private PackageFormations.Formation formation;

        public PackageFormations.Formation Formation
        {
            get { return formation; }
            set { formation = value; }
        }
        private string code;

        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        private string titre;

        public string Titre
        {
            get { return titre; }
            set { titre = value; }
        }
        private string commentaire;

        public string Commentaire
        {
            get { return commentaire; }
            set { commentaire = value; }
        }
        private DateTime dateControle;

        public DateTime DateControle
        {
            get { return dateControle; }
            set { dateControle = value; }
        }

        public ControleContinue() { }
        public ControleContinue(int id, PackageFormations.Formation formation, string code, string titre, string commentaire, DateTime dateControle)
        {

            this.Id = id;
            this.Code = code;
            this.Titre = titre;
            this.Commentaire = commentaire;
            this.DateControle = dateControle;
            this.Formation = formation;
        
        }
    }
}
