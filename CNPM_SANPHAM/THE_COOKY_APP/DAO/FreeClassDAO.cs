using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using THE_COOKY_APP.DTO;

namespace THE_COOKY_APP.DAO
{
    internal class FreeClassDAO
    {
        private string connectionString = ConnectionDTO.ConnectionString;

        // Method to get all free classes
        public List<FreeClassDTO> GetAllFreeClasses()
        {
            List<FreeClassDTO> freeClasses = new List<FreeClassDTO>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM FREE_CLASS";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            FreeClassDTO freeClass = new FreeClassDTO
                            {
                                NameSponsor = reader["NAME_SPONSOR"].ToString(),
                                IdClass = reader["ID_CLASS"].ToString()
                            };
                            freeClasses.Add(freeClass);
                        }
                    }
                }
            }

            return freeClasses; // Return the list of free classes
        }

        // Method to add a new free class
        public void AddFreeClass(FreeClassDTO freeClass)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO FREE_CLASS (NAME_SPONSOR, ID_CLASS) VALUES (@NameSponsor, @IdClass)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NameSponsor", freeClass.NameSponsor);
                    cmd.Parameters.AddWithValue("@IdClass", freeClass.IdClass);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Method to update an existing free class
        public void UpdateFreeClass(FreeClassDTO freeClass)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE FREE_CLASS SET NAME_SPONSOR = @NameSponsor WHERE ID_CLASS = @IdClass";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NameSponsor", freeClass.NameSponsor);
                    cmd.Parameters.AddWithValue("@IdClass", freeClass.IdClass);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Method to delete a free class
        public void DeleteFreeClass(string idClass)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM FREE_CLASS WHERE ID_CLASS = @IdClass";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdClass", idClass);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Method to get a free class by ID
        public FreeClassDTO GetFreeClassById(string idClass)
        {
            FreeClassDTO freeClass = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM FREE_CLASS WHERE ID_CLASS = @IdClass";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdClass", idClass);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            freeClass = new FreeClassDTO
                            {
                                NameSponsor = reader["NAME_SPONSOR"].ToString(),
                                IdClass = reader["ID_CLASS"].ToString()
                            };
                        }
                    }
                }
            }

            return freeClass; // Return the free class found or null if not found
        }
    }
}
