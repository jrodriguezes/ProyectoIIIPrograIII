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

            string insertUserQuery = "INSERT INTO Users (Name, Email, Genre, Birthday, Age, Password, FaceId) " +
                         "VALUES ('" + user.name + "', '" + user.email + "', '" + user.birthday.ToString("yyyy-MM-dd") + "', " +
                         user.age + ", '" + user.password + "', " + user.faceId + "');";

            NpgsqlCommand cmd = new NpgsqlCommand(insertUserQuery, actualConnection);
            cmd.ExecuteNonQuery();
        }

        // Queries 

        public string getPasswordbyEmail(string Email)
        {
            string password = "";

            DbConnection connection = new DbConnection();
            NpgsqlConnection actualConnection = connection.dbConnection();

            NpgsqlCommand cmd = new NpgsqlCommand("Select password from Users where email=" + "'" + Email + "'", actualConnection);

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
