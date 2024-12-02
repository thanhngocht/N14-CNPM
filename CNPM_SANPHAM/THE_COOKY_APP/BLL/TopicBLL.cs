using THE_COOKY_APP.DTO;
using THE_COOKY_APP.DAO; // Ensure you have the correct namespace for your DAO

namespace THE_COOKY_APP.BLL
{
    internal class TopicBLL
    {
        private TopicDAO topicDAO = new TopicDAO(); // Create an instance of the TopicDAO

        // Method to get all topics
        public List<TopicDTO> GetAllTopics()
        {
            return topicDAO.GetAllTopics(); // Call the DAO method to get all topics
        }

        // Method to add a new topic
        public void AddTopic(string nameTopic, bool isActive)
        {
            topicDAO.AddTopic(nameTopic, isActive); // Call the DAO method to add a topic
        }

        // Method to update an existing topic
        public void UpdateTopic(TopicDTO topic)
        {
            topicDAO.UpdateTopic(topic); // Call the DAO method to update a topic
        }

        // Method to delete a topic
        public void DeleteTopic(string idTopic)
        {
            topicDAO.DeleteTopic(idTopic); // Call the DAO method to delete a topic
        }

        // Method to search topics by name
        public List<TopicDTO> SearchTopics(string searchTerm)
        {
            return topicDAO.SearchTopics(searchTerm); // Call the DAO method to search topics
        }

        // Method to get a topic ID by name
        public string GetTopicIdByName(string nameTopic)
        {
            return topicDAO.GetTopicIdByName(nameTopic); // Call the DAO method to get topic ID by name
        }

        public TopicDTO GetTopicById(string idTopic)
        {
            return topicDAO.GetTopicById(idTopic);
        }
    }
}