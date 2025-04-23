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
using Objects;

namespace Presentation
{
    public partial class AddRole : Form
    {
        private UserManagment mainForm;
        public AddRole(UserManagment form)
        {
            InitializeComponent();
            this.mainForm = form;
        }
        UserService userService = new UserService();

        private void pb_Exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            RoleModel model = new RoleModel
            {
                role = txtClientType.Text,
                status = 1
            };
            userService.insertRole(model);
            MessageBox.Show("Haz agregado satisfactoriamente un nuevo rol.");
            cleanText();
            mainForm.loadAllIntoDGV();
            this.Close();
        }

        private void cleanText()
        {
            txtClientType.Clear();
        }
    }
}

