using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using Objects;

namespace Logic
{
    public class UserService
    {
        DbCrud crud = new DbCrud();

        public void InsertUser(UserModel user)
        {
            crud.insertUser(user);
        }
        // Queries
        public int getUserId(string Email)
        {
            return crud.getUserId(Email);
        }
        public string getPasswordByEmail(string Email)
        {
            return crud.getPasswordbyEmail(Email);
        }
    }
}
