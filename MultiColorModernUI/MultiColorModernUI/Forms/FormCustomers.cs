using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiColorModernUI.Model;

namespace MultiColorModernUI.Forms
{
    public partial class tex : Form
    {
        BDGLAtelierEntities7 db = new BDGLAtelierEntities7();
        public tex()
        {
            InitializeComponent();
            
        }
        private void FormCustomers_Load(object sender, EventArgs e)
        {
            LoadTheme();
            dgClient.DataSource= db.Client.ToList();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            label4.ForeColor = ThemeColor.SecondaryColor;
            label5.ForeColor = ThemeColor.PrimaryColor;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Personne p = new Personne();
            p.NomPers = txtNom.Text;
            p.PrenomPers = txtPrenom.Text;
            p.AdressePers = txtAdresse.Text;
            p.TelPers= txtTel.Text;
            db.Personne.Add(p);
            db.SaveChanges();
            Client c = new Client();
            c.CNIClient = txtCNI.Text;
            c.SexeClient = cbbSexe.Text;
            c.IdPers = p.IdPers;
            db.Client.Add(c);
            db.SaveChanges();
            effacer();
        }

        private void effacer()
        {
            txtNom.Text = string.Empty;
            txtPrenom.Text = string.Empty;
            txtAdresse.Text = string.Empty;
            txtTel.Text = string.Empty;
            txtCNI.Text = string.Empty;
            cbbSexe.Text = string.Empty;
            dgClient.DataSource = db.Client.ToList();
            txtNom.Focus();
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgClient.CurrentRow.Cells[0].Value.ToString());
            txtCNI.Text = dgClient.CurrentRow.Cells[1].Value.ToString();
            cbbSexe.Text = dgClient.CurrentRow.Cells[2].Value.ToString();
            var p = db.Personne.Find(id);
            txtNom.Text = p.NomPers;
            txtPrenom.Text = p.PrenomPers;
            txtAdresse.Text = p.AdressePers;
            txtTel.Text = p.TelPers;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgClient.CurrentRow.Cells[0].Value.ToString());
            Personne p = db.Personne.Find(id);
            p.NomPers = txtNom.Text;
            p.PrenomPers = txtPrenom.Text;
            p.AdressePers = txtAdresse.Text;
            p.TelPers = txtTel.Text;
            Client c = db.Client.Find(id);
            c.CNIClient = txtCNI.Text;
            c.SexeClient = cbbSexe.Text;
            db.SaveChanges();
            effacer();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgClient.CurrentRow.Cells[0].Value.ToString());
            Personne p = db.Personne.Find(id);
            db.Personne.Remove(p);
            Client c = db.Client.Find(id);
            db.Client.Remove(c);
            db.SaveChanges();
            effacer();
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            effacer();
        }

        private void btnMesure_Click(object sender, EventArgs e)
        {
            formMesure f = new formMesure();
            f.idPers = int.Parse(dgClient.CurrentRow.Cells[0].Value.ToString());
            f.sexe = cbbSexe.Text;
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var liste = db.Personne.ToList();

            if (!string.IsNullOrEmpty(txtNom.Text) )
            {
                liste = liste.Where(s => s.NomPers != null).ToList();
                liste = liste.Where(s => s.NomPers.ToUpper().Contains(txtNom.Text.ToUpper())).ToList();
                
            }

            if (!string.IsNullOrEmpty(txtPrenom.Text))
            {
                liste = liste.Where(s => s.PrenomPers != null).ToList();
                liste = liste.Where(s => s.PrenomPers.ToUpper().Contains(txtPrenom.Text.ToUpper())).ToList();

            }

            if (!string.IsNullOrEmpty(txtTel.Text))
            {
                liste = liste.Where(s => s.TelPers != null).ToList();
                liste = liste.Where(s => s.TelPers.ToUpper().Contains(txtTel.Text.ToUpper())).ToList();

            }

            dgClient.DataSource = liste.ToList();
        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            FormReportClient f = new FormReportClient();
            f.Show();
        }
    }
}
