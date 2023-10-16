using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGestionStock
{
    public partial class Form1 : Form
    {
        WcfService.Service1Client service = new WcfService.Service1Client();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgProduit.DataSource = service.getProduits();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            WcfService.Produit p = new WcfService.Produit();
            p.description = txtDescription.Text;
            p.libelle = txtLibelle.Text;
            p.Pu = !string.IsNullOrEmpty(txtPU.Text) ? double.Parse(txtPU.Text) : 0;
            p.Pu = !string.IsNullOrEmpty(txtQuantite.Text) ? double.Parse(txtQuantite.Text) : 0;
            service.AjoutProduit(p);
            effacer();
        }

        private void effacer()
        {
            txtQuantite.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtId.Text = string.Empty;
            txtLibelle.Text = string.Empty;
            txtPU.Text = string.Empty;
            dgProduit.DataSource = service.getProduits();
            txtLibelle.Focus();
        }
    }
}
