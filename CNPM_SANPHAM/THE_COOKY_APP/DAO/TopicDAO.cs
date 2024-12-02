using Microsoft.Data.SqlClient;
using THE_COOKY_APP.DTO;

namespace THE_COOKY_APP.DAO
{
    internal class TopicDAO
    {
        private string connectionString = ConnectionDTO.ConnectionString;

        public List<TopicDTO> GetAllTopics()
        {
            List<TopicDTO> topics = new List<TopicDTO>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM TOPIC WHERE ACTIVE = 1", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TopicDTO topic = new TopicDTO
                    {
                        IdTopic = reader["ID_TOPIC"].ToString(),
                        NameTopic = reader["NAME_TOPIC"].ToString(),
                        IsActive = (bool)reader["ACTIVE"] // Giữ nguyên kiểu bool
                    };
                    topics.Add(topic);
                }
            }
            return topics;
        }

        public void AddTopic(string nameTopic, bool isActive)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO TOPIC (NAME_TOPIC, ACTIVE) VALUES (@NameTopic, @IsActive)", conn);
                cmd.Parameters.AddWithValue("@NameTopic", nameTopic);
                cmd.Parameters.AddWithValue("@IsActive", isActive);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateTopic(TopicDTO topic)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE TOPIC SET NAME_TOPIC = @NameTopic, ACTIVE = @IsActive WHERE ID_TOPIC = @IdTopic", conn);
                cmd.Parameters.AddWithValue("@NameTopic", topic.NameTopic);
                cmd.Parameters.AddWithValue("@IsActive", topic.IsActive);
                cmd.Parameters.AddWithValue("@IdTopic", topic.IdTopic);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteTopic(string idTopic)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE TOPIC SET ACTIVE = 0 WHERE ID_TOPIC = @IdTopic", conn);
                cmd.Parameters.AddWithValue("@IdTopic", idTopic);
                cmd.ExecuteNonQuery();
            }
        }

        public List<TopicDTO> SearchTopics(string searchTerm)
        {
            List<TopicDTO> topics = new List<TopicDTO>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM TOPIC WHERE NAME_TOPIC LIKE @searchTerm AND ACTIVE = 1"; // Tìm kiếm với điều kiện ACTIVE = 1
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%"); // Thêm tham số tìm kiếm

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TopicDTO topic = new TopicDTO
                            {
                                IdTopic = reader["ID_TOPIC"].ToString(),
                                NameTopic = reader["NAME_TOPIC"].ToString(),
                                IsActive = (bool)reader["ACTIVE"] // Giữ nguyên kiểu bool
                            };
                            topics.Add(topic);
                        }
                    }
                }
            }

            return topics; // Trả về danh sách các chủ đề tìm thấy
        }

        public string GetTopicIdByName(string nameTopic)
        {
            string topicId = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ID_TOPIC FROM TOPIC WHERE NAME_TOPIC = @NameTopic";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NameTopic", nameTopic);

                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    topicId = result.ToString();
                }
            }

            return topicId;
        }

        public TopicDTO GetTopicById(string idTopic)
        {
            TopicDTO topic = null; // Khởi tạo biến topic với giá trị null
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM TOPIC WHERE ID_TOPIC = @IdTopic";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdTopic", idTopic);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    topic = new TopicDTO
                    {
                        IdTopic = reader["ID_TOPIC"].ToString(),
                        NameTopic = reader["NAME_TOPIC"].ToString(),
                        IsActive = (bool)reader["ACTIVE"] // Chuyển đổi từ int sang bool
                    };
                }
            }
            return topic; // Trả về đối tượng topic hoặc null nếu không tìm thấy
        }
    }
}
