namespace StockProduit
{
    partial class FrmMDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oUVIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cATEGORIEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oUVIRToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // oUVIRToolStripMenuItem
            // 
            this.oUVIRToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pRODUITToolStripMenuItem,
            this.cATEGORIEToolStripMenuItem});
            this.oUVIRToolStripMenuItem.Name = "oUVIRToolStripMenuItem";
            this.oUVIRToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oUVIRToolStripMenuItem.Text = "OUVIR";
            // 
            // pRODUITToolStripMenuItem
            // 
            this.pRODUITToolStripMenuItem.Name = "pRODUITToolStripMenuItem";
            this.pRODUITToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pRODUITToolStripMenuItem.Text = "PRODUIT";
            this.pRODUITToolStripMenuItem.Click += new System.EventHandler(this.pRODUITToolStripMenuItem_Click);
            // 
            // cATEGORIEToolStripMenuItem
            // 
            this.cATEGORIEToolStripMenuItem.Name = "cATEGORIEToolStripMenuItem";
            this.cATEGORIEToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cATEGORIEToolStripMenuItem.Text = "CATEGORIE";
            this.cATEGORIEToolStripMenuItem.Click += new System.EventHandler(this.cATEGORIEToolStripMenuItem_Click);
            // 
            // FrmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMDI";
            this.Text = "FrmMDI";
            this.Load += new System.EventHandler(this.FrmMDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oUVIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRODUITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cATEGORIEToolStripMenuItem;
    }
}