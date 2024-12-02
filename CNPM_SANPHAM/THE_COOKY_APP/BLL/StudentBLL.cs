using THE_COOKY_APP.DTO;
using THE_COOKY_APP.DAO; // Ensure you have the correct namespace for your DAO

namespace THE_COOKY_APP.BLL
{
    internal class StudentBLL
    {
        private StudentDAO studentDAO = new StudentDAO(); // Create an instance of the StudentDAO

        // Method to get all students
        public List<StudentDTO> GetAllStudents()
        {
            return studentDAO.GetAllStudents(); // Call the DAO method to get all students
        }

        // Method to add a new student
        public void AddStudent(string nameStudent, DateTime dateOfBirth, string gender, int isMember, int totalPayment, int isActive, string gmail, string phoneNumber)
        {
            studentDAO.AddStudent(nameStudent, dateOfBirth, gender, isMember, totalPayment, isActive, gmail, phoneNumber); // Call the DAO method to add a student
        }

        // Method to update an existing student
        public void UpdateStudent(StudentDTO student)
        {
            studentDAO.UpdateStudent(student); // Call the DAO method to update a student
        }

        // Method to delete a student
        public void DeleteStudent(string idStudent)
        {
            studentDAO.DeleteStudent(idStudent); // Call the DAO method to delete a student
        }

        public StudentDTO GetStudentById(string idStudent)
        {
            return studentDAO.GetStudentById(idStudent);
        }

        public List<StudentDTO> SearchStudents(string searchTerm, string property)
        {
            return studentDAO.SearchStudents(searchTerm, property);
        }
    }
}