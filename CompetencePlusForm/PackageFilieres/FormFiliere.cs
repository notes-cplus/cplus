using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompetencePlus.PackageFilieres
{
    public partial class FormFiliere : Form
    {
        public FormFiliere()
        {
            InitializeComponent();
        }
        private void FormFiliere_Load(object sender, EventArgs e)
        {

        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            try
            {
                Filiere filiere = new Filiere();
                filiere.Code = CodeTextBox.Text;
                filiere.Titre = TitreTextBox.Text;
                filiere.Description = DescriptionTextBox.Text;
                new FiliereBAO().Add(filiere);
                this.Dispose();
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Ereur de saisie");
            }
        }

        private void BtCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

   
        private void TitreTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TitreTextBox.Text))
            {
               // errorProviderTitle.Icon =Properties.Resources.Error;
                errorProviderTitle.Icon = new Icon(SystemIcons.Error,64,32);
                errorProviderTitle.SetError(TitreTextBox,"Vous devez saisie le nom de la filière");
            }
            else
            {
                errorProviderTitle.Icon=Properties.Resources.Clear;
                errorProviderTitle.SetError(TitreTextBox, "ok");
            }
        }

        private void CodeTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CodeTextBox.Text))
            {
                this.errorProviderCode.Icon = new Icon(SystemIcons.Error, 64, 32);
                errorProviderCode.SetError(CodeTextBox, "Vous devez saisie le code de la filière");
            }
            else
            {
                errorProviderCode.Icon = Properties.Resources.Clear;
                errorProviderCode.SetError(CodeTextBox, "ok");
            }
        }

       

        private void TitreTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (TitreTextBox.Text == "")
                e.Cancel = true;
        }

        private void CodeTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (CodeTextBox.Text == "")
                e.Cancel = true;
        }
    }
}
