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
    public partial class FrmCategorie : Form
    {
        stockproduitEntities3 db = new stockproduitEntities3();
        public FrmCategorie()
        {
            InitializeComponent();
        }

        private void load()
        {
            dgCategorie.DataSource = db.categorie.ToList();
        }


        private void btnAjouter_Click(object sender, EventArgs e)
        {

            categorie c = new categorie();
            c.libelle = txtLibelle.Text;
            db.categorie.Add(c);
            db.SaveChanges();
            load();
        }

        private void FrmCategorie_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
