 using THE_COOKY_APP.BLL;
using THE_COOKY_APP.DTO;
using System.Globalization;
using System;
using THE_COOKY_APP.GUI.CHEF;
using THE_COOKY_APP.GUI.LOCATION;
using THE_COOKY_APP.GUI.TOPIC;
using Newtonsoft.Json;
using System.Text;
using Microsoft.Identity.Client;
using Microsoft.VisualBasic.Devices;
using GenerativeAI.Methods;
using GenerativeAI.Models;
using GenerativeAI.Types;
using GenerativeAI.Exceptions;

namespace THE_COOKY_APP.GUI.CLASSROOM
{
    public partial class CreateClassroom : Form
    {
        private readonly ChefBLL chefBLL = new ChefBLL();
        private readonly LocationBLL locationBLL = new LocationBLL();
        private readonly TopicBLL topicBLL = new TopicBLL();
        private readonly ClassroomBLL classroomBLL = new ClassroomBLL();
        private readonly NormalClassBLL normalClassBLL = new NormalClassBLL();
        private readonly FreeClassBLL freeClassBLL = new FreeClassBLL();
        private readonly DataValidator dataValidator = new DataValidator();
        private string imagePath = "";
        public CreateClassroom()
        {
            InitializeComponent();
            this.Size = new Size(1200, 850);
            this.AutoScroll = true;
            this.Shown += new EventHandler(CreateClassroom_Shown);
            LoadComboBoxs();
        }

        private void LoadComboBoxs()
        {
            List<ChefDTO> chefDTOs = chefBLL.GetAllChefs();
            List<LocationDTO> locationDTOs = locationBLL.GetAllLocations();
            List<TopicDTO> topicDTOs = topicBLL.GetAllTopics();

            cmbChef.Items.Clear();
            cmbChef.Items.Add("Thêm mới");
            foreach (var chefDTO in chefDTOs)
            {
                cmbChef.Items.Add(chefDTO.FullName);
            }

            cmbLocation.Items.Clear();
            cmbLocation.Items.Add("Thêm mới");
            foreach (var locationDTO in locationDTOs)
            {
                cmbLocation.Items.Add(locationDTO.NameLocation);
            }

            cmbTopic.Items.Clear();
            cmbTopic.Items.Add("Thêm mới");
            foreach (var topicDTO in topicDTOs)
            {
                cmbTopic.Items.Add(topicDTO.NameTopic);
            }

            cmbForm.Items.Clear();
            cmbForm.Items.Add("Bình thường");
            cmbForm.Items.Add("Miễn phí");
            cmbForm.SelectedIndex = 0;

            cmbSponsor.Items.Clear();
            cmbSponsor.Items.Add("Không");
            cmbSponsor.SelectedIndex = 0;
        }

        private void CreateClassroom_Shown(object? sender, EventArgs e)
        {
            UpdateScrollPosition();
            this.AutoScrollPosition = new Point(0, 0);
        }

        private void UpdateScrollPosition()
        {
            int totalHeight = 0;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.Visible)
                {
                    totalHeight = Math.Max(totalHeight, ctrl.Bottom);
                }
            }

            this.AutoScrollMargin = new Size(0, 40);
        }

        private void CreateClassroom_Load(object sender, EventArgs e)
        {
            CheckAndShowEmptyMessage();
        }
        private void CheckAndShowEmptyMessage()
        {
            if (dgvListTime.Rows.Count == 0)
            {
                int rowIndex = dgvListTime.Rows.Add();
                dgvListTime.Rows[rowIndex].Cells[0].Value = "Chưa có";
                dgvListTime.Rows[rowIndex].Cells[1].Value = "Chưa có";
                dgvListTime.Rows[rowIndex].Cells[2].Value = "Chưa có";
                dgvListTime.Rows[rowIndex].Cells[3].Value = "Chưa có";
                dgvListTime.Rows[rowIndex].Cells[4].Value = "Chưa có";
                dgvListTime.Rows[rowIndex].Cells[5].Value = "Chưa có";
                dgvListTime.Rows[rowIndex].Cells[6].Value = "Chưa có";
                dgvListTime.Rows[rowIndex].Cells[7].Value = "Chưa có";
                // Thiết lập định dạng cho dòng thông báo
                dgvListTime.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Black;
                dgvListTime.Rows[rowIndex].DefaultCellStyle.Font = new Font(dgvListTime.Font.FontFamily, 10, FontStyle.Bold); // FontSize 10 và Semibold
                dgvListTime.Rows[rowIndex].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvListTime.Rows[rowIndex].ReadOnly = true; // Ngăn người dùng chỉnh sửa dòng thông báo 

            }
            else
            {
                // Nếu có dữ liệu, xóa dòng thông báo nếu tồn tại
                if (dgvListTime.Rows[0].Cells[0].Value.ToString() == "Chưa có")
                {
                    dgvListTime.Rows.RemoveAt(0);
                }
            }
        }

        private void btnAddTime_Click(object sender, EventArgs e)
        {
            if (dgvListTime.Rows.Count > 0)
            {
                if (dgvListTime.Rows[0].Cells[0].Value.ToString() == "Chưa có")
                {
                    dgvListTime.Rows.Clear();
                }
            }
            using (PickTime pickTimeForm = new PickTime())
            {
                // Hiển thị Form PickTime và kiểm tra kết quả
                if (pickTimeForm.ShowDialog() == DialogResult.OK)
                {
                    // Nhận thời gian đã chọn từ Form PickTime
                    string? organizationDay = pickTimeForm.OrganizationDay;
                    string? startHour = pickTimeForm.StartHour;
                    string? endHour = pickTimeForm.EndHour;
                    int fee = pickTimeForm.Fee;
                    int materialCost = pickTimeForm.MaterialCost;
                    int freelancerCost = pickTimeForm.FreelancerCost;
                    int anotherCost = pickTimeForm.AnotherCost;
                    string? note = pickTimeForm.Note;
                    // hHiển thị thời gian đã chọn
                    int rowIndex = dgvListTime.Rows.Add();
                    dgvListTime.Rows[rowIndex].Cells[0].Value = organizationDay;
                    dgvListTime.Rows[rowIndex].Cells[1].Value = startHour;
                    dgvListTime.Rows[rowIndex].Cells[2].Value = endHour;
                    dgvListTime.Rows[rowIndex].Cells[3].Value = fee;
                    dgvListTime.Rows[rowIndex].Cells[4].Value = materialCost;
                    dgvListTime.Rows[rowIndex].Cells[5].Value = freelancerCost;
                    dgvListTime.Rows[rowIndex].Cells[6].Value = anotherCost;
                    dgvListTime.Rows[rowIndex].Cells[7].Value = note;
                }
            }
        }

        private void cmbForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbForm.SelectedIndex == 0)
            {
                cmbSponsor.SelectedItem = "Không";
                cmbSponsor.Enabled = false;
            }
            else
            {
                cmbSponsor.Enabled = true;
            }
        }

        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            // Tạo một đối tượng OpenFileDialog
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Thiết lập các thuộc tính cho OpenFileDialog
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                // Hiển thị hộp thoại và kiểm tra xem người dùng có chọn tệp không
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn tệp đã chọn
                    string filePath = openFileDialog.FileName;

                    // Tải ảnh vào PictureBox
                    try
                    {
                        // Tạo một đối tượng Image từ đường dẫn tệp
                        Image image = Image.FromFile(filePath);

                        // Giả sử bạn có một PictureBox tên là pictureBox1
                        rpbPicture.Image = image;
                        rpbPicture.SizeMode = PictureBoxSizeMode.StretchImage; // Điều chỉnh kích thước ảnh
                        this.Refresh();

                        // Lưu đường dẫn hình ảnh vào biến toàn cục
                        imagePath = filePath;

                        // Quay lại đầu form và giữ thanh cuộn ở đầu
                        this.ActiveControl = null;
                        this.AutoScrollPosition = new Point(0, 0);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể tải ảnh: " + ex.Message);
                    }
                }
            }
        }


        private void txtFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự nhập vào có phải là số hay không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Nếu không phải số, ngăn không cho nhập
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string imagePath = "";
            string relativePath = "";

            // Kiểm tra xem hình ảnh trong PictureBox có null không
            if (rpbPicture.Image != null)
            {
                string folderPath = Path.Combine("img"); // Đường dẫn thư mục tương đối
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath); // Tạo thư mục nếu chưa tồn tại
                }

                imagePath = Path.Combine(folderPath, $"{Guid.NewGuid()}.png"); // Tạo tên tệp duy nhất
                rpbPicture.Image.Save(imagePath, System.Drawing.Imaging.ImageFormat.Png); // Lưu ảnh

                // Nếu bạn cần lưu đường dẫn tương đối để sử dụng sau này
                relativePath = imagePath; // Đường dẫn tương đối
            }
            else
            {
                // Xử lý trường hợp hình ảnh là null
                MessageBox.Show("Hình ảnh không được chọn. Vui lòng chọn một hình ảnh.");
                return;
            }

            // Tạo đối tượng lớp học
            string nameClassroom = txtClassroom.Text.Trim();
            if (string.IsNullOrEmpty(nameClassroom) || !dataValidator.IsValidName(nameClassroom))
            {
                MessageBox.Show("Tên lớp không hợp lệ.");
            }

            int quantity = 0;
            if (int.TryParse(txtQuantity.Text, out quantity))
            {
                if (quantity <= 0)
                {
                    MessageBox.Show("Số lượng học viên phải lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ.");
                return;
            }
            string nameChef = cmbChef.Text;
            string nameLocation = cmbLocation.Text;
            string nameTopic = cmbTopic.Text;
            string form = cmbForm.Text;
            string sponsor = cmbSponsor.Text;

            if (sponsor != "Không")
            {
                if (string.IsNullOrEmpty(sponsor) || !dataValidator.IsValidName(sponsor))
                {
                    MessageBox.Show("Vui lòng nhập tên nhà tài trợ hợp lệ.");
                    return;
                }
            }

            if (string.IsNullOrWhiteSpace(nameClassroom))
            {
                MessageBox.Show("Tên lớp học không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (quantity <= 0)
            {
                MessageBox.Show("Số lượng học viên phải lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(nameChef))
            {
                MessageBox.Show("Tên đầu bếp không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(nameLocation))
            {
                MessageBox.Show("Địa điểm không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(form))
            {
                MessageBox.Show("Hình thức không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(sponsor))
            {
                MessageBox.Show("Nhà tài trợ không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string description = txtDescription.Text + "";
            string idChef = chefBLL.GetChefIdByName(nameChef);
            string idLocation = locationBLL.GetLocationIdByName(nameLocation);
            string idTopic = topicBLL.GetTopicIdByName(nameTopic);

            classroomBLL.AddClassroom(nameClassroom, 0, DateTime.Now, DateTime.Now.TimeOfDay, "Sắp diễn ra", 0, description, quantity, 0, 0, 0, DateTime.Now.TimeOfDay, relativePath, idTopic, idChef, idLocation, 0, 0, 0, "");


            // Tạo lớp học từ dữ liệu trong dgvListTime
            foreach (DataGridViewRow row in dgvListTime.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() != "Chưa có")
                {
                    string organizationDay = row.Cells[0].Value.ToString() + "";
                    string startHour = row.Cells[1].Value.ToString() + "";
                    string endHour = row.Cells[2].Value.ToString() + "";
                    int fee = Convert.ToInt32(row.Cells[3].Value);
                    int materialCost = Convert.ToInt32(row.Cells[4].Value);
                    int freelancerCost = Convert.ToInt32(row.Cells[5].Value);
                    int anotherCost = Convert.ToInt32(row.Cells[6].Value);
                    string note = row.Cells[7].Value.ToString() + "";

                    // Tính DurationHour
                    TimeSpan startTime = TimeSpan.Parse(startHour);
                    TimeSpan endTime = TimeSpan.Parse(endHour);
                    int durationHour = (int)(endTime - startTime).TotalMinutes; // Tính DurationHour bằng phút
                    DateTime dateTime = DateTime.ParseExact(organizationDay, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    // Gọi phương thức AddClassroom để thêm lớp học vào cơ sở dữ liệu

                    classroomBLL.AddClassroom(nameClassroom, durationHour, dateTime, endTime, "Sắp diễn ra", quantity, description, 0, 0, 0, 0, startTime, relativePath, idTopic, idChef, idLocation, materialCost, freelancerCost, anotherCost, note);

                    ClassroomDTO classroomDTO = classroomBLL.GetClassroomWithHighestId();

                    if (form == "Bình thường")
                    {
                        NormalClassDTO normalClassDTO = new NormalClassDTO()
                        {
                            IdClass = classroomDTO.IdClass,
                            Fee = fee
                        };
                        normalClassBLL.AddNormalClass(normalClassDTO);
                    }
                    else
                    {
                        NormalClassDTO normalClassDTO = new NormalClassDTO()
                        {
                            IdClass = classroomDTO.IdClass,
                            Fee = fee
                        };
                        normalClassBLL.AddNormalClass(normalClassDTO);

                        FreeClassDTO freeClassDTO = new FreeClassDTO()
                        {
                            IdClass = classroomDTO.IdClass,
                            NameSponsor = sponsor
                        };
                        freeClassBLL.AddFreeClass(freeClassDTO);
                    }
                }
            }

            MessageBox.Show("Thêm lớp học thành công!");
            this.Close();
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự nhập vào có phải là số hay không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Nếu không phải số, ngăn không cho nhập
            }
        }

        private void cmbChef_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChef.SelectedIndex == 0)
            {
                CreateChef createChef = new CreateChef();
                createChef.ShowDialog();
                LoadComboBoxs();
            }
        }

        private void cmbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLocation.SelectedIndex == 0)
            {
                CreateLocation createLocation = new CreateLocation();
                createLocation.ShowDialog();
                LoadComboBoxs();
            }
        }

        private void cmbTopic_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTopic.SelectedIndex == 0)
            {
                CreateTopic createTopic = new CreateTopic();
                createTopic.ShowDialog();
                LoadComboBoxs();
            }
        }

        private async void btnAI_Click(object sender, EventArgs e)
        {
            string name = txtClassroom.Text;
            string des = txtDescription.Text;
            string loading = "Bạn vui lòng chờ tí. Hệ thông đang đề xuất cho bạn";
            txtDescription.Text = loading;
            string text = $"Tạo một mô tả ngắn gần 20 chữ cho món ăn '{name}' với từ khóa '{des}'.";
            string respone = await GenerateDescription(name, des, text);
            txtDescription.Text = respone;
        }

        public async Task<string> GenerateDescription(string dishName, string keyword, string prompt)
        {
            try
            {
                string apiKey = "AIzaSyBx7G4CCK9RTW4D7pDPTT0UNWrDrDwbU4Q";
                var model = new GenerativeModel(apiKey); // Hoặc GeminiProModel(apiKey) nếu cần
                var chat = model.StartChat(new StartChatParams());

                // Gửi yêu cầu đầu tiên
                var result = await chat.SendMessageAsync(prompt);
                if (string.IsNullOrEmpty(result))
                {
                    return "Không có nội dung được tạo.";
                }

                return result;
            }
            catch (GenerativeAIException ex)
            {
                // Xử lý lỗi và hiển thị thông báo
                return $"Có lỗi xảy ra: {ex.Message}";
            }
            catch (Exception ex)
            {
                // Xử lý các lỗi khác
                return $"Có lỗi không xác định: {ex.Message}";
            }
        }

        private void rdpAI_Click(object sender, EventArgs e)
        {
            string name = txtClassroom.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Bạn vui lòng nhập tên lớp học");
                return;
            }
            using (DetailDescription detailDescription = new DetailDescription(name))
            {
                // Hiển thị Form PickTime và kiểm tra kết quả
                if (detailDescription.ShowDialog() == DialogResult.OK)
                {
                    txtDescription.Text = detailDescription.descrip;
                }
            }
        }
    }
}
