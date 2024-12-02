using Microsoft.Data.SqlClient;
using THE_COOKY_APP.DTO;

namespace THE_COOKY_APP.DAO
{
    internal class LocationDAO
    {
        private string connectionString = ConnectionDTO.ConnectionString;

        public List<LocationDTO> GetAllLocations()
        {
            List<LocationDTO> locations = new List<LocationDTO>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM LOCATION WHERE ACTIVE = 1", connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        LocationDTO location = new LocationDTO
                        {
                            IdLocation = reader["ID_LOCATION"].ToString(),
                            NameLocation = reader["NAME_LOCATION"].ToString(),
                            Address = reader["ADDRESS"].ToString(),
                            Description = reader["DESCRIPTION"].ToString(),
                            MaxLocationQuantity = Convert.ToInt32(reader["MAX_LOCATION_QUANTITY"]),
                            IsActive = true // Since we're only selecting active locations, this will always be true
                        };
                        locations.Add(location);
                    }
                }
            }
            return locations;
        }

        public List<LocationDTO> GetAllNameLocations()
        {
            List<LocationDTO> locations = new List<LocationDTO>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Cập nhật câu lệnh SQL để lấy tất cả các location, không phân biệt ACTIVE
                SqlCommand command = new SqlCommand("SELECT * FROM LOCATION", connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        LocationDTO location = new LocationDTO
                        {
                            IdLocation = reader["ID_LOCATION"].ToString(),
                            NameLocation = reader["NAME_LOCATION"].ToString(),
                            Address = reader["ADDRESS"].ToString(),
                            Description = reader["DESCRIPTION"].ToString(),
                            MaxLocationQuantity = Convert.ToInt32(reader["MAX_LOCATION_QUANTITY"]),
                            IsActive = Convert.ToBoolean(reader["ACTIVE"]) // Lấy trạng thái ACTIVE từ cơ sở dữ liệu
                        };
                        locations.Add(location);
                    }
                }
            }
            return locations;
        }

        public void AddLocation(string nameLocation, string address, string description, int maxLocationQuantity, bool isActive)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO LOCATION (NAME_LOCATION, ADDRESS, DESCRIPTION, MAX_LOCATION_QUANTITY, ACTIVE) VALUES (@Name, @Address, @Description, @MaxQuantity, @IsActive)", connection);
                command.Parameters.AddWithValue("@Name", nameLocation);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@MaxQuantity", maxLocationQuantity);
                command.Parameters.AddWithValue("@IsActive", isActive);
                command.ExecuteNonQuery();
            }
        }

        public int CountClassroomsByLocation(string idLocation)
        {
            int classroomCount = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM CLASSROOM WHERE ID_LOCATION = @IdLocation"; // Truy vấn để đếm số lượng lớp học

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdLocation", idLocation); // Thêm tham số cho ID_LOCATION

                    classroomCount = (int)command.ExecuteScalar(); // Thực thi truy vấn và lấy kết quả
                }
            }

            return classroomCount; // Trả về số lượng lớp học
        }

        public void UpdateLocation(LocationDTO location)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE LOCATION SET NAME_LOCATION = @Name, ADDRESS = @Address, DESCRIPTION = @Description, MAX_LOCATION_QUANTITY = @MaxQuantity, ACTIVE = @IsActive WHERE ID_LOCATION = @Id", connection);
                command.Parameters.AddWithValue("@Id", location.IdLocation);
                command.Parameters.AddWithValue("@Name", location.NameLocation);
                command.Parameters.AddWithValue("@Address", location.Address);
                command.Parameters.AddWithValue("@Description", location.Description);
                command.Parameters.AddWithValue("@MaxQuantity", location.MaxLocationQuantity);
                command.Parameters.AddWithValue("@IsActive", location.IsActive);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteLocation(string idLocation)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE LOCATION SET ACTIVE = 0 WHERE ID_LOCATION = @Id", connection);
                command.Parameters.AddWithValue("@Id", idLocation);
                command.ExecuteNonQuery();
            }
        }

        public string GetLocationIdByName(string nameLocation)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT ID_LOCATION FROM LOCATION WHERE NAME_LOCATION = @Name", connection);
                command.Parameters.AddWithValue("@Name", nameLocation);
                return command.ExecuteScalar().ToString();
            }
        }

        public List<LocationDTO> SearchLocations(string searchTerm, string property)
        {
            List<LocationDTO> locations = new List<LocationDTO>();
            string query = "SELECT * FROM LOCATION WHERE ACTIVE = 1 AND";

            // Xác định thuộc tính tìm kiếm
            switch (property.ToUpper())
            {
                case "TÊN ĐỊA ĐIỂM":
                    query += " NAME_LOCATION COLLATE SQL_Latin1_General_CP1_CI_AI LIKE @SearchTerm"; // Không phân biệt dấu
                    break;
                case "ĐỊA CHỈ":
                    query += " ADDRESS COLLATE SQL_Latin1_General_CP1_CI_AI LIKE @SearchTerm"; // Không phân biệt dấu
                    break;
                case "SỨC CHỨA":
                    query += " MAX_LOCATION_QUANTITY LIKE @SearchTerm"; // Có thể không cần collation nếu không phân biệt dấu
                    break;
                default:
                    throw new ArgumentException("Invalid search property");
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%"); // Thêm tham số tìm kiếm

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            locations.Add(new LocationDTO
                            {
                                IdLocation = reader["ID_LOCATION"].ToString(),
                                NameLocation = reader["NAME_LOCATION"].ToString(),
                                Address = reader["ADDRESS"].ToString(),
                                Description = reader["DESCRIPTION"].ToString(),
                                MaxLocationQuantity = Convert.ToInt32(reader["MAX_LOCATION_QUANTITY"]),
                                IsActive = (bool)(reader["ACTIVE"])
                            });
                        }
                    }
                }
            }
            return locations; // Trả về danh sách địa điểm tìm thấy
        }
        public LocationDTO GetLocationById(string locationId)
        {
            LocationDTO location = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM LOCATION WHERE ID_LOCATION = @LocationId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@LocationId", locationId);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    location = new LocationDTO
                    {
                        IdLocation = reader["ID_LOCATION"].ToString(),
                        NameLocation = reader["NAME_LOCATION"].ToString(),
                        Address = reader["ADDRESS"].ToString(),
                        Description = reader["DESCRIPTION"].ToString(),
                        MaxLocationQuantity = Convert.ToInt32(reader["MAX_LOCATION_QUANTITY"]),
                        IsActive = (bool)(reader["ACTIVE"])
                    };
                }
            }
            return location;
        }

        public bool IsLocationNameExists(string locationName)
        {
            bool exists = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM LOCATION WHERE NAME_LOCATION = @LocationName";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@LocationName", locationName);

                int count = (int)command.ExecuteScalar();
                exists = count > 0;
            }
            return exists;
        }
    }
}
