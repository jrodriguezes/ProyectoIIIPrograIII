using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Logic;
using Objects;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Presentation
{
    public partial class Register : Form
    {

        SecurityUtils securityUtils = new SecurityUtils();
        public Register()
        {
            InitializeComponent();
        }

        private void ClearText()
        {
            txtEmail.Text = "CORREO ELECTRONICO";
            txtEmail.ForeColor = Color.DimGray;

            txtName.Text = "NOMBRE";
            txtName.ForeColor = Color.DimGray;

            txtPassword.Text = "CONTRASEÑA";
            txtPassword.ForeColor = Color.DimGray;

            cmbGenre.SelectedIndex = -1;
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void pb_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private async void btnRegister_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            string imagePath = @"C:\ruta\imagen.jpg"; // ruta o captura previa

            UserModel newUser = new UserModel
            {
                name = txtName.Text,
                email = txtEmail.Text,
                genre = cmbGenre.SelectedItem.ToString(),
                birthday = dtpBirthday.Value,
                age = calculateAge(dtpBirthday.Value),
                password = securityUtils.encryptMD5(txtPassword.Text)
            };

            string endpoint = "https://faceapi-utn2025.cognitiveservices.azure.com/";
            string key = "2CRnWntv6cQ1b3QlV011nSreZmt6S6hZNxRoyW7hLksrwamVFT4HJQQJ99BDACYeBjFXJ3w3AAAKACOGVv4N";

            FaceIdService faceIdService = new FaceIdService(endpoint, key);
            await faceIdService.RegisterUserAsync(newUser, imagePath);

            MessageBox.Show("Usuario registrado con Face ID");
            //Ya se guarda en BD dentro de FaceIdServic
            userService.InsertUser(newUser);
            MessageBox.Show("Te has registrado satisfactoriamente!");
            ClearText();
        }

        private int calculateAge(DateTime birthday)
        {
            DateTime today = DateTime.Today;

            int age = today.Year - birthday.Year;

            if (birthday.Date > today.AddYears(-age)) 
            {
                age--;
            }
            return age;
         }

        private void pbFaceID_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "CORREO ELECTRONICO")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.LightGray;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "CORREO ELECTRONICO";
                txtEmail.ForeColor = Color.DimGray;
            }
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "NOMBRE")
            {
                txtName.Text = "";
                txtName.ForeColor = Color.LightGray;
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "NOMBRE";
                txtName.ForeColor = Color.DimGray;
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

