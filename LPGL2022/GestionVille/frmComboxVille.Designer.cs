namespace GestionVille
{
    partial class frmComboxVille
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
            this.cbbVille = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bntSupprimer = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.bntAjouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbVille
            // 
            this.cbbVille.FormattingEnabled = true;
            this.cbbVille.Location = new System.Drawing.Point(63, 68);
            this.cbbVille.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cbbVille.Name = "cbbVille";
            this.cbbVille.Size = new System.Drawing.Size(438, 32);
            this.cbbVille.TabIndex = 0;
            this.cbbVille.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Saisir une ville";
            // 
            // bntSupprimer
            // 
            this.bntSupprimer.Location = new System.Drawing.Point(198, 250);
            this.bntSupprimer.Name = "bntSupprimer";
            this.bntSupprimer.Size = new System.Drawing.Size(114, 30);
            this.bntSupprimer.TabIndex = 5;
            this.bntSupprimer.Text = "&Supprimer";
            this.bntSupprimer.UseVisualStyleBackColor = true;
            this.bntSupprimer.Click += new System.EventHandler(this.bntSupprimer_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(198, 342);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(114, 30);
            this.btnQuitter.TabIndex = 6;
            this.btnQuitter.Text = "&Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // bntAjouter
            // 
            this.bntAjouter.Location = new System.Drawing.Point(198, 150);
            this.bntAjouter.Name = "bntAjouter";
            this.bntAjouter.Size = new System.Drawing.Size(114, 30);
            this.bntAjouter.TabIndex = 4;
            this.bntAjouter.Text = "&Ajouter";
            this.bntAjouter.UseVisualStyleBackColor = true;
            this.bntAjouter.Click += new System.EventHandler(this.bntAjouter_Click);
            // 
            // frmComboxVille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 539);
            this.ControlBox = false;
            this.Controls.Add(this.bntSupprimer);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.bntAjouter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbVille);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmComboxVille";
            this.Text = "frmComboxVille";
            this.Load += new System.EventHandler(this.frmComboxVille_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbbVille;
        private Label label1;
        private Button bntSupprimer;
        private Button btnQuitter;
        private Button bntAjouter;
    }
}