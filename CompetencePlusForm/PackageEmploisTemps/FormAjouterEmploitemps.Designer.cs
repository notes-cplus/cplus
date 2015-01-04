namespace CompetencePlus.PackageEmploisTemps
{
    partial class FormAjouterEmploitemps
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.anneeFormationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.seanceplanningBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btajouter = new System.Windows.Forms.Button();
            this.heuredebutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heurefinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anneeFormationBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seanceplanningBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Emploistemps";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(142, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.anneeFormationBindingSource;
            this.comboBox1.DisplayMember = "Titre";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(142, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "Id";
            // 
            // anneeFormationBindingSource
            // 
            this.anneeFormationBindingSource.DataSource = typeof(CompetencePlus.PackageAnneeFormations.AnneeFormation);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date Fin :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date Début :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Années de Formation :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(598, 214);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Séances";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.heuredebutDataGridViewTextBoxColumn,
            this.heurefinDataGridViewTextBoxColumn,
            this.jourDataGridViewTextBoxColumn,
            this.formationDataGridViewTextBoxColumn,
            this.Column1,
            this.Column2});
            this.dataGridView1.DataSource = this.seanceplanningBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(528, 176);
            this.dataGridView1.TabIndex = 0;
            // 
            // seanceplanningBindingSource
            // 
            this.seanceplanningBindingSource.DataSource = typeof(CompetencePlus.PackageEmploisTemps.Seanceplanning);
            // 
            // btajouter
            // 
            this.btajouter.Location = new System.Drawing.Point(509, 118);
            this.btajouter.Name = "btajouter";
            this.btajouter.Size = new System.Drawing.Size(101, 23);
            this.btajouter.TabIndex = 2;
            this.btajouter.Text = "Ajouter";
            this.btajouter.UseVisualStyleBackColor = true;
            this.btajouter.Click += new System.EventHandler(this.btajouter_Click);
            // 
            // heuredebutDataGridViewTextBoxColumn
            // 
            this.heuredebutDataGridViewTextBoxColumn.DataPropertyName = "Heuredebut";
            this.heuredebutDataGridViewTextBoxColumn.HeaderText = "Heuredebut";
            this.heuredebutDataGridViewTextBoxColumn.Name = "heuredebutDataGridViewTextBoxColumn";
            this.heuredebutDataGridViewTextBoxColumn.Width = 90;
            // 
            // heurefinDataGridViewTextBoxColumn
            // 
            this.heurefinDataGridViewTextBoxColumn.DataPropertyName = "Heurefin";
            this.heurefinDataGridViewTextBoxColumn.HeaderText = "Heurefin";
            this.heurefinDataGridViewTextBoxColumn.Name = "heurefinDataGridViewTextBoxColumn";
            this.heurefinDataGridViewTextBoxColumn.Width = 90;
            // 
            // jourDataGridViewTextBoxColumn
            // 
            this.jourDataGridViewTextBoxColumn.DataPropertyName = "Jour";
            this.jourDataGridViewTextBoxColumn.HeaderText = "Jour";
            this.jourDataGridViewTextBoxColumn.Name = "jourDataGridViewTextBoxColumn";
            // 
            // formationDataGridViewTextBoxColumn
            // 
            this.formationDataGridViewTextBoxColumn.DataPropertyName = "Formation";
            this.formationDataGridViewTextBoxColumn.HeaderText = "Formation";
            this.formationDataGridViewTextBoxColumn.Name = "formationDataGridViewTextBoxColumn";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Modifier";
            this.Column1.Image = global::CompetencePlus.Properties.Resources.Update;
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Supprimer";
            this.Column2.Image = global::CompetencePlus.Properties.Resources.Delete;
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // FormAjouterEmploitemps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 373);
            this.Controls.Add(this.btajouter);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAjouterEmploitemps";
            this.Text = "FormAjouterEmploitemps";
            this.Load += new System.EventHandler(this.FormAjouterEmploitemps_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anneeFormationBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seanceplanningBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource seanceplanningBindingSource;
        private System.Windows.Forms.Button btajouter;
        private System.Windows.Forms.BindingSource anneeFormationBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn heuredebutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heurefinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
    }
}