using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompetencePlus.Outils
{

    /// <summary>
    /// Interface utilisée pour déterminer les prototypes des méthode à défnire dans les classe "GestionObjets"
    /// </summary>
    /// <typeparam name="Obj"></typeparam>
    public interface IGestion<Obj>
    {
        /// <summary>
        /// Ajouter l'objet o 
        /// </summary>
        /// <param name="o"></param>
        int Add(Obj o);
        /// <summary>
        /// Mise à jour l'objet O en se basant sur la propriété Id
        /// </summary>
        /// <param name="o"></param>
        int Update(Obj o);
        /// <summary>
        ///  Supprimer un objet par son Id
        /// </summary>
        /// <param name="id"></param>
        int Delete(int id);
        /// <summary>
        /// Trouver la liste de tous les objets
        /// </summary>
        /// <returns></returns>
        List<Obj> Select();

        /// <summary>
        ///  Rechercher un objet par son Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
         Obj FindById(int id);
    }
}
