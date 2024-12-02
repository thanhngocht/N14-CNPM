using THE_COOKY_APP.DTO;
using THE_COOKY_APP.DAO; // Đảm bảo bạn có namespace đúng cho DAO
using System;
using System.Collections.Generic;

namespace THE_COOKY_APP.BLL
{
    internal class ClassroomBLL
    {
        private readonly ClassroomDAO classroomDAO = new ClassroomDAO(); // Tạo một thể hiện của ClassroomDAO

        // Phương thức để lấy tất cả các lớp học
        public List<ClassroomDTO> GetAllClassrooms()
        {
            return classroomDAO.GetAllClassrooms(); // Gọi phương thức DAO để lấy tất cả các lớp học
        }

        // Phương thức để thêm một lớp học mới
        public void AddClassroom(string nameClass, int durationHour, DateTime startDate, TimeSpan endHour,
                                 string statusClass, int maxQuantity, string description,
                                 int quantityArise, decimal provisionalRevenue,
                                 decimal realRevenue, decimal commission,
                                 TimeSpan startHour, string picture,
                                 string idTopic, string idChef, string idLocation,
                                 int materialCost, int freelancerCost, int anotherCost, string note)
        {
            classroomDAO.AddClassroom(nameClass, durationHour, startDate, endHour,
                                       statusClass, maxQuantity, description,
                                       quantityArise, provisionalRevenue,
                                       realRevenue, commission, startHour,
                                       picture, idTopic, idChef, idLocation,
                                       materialCost, freelancerCost, anotherCost, note); // Gọi phương thức DAO để thêm lớp học
        }

        // Phương thức để cập nhật một lớp học hiện có
        public void UpdateClassroom(ClassroomDTO classroom)
        {
            classroomDAO.UpdateClassroom(classroom); // Gọi phương thức DAO để cập nhật lớp học
        }

        // Phương thức để xóa một lớp học
        public void DeleteClassroom(string idClass)
        {
            classroomDAO.DeleteClassroom(idClass); // Gọi phương thức DAO để xóa lớp học
        }

        // Phương thức để tìm kiếm lớp học theo tên
        public List<ClassroomDTO> SearchClassrooms(string searchTerm, string property)
        {
            return classroomDAO.SearchClassrooms(searchTerm, property); // Gọi phương thức DAO để tìm kiếm lớp học
        }

        public ClassroomDTO GetClassroomById(string idClass)
        {
            return classroomDAO.GetClassroomById(idClass);
        }

        public List<ClassroomDTO> GetClassroomByPicture(string picturePath)
        {
            return classroomDAO.GetClassroomByPicture(picturePath);
        }
        public List<ClassroomDTO> GetAllClassroomsByLocation(string idLocation)
        {
            return classroomDAO.GetAllClassroomsByLocation(idLocation);
        }

        public ClassroomDTO GetClassroomWithHighestId()
        {
            return classroomDAO.GetClassroomWithHighestId();
        }

        public ClassroomDTO GetClassroomByCriteria(string picture, DateTime startDate, TimeSpan startHour)
        {
            return classroomDAO.GetClassroomByCriteria(picture, startDate, startHour);
        }

        public List<ClassroomDTO> GetAllClassroomsByMonth(int month, string idLocation)
        {
            return classroomDAO.GetAllClassroomsByMonth(month, idLocation);
        }
    }
}