using System;
using System.Windows.Forms;
using Logic;
using System.Xml;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Xml.Linq;
using System.IO;

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

        private async void pbFaceId_Click(object sender, EventArgs e)
        {
            using (CameraCapture cam = new CameraCapture())
            {
                if (cam.ShowDialog() == DialogResult.OK && cam.CapturedImagePath != null)
                {
                    // Mostrar imagen en el PictureBox
                    pbFaceId.Image = System.Drawing.Image.FromFile(cam.CapturedImagePath);

                    // ✅ Validar que se ingresó la cédula antes
                    if (!int.TryParse(txtCed.Text, out int userId))
                    {
                        MessageBox.Show("⚠️ Ingresá una cédula válida antes de usar Face ID.");
                        return;
                    }

                    // ✅ Obtener faceId guardado en la BD
                    Guid storedFaceId = userService.getFaceIdById(userId);
                    if (storedFaceId == Guid.Empty)
                    {
                        MessageBox.Show("⚠️ Este usuario no tiene un Face ID registrado.");
                        return;
                    }

                    // ✅ Guardar la imagen actual del PictureBox en un archivo temporal
                    string tempImagePath = Path.Combine(Path.GetTempPath(), $"face_login_{Guid.NewGuid()}.jpg");
                    pbFaceId.Image.Save(tempImagePath, System.Drawing.Imaging.ImageFormat.Jpeg);

                    // ✅ Enviar a Azure Face API para identificar
                    string endpoint = "https://faceapi-utn2025.cognitiveservices.azure.com/";
                    string key = "2hOrQAs5oiB1o6XKDSl5pVkhlHvZ15TUciHoeg3bGxglNgSdeqyAJQQJ99BDACYeBjFXJ3w3AAAKACOGb7yu";
                    FaceIdService faceService = new FaceIdService(endpoint, key);

                    Guid? matchedPersonId = await faceService.IdentifyUserByImage(tempImagePath);

                    if (matchedPersonId != null && matchedPersonId == storedFaceId)
                    {
                        MessageBox.Show("✅ Bienvenido. Face ID verificado correctamente.");
                        Principal principalForm = new Principal(userId);
                        principalForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("❌ La cara no coincide con el usuario ingresado.");
                    }
                }
                else
                {
                    MessageBox.Show("⚠️ No se capturó ninguna imagen.");
                }
            }
        }
    }
}
