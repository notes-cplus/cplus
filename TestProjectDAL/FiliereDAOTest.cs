using CompetencePlus.PackageFilieres;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestProjectDAL
{
    
    
    /// <summary>
    ///Classe de test pour FiliereDAOTest, destinée à contenir tous
    ///les tests unitaires FiliereDAOTest
    ///</summary>
    [TestClass()]
    public class FiliereDAOTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Obtient ou définit le contexte de test qui fournit
        ///des informations sur la série de tests active ainsi que ses fonctionnalités.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Attributs de tests supplémentaires
        // 
        //Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        //
        //Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test dans la classe
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Utilisez ClassCleanup pour exécuter du code après que tous les tests ont été exécutés dans une classe
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Test pour Constructeur FiliereDAO
        ///</summary>
        [TestMethod()]
        public void FiliereDAOConstructorTest()
        {
            FiliereDAO target = new FiliereDAO();
            Assert.Inconclusive("TODO: implémentez le code pour vérifier la cible");
        }

        /// <summary>
        ///Test pour Add
        ///</summary>
        [TestMethod()]
        public void AddTest()
        {
            FiliereDAO target = new FiliereDAO(); // TODO: initialisez à une valeur appropriée
            Filiere f = new Filiere();
            target.Add(f);
            Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.");
        }

        /// <summary>
        ///Test pour Delete
        ///</summary>
        [TestMethod()]
        public void DeleteTest()
        {
            FiliereDAO target = new FiliereDAO(); // TODO: initialisez à une valeur appropriée
            int id = 0; // TODO: initialisez à une valeur appropriée
            target.Delete(id);
            Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.");
        }

        /// <summary>
        ///Test pour FindByFilier
        ///</summary>
        [TestMethod()]
        public void FindByFilierTest()
        {
            FiliereDAO target = new FiliereDAO(); // TODO: initialisez à une valeur appropriée
            Filiere filier = null; // TODO: initialisez à une valeur appropriée
            List<Filiere> expected = null; // TODO: initialisez à une valeur appropriée
            List<Filiere> actual;
            actual = target.FindByFilier(filier);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour FindById
        ///</summary>
        [TestMethod()]
        public void FindByIdTest()
        {
            FiliereDAO target = new FiliereDAO(); // TODO: initialisez à une valeur appropriée
            int id = 0; // TODO: initialisez à une valeur appropriée
            Filiere expected = null; // TODO: initialisez à une valeur appropriée
            Filiere actual;
            actual = target.FindById(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour FindByName
        ///</summary>
        [TestMethod()]
        public void FindByNameTest()
        {
            FiliereDAO target = new FiliereDAO(); // TODO: initialisez à une valeur appropriée
            string Name = string.Empty; // TODO: initialisez à une valeur appropriée
            Filiere expected = null; // TODO: initialisez à une valeur appropriée
            Filiere actual;
            actual = target.FindByName(Name);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour Select
        ///</summary>
        [TestMethod()]
        public void SelectTest()
        {
            FiliereDAO target = new FiliereDAO(); // TODO: initialisez à une valeur appropriée
            List<Filiere> expected = null; // TODO: initialisez à une valeur appropriée
            List<Filiere> actual;
            actual = target.Select();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour Update
        ///</summary>
        [TestMethod()]
        public void UpdateTest()
        {
            FiliereDAO target = new FiliereDAO(); // TODO: initialisez à une valeur appropriée
            Filiere f = null; // TODO: initialisez à une valeur appropriée
            target.Update(f);
            Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.");
        }
    }
}
