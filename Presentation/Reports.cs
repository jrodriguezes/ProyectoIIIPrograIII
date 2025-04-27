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
using Logic;

namespace Presentation
{
    public partial class Reports : Form
    {
        EmailService emailService = new EmailService();
        DbCrud crud = new DbCrud();
        UserService userService = new UserService();
        int userId = -1;
        public Reports(int id)
        {
            InitializeComponent();
            this.userId = id;
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

        private void dgvReports_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var result = MessageBox.Show("¿Desea enviar esta información a su correo?", "Enviar PDF", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow row = dgvReports.Rows[e.RowIndex];
                    Dictionary<string, string> data = new Dictionary<string, string>();

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.OwningColumn != null && cell.Value != null)
                        {
                            string columnName = cell.OwningColumn.HeaderText;
                            string value = cell.Value.ToString();
                            data.Add(columnName, value);
                        }
                    }

                    // 👉 Generar el PDF
                    byte[] pdfBytes = emailService.generateSimplePdfFromData(data);

                    // 👉 Obtener correo por userId
                    string email = userService.getEmailById(userId);

                    if (!string.IsNullOrEmpty(email))
                    {
                        emailService.sendPDFEmail(email, pdfBytes);
                    }
                    else
                    {
                        MessageBox.Show("⚠️ No se encontró un correo para este usuario.");
                    }
                }
            }
        }
    }
}

