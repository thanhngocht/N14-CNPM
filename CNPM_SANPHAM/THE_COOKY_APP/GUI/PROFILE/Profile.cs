using THE_COOKY_APP.BLL;
using THE_COOKY_APP.DTO;
using THE_COOKY_APP.DAO;
using System.Globalization;
using THE_COOKY_APP.GUI.CLASSROOM;

namespace THE_COOKY_APP.GUI.PROFILE
{
    public partial class Profile : UserControl
    {
        private AccountBLL accountBLL = new AccountBLL();
        private RoleBLL roleBLL = new RoleBLL();
        private PersonalProfileBLL personalProfileBLL = new PersonalProfileBLL();
        private UserFunctionBLL userFunctionBLL = new UserFunctionBLL();
        private DataValidator dataValidator = new DataValidator();
        private AccountDTO accountDTO;
        private PersonalProfileDTO personalProfileDTO;
        private bool isEditing = false; // Biến để theo dõi trạng thái chỉnh sửa
        public Profile(string accountId)
        {
            InitializeComponent();
            accountDTO = accountBLL.GetAccountById(accountId);
            LoadAccountDetails();
        }

        private void LoadAccountDetails()
        {
            if (accountDTO != null)
            {
                // Cập nhật các ô với thông tin từ accountDTO
                txtFullName.Text = accountDTO.FullName;
                txtUsername.Text = accountDTO.Username;
                txtPassword.Text = accountDTO.Password; // Có thể ẩn mật khẩu nếu cần
                txtPhoneNumber.Text = accountDTO.PhoneNumber;
                txtGmail.Text = accountDTO.Gmail;
                personalProfileDTO = personalProfileBLL.GetProfileByAccountId(accountDTO.IdAccount);
                txtDateOfBirth.Text = personalProfileDTO.DateOfBirth.ToString("dd/MM/yyyy"); // Định dạng ngày tháng
                txtNativePlace.Text = personalProfileDTO.NativePlace;
                txtCCCD.Text = personalProfileDTO.Cccd; // Căn cước công dân
                txtAddress.Text = personalProfileDTO.Address;
                UserFunctionDTO userFunctionDTO = userFunctionBLL.GetPermissionsByAccountId(accountDTO.IdAccount);
                RoleDTO roleDTO = roleBLL.GetRoleById(userFunctionDTO.IdRole);
                List<RoleDTO> roles = roleBLL.GetAllRoles();
                cmbRole.Items.Clear();
                foreach (var role in roles)
                {
                    cmbRole.Items.Add(role.NameRole);
                }
                cmbRole.Items.Add(roleDTO.NameRole);
                cmbRole.SelectedItem = roleDTO.NameRole;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin")
            {
                MessageBox.Show("Không thể cập nhật thông tin admin");
                return;
            }
            if (!isEditing)
            {
                using (ConfirmPassword confirm = new ConfirmPassword(accountDTO.IdAccount))
                {
                    // Hiển thị Form PickTime và kiểm tra kết quả
                    if (confirm.ShowDialog() == DialogResult.OK)
                    {
                        bool check = confirm.check;
                        if (check)
                        {
                            // Bật chế độ chỉnh sửa
                            EnableEditing(true);
                            btnUpdate.Text = "Lưu"; // Đổi chữ thành "Lưu"
                            isEditing = true;
                        }
                    }
                }
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
        private void EnableEditing(bool enable)
        {
            /// Kích hoạt hoặc vô hiệu hóa các ô văn bản trong panelT
            //txtUsername.Enabled = enable;
            txtPassword.Enabled = enable;
            if (txtPassword.PasswordChar == '*' && txtPassword.Enabled == true)
            {
                txtPassword.PasswordChar = '\0'; // Hiện mật khẩu
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
            txtFullName.Enabled = enable;
            txtAddress.Enabled = enable;
            txtGmail.Enabled = enable;
            txtNativePlace.Enabled = enable;
            txtPhoneNumber.Enabled = enable;
            txtDateOfBirth.Enabled = enable;
            txtCCCD.Enabled = enable;
            cmbRole.Enabled = enable;
            // Thêm các ô khác nếu cần
        }

        private bool SaveDetailAccount()
        {
            // Lấy thông tin từ các điều khiển trên form
            string phoneNumber = txtPhoneNumber.Text;
            string fullName = txtFullName.Text.Trim();
            string gmail = txtGmail.Text;

            if (string.IsNullOrEmpty(fullName) || !dataValidator.IsValidName(fullName))
            {
                MessageBox.Show("Họ tên không hợp lệ..");
                return false;
            }

            // Kiểm tra định dạng email
            if (!dataValidator.IsValidEmail(gmail))
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

            string cccd = txtCCCD.Text + "";
            string dateOfBirth = txtDateOfBirth.Text;
            string address = txtAddress.Text + "";
            string navivePlace = txtNativePlace.Text + "";

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
            DateTime dateOfBirthAccount;
            if (!DateTime.TryParseExact(dateOfBirth, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, DateTimeStyles.None, out dateOfBirthAccount))
            {
                MessageBox.Show("Vui lòng nhập ngày sinh hợp lệ theo định dạng dd/MM/yyyy.");
                return false;
            }

            DataValidator validator = new DataValidator();
            int age = validator.CalculateAge(dateOfBirthAccount);

            if (age < 18)
            {
                MessageBox.Show("Tuổi phải lớn hơn hoặc bằng 18.");
                return false;
            }

            // Lấy thông tin từ các điều khiển trên form
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Kiểm tra xem tên người dùng và mật khẩu có chứa dấu hay không
            if (!dataValidator.HasNoDiacritics(username) || username.Contains(" ") || string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Tên người dùng không hợp lệ.");
                return false;
            }

            if (!dataValidator.HasNoDiacritics(password))
            {
                MessageBox.Show("Mật khẩu không hợp lệ.");
                return false;
            }

            string role = cmbRole.Text.Trim();
            if (string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Vui lòng chọn vai trò.");
                return false;
            }

            // Tiếp tục xử lý nếu tất cả các điều kiện đều hợp lệ

            DateTime birth = dateOfBirthAccount;

            // Lưu thông tin vào BLL
            var detailAccountToUpdate = new AccountDTO
            {
                IdAccount = accountDTO.IdAccount,
                Gmail = gmail,
                PhoneNumber = phoneNumber,
                FullName = fullName,
                Username = username,
                Password = password
            };

            accountBLL.UpdateAccount(detailAccountToUpdate); // Gọi phương thức cập nhật trong BLL
            var detailProfileToUpdate = new PersonalProfileDTO
            {
                IdProfile = personalProfileDTO.IdProfile,
                Cccd = txtCCCD.Text,
                DateOfBirth = birth,
                Address = txtAddress.Text,
                NativePlace = txtNativePlace.Text,
                IdAccount = detailAccountToUpdate.IdAccount,
                IdChef = null
            };
            accountDTO = detailAccountToUpdate;
            personalProfileDTO = detailProfileToUpdate;
            LoadAccountDetails(); // Tải lại danh sách để cập nhật
            return true;
        }
    }
}
