using Microsoft.Data.SqlClient;
using THE_COOKY_APP.DTO;

namespace THE_COOKY_APP.DAO
{
    internal class TopicChefDAO
    {
        private string connectionString = ConnectionDTO.ConnectionString;

        // Method to get all topic chefs
        public List<TopicChefDTO> GetAllTopicChefs()
        {
            List<TopicChefDTO> topicChefs = new List<TopicChefDTO>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM TOPIC_CHEF";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TopicChefDTO topicChef = new TopicChefDTO
                            {
                                NameSpeciality = reader["NAME_SPECIALITY"].ToString(),
                                IdChef = reader["ID_CHEF"].ToString(),
                                IdTopic = reader["ID_TOPIC"].ToString()
                            };
                            topicChefs.Add(topicChef);
                        }
                    }
                }
            }

            return topicChefs; // Return the list of topic chefs
        }

        // Method to add a new topic chef
        public void AddTopicChef(TopicChefDTO topicChef)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO TOPIC_CHEF (NAME_SPECIALITY, ID_CHEF, ID_TOPIC) VALUES (@NameSpeciality, @IdChef, @IdTopic)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NameSpeciality", topicChef.NameSpeciality);
                    cmd.Parameters.AddWithValue("@IdChef", topicChef.IdChef);
                    cmd.Parameters.AddWithValue("@IdTopic", topicChef.IdTopic);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Method to update an existing topic chef
        public void UpdateTopicChef(TopicChefDTO topicChef)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE TOPIC_CHEF SET NAME_SPECIALITY = @NameSpeciality WHERE ID_CHEF = @IdChef AND ID_TOPIC = @IdTopic";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NameSpeciality", topicChef.NameSpeciality);
                    cmd.Parameters.AddWithValue("@IdChef", topicChef.IdChef);
                    cmd.Parameters.AddWithValue("@IdTopic", topicChef.IdTopic);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Method to delete a topic chef
        public void DeleteTopicChef(string idChef, string idTopic)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM TOPIC_CHEF WHERE ID_CHEF = @IdChef AND ID_TOPIC = @IdTopic";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdChef", idChef);
                    cmd.Parameters.AddWithValue("@IdTopic", idTopic);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Method to get a topic chef by chef ID and topic ID
        public TopicChefDTO GetTopicChefById(string idChef, string idTopic)
        {
            TopicChefDTO topicChef = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM TOPIC_CHEF WHERE ID_CHEF = @IdChef AND ID_TOPIC = @IdTopic";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdChef", idChef);
                    cmd.Parameters.AddWithValue("@IdTopic", idTopic);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            topicChef = new TopicChefDTO
                            {
                                NameSpeciality = reader["NAME_SPECIALITY"].ToString(),
                                IdChef = reader["ID_CHEF"].ToString(),
                                IdTopic = reader["ID_TOPIC"].ToString()
                            };
                        }
                    }
                }
            }

            return topicChef; // Return the topic chef found or null if not found
        }

        // Method to get topics by chef ID
        public TopicChefDTO GetTopicsByChefId(string idChef)
        {
            TopicChefDTO topicChefs = new TopicChefDTO();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM TOPIC_CHEF WHERE ID_CHEF = @IdChef";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdChef", idChef);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            topicChefs = new TopicChefDTO
                            {
                                NameSpeciality = reader["NAME_SPECIALITY"].ToString(),
                                IdChef = reader["ID_CHEF"].ToString(),
                                IdTopic = reader["ID_TOPIC"].ToString()
                            };
                            
                        }
                    }
                }
            }

            return topicChefs; // Return the list of topic chefs for the specified chef ID
        }
    }
}