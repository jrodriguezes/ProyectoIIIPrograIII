using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Logic;
using Objects;

namespace Presentation
{
    public partial class PlaneInformation : Form
    {
        int userId = -1;
        public PlaneInformation(int id)
        {
            InitializeComponent();
            this.userId = id;
        }
        UserService userService = new UserService();

        private void pb_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearText()
        {
            txtStudentName.Text = "NOMBRE DE ESTUDIANTE";
            txtStudentName.ForeColor = Color.DimGray;

            txtPoints.Text = "PUNTOS OBTENIDOS";
            txtPoints.ForeColor = Color.DimGray;

            rchFeedback.Text = "FEEDBACK";
            rchFeedback.ForeColor = Color.DimGray;
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            // 1. Crear modelo de información del plano
            PlaneInformationModel infModel = new PlaneInformationModel
            {
                studentName = txtStudentName.Text,
                points = Convert.ToInt32(txtPoints.Text),
                feedback = rchFeedback.Text
            };

            // 2. Insertar PlaneInformation y capturar el ID generado
            int planeInformationId = userService.insertPlaneInformation(infModel); 

            // 3. Convertir la imagen del PictureBox a byte array
            byte[] imageBytes;
            using (var ms = new MemoryStream())
            {
                pbModel.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                imageBytes = ms.ToArray();
            }

            // 4. Crear modelo de Plane
            PlaneModel planeModel = new PlaneModel
            {
                userId = userId, 
                photo = imageBytes,
                planeInformationId = planeInformationId
            };

            // 5. Insertar el plano
            userService.insertPlane(planeModel);

            // 6. Confirmacion
            MessageBox.Show("Plano registrado exitosamente!");
        }

        private void pbModel_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Seleccionar imagen del plano";
                openFileDialog.Filter = "Imágenes (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Mostrar la imagen seleccionada en el PictureBox
                    pbModel.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void txtStudentName_Enter(object sender, EventArgs e)
        {
            if (txtStudentName.Text == "NOMBRE DE ESTUDIANTE")
            {
                txtStudentName.Text = "";
                txtStudentName.ForeColor = Color.LightGray;
            }
        }

        private void txtStudentName_Leave(object sender, EventArgs e)
        {
            if (txtStudentName.Text == "")
            {
                txtStudentName.Text = "NOMBRE DE ESTUDIANTE";
                txtStudentName.ForeColor = Color.DimGray;
            }
        }

        private void txtPoints_Enter(object sender, EventArgs e)
        {
            if (txtPoints.Text == "PUNTOS OBTENIDOS")
            {
                txtPoints.Text = "";
                txtPoints.ForeColor = Color.LightGray;
            }
        }

        private void txtPoints_Leave(object sender, EventArgs e)
        {
            if (txtPoints.Text == "")
            {
                txtPoints.Text = "PUNTOS OBTENIDOS";
                txtPoints.ForeColor = Color.DimGray;
            }
        }

        private void rchFeedback_Enter(object sender, EventArgs e)
        {
            if (rchFeedback.Text == "FEEDBACK")
            {
                rchFeedback.Text = "";
                rchFeedback.ForeColor = Color.LightGray;
            }
        }

        private void rchFeedback_Leave(object sender, EventArgs e)
        {
            if (rchFeedback.Text == "")
            {
                rchFeedback.Text = "FEEDBACK";
                rchFeedback.ForeColor = Color.DimGray;
            }
        }
    }
}

