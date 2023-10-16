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

namespace StockProduit
{
    public partial class FrmMDI : Form
    {
        public FrmMDI()
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

        private void pRODUITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            FrmProduit f = new FrmProduit();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;

        }

        private void FrmMDI_Load(object sender, EventArgs e)
        {
            Computer myComputer = new Computer();
            this.Width = myComputer.Screen.Bounds.Width;
            this.Height = myComputer.Screen.Bounds.Height;
            this.Location = new Point(0, 0);
        }

        private void cATEGORIEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            FrmCategorie f = new FrmCategorie();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;

        }
    }
}
