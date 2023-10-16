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
    public partial class frmComboxVille : Form
    {
        public frmComboxVille()
        {
            InitializeComponent();
        }

        private void frmComboxVille_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bntAjouter_Click(object sender, EventArgs e)
        {
            cbbVille.Items.Add(cbbVille.Text);
            cbbVille.Text = string.Empty;
            cbbVille.Focus();
        }

        private void bntSupprimer_Click(object sender, EventArgs e)
        {
            cbbVille.Items.RemoveAt(cbbVille.SelectedIndex);
        }
    }
}
