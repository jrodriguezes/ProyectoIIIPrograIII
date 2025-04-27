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
        int selectedRowIndexRoleInformation = -1;
        int selectedRowIndexClientTypeInformation = -1;

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRowIndexUsers = e.RowIndex;
                int userId = Convert.ToInt32(dgvUsers.Rows[selectedRowIndexUsers].Cells["userId"].Value);
                loadUserInformation(userId);
            }
        }

        private void dgvInformation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRowIndexUserInformation = e.RowIndex;
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
                dgvRole.Rows[rowIndex].Cells["serialIdRole"].Value = role.id;
                dgvRole.Rows[rowIndex].Cells["Role"].Value = role.role;
                dgvRole.Rows[rowIndex].Cells["statusRole"].Value = role.status;
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
                dgvInformation.Rows[rowIndex].Cells["userName"].Value = person.name;
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
                dgvUsers.Rows[rowIndex].Cells["userId"].Value = person.id;
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (selectedRowIndexUserInformation >= 0)
            {
                // Obtener los valores de las celdas de dgvInformation
                string userName = dgvInformation.Rows[selectedRowIndexUserInformation].Cells["userName"].Value.ToString();
                string userEmail = dgvInformation.Rows[selectedRowIndexUserInformation].Cells["userEmail"].Value.ToString();
                string userGenre = dgvInformation.Rows[selectedRowIndexUserInformation].Cells["userGenre"].Value.ToString();
                DateTime userBirthday = Convert.ToDateTime(dgvInformation.Rows[selectedRowIndexUserInformation].Cells["userBirthdayDate"].Value);
                int userAge = Convert.ToInt32(dgvInformation.Rows[selectedRowIndexUserInformation].Cells["userAge"].Value);

                // Obtener los valores del ComboBox para Role y ClientType
                string userRoleString = dgvInformation.Rows[selectedRowIndexUserInformation].Cells["userRole"].Value.ToString();
                string userClientTypeString = dgvInformation.Rows[selectedRowIndexUserInformation].Cells["userClientType"].Value.ToString();

                // Obtener los IDs correspondientes al nombre del role y clientType desde la base de datos
                int userRoleId = userService.getRoleId(userRoleString);  // Llamar al servicio para obtener el ID del role
                int userClientTypeId = userService.getClientTypeId(userClientTypeString);  // Llamar al servicio para obtener el ID del tipo de cliente

                // Obtener el valor de status
                bool userStatus = (bool)dgvInformation.Rows[selectedRowIndexUserInformation].Cells["userStatus"].Value;

                // Crear el modelo con los datos obtenidos
                UserModel updatedUser = new UserModel
                {
                    id = Convert.ToInt32(dgvUsers.Rows[selectedRowIndexUserInformation].Cells["userId"].Value), // Asegúrate de tener una columna para "Id"
                    name = userName,
                    email = userEmail,
                    genre = userGenre,
                    birthday = userBirthday,
                    age = userAge,
                    role = userRoleId, // Asignar el ID del role
                    clientType = userClientTypeId, // Asignar el ID del tipo de cliente
                    status = userStatus ? 1 : 0 // Convertir el booleano a int
                };

                // Llamar al servicio para actualizar la base de datos
                userService.updateUserInformation(updatedUser);
                loadUserInformation(updatedUser.id);
                MessageBox.Show("Haz modificado satisfactoriamente los datos del usuario.");
            }
            else
            {
                MessageBox.Show("Selecciona una fila para modificar.");
            }
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            AddRole form = new AddRole(this);
            form.Show();
        }

        private void btnModRole_Click(object sender, EventArgs e)
        {
            if (selectedRowIndexRoleInformation >= 0)
            {
                // Verificamos si la celda "statusRole" contiene un valor válido y es un bool
                var statusRoleCellValue = dgvRole.Rows[selectedRowIndexRoleInformation].Cells["statusRole"].Value;

                // Definimos un valor por defecto para el estado
                bool statusRoleValue = false;

                if (statusRoleCellValue != null && statusRoleCellValue is bool)
                {
                    // Si el valor es válido y es un bool, lo asignamos
                    statusRoleValue = (bool)statusRoleCellValue;
                }
                else
                {
                    // Si no es un bool o es nulo, asignamos un valor por defecto (false o true según sea necesario)
                    statusRoleValue = false; // o `true` si lo deseas
                }

                // Crear el modelo con los valores correctos
                RoleModel model = new RoleModel
                {
                    id = Convert.ToInt32(dgvRole.Rows[selectedRowIndexRoleInformation].Cells["serialIdRole"].Value),
                    role = Convert.ToString(dgvRole.Rows[selectedRowIndexRoleInformation].Cells["Role"].Value),
                    status = statusRoleValue ? 1 : 0, // Convertimos el valor booleano en 1 o 0
                };

                // Actualizar el rol en el servicio
                userService.updateRole(model);
                MessageBox.Show("Haz modificado satisfactoriamente un rol.");
            }
            else
            {
                MessageBox.Show("El índice no debe de ser negativo. Haga click en una fila rol.");
            }
        }


        private void btnModClientType_Click(object sender, EventArgs e)
        {
            if (selectedRowIndexClientTypeInformation >= 0)
            {
                ClientTypeModel model = new ClientTypeModel
                {
                    id = Convert.ToInt32(dgvClientType.Rows[selectedRowIndexClientTypeInformation].Cells["SerialIdClientType"].Value),
                    clientType = Convert.ToString(dgvClientType.Rows[selectedRowIndexClientTypeInformation].Cells["ClientTypeClientType"].Value),
                    status = (bool)dgvClientType.Rows[selectedRowIndexClientTypeInformation].Cells["statusClientType"].Value ? 1 : 0,
                };
                userService.updateClientType(model);
                MessageBox.Show("Haz modificado satisfactoriamente un tipo-cliente.");
            } else
            {
                MessageBox.Show("El indice no debe de ser negativo. Haga click en una fila tipo-cliente.");
            }
        }

        private void btnAddClientType_Click(object sender, EventArgs e)
        {
            AddClientType form = new AddClientType(this);
            form.Show();
        }

        private void UserManagment_Load(object sender, EventArgs e)
        {
            loadRoles();
            loadClientTypes();
        }

        private void dgvRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRowIndexRoleInformation = e.RowIndex;
            }
        }

        private void dgvClientType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRowIndexClientTypeInformation = e.RowIndex;
            }
        }
    }
}
