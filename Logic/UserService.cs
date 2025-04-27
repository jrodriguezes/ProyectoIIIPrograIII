using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using Objects;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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

        public int insertPlaneInformation(PlaneInformationModel planeInfo)
        {
            return crud.insertPlaneInformation(planeInfo);
        }

        public void insertPlane(PlaneModel plane)
        {
            crud.insertPlane(plane);
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

        public List<(PlaneModel, PlaneInformationModel)> getAllPlanes()
        {
            return crud.getAllPlanes();
        }

        public List<RoleModel> getAllRoles()
        {
            return crud.getAllRoles();
        }

        public List<BotPromptModel> getAllPrompts()
        {
            return crud.getAllPrompts();
        }

        public void insertClientType(ClientTypeModel model)
        {
            crud.insertClientType(model);
        }

        public void insertRole(RoleModel model)
        {
            crud.insertRole(model);
        }

        public void updatePlaneInformation(PlaneInformationModel planeInfo)
        {
            crud.updatePlaneInformation(planeInfo);
        }

        public void insertBotPrompt(BotPromptModel model)
        {
            crud.insertBotPrompt(model);
        }

        public void updateBotPrompt(BotPromptModel model)
        {
            crud.updateBotPrompt(model);
        }

        public void updateClientType(ClientTypeModel model)
        {
            crud.updateClientType(model);
        }

        public void updateRole(RoleModel model)
        {
            crud.updateRole(model);
        }

        public void updateUserInformation(UserModel model)
        {
            crud.updateUserInformation(model);
        }

        public int getClientTypeId(string clientType)
        {
            return crud.getClientTypeId(clientType);
        }

        public int getRoleId(string roleName)
        {
            return crud.getRoleId(roleName);
        }

        public int getRoleByUserId(int userId)
        {
            return crud.getRoleByUserId(userId);
        }

    }
}
