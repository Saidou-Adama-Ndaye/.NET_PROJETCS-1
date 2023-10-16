using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPLINQ.Model;

namespace TPLINQ
{
    public partial class Form1 : Form
    {
        TSQLV4Entities db = new TSQLV4Entities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DgExercice.DataSource= db.Customers.Select(c => new
            {
                c.custid,
                c.companyname,
                c.contactname
            }).ToList();
        }
    }
}
