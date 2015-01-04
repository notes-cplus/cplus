namespace CompetencePlus.PackageGroupes
{
    partial class FormGestionGroupes
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FiliereComboBox = new System.Windows.Forms.ComboBox();
            this.filiereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtResearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.CodeTextBox = new System.Windows.Forms.TextBox();
            this.NomTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CodeLabel = new System.Windows.Forms.Label();
            this.NomLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtAdd = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupeDataGridView = new System.Windows.Forms.DataGridView();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filiereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtLast = new System.Windows.Forms.Button();
            this.BtNext = new System.Windows.Forms.Button();
            this.BtPrevious = new System.Windows.Forms.Button();
            this.BtFirst = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filiereBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FiliereComboBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.BtResearch);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.DescriptionTextBox);
            this.groupBox2.Controls.Add(this.CodeTextBox);
            this.groupBox2.Controls.Add(this.NomTextBox);
            this.groupBox2.Location = new System.Drawing.Point(21, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 248);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recherche";
            // 
            // FiliereComboBox
            // 
            this.FiliereComboBox.DataSource = this.filiereBindingSource;
            this.FiliereComboBox.DisplayMember = "Id";
            this.FiliereComboBox.FormattingEnabled = true;
            this.FiliereComboBox.Location = new System.Drawing.Point(75, 108);
            this.FiliereComboBox.Name = "FiliereComboBox";
            this.FiliereComboBox.Size = new System.Drawing.Size(146, 21);
            this.FiliereComboBox.TabIndex = 9;
            this.FiliereComboBox.ValueMember = "Id";
            // 
            // filiereBindingSource
            // 
            this.filiereBindingSource.DataSource = typeof(CompetencePlus.PackageFilieres.Filiere);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Filiere";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Description";
            // 
            // BtResearch
            // 
            this.BtResearch.Location = new System.Drawing.Point(75, 208);
            this.BtResearch.Name = "BtResearch";
            this.BtResearch.Size = new System.Drawing.Size(114, 23);
            this.BtResearch.TabIndex = 7;
            this.BtResearch.Text = "Recherche";
            this.BtResearch.UseVisualStyleBackColor = true;
            this.BtResearch.Click += new System.EventHandler(this.BtResearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nom";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(75, 144);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(146, 20);
            this.DescriptionTextBox.TabIndex = 2;
            // 
            // CodeTextBox
            // 
            this.CodeTextBox.Location = new System.Drawing.Point(75, 71);
            this.CodeTextBox.Name = "CodeTextBox";
            this.CodeTextBox.Size = new System.Drawing.Size(146, 20);
            this.CodeTextBox.TabIndex = 1;
            // 
            // NomTextBox
            // 
            this.NomTextBox.Location = new System.Drawing.Point(75, 29);
            this.NomTextBox.Name = "NomTextBox";
            this.NomTextBox.Size = new System.Drawing.Size(146, 20);
            this.NomTextBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CodeLabel);
            this.groupBox1.Controls.Add(this.NomLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 89);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Groupe";
            // 
            // CodeLabel
            // 
            this.CodeLabel.AutoSize = true;
            this.CodeLabel.Location = new System.Drawing.Point(47, 56);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(31, 13);
            this.CodeLabel.TabIndex = 3;
            this.CodeLabel.Text = "code";
            // 
            // NomLabel
            // 
            this.NomLabel.AutoSize = true;
            this.NomLabel.BackColor = System.Drawing.SystemColors.Control;
            this.NomLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NomLabel.Location = new System.Drawing.Point(47, 29);
            this.NomLabel.Name = "NomLabel";
            this.NomLabel.Size = new System.Drawing.Size(28, 13);
            this.NomLabel.TabIndex = 2;
            this.NomLabel.Text = "Titre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // BtAdd
            // 
            this.BtAdd.Location = new System.Drawing.Point(762, 12);
            this.BtAdd.Name = "BtAdd";
            this.BtAdd.Size = new System.Drawing.Size(75, 23);
            this.BtAdd.TabIndex = 9;
            this.BtAdd.Text = "Ajouter";
            this.BtAdd.UseVisualStyleBackColor = true;
            this.BtAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupeDataGridView);
            this.groupBox3.Location = new System.Drawing.Point(317, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(520, 343);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Liste des Groupes";
            // 
            // groupeDataGridView
            // 
            this.groupeDataGridView.AutoGenerateColumns = false;
            this.groupeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.filiereDataGridViewTextBoxColumn,
            this.Update,
            this.Delete});
            this.groupeDataGridView.DataSource = this.groupeBindingSource;
            this.groupeDataGridView.Location = new System.Drawing.Point(6, 19);
            this.groupeDataGridView.Name = "groupeDataGridView";
            this.groupeDataGridView.Size = new System.Drawing.Size(503, 318);
            this.groupeDataGridView.TabIndex = 0;
            this.groupeDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.groupeDataGridView_CellClick);
            this.groupeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.groupeDataGridView_CellContentClick);
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.Width = 120;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.Width = 120;
            // 
            // filiereDataGridViewTextBoxColumn
            // 
            this.filiereDataGridViewTextBoxColumn.DataPropertyName = "Filiere";
            this.filiereDataGridViewTextBoxColumn.HeaderText = "Filiere";
            this.filiereDataGridViewTextBoxColumn.Name = "filiereDataGridViewTextBoxColumn";
            this.filiereDataGridViewTextBoxColumn.Width = 120;
            // 
            // Update
            // 
            this.Update.HeaderText = "";
            this.Update.Image = global::CompetencePlus.Properties.Resources.Update;
            this.Update.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Update.Name = "Update";
            this.Update.Width = 50;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Image = global::CompetencePlus.Properties.Resources.Delete;
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            this.Delete.Width = 50;
            // 
            // groupeBindingSource
            // 
            this.groupeBindingSource.DataSource = typeof(CompetencePlus.PackageGroupes.Groupe);
            // 
            // BtLast
            // 
            this.BtLast.Location = new System.Drawing.Point(671, 404);
            this.BtLast.Name = "BtLast";
            this.BtLast.Size = new System.Drawing.Size(75, 23);
            this.BtLast.TabIndex = 14;
            this.BtLast.Text = ">>";
            this.BtLast.UseVisualStyleBackColor = true;
            this.BtLast.Click += new System.EventHandler(this.BtLast_Click);
            // 
            // BtNext
            // 
            this.BtNext.Location = new System.Drawing.Point(579, 404);
            this.BtNext.Name = "BtNext";
            this.BtNext.Size = new System.Drawing.Size(75, 23);
            this.BtNext.TabIndex = 13;
            this.BtNext.Text = ">";
            this.BtNext.UseVisualStyleBackColor = true;
            this.BtNext.Click += new System.EventHandler(this.BtNext_Click);
            // 
            // BtPrevious
            // 
            this.BtPrevious.Location = new System.Drawing.Point(481, 404);
            this.BtPrevious.Name = "BtPrevious";
            this.BtPrevious.Size = new System.Drawing.Size(75, 23);
            this.BtPrevious.TabIndex = 12;
            this.BtPrevious.Text = "<";
            this.BtPrevious.UseVisualStyleBackColor = true;
            this.BtPrevious.Click += new System.EventHandler(this.BtPrevious_Click);
            // 
            // BtFirst
            // 
            this.BtFirst.Location = new System.Drawing.Point(388, 404);
            this.BtFirst.Name = "BtFirst";
            this.BtFirst.Size = new System.Drawing.Size(75, 23);
            this.BtFirst.TabIndex = 11;
            this.BtFirst.Text = "<<";
            this.BtFirst.UseVisualStyleBackColor = true;
            this.BtFirst.Click += new System.EventHandler(this.BtFirst_Click);
            // 
            // FormGestionGroupes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 451);
            this.Controls.Add(this.BtLast);
            this.Controls.Add(this.BtNext);
            this.Controls.Add(this.BtPrevious);
            this.Controls.Add(this.BtFirst);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.BtAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormGestionGroupes";
            this.Text = "FormGestionGroupes";
            this.Load += new System.EventHandler(this.FormGestionGroupes_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filiereBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtResearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.TextBox CodeTextBox;
        private System.Windows.Forms.TextBox NomTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label CodeLabel;
        private System.Windows.Forms.Label NomLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView groupeDataGridView;
        private System.Windows.Forms.ComboBox FiliereComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtLast;
        private System.Windows.Forms.Button BtNext;
        private System.Windows.Forms.Button BtPrevious;
        private System.Windows.Forms.Button BtFirst;
        private System.Windows.Forms.BindingSource filiereBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filiereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Update;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.BindingSource groupeBindingSource;
    }
}