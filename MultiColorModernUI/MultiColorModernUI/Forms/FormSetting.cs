using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiColorModernUI.App_Code;
using MultiColorModernUI.Model;

namespace MultiColorModernUI.Forms
{
    public partial class FormSetting : Form
    {
        BDGLAtelierEntities7 db = new BDGLAtelierEntities7();
        public FormSetting()
        {
            InitializeComponent();
        }

        private void FormSetting_Load(object sender, EventArgs e)
        {
            LoadTheme();
            dgUtilisateur.DataSource = db.Personne.Join(db.Gerant, p => p.IdPers,
                g => g.IdPers, (p, g) =>new
                {
                    p.IdPers,
                    g.IdentifiantGer,
                    p.NomPers,
                    p.PrenomPers
                }).ToList();
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

        private void btnCreer_Click(object sender, EventArgs e)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                Personne p = new Personne();
                p.AdressePers = txtAdresse.Text;
                p.NomPers = txtNom.Text;
                p.PrenomPers = txtPrenom.Text;
                p.TelPers = txtTelephone.Text;
                db.Personne.Add(p);
                db.SaveChanges();
                Gerant ut = new Gerant();
                ut.IdPers = p.IdPers;
                ut.IdentifiantGer = txtIdentifiant.Text;
                ut.MotDePasseGer = Helpers.GetMd5Hash(md5Hash, txtMotDePasse.Text);
                db.Gerant.Add(ut);
                db.SaveChanges();
                txtMotDePasse.Clear();
                txtIdentifiant.Clear();
                txtNom.Clear();
                txtPrenom.Clear();
                txtTelephone.Clear();
                txtAdresse.Clear();

                dgUtilisateur.DataSource = db.Personne.Join(db.Gerant, pp => pp.IdPers,
               g => g.IdPers, (pp, g) => new
               {
                   p.IdPers,
                   g.IdentifiantGer,
                   pp.NomPers,
                   pp.PrenomPers
               }).ToList();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
