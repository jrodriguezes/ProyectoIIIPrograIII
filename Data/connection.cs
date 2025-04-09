using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Data
{
    public class connection
    {
        public NpgsqlConnection connections;
        public NpgsqlConnection dbConnection()
        {
            string server = "localhost";
            int port = 5432;
            string user = "postgres";
            int password = 123;
            string database = "Lab03_DB";

            string cadenaConexion = "Server=" + server + ";" + "Port=" + port + ";" + "User Id=" + user + ";" + "Password=" + password + ";" + "Database=" + database;
            connections = new NpgsqlConnection(cadenaConexion);
            connections.Open();

            return connections;
        }
    }
}
