using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiColorModernUI.Model;
using MultiColorModernUI.Report;

namespace MultiColorModernUI.Forms
{
    public partial class FormReportClient : Form
    {
        BDGLAtelierEntities7 db = new BDGLAtelierEntities7();
        public FormReportClient()
        {
            InitializeComponent();
        }

        private void FormReportClient_Load(object sender, EventArgs e)
        {
            rptListeClient objRpt = new rptListeClient();
            objRpt.SetDataSource(GetTableClent());
            crystalReportViewer1.ReportSource= objRpt;
            crystalReportViewer1.Refresh();
        }

        public DataTable GetTableClent()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("NomPers", typeof(string));
            dt.Columns.Add("PrenomPers", typeof(string));
            dt.Columns.Add("AdressePers", typeof(string));
            dt.Columns.Add("TelPers", typeof(string));
            dt.Columns.Add("CNIClient", typeof(string));
            dt.Columns.Add("SexeClient", typeof(string));

            var listeClient = db.Client.ToList();
            foreach (var i  in listeClient) 
            {
                var p = db.Personne.Find(i.IdPers);
                dt.Rows.Add(p.NomPers, p.PrenomPers, p.AdressePers, p.TelPers,
                                i.CNIClient, i.SexeClient) ;
            }

            return dt;

        }
    }
}
