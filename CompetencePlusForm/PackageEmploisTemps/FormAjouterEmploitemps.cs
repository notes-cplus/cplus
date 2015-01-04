using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompetencePlus.PackageEmploisTemps
{
    public partial class FormAjouterEmploitemps : Form
    {
        public FormAjouterEmploitemps()
        {
            InitializeComponent();
        }

        public void refresh()
        {
            seanceplanningBindingSource.DataSource = null;
            seanceplanningBindingSource.DataSource = new SeanceplanningDAO().Select();


        }

        private void btajouter_Click(object sender, EventArgs e)
        {
            formSeancePlanning s = new formSeancePlanning();
            s.ShowDialog();
            this.refresh();
           
        }
        public Seanceplanning returnid(Seanceplanning s)
        {
            Seanceplanning g = (Seanceplanning)seanceplanningBindingSource.Current;
            int ide = g.Id;
            return g;

        }
    
        private void FormAjouterEmploitemps_Load(object sender, EventArgs e)
        {
          
            this.refresh();
            anneeFormationBindingSource.DataSource = new PackageAnneeFormations.AnneformationDAO().select() ;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.refresh();
        }
    }
}
