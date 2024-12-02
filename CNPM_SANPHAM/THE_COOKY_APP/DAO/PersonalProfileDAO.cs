using Microsoft.Data.SqlClient;
using THE_COOKY_APP.DTO;

namespace THE_COOKY_APP.DAO
{
    internal class PersonalProfileDAO
    {
        private string connectionString = ConnectionDTO.ConnectionString;

        public PersonalProfileDTO GetProfileById(string profileId)
        {
            PersonalProfileDTO profile = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM PERSONAL_PROFILE WHERE ID_PROFILE = @IdProfile";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdProfile", profileId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    profile = new PersonalProfileDTO
                    {
                        IdProfile = reader["ID_PROFILE"].ToString(),
                        Cccd = reader["CCCD"].ToString(),
                        DateOfBirth = Convert.ToDateTime(reader["DATE_OF_BIRTH"]),
                        Address = reader["ADDRESS"].ToString(),
                        NativePlace = reader["NATIVE_PLACE"].ToString(),
                        IdAccount = reader["ID_ACCOUNT"].ToString(),
                        IdChef = reader["ID_CHEF"].ToString()
                    };
                }
            }

            return profile;
        }

        public void AddProfile(string cccd, DateTime dateOfBirth, string address, string nativePlace, string idAccount, string idChef)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO PERSONAL_PROFILE (CCCD, DATE_OF_BIRTH, ADDRESS, NATIVE_PLACE, ID_ACCOUNT, ID_CHEF) " +
                               "VALUES (@Cccd, @DateOfBirth, @Address, @NativePlace, @IdAccount, @IdChef)";
                SqlCommand command = new SqlCommand(query, connection);

                // Thêm các tham số vào câu lệnh SQL
                command.Parameters.AddWithValue("@Cccd", cccd);
                command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@NativePlace", nativePlace);
                // Kiểm tra nếu idChef là null hoặc chuỗi rỗng
                if (string.IsNullOrEmpty(idAccount))
                {
                    command.Parameters.AddWithValue("@IdAccount", DBNull.Value); // Thay thế bằng DBNull nếu idChef là null
                }
                else
                {
                    command.Parameters.AddWithValue("@IdAccount", idAccount);
                }
                
                // Kiểm tra nếu idChef là null hoặc chuỗi rỗng
                if (string.IsNullOrEmpty(idChef))
                {
                    command.Parameters.AddWithValue("@IdChef", DBNull.Value); // Thay thế bằng DBNull nếu idChef là null
                }
                else
                {
                    command.Parameters.AddWithValue("@IdChef", idChef);
                }

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void UpdateProfile(PersonalProfileDTO profile)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE PERSONAL_PROFILE SET CCCD = @Cccd, DATE_OF_BIRTH = @DateOfBirth, ADDRESS = @Address, " +
                               "NATIVE_PLACE = @NativePlace, ID_ACCOUNT = @IdAccount, ID_CHEF = @IdChef WHERE ID_PROFILE = @IdProfile";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdProfile", profile.IdProfile);
                command.Parameters.AddWithValue("@Cccd", profile.Cccd);
                command.Parameters.AddWithValue("@DateOfBirth", profile.DateOfBirth);
                command.Parameters.AddWithValue("@Address", profile.Address);
                command.Parameters.AddWithValue("@NativePlace", profile.NativePlace);
                // Kiểm tra nếu idChef là null hoặc chuỗi rỗng
                if (string.IsNullOrEmpty(profile.IdAccount))
                {
                    command.Parameters.AddWithValue("@IdAccount", DBNull.Value); // Thay thế bằng DBNull nếu idChef là null
                }
                else
                {
                    command.Parameters.AddWithValue("@IdAccount", profile.IdAccount);
                }

                // Kiểm tra nếu idChef là null hoặc chuỗi rỗng
                if (string.IsNullOrEmpty(profile.IdChef))
                {
                    command.Parameters.AddWithValue("@IdChef", DBNull.Value); // Thay thế bằng DBNull nếu idChef là null
                }
                else
                {
                    command.Parameters.AddWithValue("@IdChef", profile.IdChef);
                }

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteProfile(string profileId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM PERSONAL_PROFILE WHERE ID_PROFILE = @IdProfile";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdProfile", profileId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public PersonalProfileDTO GetProfileByAccountId(string accountId)
        {
            PersonalProfileDTO profile = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM PERSONAL_PROFILE WHERE ID_ACCOUNT = @IdAccount";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdAccount", accountId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    profile = new PersonalProfileDTO
                    {
                        IdProfile = reader["ID_PROFILE"].ToString(),
                        Cccd = reader["CCCD"].ToString(),
                        DateOfBirth = Convert.ToDateTime(reader["DATE_OF_BIRTH"]),
                        Address = reader["ADDRESS"].ToString(),
                        NativePlace = reader["NATIVE_PLACE"].ToString(),
                        IdAccount = reader["ID_ACCOUNT"].ToString(),
                        IdChef = reader["ID_CHEF"].ToString()
                    };
                }
            }

            return profile;
        }

        public PersonalProfileDTO GetProfileByChefId(string chefId)
        {
            PersonalProfileDTO profile = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM PERSONAL_PROFILE WHERE ID_CHEF = @IdChef";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdChef", chefId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    profile = new PersonalProfileDTO
                    {
                        IdProfile = reader["ID_PROFILE"].ToString(),
                        Cccd = reader["CCCD"].ToString(),
                        DateOfBirth = Convert.ToDateTime(reader["DATE_OF_BIRTH"]),
                        Address = reader["ADDRESS"].ToString(),
                        NativePlace = reader["NATIVE_PLACE"].ToString(),
                        IdAccount = reader["ID_ACCOUNT"].ToString(),
                        IdChef = reader["ID_CHEF"].ToString()
                    };
                }
            }

            return profile;
        }
    }
}