namespace Essaie
{
    partial class Form1
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
            this.dgProduit = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.txtQteStock = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQteMin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnReinitialiser = new System.Windows.Forms.Button();
            this.btnRechercherDesignation = new System.Windows.Forms.Button();
            this.txtDatePeremption = new System.Windows.Forms.DateTimePicker();
            this.btnRechercherDate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProduit
            // 
            this.dgProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduit.Location = new System.Drawing.Point(244, 78);
            this.dgProduit.Name = "dgProduit";
            this.dgProduit.Size = new System.Drawing.Size(544, 346);
            this.dgProduit.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Designation";
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(17, 112);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(184, 20);
            this.txtDesignation.TabIndex = 1;
            // 
            // txtQteStock
            // 
            this.txtQteStock.Location = new System.Drawing.Point(17, 180);
            this.txtQteStock.Name = "txtQteStock";
            this.txtQteStock.Size = new System.Drawing.Size(184, 20);
            this.txtQteStock.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantite en stock";
            // 
            // txtQteMin
            // 
            this.txtQteMin.Location = new System.Drawing.Point(17, 248);
            this.txtQteMin.Name = "txtQteMin";
            this.txtQteMin.Size = new System.Drawing.Size(184, 20);
            this.txtQteMin.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantite minimale";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date de peremption";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(9, 13);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(98, 37);
            this.btnAjouter.TabIndex = 5;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(120, 13);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(98, 37);
            this.btnModifier.TabIndex = 6;
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(231, 13);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(98, 37);
            this.btnSupprimer.TabIndex = 7;
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(342, 13);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(98, 37);
            this.btnSelect.TabIndex = 8;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnReinitialiser
            // 
            this.btnReinitialiser.Location = new System.Drawing.Point(453, 13);
            this.btnReinitialiser.Name = "btnReinitialiser";
            this.btnReinitialiser.Size = new System.Drawing.Size(98, 37);
            this.btnReinitialiser.TabIndex = 9;
            this.btnReinitialiser.Text = "Reinitialiser";
            this.btnReinitialiser.UseVisualStyleBackColor = true;
            this.btnReinitialiser.Click += new System.EventHandler(this.btnReinitialiser_Click);
            // 
            // btnRechercherDesignation
            // 
            this.btnRechercherDesignation.Location = new System.Drawing.Point(564, 13);
            this.btnRechercherDesignation.Name = "btnRechercherDesignation";
            this.btnRechercherDesignation.Size = new System.Drawing.Size(98, 37);
            this.btnRechercherDesignation.TabIndex = 10;
            this.btnRechercherDesignation.Text = "Recherche par designation";
            this.btnRechercherDesignation.UseVisualStyleBackColor = true;
            this.btnRechercherDesignation.Click += new System.EventHandler(this.btnRechercherDesignation_Click);
            // 
            // txtDatePeremption
            // 
            this.txtDatePeremption.Location = new System.Drawing.Point(17, 314);
            this.txtDatePeremption.Name = "txtDatePeremption";
            this.txtDatePeremption.Size = new System.Drawing.Size(200, 20);
            this.txtDatePeremption.TabIndex = 4;
            // 
            // btnRechercherDate
            // 
            this.btnRechercherDate.Location = new System.Drawing.Point(675, 13);
            this.btnRechercherDate.Name = "btnRechercherDate";
            this.btnRechercherDate.Size = new System.Drawing.Size(98, 37);
            this.btnRechercherDate.TabIndex = 11;
            this.btnRechercherDate.Text = "Rechercher par Date peremption";
            this.btnRechercherDate.UseVisualStyleBackColor = true;
            this.btnRechercherDate.Click += new System.EventHandler(this.btnRechercherDate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRechercherDate);
            this.Controls.Add(this.txtDatePeremption);
            this.Controls.Add(this.btnRechercherDesignation);
            this.Controls.Add(this.btnReinitialiser);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQteMin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQteStock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDesignation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgProduit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProduit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.TextBox txtQteStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQteMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnReinitialiser;
        private System.Windows.Forms.Button btnRechercherDesignation;
        private System.Windows.Forms.DateTimePicker txtDatePeremption;
        private System.Windows.Forms.Button btnRechercherDate;
    }
}

