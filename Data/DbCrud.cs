using System;
using System.Collections.Generic;
using System.Data;
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

            string faceIdValue = user.faceId.HasValue ? "'" + user.faceId.Value + "'" : "NULL";

            string insertUserQuery = "INSERT INTO Users (Id, Name, Email, Genre, Birthday, Age, Password, FaceId, Role, CLIENT_TYPE_ID, Status) " +
                "VALUES (" + user.id + ", '" + user.name + "', '" + user.email + "', '" + user.genre + "', '" +
                user.birthday.ToString("yyyy-MM-dd") + "', " + user.age + ", '" + user.password + "', " + faceIdValue + ", " +
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

            string query = "SELECT id, type, status FROM CLIENT_TYPE"; 

            NpgsqlCommand cmd = new NpgsqlCommand(query, actualConnection);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
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

        public List<(PlaneModel, PlaneInformationModel)> getAllPlanes()
        {
            List<(PlaneModel, PlaneInformationModel)> planesList = new List<(PlaneModel, PlaneInformationModel)>();

            DbConnection connection = new DbConnection();
            NpgsqlConnection actualConnection = connection.dbConnection();

            string query = "SELECT p.id AS plane_id, p.user_id, p.photo, p.created, " +
                           "pi.id AS plane_info_id, pi.student_name, pi.points, pi.feedback " +
                           "FROM PLANE p " +
                           "INNER JOIN PLANE_INFORMATION pi ON p.plane_information_id = pi.id";

            NpgsqlCommand cmd = new NpgsqlCommand(query, actualConnection);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                PlaneModel plane = new PlaneModel
                {
                    id = Convert.ToInt32(dr["plane_id"]),
                    userId = Convert.ToInt32(dr["user_id"]),
                    photo = (byte[])dr["photo"],
                    created = Convert.ToDateTime(dr["created"]),
                    planeInformationId = Convert.ToInt32(dr["plane_info_id"])
                };

                PlaneInformationModel planeInfo = new PlaneInformationModel
                {
                    id = Convert.ToInt32(dr["plane_info_id"]),
                    studentName = Convert.ToString(dr["student_name"]),
                    points = Convert.ToInt32(dr["points"]),
                    feedback = Convert.ToString(dr["feedback"])
                };

                planesList.Add((plane, planeInfo));
            }

            return planesList;
        }

        public void updatePlaneInformation(PlaneInformationModel planeInfo)
        {
            DbConnection connection = new DbConnection();
            NpgsqlConnection actualConnection = connection.dbConnection();

            string updateQuery = "UPDATE PLANE_INFORMATION " +
                                 "SET student_name = '" + planeInfo.studentName + "', " +
                                 "points = " + planeInfo.points + ", " +
                                 "feedback = '" + planeInfo.feedback + "' " +
                                 "WHERE id = " + planeInfo.id + ";";

            NpgsqlCommand cmd = new NpgsqlCommand(updateQuery, actualConnection);
            cmd.ExecuteNonQuery();
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

        public int insertPlaneInformation(PlaneInformationModel planeInfo)
        {
            DbConnection connection = new DbConnection();
            NpgsqlConnection actualConnection = connection.dbConnection();

            string insertPlaneInformationQuery = "INSERT INTO PLANE_INFORMATION (student_name, points, feedback) " +
                                                  "VALUES ('" + planeInfo.studentName + "', " + planeInfo.points + ", '" + planeInfo.feedback + "') " +
                                                  "RETURNING id;";

            NpgsqlCommand cmd = new NpgsqlCommand(insertPlaneInformationQuery, actualConnection);
            int generatedId = Convert.ToInt32(cmd.ExecuteScalar());
            return generatedId;
        }

        public void insertPlane(PlaneModel plane)
        {
            DbConnection connection = new DbConnection();
            NpgsqlConnection actualConnection = connection.dbConnection();

            string hexPhoto = BitConverter.ToString(plane.photo).Replace("-", ""); // Solo quita los guiones
            string insertPlaneQuery = "INSERT INTO PLANE (user_id, photo, PLANE_INFORMATION_ID) " +
                                      "VALUES (" + plane.userId + ", decode('" + hexPhoto + "', 'hex'), " + plane.planeInformationId + ");";

            NpgsqlCommand cmd = new NpgsqlCommand(insertPlaneQuery, actualConnection);
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
            DbConnection connection = new DbConnection();
            NpgsqlConnection actualConnection = connection.dbConnection();

            string updatePromptQuery = "UPDATE BOT_PROMPT SET PROMPT = '" + prompt.prompt + "', status = " + prompt.status + " WHERE ID = " + prompt.id + ";";

            NpgsqlCommand cmd = new NpgsqlCommand(updatePromptQuery, actualConnection);

            cmd.ExecuteNonQuery();
        }

        public void updateClientType(ClientTypeModel clientType)
        {
            DbConnection connection = new DbConnection();
            NpgsqlConnection actualConnection = connection.dbConnection();

            string updateClientTypeQuery = "UPDATE CLIENT_TYPE SET type = '" + clientType.clientType + "', status = " + clientType.status + " WHERE id = " + clientType.id + ";";

            NpgsqlCommand cmd = new NpgsqlCommand(updateClientTypeQuery, actualConnection);

            cmd.ExecuteNonQuery();
        }

        public void updateRole(RoleModel role)
        {
            DbConnection connection = new DbConnection();
            NpgsqlConnection actualConnection = connection.dbConnection();

            string updateRoleQuery = "UPDATE Role SET Role = '" + role.role + "', status = " + role.status + " WHERE id = " + role.id + ";";

            NpgsqlCommand cmd = new NpgsqlCommand(updateRoleQuery, actualConnection);

            cmd.ExecuteNonQuery();
        }

        public void updateUserInformation(UserModel user)
        {
            DbConnection connection = new DbConnection();
            NpgsqlConnection actualConnection = connection.dbConnection();

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

            NpgsqlCommand cmd = new NpgsqlCommand(updateUserQuery, actualConnection);

            cmd.ExecuteNonQuery();
        }

        public int getRoleId(string roleName)
        {
            int roleId = -1;
            DbConnection connection = new DbConnection();
            NpgsqlConnection actualConnection = connection.dbConnection();

            NpgsqlCommand cmd = new NpgsqlCommand("SELECT id FROM Role WHERE Role = '" + roleName + "'", actualConnection);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                if (dr.Read())
                {
                    roleId = dr.GetInt32(0); 
                }
            }
            return roleId;
        }

        public int getClientTypeId(string clientTypeName)
        {
            int clientTypeId = -1;
            DbConnection connection = new DbConnection();
            NpgsqlConnection actualConnection = connection.dbConnection();

            NpgsqlCommand cmd = new NpgsqlCommand("SELECT id FROM CLIENT_TYPE WHERE type = '" + clientTypeName + "'", actualConnection);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                if (dr.Read())
                {
                    clientTypeId = dr.GetInt32(0); 
                }
            }
            return clientTypeId;
        }

        public int getRoleByUserId(int id)
        {
            int role = -1;
            DbConnection connection = new DbConnection();
            NpgsqlConnection actualConnection = connection.dbConnection();

            NpgsqlCommand cmd = new NpgsqlCommand("SELECT Role FROM USERS WHERE Id =" + id, actualConnection);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                if (dr.Read())
                {
                    role = dr.GetInt32(0); 
                }
            }
            return role;

        }
        public DataTable GetReporte1()
        {
            DbConnection connection = new DbConnection();
            NpgsqlConnection actualConnection = connection.dbConnection();

            string query = "SELECT " +
                           "u.name AS \"Nombre del Usuario\", " +
                           "u.email AS \"Correo\", " +
                           "ct.type AS \"Tipo de Cliente\", " +
                           "r.role AS \"Rol de Usuario\", " +
                           "ap.accerted_prompts AS \"Prompts Aciertos\", " +
                           "ap.innacerted_prompts AS \"Prompts Fallos\" " +
                           "FROM USERS u " +
                           "JOIN CLIENT_TYPE ct ON u.client_type_id = ct.id " +
                           "JOIN ROLE r ON u.role = r.id " +
                           "JOIN ACCERTED_PROMPTS ap ON u.id = ap.id " +
                           "WHERE u.status = 1;";

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, actualConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable GetReporte2()
        {
            DbConnection connection = new DbConnection();
            NpgsqlConnection actualConnection = connection.dbConnection();

            string query = "SELECT " +
                           "u.name AS \"Nombre del Usuario\", " +
                           "r.role AS \"Rol\", " +
                           "pi.student_name AS \"Nombre del Estudiante\", " +
                           "pi.points AS \"Puntos\", " +
                           "pi.feedback AS \"Retroalimentación\", " +
                           "p.created AS \"Fecha de Creación\" " +
                           "FROM USERS u " +
                           "JOIN ROLE r ON u.role = r.id " +
                           "JOIN PLANE p ON u.id = p.user_id " +
                           "JOIN PLANE_INFORMATION pi ON p.plane_information_id = pi.id " +
                           "ORDER BY p.created DESC;";

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, actualConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable GetReporte3()
        {
            DbConnection connection = new DbConnection();
            NpgsqlConnection actualConnection = connection.dbConnection();

            string query = "SELECT " +
                           "u.name AS \"Nombre del Usuario\", " +
                           "ct.type AS \"Tipo de Cliente\", " +
                           "COUNT(p.id) AS \"Cantidad de Planos\", " +
                           "AVG(pi.points) AS \"Promedio de Puntos en Planos\" " +
                           "FROM USERS u " +
                           "JOIN CLIENT_TYPE ct ON u.client_type_id = ct.id " +
                           "LEFT JOIN PLANE p ON u.id = p.user_id " +
                           "LEFT JOIN PLANE_INFORMATION pi ON p.plane_information_id = pi.id " +
                           "WHERE u.status = 1 " +
                           "GROUP BY u.name, ct.type;";

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, actualConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public string getEmailById(int id)
        {
            string email = "";
            DbConnection connection = new DbConnection();
            NpgsqlConnection actualConnection = connection.dbConnection();

            NpgsqlCommand cmd = new NpgsqlCommand("SELECT Email FROM USERS WHERE Id =" + id, actualConnection);

            NpgsqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                if (dr.Read())
                {
                    email = dr.GetString(0);
                }
            }
            return email;

        }
    }

}


