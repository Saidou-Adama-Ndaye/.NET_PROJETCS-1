namespace GestionVille
{
    public partial class frmVille : Form
    {
        public frmVille()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bntAjouter_Click(object sender, EventArgs e)
        {
            lstVille.Items.Add(txtVille.Text);
            txtVille.Clear();
            txtVille.Focus();
        }

        private void bntSupprimer_Click(object sender, EventArgs e)
        {
            lstVille.Items.RemoveAt(lstVille.SelectedIndex);
        }
    }
}