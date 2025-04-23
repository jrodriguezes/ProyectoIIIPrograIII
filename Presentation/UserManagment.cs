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
using Microsoft.Azure.CognitiveServices.Vision.Face.Models;
using Objects;

namespace Presentation
{
    public partial class UserManagment : Form
    {
        UserService userService = new UserService();
        public UserManagment()
        {
            InitializeComponent();
            loadInformationIntoDGVUsers();
        }
        int selectedRowIndexUsers = -1;
        int selectedRowIndexUserInformation = -1;

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRowIndexUsers = e.RowIndex;
                int userId = Convert.ToInt32(dgvUsers.Rows[selectedRowIndexUsers].Cells["Id"].Value);
                loadUserInformation(userId);
            }
        }

        private void loadInformationIntoUserInformationComboBox()
        {
            // Limpiar los Items previos antes de agregar nuevos
            ((DataGridViewComboBoxColumn)dgvInformation.Columns["userRole"]).Items.Clear();
            ((DataGridViewComboBoxColumn)dgvInformation.Columns["userClientType"]).Items.Clear();

            // Cargar los roles en el ComboBox de la columna userRole
            List<RoleModel> roles = userService.getAllRoles();  // Llamar al servicio que obtiene los roles
            foreach (var role in roles)
            {
                ((DataGridViewComboBoxColumn)dgvInformation.Columns["userRole"]).Items.Add(role.role); // Agregar cada rol al ComboBox
            }

            // Cargar los tipos de cliente en el ComboBox de la columna userClientType
            List<ClientTypeModel> clientTypes = userService.getAllClientTypes();  // Llamar al servicio que obtiene los tipos de cliente
            foreach (var clientType in clientTypes)
            {
                ((DataGridViewComboBoxColumn)dgvInformation.Columns["userClientType"]).Items.Add(clientType.clientType); // Agregar cada tipo de cliente al ComboBox
            }
        }

        private void loadRoles()
        {
            List<RoleModel> roleList = userService.getAllRoles();

            dgvRole.Rows.Clear();

            foreach (RoleModel role in roleList)
            {
                int rowIndex = dgvRole.Rows.Add();
                dgvRole.Rows[rowIndex].Cells["serialIdStatus"].Value = role.id;
                dgvRole.Rows[rowIndex].Cells["clientTypeRole"].Value = role.role;
                dgvRole.Rows[rowIndex].Cells["roleClientType"].Value = role.status;
            }
        }

        public void loadAllIntoDGV()
        {
            loadRoles();
            loadClientTypes();
            loadInformationIntoDGVUsers();
        }


        private void loadClientTypes()
        {
            List<ClientTypeModel> clientTypeList = userService.getAllClientTypes();

            dgvClientType.Rows.Clear();

            foreach (ClientTypeModel clientType in clientTypeList)
            {
                int rowIndex = dgvClientType.Rows.Add();
                dgvClientType.Rows[rowIndex].Cells["SerialIdClientType"].Value = clientType.id;
                dgvClientType.Rows[rowIndex].Cells["ClientTypeClientType"].Value = clientType.clientType;
                dgvClientType.Rows[rowIndex].Cells["statusClientType"].Value = clientType.status == 1 ? true : false;
            }
        }

        private void loadUserInformation(int userId)
        {
            // Primero, cargar los ComboBoxes con los valores de roles y tipos de cliente
            loadInformationIntoUserInformationComboBox();

            // Obtener los datos del usuario
            List<UserModel> usersList = userService.getUserInformationById(userId);

            // Limpiar cualquier fila anterior en el DataGridView
            dgvInformation.Rows.Clear();

            // Llenar las filas con los datos obtenidos
            foreach (UserModel person in usersList)
            {
                int rowIndex = dgvInformation.Rows.Add(); // Agregar una nueva fila

                // Asignar valores a cada columna en la fila correspondiente
                dgvInformation.Rows[rowIndex].Cells["userEmail"].Value = person.email;
                dgvInformation.Rows[rowIndex].Cells["userGenre"].Value = person.genre;
                dgvInformation.Rows[rowIndex].Cells["userBirthdayDate"].Value = person.birthday.ToString("yyyy-MM-dd"); // Formato de fecha
                dgvInformation.Rows[rowIndex].Cells["userAge"].Value = person.age.ToString();

                // Asignar valores a ComboBoxColumn: Asegúrate de que el valor esté en la lista de Items
                if (((DataGridViewComboBoxColumn)dgvInformation.Columns["userRole"]).Items.Contains(person.role))
                {
                    dgvInformation.Rows[rowIndex].Cells["userRole"].Value = person.role;
                }
                else
                {
                    // Si no está en la lista, asigna un valor por defecto (por ejemplo, el primer rol)
                    dgvInformation.Rows[rowIndex].Cells["userRole"].Value = ((DataGridViewComboBoxColumn)dgvInformation.Columns["userRole"]).Items[0];
                }

                if (((DataGridViewComboBoxColumn)dgvInformation.Columns["userClientType"]).Items.Contains(person.clientType))
                {
                    dgvInformation.Rows[rowIndex].Cells["userClientType"].Value = person.clientType;
                }
                else
                {
                    // Si no está en la lista, asigna un valor por defecto (por ejemplo, el primer tipo de cliente)
                    dgvInformation.Rows[rowIndex].Cells["userClientType"].Value = ((DataGridViewComboBoxColumn)dgvInformation.Columns["userClientType"]).Items[0];
                }

                // Asignar el valor de "status" (activo/inactivo)
                dgvInformation.Rows[rowIndex].Cells["userStatus"].Value = person.status == 1 ? true : false; // Asumiendo que 1 es activo y 0 es inactivo
            }
        }

        private void loadInformationIntoDGVUsers()
        {
            List<UserModel> usersList = userService.getAllUsersIdAndName();

            dgvUsers.Rows.Clear();

            foreach (UserModel person in usersList)
            {
                int rowIndex = dgvUsers.Rows.Add();
                dgvUsers.Rows[rowIndex].Cells["Id"].Value = person.id;
                dgvUsers.Rows[rowIndex].Cells["userName"].Value = person.name;
            }
        }

        private void dgvInformation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRowIndexUserInformation = e.RowIndex;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnMod_Click(object sender, EventArgs e)
        {

        }

        private void btnInactive_Click(object sender, EventArgs e)
        {

        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            AddRole form = new AddRole(this);
            form.Show();
        }

        private void btnModRole_Click(object sender, EventArgs e)
        {

        }

        private void btnDelRole_Click(object sender, EventArgs e)
        {

        }

        private void btnDeactiveClientType_Click(object sender, EventArgs e)
        {

        }

        private void btnModClientType_Click(object sender, EventArgs e)
        {

        }

        private void btnAddClientType_Click(object sender, EventArgs e)
        {
            AddClientType form = new AddClientType(this);
            form.Show();
        }

        private void rolePage_Click(object sender, EventArgs e)
        {
          
        }

        private void UserManagment_Load(object sender, EventArgs e)
        {
            loadRoles();
            loadClientTypes();
        }
    }
}
