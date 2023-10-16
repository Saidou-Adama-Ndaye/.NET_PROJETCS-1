using StockProduit.Model;
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
    public partial class FrmProduit : Form
    {
       stockproduitEntities3 db = new stockproduitEntities3();
        public FrmProduit()
        {
            InitializeComponent();
        }

        private void FrmProduit_Load(object sender, EventArgs e)
        {
            cbbCategorie.DisplayMember = "libelle";
            cbbCategorie.DataSource = db.categorie.Select(s => s.libelle).ToList();
            load();
        }

        private void load()
        {
            dgProduit.DataSource = db.produit.ToList();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            produit p = new produit();
            p.DenominationProduit = txtDesignation.Text;
            p.QuantiteProduit = txtQuantite.Text;
            p.PUProduit = float.Parse(txtPU.Text);
            db.produit.Add(p);
            db.SaveChanges();
            load();


        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
            produit p = db.produit.Find(id);
            db.produit.Remove(p);
            db.SaveChanges();

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
            produit p = db.produit.Find(id);
            p.DenominationProduit = txtDesignation.Text;
            p.CategorieProuit = cbbCategorie.Text;
            p.QuantiteProduit = txtQuantite.Text;
            p.PUProduit = float.Parse(txtPU.Text);
            db.SaveChanges();
        }

      
    }
}
