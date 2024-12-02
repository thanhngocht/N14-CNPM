using THE_COOKY_APP.DAO;
using THE_COOKY_APP.DTO;

namespace THE_COOKY_APP.BLL
{
    internal class TopicChefBLL
    {
        private TopicChefDAO topicChefDAO = new TopicChefDAO(); // Tạo một instance của TopicChefDAO

        // Method to get all topic chefs
        public List<TopicChefDTO> GetAllTopicChefs()
        {
            return topicChefDAO.GetAllTopicChefs(); // Gọi phương thức DAO để lấy tất cả các chủ đề đầu bếp
        }

        // Method to add a new topic chef
        public void AddTopicChef(TopicChefDTO topicChef)
        {
            if (topicChef == null)
            {
                throw new ArgumentNullException(nameof(topicChef), "TopicChef cannot be null");
            }
            topicChefDAO.AddTopicChef(topicChef); // Gọi phương thức DAO để thêm một chủ đề đầu bếp
        }

        // Method to update an existing topic chef
        public void UpdateTopicChef(TopicChefDTO topicChef)
        {
            if (topicChef == null)
            {
                throw new ArgumentNullException(nameof(topicChef), "TopicChef cannot be null");
            }
            topicChefDAO.UpdateTopicChef(topicChef); // Gọi phương thức DAO để cập nhật một chủ đề đầu bếp
        }

        // Method to delete a topic chef
        public void DeleteTopicChef(string idChef, string idTopic)
        {
            topicChefDAO.DeleteTopicChef(idChef, idTopic); // Gọi phương thức DAO để xóa một chủ đề đầu bếp
        }

        // Method to get topics by chef ID
        public TopicChefDTO GetTopicsByChefId(string idChef)
        {
            return topicChefDAO.GetTopicsByChefId(idChef); // Gọi phương thức DAO để lấy các chủ đề theo ID đầu bếp
        }
    }
}