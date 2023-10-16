using Carnet_adresse_contact.Model;
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

namespace Carnet_adresse_contact
{
    public partial class frmContact : Form
    {
        GestionCarnetContactEntities db = new GestionCarnetContactEntities();
        public frmContact()
        {
            InitializeComponent();
        }

        private void frmContact_Load(object sender, EventArgs e)
        {
            dgContact.DataSource= db.Contact.ToList();
        }

        private void effacer()
        {
            txtNom.Text = string.Empty;
            txtPrenom.Text = string.Empty;
            txtCSP.Text = string.Empty;
            cbbSexe.Text = string.Empty;
            txtCSP.Text = string.Empty;
            txtVille.Text = string.Empty;
            dgContact.DataSource = db.Contact.ToList();
            txtNom.Focus();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Contact c = new Contact();
            c.Nom = txtNom.Text;
            c.Prenom = txtPrenom.Text;
            c.CSP = txtCSP.Text;
            c.Sexe = cbbSexe.Text;
            c.Ville = txtVille.Text;
            db.Contact.Add(c);
            db.SaveChanges();
            effacer();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgContact.CurrentRow.Cells[0].Value.ToString());
            Contact c = db.Contact.Find(id);
            c.Nom = txtNom.Text;
            c.Prenom = txtPrenom.Text;
            c.CSP = txtCSP.Text;
            c.Sexe = cbbSexe.Text;
            c.Ville = txtVille.Text;
            db.SaveChanges();
            effacer();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgContact.CurrentRow.Cells[0].Value.ToString());
            Contact c = db.Contact.Find(id);
            db.Contact.Remove(c);
            db.SaveChanges();
            effacer();
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgContact.CurrentRow.Cells[0].Value.ToString());
            txtNom.Text = dgContact.CurrentRow.Cells[1].Value.ToString();
            txtPrenom.Text = dgContact.CurrentRow.Cells[2].Value.ToString();
            txtCSP.Text = dgContact.CurrentRow.Cells[3].Value.ToString();
            cbbSexe.Text = dgContact.CurrentRow.Cells[4].Value.ToString();
            txtVille.Text = dgContact.CurrentRow.Cells[5].Value.ToString();
            cbbSexe.Text = dgContact.CurrentRow.Cells[6].Value.ToString();
            
        }

        private void btnReinitialiser_Click(object sender, EventArgs e)
        {
            effacer();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            var liste = db.Contact.ToList();

            if (!string.IsNullOrEmpty(txtNom.Text))
            {
                liste = liste.Where(s => s.Nom != null).ToList();
                liste = liste.Where(s => s.Nom.ToUpper().Contains(txtNom.Text.ToUpper())).ToList();

            }

            if (!string.IsNullOrEmpty(txtPrenom.Text))
            {
                liste = liste.Where(s => s.Prenom != null).ToList();
                liste = liste.Where(s => s.Prenom.ToUpper().Contains(txtPrenom.Text.ToUpper())).ToList();

            }

            if (!string.IsNullOrEmpty(txtCSP.Text))
            {
                liste = liste.Where(s => s.CSP != null).ToList();
                liste = liste.Where(s => s.CSP.ToUpper().Contains(txtCSP.Text.ToUpper())).ToList();

            }

            if (!string.IsNullOrEmpty(cbbSexe.Text))
            {
                liste = liste.Where(s => s.Sexe != null).ToList();
                liste = liste.Where(s => s.Sexe.ToUpper().Contains(cbbSexe.Text.ToUpper())).ToList();

            }

            if (!string.IsNullOrEmpty(txtVille.Text))
            {
                liste = liste.Where(s => s.Ville != null).ToList();
                liste = liste.Where(s => s.Ville.ToUpper().Contains(txtCSP.Text.ToUpper())).ToList();

            }

            dgContact.DataSource = liste.ToList();
        }

       
    }
}
