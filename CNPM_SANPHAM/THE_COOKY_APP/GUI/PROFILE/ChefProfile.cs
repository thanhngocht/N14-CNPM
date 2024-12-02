using System.Globalization;
using THE_COOKY_APP.BLL;
using THE_COOKY_APP.DAO;
using THE_COOKY_APP.DTO;
using THE_COOKY_APP.GUI.LOCATION;

namespace THE_COOKY_APP.GUI.PROFILE
{
    public partial class ChefProfile : Form
    {
        private readonly UserFunctionBLL userFunctionBLL = new UserFunctionBLL();
        private readonly AccountBLL accountBLL = new AccountBLL();
        private readonly UserFunctionDTO userFunctionDTO;
        private readonly AccountDTO accountDTO;
        private ChefBLL chefBLL = new ChefBLL();
        private PersonalProfileBLL profileBLL = new PersonalProfileBLL();
        private TopicChefBLL topicChefBLL = new TopicChefBLL();
        private TopicBLL topicBLL = new TopicBLL();
        private DataValidator dataValidator = new DataValidator();
        private ChefDTO chefDTO;
        private PersonalProfileDTO personalProfileDTO = null;
        private bool isEditing = false; // Biến để theo dõi trạng thái chỉnh sửa
        public ChefProfile(string chefId, string accountId)
        {
            InitializeComponent();
            chefDTO = chefBLL.GetChefById(chefId);
            LoadComboBoxSpeciality();
            LoadChef();
            if (accountId == "")
            {
                return;
            }
            userFunctionDTO = userFunctionBLL.GetPermissionsByAccountId(accountId);
            accountDTO = accountBLL.GetAccountById(accountId);
        }

        public void LoadChef()
        {
            txtPhoneNumber.Text = chefDTO.PhoneNumber;
            txtFullName.Text = chefDTO.FullName;
            dtpStartDate.Text = chefDTO.StartDate.ToString();
            txtGmail.Text = chefDTO.Gmail;
            personalProfileDTO = profileBLL.GetProfileByChefId(chefDTO.IdChef);
            txtCCCD.Text = personalProfileDTO.Cccd;
            txtAddress.Text = personalProfileDTO.Address;
            txtDateOfBirth.Text = personalProfileDTO.DateOfBirth.ToString("dd/MM/yyyy");
            txtNativePlace.Text = personalProfileDTO.NativePlace;
            TopicChefDTO topicChefDTO = topicChefBLL.GetTopicsByChefId(chefDTO.IdChef);
            TopicDTO topicDTO = topicBLL.GetTopicById(topicChefDTO.IdTopic);
            cmbSpeciality.SelectedItem = topicDTO.NameTopic;
        }

        private void LoadComboBoxSpeciality()
        {
            cmbSpeciality.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSpeciality.Items.Clear();
            List<TopicDTO> list = topicBLL.GetAllTopics();
            foreach (var item in list)
            {
                cmbSpeciality.Items.Add(item.NameTopic);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (userFunctionDTO.UpdateChef) // Kiểm tra quyền truy cập
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
                    if (SaveDetailAccount())
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
            // Kích hoạt hoặc vô hiệu hóa các ô văn bản trong panelTopic
            txtFullName.Enabled = enable;
            txtAddress.Enabled = enable;
            txtGmail.Enabled = enable;
            txtNativePlace.Enabled = enable;
            txtPhoneNumber.Enabled = enable;
            txtDateOfBirth.Enabled = enable;
            txtCCCD.Enabled = enable;
            dtpStartDate.Enabled = enable;
            cmbSpeciality.Enabled = enable;
            // Thêm các ô khác nếu cần
        }

        private bool SaveDetailAccount()
        {
            // Lấy thông tin từ các điều khiển trên form
            string phoneNumber = txtPhoneNumber.Text;
            string fullName = txtFullName.Text.Trim();
            string startDate = dtpStartDate.Text;
            string gmailChef = txtGmail.Text;


            if (string.IsNullOrEmpty(fullName) || dataValidator.IsValidName(fullName))
            {
                MessageBox.Show("Họ tên không hợp lệ.");
                return false;
            }

            // Kiểm tra định dạng email
            if (!dataValidator.IsValidEmail(gmailChef))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ email hợp lệ.");
                return false;
            }

            // Kiểm tra định dạng số điện thoại
            if (!dataValidator.IsPhoneNumber(phoneNumber))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại hợp lệ.");
                return false;
            }

            // Kiểm tra định dạng ngày bắt đầu
            DateTime startDateChef;
            if (!DateTime.TryParseExact(startDate, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, DateTimeStyles.None, out startDateChef))
            {
                MessageBox.Show("Vui lòng nhập ngày bắt đầu hợp lệ theo định dạng dd/MM/yyyy.");
                return false;
            }

            string cccd = txtCCCD.Text;
            string dateOfBirth = txtDateOfBirth.Text;
            string address = txtAddress.Text;
            string navivePlace = txtNativePlace.Text;

            if (!string.IsNullOrEmpty(address))
            {
                if (!dataValidator.IsValidAddressOrNativePlace(address))
                {
                    MessageBox.Show("Vui lòng nhập địa chỉ hợp lệ.");
                    return false;
                }
            }

            if (!string.IsNullOrEmpty(navivePlace))
            {
                if (!dataValidator.IsValidAddressOrNativePlace(navivePlace))
                {
                    MessageBox.Show("Vui lòng nhập nguyên quán hợp lệ.");
                    return false;
                }
            }

            // Kiểm tra định dạng CCCD
            if (!string.IsNullOrEmpty(cccd))
            {
                if (!dataValidator.IsNumeric(cccd) || cccd.Length != 10)
                {
                    MessageBox.Show("CCCD không hợp lệ.");
                    return false;
                }
            }

            // Kiểm tra định dạng ngày sinh
            DateTime dateOfBirthChef;
            if (!DateTime.TryParseExact(dateOfBirth, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, DateTimeStyles.None, out dateOfBirthChef))
            {
                MessageBox.Show("Vui lòng nhập ngày sinh hợp lệ theo định dạng dd/MM/yyyy.");
                return false;
            }

            string? idAccount = null;

            string speciality = cmbSpeciality.SelectedItem?.ToString() ?? "";

            // Kiểm tra nếu speciality không được chọn
            if (string.IsNullOrEmpty(speciality))
            {
                MessageBox.Show("Vui lòng chọn chuyên môn.");
                return false;
            }

            // Lưu thông tin vào BLL
            var detailAccountToUpdate = new ChefDTO
            {
                IdChef = chefDTO.IdChef,
                PhoneNumber = phoneNumber,
                FullName = fullName,
                StartDate = startDateChef,
                Gmail = gmailChef,
                IsActive = chefDTO.IsActive
            };

            chefBLL.UpdateChef(detailAccountToUpdate); // Gọi phương thức cập nhật trong BLL

            var detailProfileToUpdate = new PersonalProfileDTO
            {
                IdProfile = personalProfileDTO.IdProfile,
                Cccd = cccd,
                DateOfBirth = dateOfBirthChef,
                Address = address,
                NativePlace = navivePlace,
                IdAccount = null,
                IdChef = detailAccountToUpdate.IdChef,
            };
            chefDTO = detailAccountToUpdate;
            personalProfileDTO = detailProfileToUpdate;
            

            // Lấy ID chủ đề từ chuyên môn đã chọn
            string topicId = topicBLL.GetTopicIdByName(speciality);

            TopicChefDTO topicChef = new TopicChefDTO
            {
                NameSpeciality = speciality,
                IdChef = chefDTO.IdChef,
                IdTopic = topicId,
            };

            // Thêm thông tin chủ đề đầu bếp
            topicChefBLL.UpdateTopicChef(topicChef);
            profileBLL.UpdateProfile(detailProfileToUpdate);
            chefDTO = detailAccountToUpdate;
            LoadChef(); // Tải lại danh sách để cập nhật
            return true;
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự nhập vào có phải là số hay không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Nếu không phải số, ngăn không cho nhập
            }

            // Kiểm tra số ký tự đã nhập
            if (txtPhoneNumber.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Nếu đã nhập đủ 10 ký tự, ngăn không cho nhập thêm
            }
        }

        private void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự nhập vào có phải là số hay không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Nếu không phải số, ngăn không cho nhập
            }

            // Kiểm tra số ký tự đã nhập
            if (txtCCCD.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Nếu đã nhập đủ 10 ký tự, ngăn không cho nhập thêm
            }
        }
    }
}
