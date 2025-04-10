using System;
using System.Windows.Forms;
using Logic;
using System.Xml;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

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
            if (securityUtils.creedentials(txtEmail, txtPassword))
            {
                //id = Convert.ToInt32(txtEmail.Text);
                email = Convert.ToString(txtEmail.Text);
                Principal principalForm = new Principal(email);
                principalForm.ShowDialog();
            }
        }
    }
}
