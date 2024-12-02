using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using THE_COOKY_APP.DTO;

namespace THE_COOKY_APP.DAO
{
    internal class StudentClassDAO
    {
        private string connectionString = ConnectionDTO.ConnectionString;

        // Thêm sinh viên vào lớp
        public void AddStudentToClass(StudentClassDTO studentClassDTO)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO STUDENT_CLASS (STATUS_PAYMENT, FORM_PAYMENT, CODE_MEMBER_DISCOUNT, VOUCHER_DISCOUNT, DEAL_DISCOUNT, APP_DISCOUNT, CASH, QUANTITY, TOTAL_PAYMENT, ID_CLASS, ID_STUDENT) " +
                               "VALUES (@StatusPayment, @FormPayment, @CodeMemberDiscount, @VoucherDiscount, @DealDiscount, @AppDiscount, @Cash, @Quantity, @TotalPayment, @IdClass, @IdStudent)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StatusPayment", studentClassDTO.StatusPayment);
                    command.Parameters.AddWithValue("@FormPayment", studentClassDTO.FormPayment);
                    command.Parameters.AddWithValue("@CodeMemberDiscount", studentClassDTO.CodeMemberDiscount);
                    command.Parameters.AddWithValue("@VoucherDiscount", studentClassDTO.VoucherDiscount);
                    command.Parameters.AddWithValue("@DealDiscount", studentClassDTO.DealDiscount);
                    command.Parameters.AddWithValue("@AppDiscount", studentClassDTO.AppDiscount);
                    command.Parameters.AddWithValue("@Cash", studentClassDTO.Cash);
                    command.Parameters.AddWithValue("@Quantity", studentClassDTO.Quantity);
                    command.Parameters.AddWithValue("@TotalPayment", studentClassDTO.TotalPayment);
                    command.Parameters.AddWithValue("@IdClass", studentClassDTO.IdClass);
                    command.Parameters.AddWithValue("@IdStudent", studentClassDTO.IdStudent);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public StudentClassDTO GetStudentClassByClassIdAndStudentId(string idClass, string idStudent)
        {
            StudentClassDTO studentClassDTO = new StudentClassDTO();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT SC.*, S.NAME_STUDENT, S.PHONE_NUMBER FROM STUDENT_CLASS SC " +
                               "JOIN STUDENT S ON SC.ID_STUDENT = S.ID_STUDENT " +
                               "WHERE SC.ID_CLASS = @IdClass AND SC.ID_STUDENT = @IdStudent";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdClass", idClass);
                    command.Parameters.AddWithValue("@IdStudent", idStudent);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            studentClassDTO = new StudentClassDTO
                            {
                                StatusPayment = reader["STATUS_PAYMENT"].ToString(),
                                FormPayment = reader["FORM_PAYMENT"].ToString(),
                                CodeMemberDiscount = Convert.ToInt32(reader["CODE_MEMBER_DISCOUNT"]),
                                VoucherDiscount = Convert.ToInt32(reader["VOUCHER_DISCOUNT"]),
                                DealDiscount = Convert.ToInt32(reader["DEAL_DISCOUNT"]),
                                AppDiscount = Convert.ToInt32(reader["APP_DISCOUNT"]),
                                Cash = Convert.ToInt32(reader["CASH"]),
                                Quantity = Convert.ToInt32(reader["QUANTITY"]),
                                TotalPayment = Convert.ToInt32(reader["TOTAL_PAYMENT"]),
                                IdClass = reader["ID_CLASS"].ToString(),
                                IdStudent = reader["ID_STUDENT"].ToString(),
                            };
                        }
                    }
                }
            }

            return studentClassDTO; // Trả về thông tin sinh viên trong lớp nếu tìm thấy, ngược lại trả về null
        }

        // Update student information in a class
        public void UpdateStudentInClass(StudentClassDTO studentClassDTO)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE STUDENT_CLASS SET STATUS_PAYMENT = @StatusPayment, FORM_PAYMENT = @FormPayment, CODE_MEMBER_DISCOUNT = @CodeMemberDiscount, " +
                               "VOUCHER_DISCOUNT = @VoucherDiscount, DEAL_DISCOUNT = @DealDiscount, APP_DISCOUNT = @AppDiscount, CASH = @Cash, QUANTITY = @Quantity, TOTAL_PAYMENT = @TotalPayment " +
                               "WHERE ID_CLASS = @IdClass AND ID_STUDENT = @IdStudent";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StatusPayment", studentClassDTO.StatusPayment);
                    command.Parameters.AddWithValue("@FormPayment", studentClassDTO.FormPayment);
                    command.Parameters.AddWithValue("@CodeMemberDiscount", studentClassDTO.CodeMemberDiscount);
                    command.Parameters.AddWithValue("@VoucherDiscount", studentClassDTO.VoucherDiscount);
                    command.Parameters.AddWithValue("@DealDiscount", studentClassDTO.DealDiscount);
                    command.Parameters.AddWithValue("@AppDiscount", studentClassDTO.AppDiscount);
                    command.Parameters.AddWithValue("@Cash", studentClassDTO.Cash);
                    command.Parameters.AddWithValue("@Quantity", studentClassDTO.Quantity);
                    command.Parameters.AddWithValue("@TotalPayment", studentClassDTO.TotalPayment);
                    command.Parameters.AddWithValue("@IdClass", studentClassDTO.IdClass);
                    command.Parameters.AddWithValue("@IdStudent", studentClassDTO.IdStudent);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        // Delete a student from a class
        public void DeleteStudentFromClass(string idClass, string idStudent)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM STUDENT_CLASS WHERE ID_CLASS = @IdClass AND ID_STUDENT = @IdStudent";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdClass", idClass);
                    command.Parameters.AddWithValue("@IdStudent", idStudent);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public (int totalQuantity, int totalPayment) CalculateTotalPaymentAndQuantity(string idClass)
        {
            int totalQuantity = 0;
            int totalPayment = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT SUM(QUANTITY) AS TotalQuantity, SUM(TOTAL_PAYMENT) AS TotalPayment " +
                               "FROM STUDENT_CLASS " +
                               "WHERE ID_CLASS = @IdClass AND STATUS_PAYMENT = N'Đã thanh toán'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdClass", idClass);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            totalQuantity = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                            totalPayment = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
                        }
                    }
                }
            }

            return (totalQuantity, totalPayment); // Trả về tổng số lượng và tổng tiền
        }

        // Get all students by class ID
        public List<StudentClassDTO> GetAllStudentsByClassId(string idClass)
        {
            List<StudentClassDTO> students = new List<StudentClassDTO>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM STUDENT_CLASS WHERE ID_CLASS = @IdClass";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdClass", idClass);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            StudentClassDTO studentClassDTO = new StudentClassDTO
                            {
                                StatusPayment = reader["STATUS_PAYMENT"].ToString(),
                                FormPayment = reader["FORM_PAYMENT"].ToString(),
                                CodeMemberDiscount = Convert.ToInt32(reader["CODE_MEMBER_DISCOUNT"]),
                                VoucherDiscount = Convert.ToInt32(reader["VOUCHER_DISCOUNT"]),
                                DealDiscount = Convert.ToInt32(reader["DEAL_DISCOUNT"]),
                                AppDiscount = Convert.ToInt32(reader["APP_DISCOUNT"]),
                                Cash = Convert.ToInt32(reader["CASH"]),
                                Quantity = Convert.ToInt32(reader["QUANTITY"]),
                                TotalPayment = Convert.ToInt32(reader["TOTAL_PAYMENT"]),
                                IdClass = reader["ID_CLASS"].ToString(),
                                IdStudent = reader["ID_STUDENT"].ToString()
                            };
                            students.Add(studentClassDTO);
                        }
                    }
                }
            }

            return students;
        }

        // Count students by class ID
        public int CountStudentsByClassId(string idClass)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT SUM(QUANTITY) FROM STUDENT_CLASS WHERE ID_CLASS = @IdClass";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdClass", idClass);
                    connection.Open();
                    object result = command.ExecuteScalar();

                    return result != null && result != DBNull.Value ? Convert.ToInt32(result) : 0;
                }
            }
        }

        public List<StudentClassDTO> SearchStudentClass(string idClass, string searchTerm, string property)
        {
            List<StudentClassDTO> studentClasses = new List<StudentClassDTO>();
            string query = "SELECT SC.*, S.NAME_STUDENT, S.PHONE_NUMBER FROM STUDENT_CLASS SC " +
                           "JOIN STUDENT S ON SC.ID_STUDENT = S.ID_STUDENT " +
                           "WHERE SC.ID_CLASS = @IdClass ";

            // Determine the search property
            switch (property.ToUpper())
            {
                case "TÊN HỌC VIÊN":
                    query += "AND S.NAME_STUDENT COLLATE SQL_Latin1_General_CP1_CI_AI LIKE @SearchTerm"; // Case-insensitive, accent-insensitive
                    break;
                case "SỐ ĐIỆN THOẠI":
                    query += "AND S.PHONE_NUMBER LIKE @SearchTerm"; // No collation needed for phone numbers
                    break;
                case "SỐ LƯỢNG ĐĂNG KÍ":
                    query += "AND SC.QUANTITY LIKE @SearchTerm"; // No collation needed for numbers
                    break;
                default:
                    throw new ArgumentException("Invalid search property");
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdClass", idClass);
                    command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%"); // Add search term parameter

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            studentClasses.Add(new StudentClassDTO
                            {
                                StatusPayment = reader["STATUS_PAYMENT"].ToString(),
                                FormPayment = reader["FORM_PAYMENT"].ToString(),
                                CodeMemberDiscount = Convert.ToInt32(reader["CODE_MEMBER_DISCOUNT"]),
                                VoucherDiscount = Convert.ToInt32(reader["VOUCHER_DISCOUNT"]),
                                DealDiscount = Convert.ToInt32(reader["DEAL_DISCOUNT"]), // Updated field
                                AppDiscount = Convert.ToInt32(reader["APP_DISCOUNT"]),
                                Cash = Convert.ToInt32(reader["CASH"]), // Updated field
                                Quantity = Convert.ToInt32(reader["QUANTITY"]),
                                TotalPayment = Convert.ToInt32(reader["TOTAL_PAYMENT"]), // Updated field
                                IdClass = reader["ID_CLASS"].ToString(),
                                IdStudent = reader["ID_STUDENT"].ToString(),
                            });
                        }
                    }
                }
            }
            return studentClasses; // Return the list of students found in the class
        }

        public void DeleteStudentClass(string idClass)
        {
            string query = "DELETE FROM STUDENT_CLASS WHERE ID_CLASS = @IdClass";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdClass", idClass); // Thêm tham số ID lớp

                    int rowsAffected = command.ExecuteNonQuery(); // Thực hiện lệnh xóa

                }
            }
        }

        // Kiểm tra sinh viên đã có trong lớp hay chưa
        public bool IsStudentInClass(string idClass, string idStudent)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM STUDENT_CLASS WHERE ID_CLASS = @IdClass AND ID_STUDENT = @IdStudent";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdClass", idClass);
                    command.Parameters.AddWithValue("@IdStudent", idStudent);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0; // Nếu có ít nhất 1 bản ghi, sinh viên đã có trong lớp
                }
            }
        }

        public int CalculateTotalPaymentByFormPayment(string idClass, string formPayment)
        {
            int totalPayment = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT SUM(TOTAL_PAYMENT) FROM STUDENT_CLASS " +
                               "WHERE ID_CLASS = @IdClass AND STATUS_PAYMENT = N'Đã thanh toán' AND FORM_PAYMENT = @FormPayment";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdClass", idClass);
                    command.Parameters.AddWithValue("@FormPayment", formPayment);
                    connection.Open();

                    object result = command.ExecuteScalar();
                    totalPayment = result != null && result != DBNull.Value ? Convert.ToInt32(result) : 0;
                }
            }

            return totalPayment; // Trả về tổng tiền
        }
    }
}