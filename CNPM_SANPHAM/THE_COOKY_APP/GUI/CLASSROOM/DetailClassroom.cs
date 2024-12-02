using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using THE_COOKY_APP.BLL;
using THE_COOKY_APP.DAO;
using THE_COOKY_APP.DTO;
using THE_COOKY_APP.GUI.ACCOUNT;
using THE_COOKY_APP.GUI.CHEF;
using THE_COOKY_APP.GUI.LOCATION;
using THE_COOKY_APP.GUI.STUDENT;
using THE_COOKY_APP.GUI.TOPIC;

namespace THE_COOKY_APP.GUI.CLASSROOM
{
    public partial class DetailClassroom : Form
    {
        private readonly UserFunctionBLL userFunctionBLL = new UserFunctionBLL();
        private readonly AccountBLL accountBLL = new AccountBLL();
        private readonly UserFunctionDTO userFunctionDTO;
        private readonly AccountDTO accountDTO;
        private readonly ClassroomBLL classroomBLL = new ClassroomBLL();
        private readonly NormalClassBLL normalClassBLL = new NormalClassBLL();
        private readonly FreeClassBLL freeClassBLL = new FreeClassBLL();
        private readonly StudentClassBLL studentClassBLL = new StudentClassBLL();
        private readonly StudentBLL studentBLL = new StudentBLL();
        private readonly ChefBLL chefBLL = new ChefBLL();
        private readonly LocationBLL locationBLL = new LocationBLL();
        private readonly TopicBLL topicBLL = new TopicBLL();
        private readonly ClassroomDTO classroomDTO;
        private readonly NormalClassDTO normalClassDTO;
        private readonly FreeClassDTO freeClassDTO;
        private readonly DataValidator dataValidator = new DataValidator();
        private bool isEditing = false; // Biến để theo dõi trạng thái chỉnh sửa
        private string imagePath = "";
        private string selectedClass = "";
        public DetailClassroom(string classroomId, string accountId)
        {
            InitializeComponent();
            this.Size = new Size(1200, 850);
            this.AutoScroll = true;
            this.Shown += new EventHandler(DetailClass_Shown); // Sử dụng sự kiện Shown
            classroomDTO = classroomBLL.GetClassroomById(classroomId);
            imagePath = classroomDTO.Picture;
            normalClassDTO = normalClassBLL.GetNormalClassById(classroomId);
            freeClassDTO = freeClassBLL.GetFreeClassById(classroomId);
            LoadComboBoxs();
            LoadClassroomDetails();
            if (accountId == "")
            {
                return;
            }
            userFunctionDTO = userFunctionBLL.GetPermissionsByAccountId(accountId);
            accountDTO = accountBLL.GetAccountById(accountId);
        }

        private void LoadClassroomDetails()
        {
            if (classroomDTO != null)
            {

                txtClassroom.Text = classroomDTO.NameClass;
                txtQuantity.Text = classroomDTO.QuantityArise.ToString();

                if (!cmbChef.Items.Contains(classroomDTO.NameChef))
                {
                    cmbChef.Items.Add(classroomDTO.NameChef);
                }
                cmbChef.SelectedItem = classroomDTO.NameChef;

                if (!cmbLocation.Items.Contains(classroomDTO.NameLocation))
                {
                    cmbLocation.Items.Add(classroomDTO.NameLocation);
                }
                cmbLocation.SelectedItem = classroomDTO.NameLocation;

                if (!cmbTopic.Items.Contains(classroomDTO.NameTopic))
                {
                    cmbTopic.Items.Add(classroomDTO.NameTopic);
                }
                cmbTopic.SelectedItem = classroomDTO.NameTopic;

                cmbForm.SelectedIndex = 0;
                cmbSponsor.SelectedIndex = 0;
                txtDescription.Text = classroomDTO.Description;

                List<ClassroomDTO> list = classroomBLL.GetClassroomByPicture(classroomDTO.Picture);
                dgvListTime.Rows.Clear();
                foreach (ClassroomDTO classroom in list)
                {
                    // hHiển thị thời gian đã chọn
                    int rowIndex = dgvListTime.Rows.Add();
                    NormalClassDTO normalClassDTO = normalClassBLL.GetNormalClassById(classroom.IdClass);
                    FreeClassDTO freeClassDTO = freeClassBLL.GetFreeClassById(classroom.IdClass);
                    if (freeClassDTO != null && cmbSponsor.Items.Count < 2)
                    {
                        cmbForm.SelectedIndex = 1;
                        cmbSponsor.Items.Add(freeClassDTO.NameSponsor);
                        cmbSponsor.SelectedItem = freeClassDTO.NameSponsor;
                    }
                    txtQuantity.Text = classroom.MaxQuantity.ToString();
                    dgvListTime.Rows[rowIndex].Cells[0].Value = classroom.StartDate.ToString("dd/MM/yyyy");
                    dgvListTime.Rows[rowIndex].Cells[1].Value = classroom.StartHour.ToString(@"hh\:mm");
                    dgvListTime.Rows[rowIndex].Cells[2].Value = classroom.EndHour.ToString(@"hh\:mm");
                    if (normalClassDTO != null)
                    {
                        dgvListTime.Rows[rowIndex].Cells[3].Value = ConvertToMoney(normalClassDTO.Fee.ToString("0"));
                    }
                    dgvListTime.Rows[rowIndex].Cells[4].Value = ConvertToMoney(classroom.MaterialCost.ToString());
                    dgvListTime.Rows[rowIndex].Cells[5].Value = ConvertToMoney(classroom.FreelancerCost.ToString());
                    dgvListTime.Rows[rowIndex].Cells[6].Value = ConvertToMoney(classroom.AnotherCost.ToString());
                    dgvListTime.Rows[rowIndex].Cells[7].Value = classroom.Note.ToString();
                    dgvListTime.Rows[rowIndex].Cells[8].Value = classroom.IdClass;
                }

                string imagePath = classroomDTO.Picture.ToString();
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    rpbPicture.Image = Image.FromFile(imagePath);
                    rpbPicture.SizeMode = PictureBoxSizeMode.StretchImage; // Chỉnh kích thước hình ảnh vừa với PictureBox
                }
                else
                {
                    rpbPicture.Image = null;
                }
                CheckAndShowEmptyMessage();
            }
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
                dgvListTime.Rows[rowIndex].Cells[8].Value = "Chưa có";
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

        private void DetailClassroom_Load(object sender, EventArgs e)
        {
            CheckAndShowEmptyMessage();
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

        private void DetailClass_Shown(object? sender, EventArgs e)
        {
            UpdateScrollPosition(); // Cập nhật vị trí cuộn sau khi form hiển thị
            this.AutoScrollPosition = new Point(0, 0); // Đặt lại vị trí cuộn về đầu trang
        }

        private void UpdateScrollPosition()
        {
            // Tính chiều cao tổng của tất cả các điều khiển
            int totalHeight = 0;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.Visible)
                {
                    totalHeight = Math.Max(totalHeight, ctrl.Bottom);
                }
            }

            // Thiết lập AutoScrollMinSize và đặt vị trí cuộn về đầu trang
            this.AutoScrollMargin = new Size(0, 40); // Thêm khoảng trống sau phần tử cuối cùng
        }

        private void rpbListStudentInClass_Click(object sender, EventArgs e)
        {
            if (userFunctionDTO.ListStudent) // Kiểm tra quyền truy cập
            {
                if (selectedClass != "" && selectedClass != "New")
                {
                    ListStudentInClass listStudentInClass = new ListStudentInClass(selectedClass, accountDTO.IdAccount);
                    listStudentInClass.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (userFunctionDTO.UpdateClass) // Kiểm tra quyền truy cập
            {
                if (!isEditing)
                {
                    // Bật chế độ chỉnh sửa
                    EnableEditing(true);
                    btnUpdate.Text = "Lưu"; // Đổi chữ thành "Lưu"
                    isEditing = true;
                }
                else
                {
                    // Lưu thông tin
                    if (SaveDetailClassroom())
                    {
                        EnableEditing(false);
                        btnUpdate.Text = "Sửa"; // Đổi chữ về "Sửa"
                        isEditing = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void EnableEditing(bool enable)
        {
            txtClassroom.Enabled = enable;
            txtQuantity.Enabled = enable;
            cmbChef.Enabled = enable;
            cmbLocation.Enabled = enable;
            cmbTopic.Enabled = enable;
            cmbForm.Enabled = enable;
            if (cmbForm.SelectedIndex == 1)
            {
                cmbSponsor.Enabled = enable;
            }
            txtDescription.Enabled = enable;
            btnAddPicture.Enabled = enable;
            rbpAdd.Enabled = enable;
        }


        private bool SaveDetailClassroom()
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
                return false;
            }

            // Tạo đối tượng lớp học
            string nameClassroom = txtClassroom.Text.Trim();
            if (string.IsNullOrEmpty(nameClassroom) || !dataValidator.IsValidName(nameClassroom))
            {
                MessageBox.Show("Tên lớp không hợp lệ.");
                return false;
            }

            int quantity = 0;
            if (int.TryParse(txtQuantity.Text, out quantity))
            {
                if (quantity <= 0)
                {
                    MessageBox.Show("Số lượng học viên phải lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ.");
                return false;
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
                    return false;
                }
            }

            if (string.IsNullOrWhiteSpace(nameClassroom))
            {
                MessageBox.Show("Tên lớp học không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (quantity <= 0)
            {
                MessageBox.Show("Số lượng học viên phải lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(nameChef))
            {
                MessageBox.Show("Tên đầu bếp không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(nameLocation))
            {
                MessageBox.Show("Địa điểm không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(form))
            {
                MessageBox.Show("Hình thức không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(sponsor))
            {
                MessageBox.Show("Nhà tài trợ không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string description = txtDescription.Text + "";
            string idChef = chefBLL.GetChefIdByName(nameChef);
            string idLocation = locationBLL.GetLocationIdByName(nameLocation);
            string idTopic = topicBLL.GetTopicIdByName(nameTopic);



            foreach (DataGridViewRow row in dgvListTime.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() != "Chưa có")
                {
                    string organizationDay = row.Cells[0].Value.ToString() + "";
                    string startHour = row.Cells[1].Value.ToString() + "";
                    string endHour = row.Cells[2].Value.ToString() + "";
                    int fee = ConvertToInt(row.Cells[3].Value + "");
                    int materialCost = ConvertToInt(row.Cells[4].Value + "");
                    int freelancerCost = ConvertToInt(row.Cells[5].Value + "");
                    int anotherCost = ConvertToInt(row.Cells[6].Value + "");
                    string note = row.Cells[7].Value.ToString() + "";
                    string id = row.Cells[8].Value.ToString() + "";
                    // Tính DurationHour
                    TimeSpan startTime = TimeSpan.Parse(startHour);
                    TimeSpan endTime = TimeSpan.Parse(endHour);
                    int durationHour = (int)(endTime - startTime).TotalMinutes; // Tính DurationHour bằng phút
                    DateTime dateTime = DateTime.ParseExact(organizationDay, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    // Gọi phương thức AddClassroom để thêm lớp học vào cơ sở dữ liệu

                    if (id == "New")
                    {
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
                    else
                    {
                        var detailClassroomToUpdate = new ClassroomDTO
                        {
                            IdClass = id,
                            NameClass = nameClassroom,
                            DurationHour = durationHour,
                            StartDate = dateTime,
                            EndHour = endTime,
                            StatusClass = "Sắp diễn ra",
                            MaxQuantity = quantity,
                            Description = description,
                            QuantityArise = 0,
                            ProvisionalRevenue = 0,
                            RealRevenue = 0,
                            Commission = 0,
                            StartHour = startTime,
                            Picture = relativePath,
                            NameChef = nameChef,
                            NameLocation = nameLocation,
                            NameTopic = nameTopic,
                            MaterialCost = materialCost,
                            FreelancerCost = freelancerCost,
                            AnotherCost = anotherCost,
                            Note = note
                        };
                        classroomBLL.UpdateClassroom(detailClassroomToUpdate);

                        if (form == "Bình thường")
                        {
                            NormalClassDTO normalClassDTO = new NormalClassDTO()
                            {
                                IdClass = id,
                                Fee = fee
                            };
                            normalClassBLL.UpdateNormalClass(normalClassDTO);
                        }
                        else
                        {
                            NormalClassDTO normalClassDTO = new NormalClassDTO()
                            {
                                IdClass = id,
                                Fee = fee
                            };
                            normalClassBLL.UpdateNormalClass(normalClassDTO);

                            FreeClassDTO freeClassDTO = new FreeClassDTO()
                            {
                                IdClass = id,
                                NameSponsor = sponsor
                            };
                            freeClassBLL.UpdateFreeClass(freeClassDTO);
                        }
                    }
                }
            }
            if (classroomDTO != null)
            {
                classroomDTO.Picture = relativePath;
                classroomDTO.NameChef = nameChef;
                classroomDTO.NameLocation = nameLocation;
                classroomDTO.Description = description;
                classroomDTO.NameTopic = nameTopic;
                classroomDTO.NameClass = nameClassroom;
                classroomBLL.UpdateClassroom(classroomDTO);
                // Hiển thị MessageBox thông báo cập nhật thành công
                MessageBox.Show("Cập nhật thông tin lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadClassroomDetails();
            return true;
        }

        private int ConvertToInt(string input)
        {
            // Xóa tất cả ký tự không phải số
            string cleanedInput = new string(input.Where(char.IsDigit).ToArray());

            // Chuyển đổi chuỗi thành số
            if (int.TryParse(cleanedInput, out int result))
            {
                return result;
            }
            return 0; // Trả về 0 nếu không thể chuyển đổi
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

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự nhập vào có phải là số hay không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Nếu không phải số, ngăn không cho nhập
            }
        }

        private void dgvListTime_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvListTime.Rows[e.RowIndex].Cells[0].Value.ToString() != "Chưa có")
                {
                    selectedClass = dgvListTime.Rows[e.RowIndex].Cells[8].Value.ToString() + "";
                }
            }
        }

        private void rbpAdd_Click(object sender, EventArgs e)
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
                    dgvListTime.Rows[rowIndex].Cells[8].Value = "New";
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

        private async void rpbCancel_Click(object sender, EventArgs e)
        {
            if (userFunctionDTO.DeleteClass) // Kiểm tra quyền truy cập
            {
                if (selectedClass != "" && selectedClass != "New")
                {
                    DialogResult result = MessageBox.Show(
                        "Bạn có chắc chắn muốn hủy lớp học này?",
                        "Xác nhận hủy lớp học",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.OK)
                    {
                        ClassroomDTO classroomDTO = classroomBLL.GetClassroomById(selectedClass);
                        classroomBLL.DeleteClassroom(selectedClass);
                        List<StudentClassDTO> studentClassDTOs = studentClassBLL.GetAllStudents(selectedClass);
                        foreach(var  studentClass in studentClassDTOs)
                        {
                            StudentDTO studentDTO = studentBLL.GetStudentById(studentClass.IdStudent);
                            string gmail = studentDTO.Gmail;
                            await SendVerificationEmailAsync(gmail, classroomDTO.NameClass, classroomDTO.StartDate);
                        } 
                        LoadClassroomDetails();
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async Task SendVerificationEmailAsync(string gmail, string nameClass, DateTime organizationDay)
        {
            try
            {
                EmailAuto autoEmail = new EmailAuto(
                    receiver: gmail, topic: "[The Cooky]",
                    content: CreateEmailContent(nameClass, organizationDay)


                    );
                await Task.Run(() => autoEmail.Letter("html"));
                MessageBox.Show("Đang gửi email");

            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show("Đã có lỗi xảy ra khi gửi mail:" + ex.Message);
                }
            }
        }

        
        private string CreateEmailContent(string nameClass, DateTime organizationDay)
        {


            return $@"
     <div style='font-family: Arial, sans-serif; padding: 30px; background-color: #f0f8ff; border-radius: 8px; border: 1px solid #ccc; box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);'>
            <h2 style='color: #e74c3c; text-align: center; font-size: 24px; margin-bottom: 20px;'>Thông báo sự kiện hủy lớp học</h2> 
            <p>Chào Anh/Chị,<br>
            Lớp học: <b>{nameClass}</b> được tổ chức vào ngày <b>{organizationDay.Day}</b> đã bị hủy  .<br> 
     
      
            </p>
            <div style='margin-top: 20px; text-align: center;'>
                <p style='font-size: 12px; color: #999;'>Trân trọng,<br>Đội ngũ hỗ trợ của The Cooky</p>
            </div>
     </div>";


        }

        private string ConvertToMoney(string inputInt)
        {
            // Xóa tất cả ký tự không phải số
            string input = new string(inputInt.Where(char.IsDigit).ToArray());

            // Chuyển đổi chuỗi thành số và định dạng
            if (long.TryParse(input, out long number))
            {
                // Định dạng số với dấu phân cách
                return string.Format("{0:N0}", number).Replace(",", ".");
            }
            return "0";
        }
    }
}
