using Microsoft.Data.SqlClient;
using THE_COOKY_APP.DTO;

namespace THE_COOKY_APP.DAO
{
    internal class ChefDAO
    {
        private string connectionString = ConnectionDTO.ConnectionString;

        public List<ChefDTO> GetAllChefs()
        {
            List<ChefDTO> chefs = new List<ChefDTO>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                // Cập nhật câu lệnh SQL để chỉ lấy các đầu bếp đang hoạt động
                SqlCommand cmd = new SqlCommand("SELECT * FROM CHEF WHERE ACTIVE = 1", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ChefDTO chef = new ChefDTO
                    {
                        IdChef = reader["ID_CHEF"].ToString(),
                        PhoneNumber = reader["PHONE_NUMBER"].ToString(),
                        FullName = reader["FULL_NAME"].ToString(),
                        StartDate = reader.GetDateTime(reader.GetOrdinal("START_DATE")),
                        Gmail = reader["GMAIL"].ToString()
                    };
                    chefs.Add(chef);
                }
            }
            return chefs; // Trả về danh sách các đầu bếp đang hoạt động
        }

        public void AddChef(string phoneNumber, string fullName, DateTime startDate, string gmail, bool isActive)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO CHEF (PHONE_NUMBER, FULL_NAME, START_DATE, GMAIL, ACTIVE) VALUES (@PhoneNumber, @FullName, @StartDate, @Gmail, @IsActive)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("@FullName", fullName);
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@Gmail", gmail);
                cmd.Parameters.AddWithValue("@IsActive", isActive); // Thêm tham số ACTIVE

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateChef(ChefDTO chef)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE CHEF SET PHONE_NUMBER = @PhoneNumber, FULL_NAME = @FullName, START_DATE = @StartDate, GMAIL = @Gmail WHERE ID_CHEF = @IdChef";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PhoneNumber", chef.PhoneNumber);
                cmd.Parameters.AddWithValue("@FullName", chef.FullName);
                cmd.Parameters.AddWithValue("@StartDate", chef.StartDate);
                cmd.Parameters.AddWithValue("@Gmail", chef.Gmail);
                cmd.Parameters.AddWithValue("@IdChef", chef.IdChef);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteChef(string chefId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE CHEF SET Active = 0 WHERE ID_CHEF = @IdChef";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdChef", chefId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public string GetChefIdByName(string fullName)
        {
            string idChef = ""; // Initialize ID with -1 to indicate not found
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT ID_CHEF FROM CHEF WHERE FULL_NAME = @FullName", conn);
                cmd.Parameters.AddWithValue("@FullName", fullName);

                // Execute query and get ID
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    idChef = reader["ID_CHEF"].ToString(); // Get ID_CHEF if found
                }
            }
            return idChef; // Return ID or -1 if not found
        }

        public List<ChefDTO> SearchChefs(string searchTerm, string property)
        {
            List<ChefDTO> chefs = new List<ChefDTO>();
            string query = "SELECT c.* FROM CHEF c " +
                           "LEFT JOIN TOPIC_CHEF tc ON c.ID_CHEF = tc.ID_CHEF " +
                           "LEFT JOIN TOPIC t ON tc.ID_TOPIC = t.ID_TOPIC " +
                           "WHERE c.ACTIVE = 1 AND "; // Thêm điều kiện ACTIVE = 1

            // Xác định thuộc tính tìm kiếm
            switch (property.ToUpper())
            {
                case "TÊN GIÁO VIÊN":
                    query += "c.FULL_NAME COLLATE SQL_Latin1_General_CP1_CI_AI LIKE @searchTerm"; // Không phân biệt dấu
                    break;
                case "SỐ ĐIỆN THOẠI":
                    query += "c.PHONE_NUMBER LIKE @searchTerm";
                    break;
                case "GMAIL":
                    query += "c.GMAIL LIKE @searchTerm";
                    break;
                case "NGÀY LÀM VIỆC":
                    query += "FORMAT(c.START_DATE, 'dd/MM/yyyy') LIKE @searchTerm"; // Định dạng ngày tháng
                    break;
                case "CHUYÊN MÔN":
                    query += "tc.NAME_SPECIALITY COLLATE SQL_Latin1_General_CP1_CI_AI LIKE @searchTerm"; // Không phân biệt dấu
                    break;
                default:
                    throw new ArgumentException("Invalid search property");
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%"); // Thêm tham số tìm kiếm

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ChefDTO chef = new ChefDTO
                            {
                                IdChef = reader["ID_CHEF"].ToString(),
                                PhoneNumber = reader["PHONE_NUMBER"].ToString(),
                                FullName = reader["FULL_NAME"].ToString(),
                                StartDate = reader.GetDateTime(reader.GetOrdinal("START_DATE")),
                                Gmail = reader["GMAIL"].ToString(),
                                IsActive = (bool)reader["ACTIVE"]
                            };
                            chefs.Add(chef);
                        }
                    }
                }
            }

            return chefs; // Trả về danh sách đầu bếp tìm thấy
        }

        public ChefDTO GetChefById(string idChef)
        {
            ChefDTO chef = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM CHEF WHERE ID_CHEF = @IdChef";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdChef", idChef);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    chef = new ChefDTO
                    {
                        IdChef = reader["ID_CHEF"].ToString(),
                        PhoneNumber = reader["PHONE_NUMBER"].ToString(),
                        FullName = reader["FULL_NAME"].ToString(),
                        StartDate = reader.GetDateTime(reader.GetOrdinal("START_DATE")),
                        Gmail = reader["GMAIL"].ToString(),
                        IsActive = (bool)reader["ACTIVE"]
                    };
                }
            }

            return chef; // Trả về đối tượng ChefDTO hoặc null nếu không tìm thấy
        }

        public ChefDTO FindChef(string phoneNumber, string fullName, DateTime startDate, string gmailChef, bool isActive)
        {
            ChefDTO chef = null; // Khởi tạo biến chef với giá trị null
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM CHEF WHERE PHONE_NUMBER = @PhoneNumber AND FULL_NAME = @FullName AND START_DATE = @StartDate AND GMAIL = @Gmail AND ACTIVE = @IsActive";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("@FullName", fullName);
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@Gmail", gmailChef);
                cmd.Parameters.AddWithValue("@IsActive", isActive);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    chef = new ChefDTO
                    {
                        IdChef = reader["ID_CHEF"].ToString(),
                        PhoneNumber = reader["PHONE_NUMBER"].ToString(),
                        FullName = reader["FULL_NAME"].ToString(),
                        StartDate = reader.GetDateTime(reader.GetOrdinal("START_DATE")),
                        Gmail = reader["GMAIL"].ToString(),
                        IsActive = (bool)reader["ACTIVE"]
                    };
                }
            }
            return chef; // Trả về đối tượng chef hoặc null nếu không tìm thấy
        }
    }
}