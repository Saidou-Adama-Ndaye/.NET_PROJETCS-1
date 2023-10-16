namespace GestionVille
{
    partial class frmVille
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstVille = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bntAjouter = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.bntSupprimer = new System.Windows.Forms.Button();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstVille
            // 
            this.lstVille.FormattingEnabled = true;
            this.lstVille.ItemHeight = 24;
            this.lstVille.Location = new System.Drawing.Point(12, 12);
            this.lstVille.Name = "lstVille";
            this.lstVille.Size = new System.Drawing.Size(185, 340);
            this.lstVille.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Saisir une ville";
            // 
            // bntAjouter
            // 
            this.bntAjouter.Location = new System.Drawing.Point(261, 130);
            this.bntAjouter.Name = "bntAjouter";
            this.bntAjouter.Size = new System.Drawing.Size(114, 30);
            this.bntAjouter.TabIndex = 1;
            this.bntAjouter.Text = "&Ajouter";
            this.bntAjouter.UseVisualStyleBackColor = true;
            this.bntAjouter.Click += new System.EventHandler(this.bntAjouter_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(261, 322);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(114, 30);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.Text = "&Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // bntSupprimer
            // 
            this.bntSupprimer.Location = new System.Drawing.Point(261, 230);
            this.bntSupprimer.Name = "bntSupprimer";
            this.bntSupprimer.Size = new System.Drawing.Size(114, 30);
            this.bntSupprimer.TabIndex = 2;
            this.bntSupprimer.Text = "&Supprimer";
            this.bntSupprimer.UseVisualStyleBackColor = true;
            this.bntSupprimer.Click += new System.EventHandler(this.bntSupprimer_Click);
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(216, 51);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(198, 29);
            this.txtVille.TabIndex = 0;
            this.txtVille.Text = "\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 488);
            this.ControlBox = false;
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.bntSupprimer);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.bntAjouter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstVille);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Gestion des villes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstVille;
        private Label label1;
        private Button bntAjouter;
        private Button btnQuitter;
        private Button bntSupprimer;
        private TextBox txtVille;
    }
}