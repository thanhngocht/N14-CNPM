using System.Data;
using Microsoft.Data.SqlClient;
using THE_COOKY_APP.DTO;

namespace THE_COOKY_APP.DAO
{
    internal class AccountDAO
    {
        private string connectionString = ConnectionDTO.ConnectionString;

        public List<AccountDTO> GetAllAccounts()
        {
            List<AccountDTO> accounts = new List<AccountDTO>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM ACCOUNT WHERE USERNAME <> 'admin' AND PASSWORD <> 'admin'", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    AccountDTO account = new AccountDTO
                    {
                        IdAccount = reader["ID_ACCOUNT"].ToString(),
                        Gmail = reader["GMAIL"].ToString(),
                        PhoneNumber = reader["PHONE_NUMBER"].ToString(),
                        FullName = reader["FULL_NAME"].ToString(),
                        Username = reader["USERNAME"].ToString(),
                        Password = reader["PASSWORD"].ToString()
                    };
                    accounts.Add(account);
                }
            }
            return accounts;
        }

        public void AddAccount(string gmail, string phoneNumber, string fullName, string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO ACCOUNT (GMAIL, PHONE_NUMBER, FULL_NAME, USERNAME, PASSWORD) VALUES (@Gmail, @PhoneNumber, @FullName, @Username, @Password)", conn);

                // Thêm các tham số vào câu lệnh SQL
                cmd.Parameters.AddWithValue("@Gmail", gmail);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("@FullName", fullName);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                // Thực thi câu lệnh
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateAccount(AccountDTO account)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE ACCOUNT SET GMAIL = @Gmail, PHONE_NUMBER = @PhoneNumber, FULL_NAME = @FullName, USERNAME = @Username, PASSWORD = @Password WHERE ID_ACCOUNT = @IdAccount", conn);
                cmd.Parameters.AddWithValue("@Gmail", account.Gmail);
                cmd.Parameters.AddWithValue("@PhoneNumber", account.PhoneNumber);
                cmd.Parameters.AddWithValue("@FullName", account.FullName);
                cmd.Parameters.AddWithValue("@Username", account.Username);
                cmd.Parameters.AddWithValue("@Password", account.Password);
                cmd.Parameters.AddWithValue("@IdAccount", account.IdAccount);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteAccount(string idAccount)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM ACCOUNT WHERE ID_ACCOUNT = @IdAccount", conn);
                cmd.Parameters.AddWithValue("@IdAccount", idAccount);
                cmd.ExecuteNonQuery();
            }
        }

        public int? GetAccountIdByName(string fullName)
        {
            int? idAccount = null; // Initialize ID with null
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT ID_ACCOUNT FROM ACCOUNT WHERE FULL_NAME = @FullName", conn);
                cmd.Parameters.AddWithValue("@FullName", fullName);

                // Execute query and get ID
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    idAccount = reader.IsDBNull(reader.GetOrdinal("ID_ACCOUNT")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("ID_ACCOUNT")); // Get ID_ACCOUNT if found
                }
            }
            return idAccount; // Return ID or null if not found
        }

        public List<AccountDTO> SearchAccounts(string searchTerm, string property)
        {
            List<AccountDTO> accounts = new List<AccountDTO>();
            string query = "SELECT a.* FROM ACCOUNT a WHERE a.USERNAME <> 'admin' AND a.PASSWORD <> 'admin' ";

            // Xác định thuộc tính tìm kiếm
            switch (property.ToUpper())
            {
                case "HỌ VÀ TÊN":
                    query += "AND a.FULL_NAME COLLATE SQL_Latin1_General_CP1_CI_AI LIKE @searchTerm";
                    break;
                case "GMAIL":
                    query += "AND a.GMAIL LIKE @searchTerm";
                    break;
                case "SỐ ĐIỆN THOẠI":
                    query += "AND a.PHONE_NUMBER LIKE @searchTerm";
                    break;
                case "TÀI KHOẢN":
                    query += "AND a.USERNAME LIKE @searchTerm";
                    break;
                case "CHỨC VỤ":
                    query += "JOIN USER_FUNCTION uf ON a.ID_ACCOUNT = uf.ID_ACCOUNT " +
                              "JOIN ROLE r ON uf.ID_ROLE = r.ID_ROLE " +
                              "WHERE r.NAME_ROLE COLLATE SQL_Latin1_General_CP1_CI_AI LIKE @searchTerm";
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
                            AccountDTO account = new AccountDTO
                            {
                                IdAccount = reader["ID_ACCOUNT"].ToString(),
                                FullName = reader["FULL_NAME"].ToString(),
                                PhoneNumber = reader["PHONE_NUMBER"].ToString(),
                                Gmail = reader["GMAIL"].ToString(),
                                Username = reader["USERNAME"].ToString(),
                                Password = reader["PASSWORD"].ToString(),
                                // Thêm các thuộc tính khác nếu cần
                            };
                            accounts.Add(account);
                        }
                    }
                }
            }

            return accounts; // Trả về danh sách tài khoản tìm thấy
        }

        public AccountDTO GetAccountById(string idAccount)
        {
            AccountDTO account = null; // Initialize account with null
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM ACCOUNT WHERE ID_ACCOUNT = @IdAccount", conn);
                cmd.Parameters.AddWithValue("@IdAccount", idAccount);

                // Execute query and get account information
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    account = new AccountDTO
                    {
                        IdAccount = reader["ID_ACCOUNT"].ToString(),
                        Gmail = reader["GMAIL"].ToString(),
                        PhoneNumber = reader["PHONE_NUMBER"].ToString(),
                        FullName = reader["FULL_NAME"].ToString(),
                        Username = reader["USERNAME"].ToString(),
                        Password = reader["PASSWORD"].ToString()
                    };
                }
            }
            return account; // Return the account or null if not found
        }

        public bool IsUsernameExists(string username)
        {
            bool isExists = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM ACCOUNT WHERE USERNAME = @Username", conn);
                cmd.Parameters.AddWithValue("@Username", username);
                int count = (int)cmd.ExecuteScalar();
                isExists = count > 0;
            }
            return isExists;
        }

        // Hàm tìm kiếm tài khoản dựa trên username và password
        public AccountDTO FindAccount(string username, string password)
        {
            AccountDTO account = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM ACCOUNT WHERE USERNAME = @Username AND PASSWORD = @Password", conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password); // Lưu ý: Nên mã hóa mật khẩu trong thực tế

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    account = new AccountDTO
                    {
                        IdAccount = reader["ID_ACCOUNT"].ToString(),
                        Gmail = reader["GMAIL"].ToString(),
                        PhoneNumber = reader["PHONE_NUMBER"].ToString(),
                        FullName = reader["FULL_NAME"].ToString(),
                        Username = reader["USERNAME"].ToString(),
                        Password = reader["PASSWORD"].ToString()
                    };
                }
            }
            return account; // Trả về null nếu không tìm thấy tài khoản
        }


        public string GetIdByEmail(string email)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT ID_ACCOUNT FROM ACCOUNT WHERE GMAIL = @Email";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    object result = cmd.ExecuteScalar();

                    // Kiểm tra nếu kết quả không null và trả về ID hoặc null
                    return result?.ToString();
                }
            }
        }

        public void LockAccount(string username)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE ACCOUNT SET IsLocked = 1 WHERE USERNAME = @Username";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public int LoadFailedAttempts(string username)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT FailedAttempts FROM ACCOUNT WHERE username = @username COLLATE Latin1_General_BIN";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    object result = cmd.ExecuteScalar();
                    return Convert.ToInt32(result);
                }
            }
        }

        public void Logout(string username)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE ACCOUNT SET IsLoggedIn = 0 WHERE USERNAME = @username  COLLATE Latin1_General_BIN";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    cmd.ExecuteNonQuery();

                }
            }

        }

        public void SetIsLoggedIn(string username, bool status)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE ACCOUNT SET IsLoggedIn = @status WHERE USERNAME = @username COLLATE Latin1_General_BIN";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@status", status ? 1 : 0);
                    cmd.ExecuteNonQuery();

                }
            }
        }

        public AccountDTO GetAccountByEmail(string username, string email)
        {
            string query = "SELECT ID_ACCOUNT, username, GMAIL,PHONE_NUMBER ,FULL_NAME, PASSWORD FROM ACCOUNT WHERE GMAIL = @email AND username = @username";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@email", email));
                    command.Parameters.Add(new SqlParameter("@username", username));
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new AccountDTO
                            {
                                IdAccount = reader["ID_ACCOUNT"].ToString(),
                                Gmail = reader["GMAIL"].ToString(),
                                PhoneNumber = reader["PHONE_NUMBER"].ToString(),
                                FullName = reader["FULL_NAME"].ToString(),
                                Username = reader["username"].ToString(),
                                Password = reader["PASSWORD"].ToString()


                                // Gán thêm các thuộc tính khác nếu cần
                            };
                        }
                    }
                }
            }

            return null; // Trả về null nếu không tìm thấy tài khoản


        }

        public bool CheckIsLoggedIn(string username)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT IsLoggedIn FROM ACCOUNT WHERE USERNAME = @username COLLATE Latin1_General_BIN";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    object result = cmd.ExecuteScalar();
                    if (result != null && Convert.ToBoolean(result))
                    {
                        return true;
                    }
                    return false;
                }
            }
        }

        public string Login(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();



                string checkLockQuery = "SELECT IsLocked FROM ACCOUNT WHERE username = @username COLLATE Latin1_General_BIN";
                using (SqlCommand checkLockCommand = new SqlCommand(checkLockQuery, connection))
                {
                    checkLockCommand.Parameters.Add(new SqlParameter("@username", SqlDbType.NVarChar) { Value = username });

                    using (SqlDataReader reader = checkLockCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            bool isLocked = reader.GetBoolean(0);

                            if (isLocked)
                            {
                                return "locked"; // Tài khoản bị khóa
                            }
                        }
                        else
                        {
                            return "not found"; // Tài khoản không tồn tại
                        }
                    }
                }


                // Thực hiện đăng nhập
                string loginQuery = "SELECT ID_ACCOUNT FROM ACCOUNT WHERE username = @username COLLATE Latin1_General_BIN AND password = @password COLLATE Latin1_General_BIN";
                using (SqlCommand loginCommand = new SqlCommand(loginQuery, connection))
                {
                    loginCommand.Parameters.Add(new SqlParameter("@username", SqlDbType.NVarChar) { Value = username });
                    loginCommand.Parameters.Add(new SqlParameter("@password", SqlDbType.NVarChar) { Value = password });

                    object result = loginCommand.ExecuteScalar();

                    if (result == null)
                    {
                        // Tăng số lần đăng nhập sai nếu đăng nhập không thành công
                        string incrementFailedAttemptsQuery = "UPDATE ACCOUNT SET FailedAttempts = FailedAttempts + 1 WHERE username = @username COLLATE Latin1_General_BIN";
                        using (SqlCommand incrementCommand = new SqlCommand(incrementFailedAttemptsQuery, connection))
                        {
                            incrementCommand.Parameters.Add(new SqlParameter("@username", SqlDbType.NVarChar) { Value = username });
                            incrementCommand.ExecuteNonQuery();
                        }

                        // Kiểm tra xem tài khoản có bị khóa sau 5 lần đăng nhập sai hay không
                        string checkAttemptsQuery = "SELECT FailedAttempts FROM ACCOUNT WHERE username = @username COLLATE Latin1_General_BIN";
                        using (SqlCommand checkAttemptsCommand = new SqlCommand(checkAttemptsQuery, connection))
                        {
                            checkAttemptsCommand.Parameters.Add(new SqlParameter("@username", SqlDbType.NVarChar) { Value = username });

                            object attemptsResult = checkAttemptsCommand.ExecuteScalar();
                            int failedAttempts = (int)attemptsResult; // Kiểm tra NULL trước khi chuyển đổi

                            if (failedAttempts >= 5)
                            {
                                string lockAccountQuery = "UPDATE ACCOUNT SET IsLocked = 1 WHERE username = @username COLLATE Latin1_General_BIN";
                                using (SqlCommand lockCommand = new SqlCommand(lockAccountQuery, connection))
                                {
                                    lockCommand.Parameters.Add(new SqlParameter("@username", SqlDbType.NVarChar) { Value = username });
                                    lockCommand.ExecuteNonQuery();
                                }

                                return "locked"; // Tài khoản bị khóa sau 5 lần nhập sai
                            }
                        }

                        return null; // Đăng nhập thất bại, tên đăng nhập hoặc mật khẩu không đúng
                    }
                    else
                    {
                        // Đặt lại số lần đăng nhập sai khi đăng nhập thành công
                        string resetAttemptsQuery = "UPDATE ACCOUNT SET FailedAttempts = 0 WHERE username = @username COLLATE Latin1_General_BIN";
                        using (SqlCommand resetCommand = new SqlCommand(resetAttemptsQuery, connection))
                        {
                            resetCommand.Parameters.Add(new SqlParameter("@username", SqlDbType.NVarChar) { Value = username });
                            resetCommand.ExecuteNonQuery();
                        }

                        return result.ToString(); // Trả về ID tài khoản
                    }
                }

            }
        }
    }
}

