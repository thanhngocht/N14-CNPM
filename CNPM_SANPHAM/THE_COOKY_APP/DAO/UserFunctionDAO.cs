using System;
using Microsoft.Data.SqlClient;
using THE_COOKY_APP.DTO;

namespace THE_COOKY_APP.DAO
{
    internal class UserFunctionDAO
    {
        private string connectionString = ConnectionDTO.ConnectionString;

        public List<UserFunctionDTO> GetAllUserFunctions()
        {
            List<UserFunctionDTO> userFunctions = new List<UserFunctionDTO>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM USER_FUNCTION";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UserFunctionDTO userFunction = new UserFunctionDTO
                            {
                                InsertStudent = (bool)reader["INSERT_STUDENT"],
                                UpdateStudent = (bool)reader["UPDATE_STUDENT"],
                                DeleteStudent = (bool)reader["DELETE_STUDENT"],
                                InsertClass = (bool)reader["INSERT_CLASS"],
                                UpdateClass = (bool)reader["UPDATE_CLASS"],
                                DeleteClass = (bool)reader["DELETE_CLASS"],
                                InsertChef = (bool)reader["INSERT_CHEF"],
                                UpdateChef = (bool)reader["UPDATE_CHEF"],
                                DeleteChef = (bool)reader["DELETE_CHEF"],
                                ReportClass = (bool)reader["REPORT_CLASS"],
                                DataReality = (bool)reader["DATA_REALITY"],
                                Summary = (bool)reader["SUMMARY"],
                                ReportLocation = (bool)reader["REPORT_LOCATION"],
                                ReportMonth = (bool)reader["REPORT_MONTH"],
                                TimeTableOverall = (bool)reader["TIME_TABLE_OVERALL"],
                                DataPlan = (bool)reader["DATA_PLAN"],
                                GeneralKpi = (bool)reader["GENERAL_KPI"],
                                TimeTablePlan = (bool)reader["TIME_TABLE_PLAN"],
                                InsertTopic = (bool)reader["INSERT_TOPIC"],
                                UpdateTopic = (bool)reader["UPDATE_TOPIC"],
                                DeleteTopic = (bool)reader["DELETE_TOPIC"],
                                InsertLocation = (bool)reader["INSERT_LOCATION"],
                                UpdateLocation = (bool)reader["UPDATE_LOCATION"],
                                DeleteLocation = (bool)reader["DELETE_LOCATION"],
                                ListClass = (bool)reader["LIST_CLASS"],
                                ListChef = (bool)reader["LIST_CHEF"],
                                ListLocation = (bool)reader["LIST_LOCATION"],
                                ListTopic = (bool)reader["LIST_TOPIC"],
                                ListStudent = (bool)reader["LIST_STUDENT"],
                                IdRole = reader["ID_ROLE"].ToString(),
                                IdAccount = reader["ID_ACCOUNT"].ToString()
                            };
                            userFunctions.Add(userFunction);
                        }
                    }
                }
            }

            return userFunctions; // Return the list of all user functions
        }

        // Method to add a new user function
        public void AddUserFunction(bool insertStudent, bool updateStudent, bool deleteStudent, bool insertClass, bool updateClass, bool deleteClass,
                                    bool insertChef, bool updateChef, bool deleteChef, bool reportClass, bool dataReality, bool summary,
                                    bool reportLocation, bool reportMonth, bool timeTableOverall, bool dataPlan, bool generalKpi,
                                    bool timeTablePlan, bool insertTopic, bool updateTopic, bool deleteTopic, bool insertLocation,
                                    bool updateLocation, bool deleteLocation, bool listClass, bool listChef, bool listLocation,
                                    bool listTopic, bool listStudent, string idRole, string idAccount)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO USER_FUNCTION (INSERT_STUDENT, UPDATE_STUDENT, DELETE_STUDENT, INSERT_CLASS, UPDATE_CLASS, DELETE_CLASS, " +
                               "INSERT_CHEF, UPDATE_CHEF, DELETE_CHEF, REPORT_CLASS, DATA_REALITY, SUMMARY, REPORT_LOCATION, REPORT_MONTH, " +
                               "TIME_TABLE_OVERALL, DATA_PLAN, GENERAL_KPI, TIME_TABLE_PLAN, INSERT_TOPIC, UPDATE_TOPIC, DELETE_TOPIC, " +
                               "INSERT_LOCATION, UPDATE_LOCATION, DELETE_LOCATION, LIST_CLASS, LIST_CHEF, LIST_LOCATION, LIST_TOPIC, LIST_STUDENT, " +
                               "ID_ROLE, ID_ACCOUNT) " +
                               "VALUES (@InsertStudent, @UpdateStudent, @DeleteStudent, @InsertClass, @UpdateClass, @DeleteClass, " +
                               "@InsertChef, @UpdateChef, @DeleteChef, @ReportClass, @DataReality, @Summary, @ReportLocation, @ReportMonth, " +
                               "@TimeTableOverall, @DataPlan, @GeneralKpi, @TimeTablePlan, @InsertTopic, @UpdateTopic, @DeleteTopic, " +
                               "@InsertLocation, @UpdateLocation, @DeleteLocation, @ListClass, @ListChef, @ListLocation, @ListTopic, @ListStudent, " +
                               "@IdRole, @IdAccount)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters
                    command.Parameters.AddWithValue("@InsertStudent", insertStudent);
                    command.Parameters.AddWithValue("@UpdateStudent", updateStudent);
                    command.Parameters.AddWithValue("@DeleteStudent", deleteStudent);
                    command.Parameters.AddWithValue("@InsertClass", insertClass);
                    command.Parameters.AddWithValue("@UpdateClass", updateClass);
                    command.Parameters.AddWithValue("@DeleteClass", deleteClass);
                    command.Parameters.AddWithValue("@InsertChef", insertChef);
                    command.Parameters.AddWithValue("@UpdateChef", updateChef);
                    command.Parameters.AddWithValue("@DeleteChef", deleteChef);
                    command.Parameters.AddWithValue("@ReportClass", reportClass);
                    command.Parameters.AddWithValue("@DataReality", dataReality);
                    command.Parameters.AddWithValue("@Summary", summary);
                    command.Parameters.AddWithValue("@ReportLocation", reportLocation);
                    command.Parameters.AddWithValue("@ReportMonth", reportMonth);
                    command.Parameters.AddWithValue("@TimeTableOverall", timeTableOverall);
                    command.Parameters.AddWithValue("@DataPlan", dataPlan);
                    command.Parameters.AddWithValue("@GeneralKpi", generalKpi);
                    command.Parameters.AddWithValue("@TimeTablePlan", timeTablePlan);
                    command.Parameters.AddWithValue("@InsertTopic", insertTopic);
                    command.Parameters.AddWithValue("@UpdateTopic", updateTopic);
                    command.Parameters.AddWithValue("@DeleteTopic", deleteTopic);
                    command.Parameters.AddWithValue("@InsertLocation", insertLocation);
                    command.Parameters.AddWithValue("@UpdateLocation", updateLocation);
                    command.Parameters.AddWithValue("@DeleteLocation", deleteLocation);
                    command.Parameters.AddWithValue("@ListClass", listClass);
                    command.Parameters.AddWithValue("@ListChef", listChef);
                    command.Parameters.AddWithValue("@ListLocation", listLocation);
                    command.Parameters.AddWithValue("@ListTopic", listTopic);
                    command.Parameters.AddWithValue("@ListStudent", listStudent);
                    command.Parameters.AddWithValue("@IdRole", idRole);
                    command.Parameters.AddWithValue("@IdAccount", idAccount);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateUserFunction(UserFunctionDTO userFunction)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                UPDATE USER_FUNCTION 
                SET INSERT_STUDENT = @InsertStudent, 
                    UPDATE_STUDENT = @UpdateStudent, 
                    DELETE_STUDENT = @DeleteStudent, 
                    INSERT_CLASS = @InsertClass, 
                    UPDATE_CLASS = @UpdateClass, 
                    DELETE_CLASS = @DeleteClass, 
                    INSERT_CHEF = @InsertChef, 
                    UPDATE_CHEF = @UpdateChef, 
                    DELETE_CHEF = @DeleteChef, 
                    REPORT_CLASS = @ReportClass, 
                    DATA_REALITY = @DataReality, 
                    SUMMARY = @Summary, 
                    REPORT_LOCATION = @ReportLocation, 
                    REPORT_MONTH = @ReportMonth, 
                    TIME_TABLE_OVERALL = @TimeTableOverall, 
                    DATA_PLAN = @DataPlan, 
                    GENERAL_KPI = @GeneralKpi, 
                    TIME_TABLE_PLAN = @TimeTablePlan, 
                    INSERT_TOPIC = @InsertTopic, 
                    UPDATE_TOPIC = @UpdateTopic, 
                    DELETE_TOPIC = @DeleteTopic, 
                    INSERT_LOCATION = @InsertLocation, 
                    UPDATE_LOCATION = @UpdateLocation, 
                    DELETE_LOCATION = @DeleteLocation, 
                    LIST_CLASS = @ListClass, 
                    LIST_CHEF = @ListChef, 
                    LIST_LOCATION = @ListLocation, 
                    LIST_TOPIC = @ListTopic, 
                    LIST_STUDENT = @ListStudent 
                WHERE ID_ROLE = @IdRole AND ID_ACCOUNT = @IdAccount";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@InsertStudent", userFunction.InsertStudent);
                    cmd.Parameters.AddWithValue("@UpdateStudent", userFunction.UpdateStudent);
                    cmd.Parameters.AddWithValue("@DeleteStudent", userFunction.DeleteStudent);
                    cmd.Parameters.AddWithValue("@InsertClass", userFunction.InsertClass);
                    cmd.Parameters.AddWithValue("@UpdateClass", userFunction.UpdateClass);
                    cmd.Parameters.AddWithValue("@DeleteClass", userFunction.DeleteClass);
                    cmd.Parameters.AddWithValue("@InsertChef", userFunction.InsertChef);
                    cmd.Parameters.AddWithValue("@UpdateChef", userFunction.UpdateChef);
                    cmd.Parameters.AddWithValue("@DeleteChef", userFunction.DeleteChef);
                    cmd.Parameters.AddWithValue("@ReportClass", userFunction.ReportClass);
                    cmd.Parameters.AddWithValue("@DataReality", userFunction.DataReality);
                    cmd.Parameters.AddWithValue("@Summary", userFunction.Summary);
                    cmd.Parameters.AddWithValue("@ReportLocation", userFunction.ReportLocation);
                    cmd.Parameters.AddWithValue("@ReportMonth", userFunction.ReportMonth);
                    cmd.Parameters.AddWithValue("@TimeTableOverall", userFunction.TimeTableOverall);
                    cmd.Parameters.AddWithValue("@DataPlan", userFunction.DataPlan);
                    cmd.Parameters.AddWithValue("@GeneralKpi", userFunction.GeneralKpi);
                    cmd.Parameters.AddWithValue("@TimeTablePlan", userFunction.TimeTablePlan);
                    cmd.Parameters.AddWithValue("@InsertTopic", userFunction.InsertTopic);
                    cmd.Parameters.AddWithValue("@UpdateTopic", userFunction.UpdateTopic);
                    cmd.Parameters.AddWithValue("@DeleteTopic", userFunction.DeleteTopic);
                    cmd.Parameters.AddWithValue("@InsertLocation", userFunction.InsertLocation);
                    cmd.Parameters.AddWithValue("@UpdateLocation", userFunction.UpdateLocation);
                    cmd.Parameters.AddWithValue("@DeleteLocation", userFunction.DeleteLocation);
                    cmd.Parameters.AddWithValue("@ListClass", userFunction.ListClass);
                    cmd.Parameters.AddWithValue("@ListChef", userFunction.ListChef);
                    cmd.Parameters.AddWithValue("@ListLocation", userFunction.ListLocation);
                    cmd.Parameters.AddWithValue("@ListTopic", userFunction.ListTopic);
                    cmd.Parameters.AddWithValue("@ListStudent", userFunction.ListStudent);
                    cmd.Parameters.AddWithValue("@IdRole", userFunction.IdRole);
                    cmd.Parameters.AddWithValue("@IdAccount", userFunction.IdAccount);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteUserFunction(string idRole, string idAccount)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM USER_FUNCTION WHERE ID_ROLE = @IdRole AND ID_ACCOUNT = @IdAccount";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdRole", idRole);
                    cmd.Parameters.AddWithValue("@IdAccount", idAccount);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public UserFunctionDTO GetPermissionsByAccountId(string accountId)
        {
            UserFunctionDTO userFunction = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM USER_FUNCTION WHERE ID_ACCOUNT = @IdAccount";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdAccount", accountId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userFunction = new UserFunctionDTO
                            {
                                InsertStudent = (bool)reader["INSERT_STUDENT"],
                                UpdateStudent = (bool)reader["UPDATE_STUDENT"],
                                DeleteStudent = (bool)reader["DELETE_STUDENT"],
                                InsertClass = (bool)reader["INSERT_CLASS"],
                                UpdateClass = (bool)reader["UPDATE_CLASS"],
                                DeleteClass = (bool)reader["DELETE_CLASS"],
                                InsertChef = (bool)reader["INSERT_CHEF"],
                                UpdateChef = (bool)reader["UPDATE_CHEF"],
                                DeleteChef = (bool)reader["DELETE_CHEF"],
                                ReportClass = (bool)reader["REPORT_CLASS"],
                                DataReality = (bool)reader["DATA_REALITY"],
                                Summary = (bool)reader["SUMMARY"],
                                ReportLocation = (bool)reader["REPORT_LOCATION"],
                                ReportMonth = (bool)reader["REPORT_MONTH"],
                                TimeTableOverall = (bool)reader["TIME_TABLE_OVERALL"],
                                DataPlan = (bool)reader["DATA_PLAN"],
                                GeneralKpi = (bool)reader["GENERAL_KPI"],
                                TimeTablePlan = (bool)reader["TIME_TABLE_PLAN"],
                                InsertTopic = (bool)reader["INSERT_TOPIC"],
                                UpdateTopic = (bool)reader["UPDATE_TOPIC"],
                                DeleteTopic = (bool)reader["DELETE_TOPIC"],
                                InsertLocation = (bool)reader["INSERT_LOCATION"],
                                UpdateLocation = (bool)reader["UPDATE_LOCATION"],
                                DeleteLocation = (bool)reader["DELETE_LOCATION"],
                                ListClass = (bool)reader["LIST_CLASS"],
                                ListChef = (bool)reader["LIST_CHEF"],
                                ListLocation = (bool)reader["LIST_LOCATION"],
                                ListTopic = (bool)reader["LIST_TOPIC"],
                                ListStudent = (bool)reader["LIST_STUDENT"],
                                IdRole = reader["ID_ROLE"].ToString(),
                                IdAccount = reader["ID_ACCOUNT"].ToString()
                            };
                        }
                    }
                }
            }

            return userFunction; // Return the user function permissions for the specified account
        }

        public UserFunctionDTO GetFunctionPermissions(string roleId, string accountId)
        {
            UserFunctionDTO userFunction = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            SELECT * 
            FROM USER_FUNCTION 
            WHERE ID_ROLE = @IdRole AND ID_ACCOUNT = @IdAccount";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdRole", roleId);
                    cmd.Parameters.AddWithValue("@IdAccount", accountId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userFunction = new UserFunctionDTO
                            {
                                InsertStudent = (bool)reader["INSERT_STUDENT"],
                                UpdateStudent = (bool)reader["UPDATE_STUDENT"],
                                DeleteStudent = (bool)reader["DELETE_STUDENT"],
                                InsertClass = (bool)reader["INSERT_CLASS"],
                                UpdateClass = (bool)reader["UPDATE_CLASS"],
                                DeleteClass = (bool)reader["DELETE_CLASS"],
                                InsertChef = (bool)reader["INSERT_CHEF"],
                                UpdateChef = (bool)reader["UPDATE_CHEF"],
                                DeleteChef = (bool)reader["DELETE_CHEF"],
                                ReportClass = (bool)reader["REPORT_CLASS"],
                                DataReality = (bool)reader["DATA_REALITY"],
                                Summary = (bool)reader["SUMMARY"],
                                ReportLocation = (bool)reader["REPORT_LOCATION"],
                                ReportMonth = (bool)reader["REPORT_MONTH"],
                                TimeTableOverall = (bool)reader["TIME_TABLE_OVERALL"],
                                DataPlan = (bool)reader["DATA_PLAN"],
                                GeneralKpi = (bool)reader["GENERAL_KPI"],
                                TimeTablePlan = (bool)reader["TIME_TABLE_PLAN"],
                                InsertTopic = (bool)reader["INSERT_TOPIC"],
                                UpdateTopic = (bool)reader["UPDATE_TOPIC"],
                                DeleteTopic = (bool)reader["DELETE_TOPIC"],
                                InsertLocation = (bool)reader["INSERT_LOCATION"],
                                UpdateLocation = (bool)reader["UPDATE_LOCATION"],
                                DeleteLocation = (bool)reader["DELETE_LOCATION"],
                                ListClass = (bool)reader["LIST_CLASS"],
                                ListChef = (bool)reader["LIST_CHEF"],
                                ListLocation = (bool)reader["LIST_LOCATION"],
                                ListTopic = (bool)reader["LIST_TOPIC"],
                                ListStudent = (bool)reader["LIST_STUDENT"],
                                IdRole = reader["ID_ROLE"].ToString(),
                                IdAccount = reader["ID_ACCOUNT"].ToString()
                            };
                        }
                    }
                }
            }

            return userFunction; // Return the user function permissions for the specified role and account
        }

        // Method to get Role ID by Account ID
        public string GetRoleIdByAccountId(string accountId)
        {
            string roleId = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            SELECT ID_ROLE 
            FROM USER_FUNCTION 
            WHERE ID_ACCOUNT = @AccountId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AccountId", accountId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            roleId = reader["ID_ROLE"].ToString(); // Lấy ID_ROLE từ kết quả
                        }
                    }
                }
            }

            return roleId; // Trả về ID_ROLE tìm thấy hoặc null nếu không tìm thấy
        }

        public void AddDefaultUserFunction(string idAccount, string idRole)
        {
            UserFunctionDAO userFunctionDAO = new UserFunctionDAO();
            // Gọi phương thức AddUserFunction với tất cả các thuộc tính là false
            userFunctionDAO.AddUserFunction(
                false, // InsertStudent
                false, // UpdateStudent
                false, // DeleteStudent
                false, // InsertClass
                false, // UpdateClass
                false, // DeleteClass
                false, // InsertChef
                false, // UpdateChef
                false, // DeleteChef
                false, // ReportClass
                false, // DataReality
                false, // Summary
                false, // ReportLocation
                false, // ReportMonth
                false, // TimeTableOverall
                false, // DataPlan
                false, // GeneralKpi
                false, // TimeTablePlan
                false, // InsertTopic
                false, // UpdateTopic
                false, // DeleteTopic
                false, // InsertLocation
                false, // UpdateLocation
                false, // DeleteLocation
                false, // ListClass
                false, // ListChef
                false, // ListLocation
                false, // ListTopic
                false, // ListStudent
                idRole, // ID_ROLE (thay thế bằng ID_ROLE thực tế)
                idAccount // ID_ACCOUNT (thay thế bằng ID_ACCOUNT thực tế)
            );
        }
    }
}
