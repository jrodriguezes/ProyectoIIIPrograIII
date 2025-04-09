using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Logic;
//using Objects;

namespace Presentation
{
    public partial class Register : Form
    {
        //guiMethods gui = new guiMethods();
        //validatePassword validate = new validatePassword();
        //userService userService = new userService();

        public Register()
        {
            InitializeComponent();
        }

        private void reset_Text()
        {
            txtCed.Clear();
            txtCon.Clear();
            txtNom.Clear();
            cmbNationality.SelectedIndex = 1;
            dtpNac.ResetText();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            loadCountries();
        }

        private void loadCountries()
        {
            //var client = new org.oorsprong.webservices.CountryInfoService();
            //var resultado = client.ListOfCountryNamesByName();

            //cmbNationality.DataSource = resultado;
            //cmbNationality.DisplayMember = "sName";     // lo que se muestra
            //cmbNationality.ValueMember = "sISOCode";    // valor interno
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            //objUser user = new objUser
            //{
            //    Id = Convert.ToInt32(txtCed.Text),
            //    Name = txtNom.Text,
            //    Nacionality = cmbNationality.SelectedValue.ToString(),
            //    DateOfBirth = dtpNac.Value,
            //    Password = validate.encryptMD5(txtCon.Text),
            //    Image = gui.ImageToByteArray(pb_Imag.Image),
            //    Status = "Usuario",
            //};

            //userService.InsertUser(user);
            //MessageBox.Show("Te has registrado!");
            //reset_Text();
        }

        private void pb_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pb_Imag_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Seleccionar imagen";
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // leer la imagen seleccionada
                        string filePath = openFileDialog.FileName;
                        pb_Imag.Image = Image.FromFile(filePath);

                        // Convertir imagen a byte[]
                        byte[] imageBytes;
                        using (MemoryStream ms = new MemoryStream())
                        {
                            imageBytes = ms.ToArray();
                            pb_Imag.Image.Save(ms, pb_Imag.Image.RawFormat);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                    }
                }
            }
        }
    }
}

