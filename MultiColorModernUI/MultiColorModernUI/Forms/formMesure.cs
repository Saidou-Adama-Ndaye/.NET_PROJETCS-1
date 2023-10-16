using MultiColorModernUI.Model;
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


namespace MultiColorModernUI.Forms
{
   
    public partial class formMesure : Form
    {
        BDGLAtelierEntities7 db = new BDGLAtelierEntities7();
        public int idPers;
        public string sexe;
        public formMesure()
        {
            InitializeComponent();
        }

        private void formMesure_Load(object sender, EventArgs e)
        {
            
            if (sexe == "Homme")
            {
               
                        dgMesure.DataSource = db.Mesure.Select(s => new
                        {
                            s.IdPers,
                            s.TourP,
                            s.TourT,
                            s.TourB,
                            s.CarrureDev,
                            s.CarrureDos,
                            s.LongE,
                            s.TourBras
                        }).ToList();
               
               
            }
            else
            {
                dgMesure.DataSource = db.Mesure.ToList();
            }
            
            pnFemme.Visible = sexe == "Femme" ? true : false;
            
        }

        private void pnFemme_Paint(object sender, PaintEventArgs e)
        {
            pnFemme.Visible = sexe == "Femme" ? true : false;
            
        }

        private void dgMesure_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
                Mesure m = new Mesure();
                m.TourP = float.Parse(txtPoitrine.Text);
                m.TourT = float.Parse(txtTaille.Text);
                m.TourB = float.Parse(txtTourBassin.Text);
                m.CarrureDev = float.Parse(txtCarrureDevant.Text);
                m.CarrureDos = float.Parse(txtCarrureDos.Text);
                m.LongE = float.Parse(txtLongueurEpaule.Text);
                m.TourBras = float.Parse(txtTourBras.Text);
                m.HautTG = float.Parse(txtHauteurTailleGenou.Text);
                m.EcartPS = (sexe == "Femme") ?float.Parse(txtEcartementSeins.Text)  : 0.0;
                m.LongBD = (sexe == "Femme") ? float.Parse(txtBusteDos.Text) : 0.0;
                m.LongPS = (sexe == "Femme") ? float.Parse(txtBaseSeins.Text) : 0.0;
                m.LongBusteD = (sexe == "Femme") ? float.Parse(txtBusteDevant.Text) : 0.0;
                m.LongBP = (sexe == "Femme") ? float.Parse(txtLongueurBras.Text) : 0.0;
                m.HautTD = (sexe == "Femme") ? float.Parse(txtHauteurTailleDos.Text) : 0.0;
                m.LongTC = (sexe == "Femme") ? float.Parse(txtLongueurTailleCote.Text) : 0.0;
                m.HautEJ = (sexe == "Femme") ? float.Parse(txtHauteurEntreJambes.Text) : 0.0;
                m.IdPers = idPers;
                db.Mesure.Add(m);
                db.SaveChanges();

            if (sexe == "Homme")
            {

                dgMesure.DataSource = db.Mesure.Select(s => new
                {
                    s.IdPers,
                    s.TourP,
                    s.TourT,
                    s.TourB,
                    s.CarrureDev,
                    s.CarrureDos,
                    s.LongE,
                    s.TourBras
                }).ToList();


            }
            else
            {
                dgMesure.DataSource = db.Mesure.ToList();
            }





            /* p.NomPers = txtNom.Text;
             p.PrenomPers = txtPrenom.Text;
             p.AdressePers = txtAdresse.Text;
             p.TelPers = txtTel.Text;
             db.Personne.Add(p);
             db.SaveChanges();
             Client c = new Client();
             c.CNIClient = txtCNI.Text;
             c.SexeClient = cbbSexe.Text;
             c.IdPers = p.IdPers;
             db.Client.Add(c);
             db.SaveChanges();
             effacer();*/

        }
    }
}
