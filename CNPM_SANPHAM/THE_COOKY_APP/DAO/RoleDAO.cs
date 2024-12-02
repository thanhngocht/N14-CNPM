using Microsoft.Data.SqlClient;
using THE_COOKY_APP.DTO;

namespace THE_COOKY_APP.DAO
{
    internal class RoleDAO
    {
        private string connectionString = ConnectionDTO.ConnectionString;

        // Method to get all roles
        public List<RoleDTO> GetAllRoles()
        {
            List<RoleDTO> roles = new List<RoleDTO>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM ROLE";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            RoleDTO role = new RoleDTO
                            {
                                IdRole = reader["ID_ROLE"].ToString(),
                                NameRole = reader["NAME_ROLE"].ToString()
                            };
                            roles.Add(role);
                        }
                    }
                }
            }

            return roles; // Return the list of roles
        }

        // Method to add a new role
        public void AddRole(RoleDTO role)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO ROLE (ID_ROLE, NAME_ROLE) VALUES (@IdRole, @NameRole)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdRole", role.IdRole);
                    cmd.Parameters.AddWithValue("@NameRole", role.NameRole);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Method to update an existing role
        public void UpdateRole(RoleDTO role)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE ROLE SET NAME_ROLE = @NameRole WHERE ID_ROLE = @IdRole";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdRole", role.IdRole);
                    cmd.Parameters.AddWithValue("@NameRole", role.NameRole);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Method to delete a role
        public void DeleteRole(string idRole)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM ROLE WHERE ID_ROLE = @IdRole";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdRole", idRole);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Method to get a role by ID
        public RoleDTO GetRoleById(string idRole)
        {
            RoleDTO role = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM ROLE WHERE ID_ROLE = @IdRole";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdRole", idRole);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            role = new RoleDTO
                            {
                                IdRole = reader["ID_ROLE"].ToString(),
                                NameRole = reader["NAME_ROLE"].ToString()
                            };
                        }
                    }
                }
            }

            return role; // Return the role found or null if not found
        }

        // Method to get a role by name
        public RoleDTO GetRoleByNameRole(string nameRole)
        {
            RoleDTO role = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM ROLE WHERE NAME_ROLE = @NameRole";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NameRole", nameRole);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            role = new RoleDTO
                            {
                                IdRole = reader["ID_ROLE"].ToString(),
                                NameRole = reader["NAME_ROLE"].ToString()
                            };
                        }
                    }
                }
            }

            return role; // Return the role found or null if not found
        }
    }
}
