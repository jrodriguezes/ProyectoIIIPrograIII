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
        public int getUserIdByEmail(string Email)
        {
            return crud.getUserId(Email);
        }
        public string getPasswordById(int id)
        {
            return crud.getPasswordbyId(id);
        }

        public Guid getFaceIdById(int id)
        {
            return crud.getFaceIdById(id);
        }

        public List<UserModel> getAllUsersIdAndName()
        {
            return crud.getAllUsersIdAndName();
        }

        public List<UserModel> getUserInformationById(int userId)
        {
            return crud.getUserById(userId);
        }

        public List<ClientTypeModel> getAllClientTypes()
        {
            return crud.getAllClientTypes();
        }

        public List<RoleModel> getAllRoles()
        {
            return crud.getAllRoles();
        }

    }
}
