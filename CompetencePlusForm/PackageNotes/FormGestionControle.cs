using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace CompetencePlus.PackageNotes
{
    public partial class FormGestionControle : Form
    {
        public FormGestionControle()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ControleContinue controle = new ControleContinue();
            controle.Code = dateTimePicker1.Text;
            new ControleContinueDAO().FindByControleContinue(controle);

        }

        public void refresh()
        {
            controleContinueBindingSource.DataSource = null;
            controleContinueBindingSource.DataSource = new ControleContinueBAO().Select();
            ControleContinue controle = (ControleContinue)controleContinueBindingSource.Current;
            if (controle != null)
            {
                Titrelbl.Text = controle.Titre;
                Codelbl.Text = controle.Code;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormControle f = new FormControle();
            f.ShowDialog();
            this.refresh();
        }

        private void filiereDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ControleContinue controle = (ControleContinue)controleContinueBindingSource.Current;
                Titrelbl.Text = controle.Titre;
                Codelbl.Text = controle.Code;
                if (e.ColumnIndex == 2)
                {
                     /*????????*/
                }
                if (e.ColumnIndex == 3 && MessageBox.Show("voulez vous supprimer cet Controle", "Information dialog", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    new ControleContinueBAO().Delete(controle.Id);
                    this.refresh();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
