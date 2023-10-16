using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionVille
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        private void fermer()
        {
            Form[] charr = this.MdiChildren;
            
            //For each from set the window state to
            foreach (Form chform in charr) 
            {
                //chform.WindowState = FormWondowState.Maxim
                chform.Close();
            }
        }


       

        private void comboxBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {

            fermer();
            frmComboxVille f = new frmComboxVille();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }


        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmVille f = new frmVille();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }


        private void frmMDI_Load(object sender, EventArgs e)
        {
            Computer myComputer = new Computer();
            this.Width = myComputer.Screen.Bounds.Width;
            this.Height = myComputer.Screen.Bounds.Height;
            this.Location = new Point(0, 0);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
