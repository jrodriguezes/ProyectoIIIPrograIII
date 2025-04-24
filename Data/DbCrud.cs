using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Objects;

namespace Data
{
    public class DbCrud
    {
        public void insertUser(UserModel user)
        {
            DbConnection connection = new DbConnection();
            NpgsqlConnection actualConnection = connection.dbConnection();

            string insertUserQuery = "INSERT INTO Users (Id, Name, Email, Genre, Birthday, Age, Password, FaceId, Role, CLIENT_TYPE_ID, Status) " +
                                     "VALUES (" + user.id + ", '" + user.name + "', '" + user.email + "', '" + user.genre + "', '" +
                                     user.birthday.ToString("yyyy-MM-dd") + "', " + user.age + ", '" + user.password + "', '" + user.faceId + "', " +
                                     user.role + ", " + user.clientType + ", " + 1 + ");";

            NpgsqlCommand cmd = new NpgsqlCommand(insertUserQuery, actualConnection);
            cmd.ExecuteNonQuery();
        }


        // Queries 

        public string getPasswordbyId(int id)
        {
            string password = "";

            DbConnection connection = new DbConnection();
            NpgsqlConnection actualConnection = connection.dbConnection();

            NpgsqlCommand cmd = new NpgsqlCommand("Select password from Users where id=" + "'" + id + "'", actualConnection);

            NpgsqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                if (dr.Read())
                {
                    password = dr.GetString(0);
                }
            }
            return password;
        }

        public int getUserId(string Email)
        {
            int id = -1;
            DbConnection connection = new DbConnection();
            NpgsqlConnection actualConnection = connection.dbConnection();

            NpgsqlCommand cmd = new NpgsqlCommand("Select Id from Users where Email=" + "'" + Email + "'", actualConnection);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                if (dr.Read())
                {
                    id = dr.GetInt32(0);
                }
            }
            return id;
        }

        public Guid getFaceIdById(int id)
        {
            DbConnection connection = new DbConnection();
            NpgsqlConnection actualConnection = connection.dbConnection();

            NpgsqlCommand cmd = new NpgsqlCommand("SELECT faceid FROM Users WHERE id=" + id, actualConnection);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows && dr.Read())
            {
                return dr.GetGuid(0);
            }

            return Guid.Empty;
        }

        public List<UserModel> getAllUsersIdAndName()
        {
            List<UserModel> UserList = new List<UserModel>();

            DbConnection connection = new DbConnection();
            NpgsqlConnection actualConnection = connection.dbConnection();

            NpgsqlCommand cmd = new NpgsqlCommand("SELECT id from users", actualConnection);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                UserModel user = new UserModel
                {
                    id = Convert.ToInt32(dr["id"]),

                };

                UserList.Add(user);
            }

            return UserList;

        }

        public List<UserModel> getUserById(int userId)
        {
            List<UserModel> usersList = new List<UserModel>();

            DbConnection connection = new DbConnection();
            NpgsqlConnection actualConnection = connection.dbConnection();

            string query = "SELECT name, email, genre, birthday, age, role, CLIENT_TYPE_ID, status FROM Users WHERE id = " + userId;

            NpgsqlCommand cmd = new NpgsqlCommand(query, actualConnection);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())  // Verificamos si se encontró el usuario
            {
                UserModel user = new UserModel
                {
                    name = Convert.ToString(dr["name"]),
                    email = Convert.ToString(dr["email"]),
                    genre = Convert.ToString(dr["genre"]),
                    birthday = Convert.ToDateTime(dr["birthday"]),
                    age = Convert.ToInt32(dr["age"]),
                    role = Convert.ToInt32(dr["role"]),
                    clientType = Convert.ToInt32(dr["CLIENT_TYPE_ID"]),
                    status = Convert.ToInt32(dr["status"]),
                };
                usersList.Add(user);
            }

            return usersList;
        }

        public List<ClientTypeModel> getAllClientTypes()
        {
            List<ClientTypeModel> clientTypesList = new List<ClientTypeModel>();

            DbConnection connection = new DbConnection();
            NpgsqlConnection actualConnection = connection.dbConnection();

            string query = "SELECT id, type, status FROM CLIENT_TYPE";  // Consulta para obtener todos los tipos de cliente

            NpgsqlCommand cmd = new NpgsqlCommand(query, actualConnection);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())  // Verificamos si hay más de un tipo de cliente
            {
                ClientTypeModel clientType = new ClientTypeModel
                {
                    id = Convert.ToInt32(dr["id"]),
                    clientType = Convert.ToString(dr["type"]),
                    status = Convert.ToInt32(dr["status"]),
                };
                clientTypesList.Add(clientType);
            }

            return clientTypesList;
        }


        public List<RoleModel> getAllRoles()
        {
            List<RoleModel> rolesList = new List<RoleModel>();

            DbConnection connection = new DbConnection();
            NpgsqlConnection actualConnection = connection.dbConnection();

            string query = "SELECT id, Role, status FROM Role";  // Consulta para obtener todos los roles

            NpgsqlCommand cmd = new NpgsqlCommand(query, actualConnection);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())  // Verificamos si hay más de un rol
            {
                RoleModel role = new RoleModel
                {
                    id = Convert.ToInt32(dr["id"]),
                    role = Convert.ToString(dr["Role"]),
                    status = Convert.ToInt32(dr["status"]),
                };
                rolesList.Add(role);
            }

            return rolesList;
        }

        public List<BotPromptModel> getAllPrompts()
        {
            List<BotPromptModel> promptList = new List<BotPromptModel>();

            DbConnection connection = new DbConnection();
            NpgsqlConnection actualConnection = connection.dbConnection();

            string query = "SELECT id, PROMPT, status FROM BOT_PROMPT"; 

            NpgsqlCommand cmd = new NpgsqlCommand(query, actualConnection);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read()) 
            {
                BotPromptModel prompt = new BotPromptModel
                {
                    id = Convert.ToInt32(dr["id"]),
                    prompt = Convert.ToString(dr["PROMPT"]),
                    status = Convert.ToInt32(dr["status"]),
                };
                promptList.Add(prompt);
            }

            return promptList;
        }

        public void insertClientType(ClientTypeModel clientType)
        {
            DbConnection connection = new DbConnection();
            NpgsqlConnection actualConnection = connection.dbConnection();

            string insertClientTypeQuery = "INSERT INTO CLIENT_TYPE (type, status) " +
                                           "VALUES ('" + clientType.clientType + "', " + clientType.status + ");";

            NpgsqlCommand cmd = new NpgsqlCommand(insertClientTypeQuery, actualConnection);
            cmd.ExecuteNonQuery();
        }

        public void insertRole(RoleModel role)
        {
            DbConnection connection = new DbConnection();
            NpgsqlConnection actualConnection = connection.dbConnection();

            string insertRoleQuery = "INSERT INTO Role (Role, status) " +
                                     "VALUES ('" + role.role + "', " + role.status + ");";

            NpgsqlCommand cmd = new NpgsqlCommand(insertRoleQuery, actualConnection);
            cmd.ExecuteNonQuery();
        }

        public void insertBotPrompt(BotPromptModel prompt)
        {
            DbConnection connection = new DbConnection();
            NpgsqlConnection actualConnection = connection.dbConnection();

            string insertPromptQuery = "INSERT INTO BOT_PROMPT (PROMPT, status) " +
                                       "VALUES ('" + prompt.prompt + "', " + prompt.status + ");";

            NpgsqlCommand cmd = new NpgsqlCommand(insertPromptQuery, actualConnection);
            cmd.ExecuteNonQuery();
        }

        public void updateBotPrompt(BotPromptModel prompt)
        {
            // Crear una conexión a la base de datos
            DbConnection connection = new DbConnection();
            NpgsqlConnection actualConnection = connection.dbConnection();

            // Consulta UPDATE para modificar el estado y el mensaje usando el objeto
            string updatePromptQuery = "UPDATE BOT_PROMPT SET PROMPT = '" + prompt.prompt + "', status = " + prompt.status + " WHERE ID = " + prompt.id + ";";

            // Preparar el comando con la consulta
            NpgsqlCommand cmd = new NpgsqlCommand(updatePromptQuery, actualConnection);

            // Ejecutar la consulta
            cmd.ExecuteNonQuery();
        }

        public void updateClientType(ClientTypeModel clientType)
        {
            // Crear una conexión a la base de datos
            DbConnection connection = new DbConnection();
            NpgsqlConnection actualConnection = connection.dbConnection();

            // Consulta UPDATE para modificar el tipo y el estado utilizando el objeto
            string updateClientTypeQuery = "UPDATE CLIENT_TYPE SET type = '" + clientType.clientType + "', status = " + clientType.status + " WHERE id = " + clientType.id + ";";

            // Preparar el comando con la consulta
            NpgsqlCommand cmd = new NpgsqlCommand(updateClientTypeQuery, actualConnection);

            // Ejecutar la consulta
            cmd.ExecuteNonQuery();
        }

        public void updateRole(RoleModel role)
        {
            // Crear una conexión a la base de datos
            DbConnection connection = new DbConnection();
            NpgsqlConnection actualConnection = connection.dbConnection();

            // Consulta UPDATE para modificar el rol y el estado utilizando el objeto
            string updateRoleQuery = "UPDATE Role SET Role = '" + role.role + "', status = " + role.status + " WHERE id = " + role.id + ";";

            // Preparar el comando con la consulta
            NpgsqlCommand cmd = new NpgsqlCommand(updateRoleQuery, actualConnection);

            // Ejecutar la consulta
            cmd.ExecuteNonQuery();
        }

        public void updateUserInformation(UserModel user)
        {
            // Crear una conexión a la base de datos
            DbConnection connection = new DbConnection();
            NpgsqlConnection actualConnection = connection.dbConnection();

            // Consulta UPDATE para modificar los datos del usuario
            string updateUserQuery = "UPDATE USERS SET " +
                                     "name = '" + user.name + "', " +
                                     "email = '" + user.email + "', " +
                                     "genre = '" + user.genre + "', " +
                                     "birthday = '" + user.birthday.ToString("yyyy-MM-dd") + "', " +
                                     "age = " + user.age + ", " +
                                     "role = '" + user.role + "', " +
                                     "CLIENT_TYPE_ID = " + user.clientType + ", " +
                                     "status = " + user.status + " " +
                                     "WHERE id = " + user.id + ";";

            // Preparar el comando con la consulta
            NpgsqlCommand cmd = new NpgsqlCommand(updateUserQuery, actualConnection);

            // Ejecutar la consulta
            cmd.ExecuteNonQuery();
        }

        public int getRoleId(string roleName)
        {
            int roleId = -1;
            DbConnection connection = new DbConnection();
            NpgsqlConnection actualConnection = connection.dbConnection();

            // Consulta SQL para obtener el ID del role basado en el nombre
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT id FROM Role WHERE Role = '" + roleName + "'", actualConnection);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                if (dr.Read())
                {
                    roleId = dr.GetInt32(0); // Obtener el ID del role
                }
            }
            return roleId;
        }

        public int getClientTypeId(string clientTypeName)
        {
            int clientTypeId = -1;
            DbConnection connection = new DbConnection();
            NpgsqlConnection actualConnection = connection.dbConnection();

            // Consulta SQL para obtener el ID del tipo de cliente basado en el nombre
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT id FROM CLIENT_TYPE WHERE type = '" + clientTypeName + "'", actualConnection);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                if (dr.Read())
                {
                    clientTypeId = dr.GetInt32(0); // Obtener el ID del tipo de cliente
                }
            }
            return clientTypeId;
        }



    }
}

