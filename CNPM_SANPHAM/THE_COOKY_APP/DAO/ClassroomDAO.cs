using Microsoft.Data.SqlClient;
using THE_COOKY_APP.DTO;
namespace THE_COOKY_APP.DAO
{
    internal class ClassroomDAO
    {
        private string connectionString = ConnectionDTO.ConnectionString;

        public List<ClassroomDTO> GetAllClassrooms()
        {
            List<ClassroomDTO> classrooms = new List<ClassroomDTO>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
        SELECT c.*, 
               t.NAME_TOPIC AS NameTopic, 
               ch.FULL_NAME AS NameChef, 
               l.NAME_LOCATION AS NameLocation
        FROM CLASSROOM c
        LEFT JOIN TOPIC t ON c.ID_TOPIC = t.ID_TOPIC
        LEFT JOIN CHEF ch ON c.ID_CHEF = ch.ID_CHEF
        LEFT JOIN LOCATION l ON c.ID_LOCATION = l.ID_LOCATION
        WHERE c.STATUS_CLASS = N'Sắp diễn ra' AND c.MAX_QUANTITY = 0"; // Thay đổi điều kiện ở đây

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ClassroomDTO classroom = new ClassroomDTO
                            {
                                IdClass = reader["ID_CLASS"].ToString(),
                                NameClass = reader["NAME_CLASS"].ToString(),
                                DurationHour = (int)reader["DURATION_HOUR"],
                                StartDate = (DateTime)reader["START_DATE"],
                                EndHour = (TimeSpan)reader["END_HOUR"],
                                StatusClass = reader["STATUS_CLASS"].ToString(),
                                MaxQuantity = (int)reader["MAX_QUANTITY"],
                                Description = reader["DESCRIPTION"].ToString(),
                                QuantityArise = (int)reader["QUANTITY_ARISE"],
                                ProvisionalRevenue = Convert.ToDecimal(reader["PROVISIONAL_REVENUE"]),
                                RealRevenue = Convert.ToDecimal(reader["REAL_REVENUE"]),
                                Commission = Convert.ToDecimal(reader["COMMISSION"]),
                                StartHour = (TimeSpan)reader["START_HOUR"],
                                Picture = reader["PICTURE"].ToString(),
                                NameTopic = reader["NameTopic"].ToString(),
                                NameChef = reader["NameChef"].ToString(),
                                NameLocation = reader["NameLocation"].ToString(),
                                MaterialCost = (int)reader["MATERIAL_COST"],
                                FreelancerCost = (int)reader["FREELANCER_COST"],
                                AnotherCost = (int)reader["ANOTHER_COST"],
                                Note = reader["NOTE"].ToString()
                            };
                            classrooms.Add(classroom);
                        }
                    }
                }
            }

            return classrooms; // Trả về danh sách các lớp học thỏa mãn điều kiện
        }

        public ClassroomDTO GetClassroomWithHighestId()
        {
            ClassroomDTO highestClassroom = new ClassroomDTO();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            SELECT TOP 1 c.*, 
                   t.NAME_TOPIC AS NameTopic, 
                   ch.FULL_NAME AS NameChef, 
                   l.NAME_LOCATION AS NameLocation
            FROM CLASSROOM c
            LEFT JOIN TOPIC t ON c.ID_TOPIC = t.ID_TOPIC
            LEFT JOIN CHEF ch ON c.ID_CHEF = ch.ID_CHEF
            LEFT JOIN LOCATION l ON c.ID_LOCATION = l.ID_LOCATION
            WHERE c.ID_CLASS LIKE 'CLASS%'
            ORDER BY CAST(SUBSTRING(c.ID_CLASS, 7, LEN(c.ID_CLASS) - 6) AS INT) DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            highestClassroom = new ClassroomDTO
                            {
                                IdClass = reader["ID_CLASS"].ToString(),
                                NameClass = reader["NAME_CLASS"].ToString(),
                                DurationHour = (int)reader["DURATION_HOUR"],
                                StartDate = (DateTime)reader["START_DATE"],
                                EndHour = (TimeSpan)reader["END_HOUR"],
                                StatusClass = reader["STATUS_CLASS"].ToString(),
                                MaxQuantity = (int)reader["MAX_QUANTITY"],
                                Description = reader["DESCRIPTION"].ToString(),
                                QuantityArise = (int)reader["QUANTITY_ARISE"],
                                ProvisionalRevenue = Convert.ToDecimal(reader["PROVISIONAL_REVENUE"]),
                                RealRevenue = Convert.ToDecimal(reader["REAL_REVENUE"]),
                                Commission = Convert.ToDecimal(reader["COMMISSION"]),
                                StartHour = (TimeSpan)reader["START_HOUR"],
                                Picture = reader["PICTURE"].ToString(),
                                NameTopic = reader["NameTopic"].ToString(),
                                NameChef = reader["NameChef"].ToString(),
                                NameLocation = reader["NameLocation"].ToString(),
                                MaterialCost = (int)reader["MATERIAL_COST"],
                                FreelancerCost = (int)reader["FREELANCER_COST"],
                                AnotherCost = (int)reader["ANOTHER_COST"],
                                Note = reader["NOTE"].ToString()
                            };
                        }
                    }
                }
            }

            return highestClassroom; // Trả về lớp học có ID cao nhất
        }

        public List<ClassroomDTO> GetAllClassroomsByLocation(string idLocation)
        {
            List<ClassroomDTO> classrooms = new List<ClassroomDTO>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
        SELECT c.*, 
               t.NAME_TOPIC AS NameTopic, 
               ch.FULL_NAME AS NameChef, 
               l.NAME_LOCATION AS NameLocation
        FROM CLASSROOM c
        LEFT JOIN TOPIC t ON c.ID_TOPIC = t.ID_TOPIC
        LEFT JOIN CHEF ch ON c.ID_CHEF = ch.ID_CHEF
        LEFT JOIN LOCATION l ON c.ID_LOCATION = l.ID_LOCATION
        WHERE c.ID_LOCATION = @IdLocation"; // Thêm điều kiện lọc theo ID_LOCATION

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdLocation", idLocation); // Thêm tham số cho ID_LOCATION

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ClassroomDTO classroom = new ClassroomDTO
                            {
                                IdClass = reader["ID_CLASS"].ToString(),
                                NameClass = reader["NAME_CLASS"].ToString(),
                                DurationHour = (int)reader["DURATION_HOUR"],
                                StartDate = (DateTime)reader["START_DATE"],
                                EndHour = (TimeSpan)reader["END_HOUR"],
                                StatusClass = reader["STATUS_CLASS"].ToString(),
                                MaxQuantity = (int)reader["MAX_QUANTITY"],
                                Description = reader["DESCRIPTION"].ToString(),
                                QuantityArise = (int)reader["QUANTITY_ARISE"],
                                ProvisionalRevenue = Convert.ToDecimal(reader["PROVISIONAL_REVENUE"]),
                                RealRevenue = Convert.ToDecimal(reader["REAL_REVENUE"]),
                                Commission = Convert.ToDecimal(reader["COMMISSION"]),
                                StartHour = (TimeSpan)reader["START_HOUR"],
                                Picture = reader["PICTURE"].ToString(),
                                NameTopic = reader["NameTopic"].ToString(),
                                NameChef = reader["NameChef"].ToString(),
                                NameLocation = reader["NameLocation"].ToString(),
                                MaterialCost = (int)reader["MATERIAL_COST"],
                                FreelancerCost = (int)reader["FREELANCER_COST"],
                                AnotherCost = (int)reader["ANOTHER_COST"],
                                Note = reader["NOTE"].ToString()
                            };
                            classrooms.Add(classroom);
                        }
                    }
                }
            }

            return classrooms; // Trả về danh sách tất cả các lớp học theo ID_LOCATION
        }

        public List<ClassroomDTO> GetClassroomByPicture(string picturePath)
        {
            List<ClassroomDTO> classrooms = new List<ClassroomDTO>(); // Khởi tạo danh sách lớp học

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
        SELECT c.*, 
               t.NAME_TOPIC AS NameTopic, 
               ch.FULL_NAME AS NameChef, 
               l.NAME_LOCATION AS NameLocation
        FROM CLASSROOM c
        LEFT JOIN TOPIC t ON c.ID_TOPIC = t.ID_TOPIC
        LEFT JOIN CHEF ch ON c.ID_CHEF = ch.ID_CHEF
        LEFT JOIN LOCATION l ON c.ID_LOCATION = l.ID_LOCATION
        WHERE c.PICTURE = @PicturePath AND c.MAX_QUANTITY > 0 AND c.STATUS_CLASS = N'Sắp diễn ra'"; // Thêm điều kiện tìm kiếm theo đường dẫn ảnh và MAX_QUANTITY

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PicturePath", picturePath); // Thêm tham số đường dẫn ảnh

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read()) // Đọc tất cả các bản ghi
                        {
                            ClassroomDTO classroom = new ClassroomDTO
                            {
                                IdClass = reader["ID_CLASS"].ToString(),
                                NameClass = reader["NAME_CLASS"].ToString(),
                                DurationHour = (int)reader["DURATION_HOUR"],
                                StartDate = (DateTime)reader["START_DATE"],
                                EndHour = (TimeSpan)reader["END_HOUR"],
                                StatusClass = reader["STATUS_CLASS"].ToString(),
                                MaxQuantity = (int)reader["MAX_QUANTITY"],
                                Description = reader["DESCRIPTION"].ToString(),
                                QuantityArise = (int)reader["QUANTITY_ARISE"],
                                ProvisionalRevenue = Convert.ToDecimal(reader["PROVISIONAL_REVENUE"]),
                                RealRevenue = Convert.ToDecimal(reader["REAL_REVENUE"]),
                                Commission = Convert.ToDecimal(reader["COMMISSION"]),
                                StartHour = (TimeSpan)reader["START_HOUR"],
                                Picture = reader["PICTURE"].ToString(),
                                NameTopic = reader["NameTopic"].ToString(),
                                NameChef = reader["NameChef"].ToString(),
                                NameLocation = reader["NameLocation"].ToString(),
                                MaterialCost = (int)reader["MATERIAL_COST"],
                                FreelancerCost = (int)reader["FREELANCER_COST"],
                                AnotherCost = (int)reader["ANOTHER_COST"],
                                Note = reader["NOTE"].ToString()
                            };
                            classrooms.Add(classroom); // Thêm lớp học vào danh sách
                        }
                    }
                }
            }

            return classrooms; // Trả về danh sách các lớp học thỏa mãn điều kiện
        }

        public void AddClassroom(string nameClass, int durationHour, DateTime startDate, TimeSpan endHour, string statusClass, int maxQuantity, string description, int quantityArise, decimal provisionalRevenue, decimal realRevenue, decimal commission, TimeSpan startHour, string picture, string idTopic, string idChef, string idLocation, int materialCost, int freelancerCost, int anotherCost, string note)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                INSERT INTO CLASSROOM (NAME_CLASS, DURATION_HOUR, START_DATE, END_HOUR, STATUS_CLASS, MAX_QUANTITY, DESCRIPTION, QUANTITY_ARISE, PROVISIONAL_REVENUE, REAL_REVENUE, COMMISSION, START_HOUR, PICTURE, ID_TOPIC, ID_CHEF, ID_LOCATION, MATERIAL_COST, FREELANCER_COST, ANOTHER_COST, NOTE) 
                VALUES (@NameClass, @DurationHour, @StartDate, @EndHour, @StatusClass, @MaxQuantity, @Description, @QuantityArise, @ProvisionalRevenue, @RealRevenue, @Commission, @StartHour, @Picture, @IdTopic, @IdChef, @IdLocation, @MaterialCost, @FreelancerCost, @AnotherCost, @Note)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NameClass", nameClass);
                    cmd.Parameters.AddWithValue("@DurationHour", durationHour);
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndHour", endHour);
                    cmd.Parameters.AddWithValue("@StatusClass", statusClass);
                    cmd.Parameters.AddWithValue("@MaxQuantity", maxQuantity);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.Parameters.AddWithValue("@QuantityArise", quantityArise);
                    cmd.Parameters.AddWithValue("@ProvisionalRevenue", provisionalRevenue);
                    cmd.Parameters.AddWithValue("@RealRevenue", realRevenue);
                    cmd.Parameters.AddWithValue("@Commission", commission);
                    cmd.Parameters.AddWithValue("@StartHour", startHour);
                    cmd.Parameters.AddWithValue("@Picture", picture);
                    cmd.Parameters.AddWithValue("@IdTopic", idTopic);
                    cmd.Parameters.AddWithValue("@IdChef", idChef);
                    cmd.Parameters.AddWithValue("@IdLocation", idLocation);
                    cmd.Parameters.AddWithValue("@MaterialCost", materialCost);
                    cmd.Parameters.AddWithValue("@FreelancerCost", freelancerCost);
                    cmd.Parameters.AddWithValue("@AnotherCost", anotherCost);
                    cmd.Parameters.AddWithValue("@Note", note);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateClassroom(ClassroomDTO classroom)
        {
            // Lấy ID từ tên tương ứng
            string idTopic = GetIDByName("TopicDAO", classroom.NameTopic);
            string idChef = GetIDByName("ChefDAO", classroom.NameChef);
            string idLocation = GetIDByName("LocationDAO", classroom.NameLocation);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                UPDATE CLASSROOM 
                SET NAME_CLASS = @NameClass, 
                    DURATION_HOUR = @DurationHour, 
                    START_DATE = @StartDate, 
                    END_HOUR = @EndHour, 
                    STATUS_CLASS = @StatusClass, 
                    MAX_QUANTITY = @MaxQuantity, 
                    DESCRIPTION = @Description, 
                    QUANTITY_ARISE = @QuantityArise, 
                    PROVISIONAL_REVENUE = @ProvisionalRevenue, 
                    REAL_REVENUE = @RealRevenue, 
                    COMMISSION = @Commission, 
                    START_HOUR = @StartHour, 
                    PICTURE = @Picture, 
                    ID_TOPIC = @IdTopic, 
                    ID_CHEF = @IdChef, 
                    ID_LOCATION = @IdLocation,
                    MATERIAL_COST = @MaterialCost,
                    FREELANCER_COST = @FreelancerCost,
                    ANOTHER_COST = @AnotherCost,
                    NOTE = @Note
                WHERE ID_CLASS = @IdClass";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdClass", classroom.IdClass);
                    cmd.Parameters.AddWithValue("@NameClass", classroom.NameClass);
                    cmd.Parameters.AddWithValue("@DurationHour", classroom.DurationHour);
                    cmd.Parameters.AddWithValue("@StartDate", classroom.StartDate);
                    cmd.Parameters.AddWithValue("@EndHour", classroom.EndHour);
                    cmd.Parameters.AddWithValue("@StatusClass", classroom.StatusClass);
                    cmd.Parameters.AddWithValue("@MaxQuantity", classroom.MaxQuantity);
                    cmd.Parameters.AddWithValue("@Description", classroom.Description);
                    cmd.Parameters.AddWithValue("@QuantityArise", classroom.QuantityArise);
                    cmd.Parameters.AddWithValue("@ProvisionalRevenue", classroom.ProvisionalRevenue);
                    cmd.Parameters.AddWithValue("@RealRevenue", classroom.RealRevenue);
                    cmd.Parameters.AddWithValue("@Commission", classroom.Commission);
                    cmd.Parameters.AddWithValue("@StartHour", classroom.StartHour);
                    cmd.Parameters.AddWithValue("@Picture", classroom.Picture);
                    cmd.Parameters.AddWithValue("@IdTopic", idTopic);
                    cmd.Parameters.AddWithValue("@IdChef", idChef);
                    cmd.Parameters.AddWithValue("@IdLocation", idLocation);
                    cmd.Parameters.AddWithValue("@MaterialCost", classroom.MaterialCost);
                    cmd.Parameters.AddWithValue("@FreelancerCost", classroom.FreelancerCost);
                    cmd.Parameters.AddWithValue("@AnotherCost", classroom.AnotherCost);
                    cmd.Parameters.AddWithValue("@Note", classroom.Note);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteClassroom(string idClass)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE CLASSROOM SET STATUS_CLASS = N'Đã hủy' WHERE ID_CLASS = @IdClass";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdClass", idClass);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private string GetIDByName(string daoName, string name)
        {
            string id = "";
            switch (daoName)
            {
                case "TopicDAO":
                    id = new TopicDAO().GetTopicIdByName(name);
                    break;
                case "ChefDAO":
                    id = new ChefDAO().GetChefIdByName(name);
                    break;
                case "LocationDAO":
                    id = new LocationDAO().GetLocationIdByName(name);
                    break;
            }
            return id;
        }

        public List<ClassroomDTO> SearchClassrooms(string searchTerm, string property)
        {
            List<ClassroomDTO> classrooms = new List<ClassroomDTO>();
            string query = @"
        SELECT c.*, 
               t.NAME_TOPIC AS NameTopic, 
               ch.FULL_NAME AS NameChef, 
               l.NAME_LOCATION AS NameLocation
        FROM CLASSROOM c
        LEFT JOIN TOPIC t ON c.ID_TOPIC = t.ID_TOPIC
        LEFT JOIN CHEF ch ON c.ID_CHEF = ch.ID_CHEF
        LEFT JOIN LOCATION l ON c.ID_LOCATION = l.ID_LOCATION
        WHERE c.MAX_QUANTITY = 0 AND ";

            // Xác định thuộc tính tìm kiếm
            switch (property.ToUpper())
            {
                case "LỚP HỌC":
                    query += "c.NAME_CLASS COLLATE SQL_Latin1_General_CP1_CI_AI LIKE @searchTerm";
                    break;
                case "GIÁO VIÊN":
                    query += "ch.FULL_NAME COLLATE SQL_Latin1_General_CP1_CI_AI LIKE @searchTerm";
                    break;
                case "ĐỊA ĐIỂM":
                    query += "l.NAME_LOCATION COLLATE SQL_Latin1_General_CP1_CI_AI LIKE @searchTerm";
                    break;
                case "SỐ LƯỢNG":
                    query += "c.MAX_QUANTITY LIKE @searchTerm"; // Có thể thay đổi tùy thuộc vào cách bạn muốn tìm kiếm số lượng
                    break;
                default:
                    throw new ArgumentException("Invalid search property");
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%"); // Thêm tham số tìm kiếm

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ClassroomDTO classroom = new ClassroomDTO
                            {
                                IdClass = reader["ID_CLASS"].ToString(),
                                NameClass = reader["NAME_CLASS"].ToString(),
                                DurationHour = (int)reader["DURATION_HOUR"],
                                StartDate = (DateTime)reader["START_DATE"],
                                EndHour = (TimeSpan)reader["END_HOUR"],
                                StatusClass = reader["STATUS_CLASS"].ToString(),
                                MaxQuantity = (int)reader["MAX_QUANTITY"],
                                Description = reader["DESCRIPTION"].ToString(),
                                QuantityArise = (int)reader["QUANTITY_ARISE"],
                                ProvisionalRevenue = Convert.ToDecimal(reader["PROVISIONAL_REVENUE"]),
                                RealRevenue = Convert.ToDecimal(reader["REAL_REVENUE"]),
                                Commission = Convert.ToDecimal(reader["COMMISSION"]),
                                StartHour = (TimeSpan)reader["START_HOUR"],
                                Picture = reader["PICTURE"].ToString(),
                                NameTopic = reader["NameTopic"].ToString(),
                                NameChef = reader["NameChef"].ToString(),
                                NameLocation = reader["NameLocation"].ToString(),
                                MaterialCost = (int)reader["MATERIAL_COST"],
                                FreelancerCost = (int)reader["FREELANCER_COST"],
                                AnotherCost = (int)reader["ANOTHER_COST"],
                                Note = reader["NOTE"].ToString()
                            };
                            classrooms.Add(classroom);
                        }
                    }
                }
            }

            return classrooms; // Trả về danh sách lớp học tìm thấy
        }

        public ClassroomDTO GetClassroomById(string idClass)
        {
            ClassroomDTO classroom = null; // Khởi tạo biến classroom với giá trị null

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                SELECT c.*, 
                       t.NAME_TOPIC AS NameTopic, 
                       ch.FULL_NAME AS NameChef, 
                       l.NAME_LOCATION AS NameLocation
                FROM CLASSROOM c
                LEFT JOIN TOPIC t ON c.ID_TOPIC = t.ID_TOPIC
                LEFT JOIN CHEF ch ON c.ID_CHEF = ch.ID_CHEF
                LEFT JOIN LOCATION l ON c.ID_LOCATION = l.ID_LOCATION
                WHERE c.ID_CLASS = @IdClass"; // Thêm điều kiện WHERE để lọc theo ID_CLASS

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdClass", idClass); // Thêm tham số cho ID_CLASS

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) // Kiểm tra nếu có bản ghi nào được tìm thấy
                        {
                            classroom = new ClassroomDTO
                            {
                                IdClass = reader["ID_CLASS"].ToString(),
                                NameClass = reader["NAME_CLASS"].ToString(),
                                DurationHour = (int)reader["DURATION_HOUR"],
                                StartDate = (DateTime)reader["START_DATE"],
                                EndHour = (TimeSpan)reader["END_HOUR"],
                                StatusClass = reader["STATUS_CLASS"].ToString(),
                                MaxQuantity = (int)reader["MAX_QUANTITY"],
                                Description = reader["DESCRIPTION"].ToString(),
                                QuantityArise = (int)reader["QUANTITY_ARISE"],
                                ProvisionalRevenue = Convert.ToDecimal(reader["PROVISIONAL_REVENUE"]),
                                RealRevenue = Convert.ToDecimal(reader["REAL_REVENUE"]),
                                Commission = Convert.ToDecimal(reader["COMMISSION"]),
                                StartHour = (TimeSpan)reader["START_HOUR"],
                                Picture = reader["PICTURE"].ToString(),
                                NameTopic = reader["NameTopic"].ToString(),
                                NameChef = reader["NameChef"].ToString(),
                                NameLocation = reader["NameLocation"].ToString(),
                                MaterialCost = (int)reader["MATERIAL_COST"],
                                FreelancerCost = (int)reader["FREELANCER_COST"],
                                AnotherCost = (int)reader["ANOTHER_COST"],
                                Note = reader["NOTE"].ToString()
                            };
                        }
                    }
                }
            }

            return classroom; // Trả về đối tượng ClassroomDTO hoặc null nếu không tìm thấy
        }

        public ClassroomDTO GetClassroomByCriteria(string picture, DateTime startDate, TimeSpan startHour)
        {
            ClassroomDTO classroom = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            SELECT TOP 1 c.*, 
                   t.NAME_TOPIC AS NameTopic, 
                   ch.FULL_NAME AS NameChef, 
                   l.NAME_LOCATION AS NameLocation
            FROM CLASSROOM c
            LEFT JOIN TOPIC t ON c.ID_TOPIC = t.ID_TOPIC
            LEFT JOIN CHEF ch ON c.ID_CHEF = ch.ID_CHEF
            LEFT JOIN LOCATION l ON c.ID_LOCATION = l.ID_LOCATION
            WHERE c.STATUS_CLASS = N'Sắp diễn ra' 
              AND c.PICTURE = @Picture 
              AND c.START_DATE = @StartDate 
              AND c.START_HOUR = @StartHour";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Picture", picture);
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@StartHour", startHour);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) // Only read the first result
                        {
                            classroom = new ClassroomDTO
                            {
                                IdClass = reader["ID_CLASS"].ToString(),
                                NameClass = reader["NAME_CLASS"].ToString(),
                                DurationHour = (int)reader["DURATION_HOUR"],
                                StartDate = (DateTime)reader["START_DATE"],
                                EndHour = (TimeSpan)reader["END_HOUR"],
                                StatusClass = reader["STATUS_CLASS"].ToString(),
                                MaxQuantity = (int)reader["MAX_QUANTITY"],
                                Description = reader["DESCRIPTION"].ToString(),
                                QuantityArise = (int)reader["QUANTITY_ARISE"],
                                ProvisionalRevenue = Convert.ToDecimal(reader["PROVISIONAL_REVENUE"]),
                                RealRevenue = Convert.ToDecimal(reader["REAL_REVENUE"]),
                                Commission = Convert.ToDecimal(reader["COMMISSION"]),
                                StartHour = (TimeSpan)reader["START_HOUR"],
                                Picture = reader["PICTURE"].ToString(),
                                NameTopic = reader["NameTopic"].ToString(),
                                NameChef = reader["NameChef"].ToString(),
                                NameLocation = reader["NameLocation"].ToString(),
                                MaterialCost = (int)reader["MATERIAL_COST"],
                                FreelancerCost = (int)reader["FREELANCER_COST"],
                                AnotherCost = (int)reader["ANOTHER_COST"],
                                Note = reader["NOTE"].ToString()
                            };
                        }
                    }
                }
            }

            return classroom; // Return the single classroom that matches the criteria, or null if none found
        }

        public List<ClassroomDTO> GetAllClassroomsByMonth(int month, string idLocation)
        {
            List<ClassroomDTO> classrooms = new List<ClassroomDTO>();
            int currentYear = DateTime.Now.Year; // Lấy năm hiện tại
            DateTime currentDate = DateTime.Now; // Lấy ngày hiện tại

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                SELECT c.*, 
                       t.NAME_TOPIC AS NameTopic, 
                       ch.FULL_NAME AS NameChef, 
                       l.NAME_LOCATION AS NameLocation
                FROM CLASSROOM c
                LEFT JOIN TOPIC t ON c.ID_TOPIC = t.ID_TOPIC
                LEFT JOIN CHEF ch ON c.ID_CHEF = ch.ID_CHEF
                LEFT JOIN LOCATION l ON c.ID_LOCATION = l.ID_LOCATION
                WHERE c.MAX_QUANTITY > 0 
                  AND MONTH(c.START_DATE) = @Month 
                  AND YEAR(c.START_DATE) = @Year 
                  AND c.ID_LOCATION = @IdLocation
                  AND c.START_DATE <= @CurrentDate"; // Điều kiện kiểm tra StartDate đã qua

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Thêm các tham số vào câu lệnh SQL
                    // Thêm tham số cho ngày hiện tại
                    cmd.Parameters.AddWithValue("@Month", month);
                    cmd.Parameters.AddWithValue("@Year", currentYear);
                    cmd.Parameters.AddWithValue("@IdLocation", idLocation);
                    cmd.Parameters.AddWithValue("@CurrentDate", currentDate);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ClassroomDTO classroom = new ClassroomDTO
                            {
                                IdClass = reader["ID_CLASS"].ToString(),
                                NameClass = reader["NAME_CLASS"].ToString(),
                                DurationHour = (int)reader["DURATION_HOUR"],
                                StartDate = (DateTime)reader["START_DATE"],
                                EndHour = (TimeSpan)reader["END_HOUR"],
                                StatusClass = reader["STATUS_CLASS"].ToString(),
                                MaxQuantity = (int)reader["MAX_QUANTITY"],
                                Description = reader["DESCRIPTION"].ToString(),
                                QuantityArise = (int)reader["QUANTITY_ARISE"],
                                ProvisionalRevenue = Convert.ToDecimal(reader["PROVISIONAL_REVENUE"]),
                                RealRevenue = Convert.ToDecimal(reader["REAL_REVENUE"]),
                                Commission = Convert.ToDecimal(reader["COMMISSION"]),
                                StartHour = (TimeSpan)reader["START_HOUR"],
                                Picture = reader["PICTURE"].ToString(),
                                NameTopic = reader["NameTopic"].ToString(),
                                NameChef = reader["NameChef"].ToString(),
                                NameLocation = reader["NameLocation"].ToString(),
                                MaterialCost = (int)reader["MATERIAL_COST"],
                                FreelancerCost = (int)reader["FREELANCER_COST"],
                                AnotherCost = (int)reader["ANOTHER_COST"],
                                Note = reader["NOTE"].ToString()
                            };
                            classrooms.Add(classroom);
                        }
                    }
                }
            }

            return classrooms; // Trả về danh sách các lớp học thỏa mãn điều kiện
        }
    }
}