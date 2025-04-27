using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;

namespace Presentation
{
    public partial class Reports : Form
    {
        DbCrud crud = new DbCrud();
        public Reports()
        {
            InitializeComponent();
        }

        private void rdRep1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdRep1.Checked)
            {
                dgvReports.DataSource = crud.GetReporte1();
            }
        }

        private void rdRep2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdRep2.Checked)
            {
                dgvReports.DataSource = crud.GetReporte2();
            }
        }

        private void rdRep3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdRep3.Checked)
            {
                dgvReports.DataSource = crud.GetReporte3();
            }
        }
    }
}
