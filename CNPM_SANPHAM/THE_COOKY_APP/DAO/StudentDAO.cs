using Microsoft.Data.SqlClient;
using THE_COOKY_APP.DTO;

namespace THE_COOKY_APP.DAO
{
    internal class StudentDAO
    {
        private string connectionString = ConnectionDTO.ConnectionString;

        public List<StudentDTO> GetAllStudents()
        {
            List<StudentDTO> students = new List<StudentDTO>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM STUDENT WHERE ACTIVE = 1", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    StudentDTO student = new StudentDTO
                    {
                        IdStudent = reader["ID_STUDENT"].ToString(),
                        NameStudent = reader["NAME_STUDENT"].ToString(),
                        DateOfBirth = (DateTime)reader["DATE_OF_BIRTH"],
                        Gender = reader["GENDER"].ToString(),
                        IsMember = (bool)reader["MEMBER"],
                        TotalPayment = (int)reader["TOTAL_PAYMENT"],
                        IsActive = (bool)reader["ACTIVE"],
                        Gmail = reader["GMAIL"].ToString(),
                        PhoneNumber = reader["PHONE_NUMBER"].ToString()
                    };
                    students.Add(student);
                }
            }
            return students;
        }

        public void AddStudent(string nameStudent, DateTime dateOfBirth, string gender, int isMember, int totalPayment, int isActive, string gmail, string phoneNumber)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO STUDENT (NAME_STUDENT, DATE_OF_BIRTH, GENDER, MEMBER, TOTAL_PAYMENT, ACTIVE, GMAIL, PHONE_NUMBER) VALUES (@NameStudent, @DateOfBirth, @Gender, @IsMember, @TotalPayment, @IsActive, @Gmail, @PhoneNumber)", conn);

                // Thêm các tham số
                cmd.Parameters.AddWithValue("@NameStudent", nameStudent);
                cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@IsMember", isMember);
                cmd.Parameters.AddWithValue("@TotalPayment", totalPayment);
                cmd.Parameters.AddWithValue("@IsActive", isActive);
                cmd.Parameters.AddWithValue("@Gmail", gmail);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateStudent(StudentDTO student)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE STUDENT SET NAME_STUDENT = @NameStudent, DATE_OF_BIRTH = @DateOfBirth, GENDER = @Gender, MEMBER = @IsMember, TOTAL_PAYMENT = @TotalPayment, ACTIVE = @IsActive, GMAIL = @Gmail, PHONE_NUMBER = @PhoneNumber WHERE ID_STUDENT = @IdStudent", conn);

                // Thêm các tham số từ đối tượng StudentDTO
                cmd.Parameters.AddWithValue("@IdStudent", student.IdStudent);
                cmd.Parameters.AddWithValue("@NameStudent", student.NameStudent);
                cmd.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth);
                cmd.Parameters.AddWithValue("@Gender", student.Gender);
                cmd.Parameters.AddWithValue("@IsMember", student.IsMember);
                cmd.Parameters.AddWithValue("@TotalPayment", student.TotalPayment);
                cmd.Parameters.AddWithValue("@IsActive", student.IsActive);
                cmd.Parameters.AddWithValue("@Gmail", student.Gmail);
                cmd.Parameters.AddWithValue("@PhoneNumber", student.PhoneNumber);

                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteStudent(string idStudent)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE STUDENT SET ACTIVE = 0 WHERE ID_STUDENT = @IdStudent", conn);
                cmd.Parameters.AddWithValue("@IdStudent", idStudent);
                cmd.ExecuteNonQuery();
            }
        }

        // Lấy sinh viên theo ID
        public StudentDTO GetStudentById(string idStudent)
        {
            StudentDTO student = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM STUDENT WHERE ID_STUDENT = @IdStudent", conn);
                cmd.Parameters.AddWithValue("@IdStudent", idStudent);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    student = new StudentDTO
                    {
                        IdStudent = reader["ID_STUDENT"].ToString(),
                        NameStudent = reader["NAME_STUDENT"].ToString(),
                        DateOfBirth = (DateTime)reader["DATE_OF_BIRTH"],
                        Gender = reader["GENDER"].ToString(),
                        IsMember = (bool)reader["MEMBER"],
                        TotalPayment = (int)reader["TOTAL_PAYMENT"],
                        IsActive = (bool)reader["ACTIVE"],
                        Gmail = reader["GMAIL"].ToString(),
                        PhoneNumber = reader["PHONE_NUMBER"].ToString()
                    };
                }
            }

            return student;
        }

        public List<StudentDTO> SearchStudents(string searchTerm, string property)
        {
            List<StudentDTO> students = new List<StudentDTO>();
            string query = "SELECT * FROM STUDENT WHERE ACTIVE = 1 "; // Thêm điều kiện ACTIVE = 1

            // Xác định thuộc tính tìm kiếm
            switch (property.ToUpper())
            {
                case "TÊN HỌC VIÊN":
                    query += "AND NAME_STUDENT COLLATE SQL_Latin1_General_CP1_CI_AI LIKE @SearchTerm"; // Không phân biệt dấu
                    break;
                case "GMAIL":
                    query += "AND GMAIL COLLATE SQL_Latin1_General_CP1_CI_AI LIKE @SearchTerm"; // Không phân biệt dấu
                    break;
                case "SỐ ĐIỆN THOẠI":
                    query += "AND PHONE_NUMBER LIKE @SearchTerm"; // Có thể không cần collation nếu không phân biệt dấu
                    break;
                default:
                    throw new ArgumentException("Invalid search property");
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%"); // Thêm tham số tìm kiếm

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            students.Add(new StudentDTO
                            {
                                IdStudent = reader["ID_STUDENT"].ToString(),
                                NameStudent = reader["NAME_STUDENT"].ToString(),
                                DateOfBirth = (DateTime)reader["DATE_OF_BIRTH"],
                                Gender = reader["GENDER"].ToString(),
                                IsMember = (bool)reader["MEMBER"],
                                TotalPayment = (int)reader["TOTAL_PAYMENT"],
                                IsActive = (bool)reader["ACTIVE"],
                                Gmail = reader["GMAIL"].ToString(),
                                PhoneNumber = reader["PHONE_NUMBER"].ToString()
                            });
                        }
                    }
                }
            }
            return students; // Trả về danh sách sinh viên tìm thấy
        }
    }
}
