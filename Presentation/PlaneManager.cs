using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using Objects;

namespace Presentation
{
    public partial class PlaneManager : Form
    {
        UserService userService = new UserService();
        int selectedIndex = -1;
        public PlaneManager()
        {
            InitializeComponent();
            loadPlanes();
        }

        private void loadPlanes()
        {
            var planesList = userService.getAllPlanes(); // Ya devuelve (PlaneModel, PlaneInformationModel)

            dgvPrompt.Rows.Clear();

            foreach (var (plane, planeInfo) in planesList)
            {
                int rowIndex = dgvPrompt.Rows.Add();

                dgvPrompt.Rows[rowIndex].Cells["serialId"].Value = plane.id;
                dgvPrompt.Rows[rowIndex].Cells["studentName"].Value = planeInfo.studentName;
                dgvPrompt.Rows[rowIndex].Cells["points"].Value = planeInfo.points;
                dgvPrompt.Rows[rowIndex].Cells["feedback"].Value = planeInfo.feedback;
                dgvPrompt.Rows[rowIndex].Cells["planeId"].Value = plane.planeInformationId;
                dgvPrompt.Rows[rowIndex].Cells["professorId"].Value = plane.userId;
                dgvPrompt.Rows[rowIndex].Cells["createDate"].Value = plane.created.ToString("yyyy-MM-dd HH:mm:ss");

                // Guardar imagen en Tag para después cargar en el PictureBox
                dgvPrompt.Rows[rowIndex].Tag = plane.photo;
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (selectedIndex > 0)
            {

                // Obtener los valores del DataGridView
                string studentName = dgvPrompt.Rows[selectedIndex].Cells["studentName"].Value.ToString();
                int points = Convert.ToInt32(dgvPrompt.Rows[selectedIndex].Cells["points"].Value);
                string feedback = dgvPrompt.Rows[selectedIndex].Cells["feedback"].Value.ToString();

                // Obtener el ID del registro que se va a actualizar
                int planeInformationId = Convert.ToInt32(dgvPrompt.Rows[selectedIndex].Cells["planeId"].Value);

                // Crear el modelo actualizado
                PlaneInformationModel updatedInfo = new PlaneInformationModel
                {
                    id = planeInformationId,
                    studentName = studentName,
                    points = points,
                    feedback = feedback
                };

                // Actualizar en la base de datos
                userService.updatePlaneInformation(updatedInfo);

                // Recargar todo para refrescar los datos
                loadPlanes();


                MessageBox.Show("✅ Información del estudiante actualizada correctamente.");
            }
            else
            {
                MessageBox.Show("⚠️ Debes seleccionar una fila primero.");
            }
        }

        private void dgvPrompt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Para evitar clicks en el header
            {
                selectedIndex = e.RowIndex;
                // Obtener los datos de la fila clickeada
                DataGridViewRow selectedRow = dgvPrompt.Rows[e.RowIndex];

                // Cargar la imagen desde el Tag si existe
                if (selectedRow.Tag != null)
                {
                    byte[] photoBytes = (byte[])selectedRow.Tag;

                    using (var ms = new System.IO.MemoryStream(photoBytes))
                    {
                        pbPhoto.Image = Image.FromStream(ms); // Mostrar la imagen en el PictureBox
                    }
                }
            }

        }
    }
}
