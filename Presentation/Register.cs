using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Logic;
using Microsoft.Azure.CognitiveServices.Vision.Face.Models;
using Microsoft.Azure.CognitiveServices.Vision.Face;
using Objects;
using System.Linq;

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

            cmbGenre.SelectedIndex = 0;
            txtId.Text = "CÉDULA";
        }

        private void pb_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            string imagePath = null;

            bool capturedRealPhoto = !IsDefaultFaceImage(pbFaceID.Image);

            if (capturedRealPhoto)
            {
                imagePath = Path.Combine(Path.GetTempPath(), $"face_{Guid.NewGuid()}.jpg");
                pbFaceID.Image.Save(imagePath, System.Drawing.Imaging.ImageFormat.Jpeg);
            }

            UserModel newUser = new UserModel
            {
                id = Convert.ToInt32(txtId.Text),
                name = txtName.Text,
                email = txtEmail.Text,
                genre = cmbGenre.SelectedItem.ToString(),
                birthday = dtpBirthday.Value,
                age = calculateAge(dtpBirthday.Value),
                password = securityUtils.encryptMD5(txtPassword.Text),
                clientType = 1,
                role = 1,
                faceId = null,
            };

            string endpoint = "https://faceapi-utn2025.cognitiveservices.azure.com/";
            string key = "2hOrQAs5oiB1o6XKDSl5pVkhlHvZ15TUciHoeg3bGxglNgSdeqyAJQQJ99BDACYeBjFXJ3w3AAAKACOGb7yu";

            var faceIdService = new FaceIdService(endpoint, key);
            var userService = new UserService();

            try
            {
                if (capturedRealPhoto && !string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    bool tieneCara = await faceIdService.ValidateImageHasFace(imagePath);

                    if (tieneCara)
                    {
                        await faceIdService.RegisterUserAsync(newUser, imagePath);
                    }
                }

                userService.InsertUser(newUser);
                MessageBox.Show("✅ Usuario registrado exitosamente!");
                ClearText();
            }
            catch (APIErrorException ex)
            {
                MessageBox.Show($"❌ Error en Face API: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"⚠️ Error general: {ex.Message}");
            }
        }

        private bool IsDefaultFaceImage(Image img)
        {
            using (var ms1 = new MemoryStream())
            {
                using (var ms2 = new MemoryStream())
                {
                    img.Save(ms1, System.Drawing.Imaging.ImageFormat.Png);
                    Presentation.Properties.Resources.face_id.Save(ms2, System.Drawing.Imaging.ImageFormat.Png);

                    byte[] imgBytes1 = ms1.ToArray();
                    byte[] imgBytes2 = ms2.ToArray();

                    return imgBytes1.SequenceEqual(imgBytes2); // compara byte a byte
                }
            }
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
            using (CameraCapture cam = new CameraCapture())
            {
                if (cam.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(cam.CapturedImagePath))
                {
                    pbFaceID.Image = Image.FromFile(cam.CapturedImagePath);
                    MessageBox.Show($"✅ Imagen guardada en: {cam.CapturedImagePath}");
                }
                else
                {
                    MessageBox.Show("⚠️ No se capturó ninguna imagen.");
                }
            }
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

        private async void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "CONTRASEÑA";
                txtPassword.ForeColor = Color.DimGray;
            }
        }

        private async void btnTestFaceApi_Click(object sender, EventArgs e)
        {
            string endpoint = "https://faceapi-utn2025.cognitiveservices.azure.com/";
            string key = "2hOrQAs5oiB1o6XKDSl5pVkhlHvZ15TUciHoeg3bGxglNgSdeqyAJQQJ99BDACYeBjFXJ3w3AAAKACOGb7yu";

            var faceClient = new FaceClient(new ApiKeyServiceClientCredentials(key))
            {
                Endpoint = endpoint
            };

            try
            {
                var groups = await faceClient.PersonGroup.ListAsync();
                MessageBox.Show($"✅ Conexión correcta. Total de grupos: {groups.Count}");
            }
            catch (APIErrorException ex)
            {
                MessageBox.Show($"❌ ERROR: {ex.Response.StatusCode} - {ex.Message}");
            }
        }

        private void txtId_Enter(object sender, EventArgs e)
        {
            if (txtId.Text == "CÉDULA")
            {
                txtId.Text = "";
                txtId.ForeColor = Color.LightGray;
            }
        }

        private void txtId_Leave(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                txtId.Text = "CÉDULA";
                txtId.ForeColor = Color.DimGray;
            }
        }
    }
}

