using System;
using System.Windows.Forms;
using Logic;
using System.Xml;
using System.Collections.Generic;

namespace Presentation
{
    public partial class LogIn : Form
    {
        
        public LogIn()
        {
            InitializeComponent();
        }

        int id = 0;

        validatePassword validate = new validatePassword();

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void register_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.ShowDialog();
        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            //if (validate.creedentials(txtCed, txtPassword))
            //{
            //    id = Convert.ToInt32(txtCed.Text);
            //    Principal principalForm = new Principal(id);
            //    principalForm.ShowDialog();
            //}
        }

        private void pb_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtCed_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
