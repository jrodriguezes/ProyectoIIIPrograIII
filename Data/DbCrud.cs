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

            string insertUserQuery = "INSERT INTO Users (Id, Name, Email, Genre, Birthday, Age, Password, FaceId, Role, Status) " +
                                         "VALUES (" + user.id + ", '"+ user.name + "', '" + user.email + "', '" + user.genre + "', '" +
                                         user.birthday.ToString("yyyy-MM-dd") + "', " + user.age + ", '" + user.password + "', '" + user.faceId + "', '" + user.role + "', " + 1 + ");"; // Role default 1(activo)

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

            NpgsqlCommand cmd = new NpgsqlCommand("Select Id from Users where Email=" + "'" +Email + "'", actualConnection);
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
    }
}
