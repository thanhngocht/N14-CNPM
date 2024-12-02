using Microsoft.Data.SqlClient;
using THE_COOKY_APP.DTO;

namespace THE_COOKY_APP.DAO
{
    internal class NormalClassDAO
    {
        private string connectionString = ConnectionDTO.ConnectionString;

        // Method to get all normal classes
        public List<NormalClassDTO> GetAllNormalClasses()
        {
            List<NormalClassDTO> normalClasses = new List<NormalClassDTO>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM NORMAL_CLASS";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            NormalClassDTO normalClass = new NormalClassDTO
                            {
                                Fee = (decimal)reader["FEE"],
                                IdClass = reader["ID_CLASS"].ToString()
                            };
                            normalClasses.Add(normalClass);
                        }
                    }
                }
            }

            return normalClasses; // Return the list of normal classes
        }

        // Method to add a new normal class
        public void AddNormalClass(NormalClassDTO normalClass)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO NORMAL_CLASS (FEE, ID_CLASS) VALUES (@Fee, @IdClass)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Fee", normalClass.Fee);
                    cmd.Parameters.AddWithValue("@IdClass", normalClass.IdClass);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Method to update an existing normal class
        public void UpdateNormalClass(NormalClassDTO normalClass)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE NORMAL_CLASS SET FEE = @Fee WHERE ID_CLASS = @IdClass";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Fee", normalClass.Fee);
                    cmd.Parameters.AddWithValue("@IdClass", normalClass.IdClass);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Method to delete a normal class
        public void DeleteNormalClass(string idClass)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM NORMAL_CLASS WHERE ID_CLASS = @IdClass";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdClass", idClass);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Method to get a normal class by ID
        public NormalClassDTO GetNormalClassById(string idClass)
        {
            NormalClassDTO normalClass = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM NORMAL_CLASS WHERE ID_CLASS = @IdClass";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdClass", idClass);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            normalClass = new NormalClassDTO
                            {
                                Fee = Convert.ToDecimal(reader["FEE"]),
                                IdClass = reader["ID_CLASS"].ToString()
                            };
                        }
                    }
                }
            }

            return normalClass; // Return the normal class found or null if not found
        }
    }
}
