using MultiColorModernUI.App_Code;
using MultiColorModernUI.Model;
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

namespace MultiColorModernUI
{
    public partial class frmConnexion : Form
    {
        BDGLAtelierEntities7 db = new BDGLAtelierEntities7();

        public frmConnexion()
        {
            InitializeComponent();
        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            var leUser = db.Gerant.Where(a=> a.IdentifiantGer == txtIdentifiant.Text).FirstOrDefault();
            if (leUser != null)
            {
                using (MD5 md5Hash= MD5.Create())
                {
                    if (Helpers.VerifyMd5Hash(md5Hash, txtMotDePasse.Text, leUser.MotDePasseGer))
                    {
                        FormMainMenu f = new FormMainMenu();
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Identifiant ou mot de passe incorrect!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Identifiant ou mot de passe incorrect!");
            }
            txtIdentifiant.Text = String.Empty;
        }

        private void frmConnexion_Load(object sender, EventArgs e)
        {

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {

        }
    }
}
