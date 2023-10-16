namespace Carnet_adresse_contact
{
    partial class frmContact
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.Prenom = new System.Windows.Forms.Label();
            this.txtCSP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbSexe = new System.Windows.Forms.ComboBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnSelectionner = new System.Windows.Forms.Button();
            this.btnReinitialiser = new System.Windows.Forms.Button();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.dgContact = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgContact)).BeginInit();
            this.SuspendLayout();
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nom.Location = new System.Drawing.Point(16, 66);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(41, 18);
            this.Nom.TabIndex = 0;
            this.Nom.Text = "Nom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(16, 97);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(203, 20);
            this.txtNom.TabIndex = 1;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(16, 161);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(203, 20);
            this.txtPrenom.TabIndex = 3;
            // 
            // Prenom
            // 
            this.Prenom.AutoSize = true;
            this.Prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prenom.Location = new System.Drawing.Point(16, 130);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(61, 18);
            this.Prenom.TabIndex = 2;
            this.Prenom.Text = "Prenom";
            // 
            // txtCSP
            // 
            this.txtCSP.Location = new System.Drawing.Point(16, 225);
            this.txtCSP.Name = "txtCSP";
            this.txtCSP.Size = new System.Drawing.Size(203, 20);
            this.txtCSP.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Categorie socio-professionnel";
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(16, 354);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(203, 20);
            this.txtVille.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ville";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sexe";
            // 
            // cbbSexe
            // 
            this.cbbSexe.FormattingEnabled = true;
            this.cbbSexe.Items.AddRange(new object[] {
            "Homme",
            "Femme"});
            this.cbbSexe.Location = new System.Drawing.Point(16, 289);
            this.cbbSexe.Name = "cbbSexe";
            this.cbbSexe.Size = new System.Drawing.Size(203, 21);
            this.cbbSexe.TabIndex = 9;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(13, 13);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(95, 33);
            this.btnAjouter.TabIndex = 10;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(124, 13);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(95, 33);
            this.btnModifier.TabIndex = 11;
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(237, 13);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(95, 33);
            this.btnSupprimer.TabIndex = 12;
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnSelectionner
            // 
            this.btnSelectionner.Location = new System.Drawing.Point(352, 13);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(95, 33);
            this.btnSelectionner.TabIndex = 13;
            this.btnSelectionner.Text = "Selectionner";
            this.btnSelectionner.UseVisualStyleBackColor = true;
            this.btnSelectionner.Click += new System.EventHandler(this.btnSelectionner_Click);
            // 
            // btnReinitialiser
            // 
            this.btnReinitialiser.Location = new System.Drawing.Point(465, 13);
            this.btnReinitialiser.Name = "btnReinitialiser";
            this.btnReinitialiser.Size = new System.Drawing.Size(95, 33);
            this.btnReinitialiser.TabIndex = 14;
            this.btnReinitialiser.Text = "Reinitialiser";
            this.btnReinitialiser.UseVisualStyleBackColor = true;
            this.btnReinitialiser.Click += new System.EventHandler(this.btnReinitialiser_Click);
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(579, 13);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(95, 33);
            this.btnRechercher.TabIndex = 15;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // dgContact
            // 
            this.dgContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgContact.Location = new System.Drawing.Point(320, 98);
            this.dgContact.Name = "dgContact";
            this.dgContact.Size = new System.Drawing.Size(468, 285);
            this.dgContact.TabIndex = 16;
            // 
            // frmContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.dgContact);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.btnReinitialiser);
            this.Controls.Add(this.btnSelectionner);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.cbbSexe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCSP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.Prenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.Nom);
            this.Name = "frmContact";
            this.Text = "Contact";
            this.Load += new System.EventHandler(this.frmContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgContact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label Prenom;
        private System.Windows.Forms.TextBox txtCSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbSexe;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnSelectionner;
        private System.Windows.Forms.Button btnReinitialiser;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.DataGridView dgContact;
    }
}

