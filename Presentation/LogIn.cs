using System;
using System.Windows.Forms;
using Logic;
using System.Xml;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Xml.Linq;

namespace Presentation
{
    public partial class LogIn : Form
    {
        UserService userService = new UserService();
        SecurityUtils securityUtils = new SecurityUtils();
        public LogIn()
        {
            InitializeComponent();
        }

        int id = 0;
        string email = "";


        private void register_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.ShowDialog();
        }

        private void pb_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (securityUtils.creedentials(txtCed, txtPassword))
            {
                id = Convert.ToInt32(txtCed.Text);
                //email = Convert.ToString(txtCed.Text);
                Principal principalForm = new Principal(id);
                principalForm.ShowDialog();
            } 
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtCed.Text == "CORREO ELECTRONICO")
            {
                txtCed.Text = "";
                txtCed.ForeColor = Color.LightGray;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtCed.Text == "")
            {
                txtCed.Text = "CORREO ELECTRONICO";
                txtCed.ForeColor = Color.DimGray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "CONTRASEÑA")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.LightGray;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "CONTRASEÑA";
                txtPassword.ForeColor = Color.DimGray;
            }
        }
    }
}
