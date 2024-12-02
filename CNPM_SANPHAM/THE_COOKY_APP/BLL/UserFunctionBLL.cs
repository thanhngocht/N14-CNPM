using THE_COOKY_APP.DTO;
using THE_COOKY_APP.DAO; // Ensure you have the correct namespace for your DAO

namespace THE_COOKY_APP.BLL
{
    internal class UserFunctionBLL
    {
        private UserFunctionDAO userFunctionDAO = new UserFunctionDAO(); // Create an instance of the UserFunctionDAO

        // Method to get all user functions
        public List<UserFunctionDTO> GetAllUserFunctions()
        {
            return userFunctionDAO.GetAllUserFunctions(); // Call the DAO method to get all user functions
        }

        // Method to update a user function
        public void UpdateUserFunction(UserFunctionDTO userFunction)
        {
            userFunctionDAO.UpdateUserFunction(userFunction); // Call the DAO method to update a user function
        }

        // Method to delete a user function
        public void DeleteUserFunction(string idRole, string idAccount)
        {
            userFunctionDAO.DeleteUserFunction(idRole, idAccount); // Call the DAO method to delete a user function
        }

        // Method to get permissions by account ID
        public UserFunctionDTO GetPermissionsByAccountId(string accountId)
        {
            return userFunctionDAO.GetPermissionsByAccountId(accountId); // Call the DAO method to get permissions by account ID
        }

        // Method to get function permissions based on role ID and account ID
        public UserFunctionDTO GetFunctionPermissions(string roleId, string accountId)
        {
            return userFunctionDAO.GetFunctionPermissions(roleId, accountId); // Call the DAO method to get function permissions
        }
        public string GetRoleIdByAccountId(string accountId)
        {
            return userFunctionDAO.GetRoleIdByAccountId(accountId);
        }

        public void AddUserFunction(bool insertStudent, bool updateStudent, bool deleteStudent, bool insertClass, bool updateClass, bool deleteClass,
                                    bool insertChef, bool updateChef, bool deleteChef, bool reportClass, bool dataReality, bool summary,
                                    bool reportLocation, bool reportMonth, bool timeTableOverall, bool dataPlan, bool generalKpi,
                                    bool timeTablePlan, bool insertTopic, bool updateTopic, bool deleteTopic, bool insertLocation,
                                    bool updateLocation, bool deleteLocation, bool listClass, bool listChef, bool listLocation,
                                    bool listTopic, bool listStudent, string idRole, string idAccount)
        {
            userFunctionDAO.AddUserFunction(insertStudent, updateStudent, deleteStudent, insertClass, updateClass, deleteClass, insertChef, updateChef, deleteChef, reportClass, dataReality, summary, reportLocation, reportMonth, timeTableOverall, dataPlan, generalKpi, timeTablePlan, insertTopic, updateTopic, deleteTopic, insertLocation, updateLocation, deleteLocation, listClass, listChef, listLocation, listTopic, listStudent, idRole, idAccount);
        }

        public void AddDefaultUserFunction(string idAccount, string idRole)
        {
            userFunctionDAO.AddDefaultUserFunction(idAccount, idRole);
        }
    }
}