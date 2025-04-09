using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;

namespace Logic
{
    public class validatePassword
    {

        //bdQueries queries = new bdQueries();
        public string encryptMD5(string input)
        {
            using (MD5 md5 = MD5.Create()) // MD5.Create() Crea un objeto que permite usar el algoritmo de encriptacion MD5
            {   // using garantiza que el objeto md5 se elimine correctamente despues de usarse, evitando perdidas de memoria
                byte[] hashBytes = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
                // Encoding.UTF8.GetBytes(input) Convierte el string(input) en un arreglo de bytes, porque el algoritmo MD5 trabaja con bytes
                StringBuilder hashString = new StringBuilder(32);

                foreach (byte b in hashBytes)
                {
                    hashString.Append(b.ToString("x2")); // Convierte cada byte a hexadecimal (0F)
                }

                return hashString.ToString();
            }
        }

        //public bool creedentials(TextBox user, TextBox password)
        //{
        //    bool isValid = false;
        //    int id = 0;

        //    if (int.TryParse(user.Text, out int userId))
        //    {
        //        id = queries.getUserId(userId);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Ingrese en su cedula solo numeros!");
        //    }

        //    string encryptedPassword = encryptMD5(Convert.ToString(password.Text));
        //    string storedPassword = queries.getPasswordbyId(id);

        //    if (encryptedPassword == storedPassword)
        //    {
        //        isValid = true;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Contraseña incorrecta o usuario inhabilitado o no existente.");
        //    }
        //    return isValid;
        //}
    }
}

