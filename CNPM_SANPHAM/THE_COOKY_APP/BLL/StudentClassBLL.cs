using System;
using System.Collections.Generic;
using THE_COOKY_APP.DAO;
using THE_COOKY_APP.DTO;

namespace THE_COOKY_APP.BLL
{
    internal class StudentClassBLL
    {
        private readonly StudentClassDAO studentClassDAO;

        public StudentClassBLL()
        {
            studentClassDAO = new StudentClassDAO();
        }

        // Thêm sinh viên vào lớp
        public void AddStudent(StudentClassDTO studentClassDTO)
        {
            if (studentClassDTO == null)
                throw new ArgumentNullException(nameof(studentClassDTO), "StudentClassDTO cannot be null.");

            studentClassDAO.AddStudentToClass(studentClassDTO);
        }

        // Sửa thông tin sinh viên trong lớp
        public void UpdateStudent(StudentClassDTO studentClassDTO)
        {
            if (studentClassDTO == null)
                throw new ArgumentNullException(nameof(studentClassDTO), "StudentClassDTO cannot be null.");

            studentClassDAO.UpdateStudentInClass(studentClassDTO);
        }

        // Xóa sinh viên khỏi lớp
        public void DeleteStudent(string idClass, string idStudent)
        {
            if (string.IsNullOrEmpty(idClass))
                throw new ArgumentException("ID Class cannot be null or empty.", nameof(idClass));
            if (string.IsNullOrEmpty(idStudent))
                throw new ArgumentException("ID Student cannot be null or empty.", nameof(idStudent));

            studentClassDAO.DeleteStudentFromClass(idClass, idStudent);
        }

        // Lấy tất cả sinh viên theo ID lớp
        public List<StudentClassDTO> GetAllStudents(string idClass)
        {
            if (string.IsNullOrEmpty(idClass))
                throw new ArgumentException("ID Class cannot be null or empty.", nameof(idClass));

            return studentClassDAO.GetAllStudentsByClassId(idClass);
        }

        // Tính số lượng sinh viên của một ID lớp
        public int CountStudents(string idClass)
        {
            if (string.IsNullOrEmpty(idClass))
                throw new ArgumentException("ID Class cannot be null or empty.", nameof(idClass));

            return studentClassDAO.CountStudentsByClassId(idClass);
        }

        public List<StudentClassDTO> SearchStudentClass(string idClass, string searchTerm, string property)
        {
            return studentClassDAO.SearchStudentClass(idClass, searchTerm, property);
        }

        public void DeleteStudentClass(string idClass)
        {
            studentClassDAO.DeleteStudentClass(idClass);
        }

        public bool IsStudentInClass(string idClass, string idStudent)
        {
            return studentClassDAO.IsStudentInClass(idClass, idStudent);
        }

        public StudentClassDTO GetStudentClassByClassIdAndStudentId(string idClass, string idStudent)
        {
            return studentClassDAO.GetStudentClassByClassIdAndStudentId(idClass, idStudent);
        }

        public (int totalQuantity, int totalPayment) CalculateTotalPaymentAndQuantity(string idClass)
        {
            return studentClassDAO.CalculateTotalPaymentAndQuantity(idClass);
        }

        public int CalculateTotalPaymentByFormPayment(string idClass, string formPayment)
        {
            return studentClassDAO.CalculateTotalPaymentByFormPayment(idClass, formPayment);
        }
    }
}