using Essaie.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Essaie
{
    public partial class Form1 : Form
    {
        gestionProduitEntities db = new gestionProduitEntities();
        public Form1()
        {

            InitializeComponent();
        }

        private void effacer()
        {
            txtDesignation.Text = string.Empty;
            txtQteStock.Text = string.Empty;
            txtQteMin.Text = string.Empty;
            txtDatePeremption.Text = string.Empty;
            dgProduit.DataSource= db.Produit.ToList();
            txtDesignation.Focus();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Produit p = new Produit();
            p.Designation = txtDesignation.Text;
            p.QteStock = double.Parse(txtQteStock.Text);
            p.QteMin = double.Parse(txtQteMin.Text);
            p.DatePeremption = DateTime.Parse(txtDatePeremption.Text);
            db.Produit.Add(p);
            db.SaveChanges();
            effacer();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
            Produit p = db.Produit.Find(id);
            p.Designation = txtDesignation.Text;
            p.QteStock = double.Parse(txtQteStock.Text);
            p.QteMin = double.Parse(txtQteMin.Text);
            p.DatePeremption = DateTime.Parse(txtDatePeremption.Text);
            db.SaveChanges();
            effacer();
        }
        
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
            Produit p = db.Produit.Find(id);
            db.Produit.Remove(p);
            db.SaveChanges();
            effacer();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
            txtDesignation.Text = dgProduit.CurrentRow.Cells[1].Value.ToString();
            txtQteStock.Text = dgProduit.CurrentRow.Cells[2].Value.ToString();
            txtQteMin.Text = dgProduit.CurrentRow.Cells[3].Value.ToString();
            txtDatePeremption.Text = dgProduit.CurrentRow.Cells[4].Value.ToString();
            var p = db.Produit.Find(id);
            txtDesignation.Text = p.Designation;
            txtQteStock.Text = p.QteStock.ToString();
            txtQteMin.Text = p.QteMin.ToString();
            txtDatePeremption.Text = p.DatePeremption.ToString();
        }

        private void btnReinitialiser_Click(object sender, EventArgs e)
        {
            effacer();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            dgProduit.DataSource= db.Produit.ToList();
        }

        private void btnRechercherDesignation_Click(object sender, EventArgs e)
        {
            var liste = db.Produit.ToList();

            if (!string.IsNullOrEmpty(txtDesignation.Text))
            {
                liste = liste.Where(s => s.Designation != null).ToList();
                liste = liste.Where(s => s.Designation.ToUpper().Contains(txtDesignation.Text.ToUpper())).ToList();

            }
            dgProduit.DataSource= liste.ToList();
        }

        private void btnRechercherDate_Click(object sender, EventArgs e)
        {
            var liste = db.Produit.ToList();

            if (!string.IsNullOrEmpty(txtDatePeremption.Text))
            {
                liste = liste.Where(s => s.DatePeremption != null).ToList();
                liste = liste.Where(s => s.DatePeremption.Equals(txtDatePeremption.Text)).ToList();

            }
            dgProduit.DataSource = liste.ToList();

        }
    }
}
