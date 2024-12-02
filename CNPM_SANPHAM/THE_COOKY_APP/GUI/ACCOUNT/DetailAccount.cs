using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THE_COOKY_APP.BLL;
using THE_COOKY_APP.DTO;

namespace THE_COOKY_APP.GUI.ACCOUNT
{
    public partial class DetailAccount : Form
    {
        private AccountDTO accountDTO;
        private AccountBLL accountBLL = new AccountBLL();
        private PersonalProfileBLL personalProfileBLL = new PersonalProfileBLL();
        private UserFunctionBLL userFunctionBLL = new UserFunctionBLL();
        PersonalProfileDTO personalProfileDTO;
        private RoleBLL roleBLL = new RoleBLL();
        private DataValidator dataValidator = new DataValidator();
        private bool isEditing = false; // Biến để theo dõi trạng thái chỉnh sửa
        public DetailAccount(string acoountId)
        {
            InitializeComponent();
            this.Size = new Size(1200, 850);
            this.AutoScroll = true;
            this.Shown += new EventHandler(CreateChef_Shown); // Sử dụng sự kiện Shown
            accountDTO = accountBLL.GetAccountById(acoountId);
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
            else
            {
                MessageBox.Show("Không tìm thấy thông tin tài khoản.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SetUpFunction setUpFunction = new SetUpFunction(accountDTO.IdAccount);
            setUpFunction.ShowDialog();
            this.AutoScrollPosition = new Point(0, 0);
        }
        private void CreateChef_Shown(object? sender, EventArgs e)
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
            this.AutoScrollMargin = new Size(0, 40); // Thêm khoảng trống sau phần tử cuối cùng
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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

        private void EnableEditing(bool enable)
        {
            // Kích hoạt hoặc vô hiệu hóa các ô văn bản trong panelTopic
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
                MessageBox.Show("Họ tên không được để trống.");
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

            // Kiểm tra định dạng CCCD
            if (!string.IsNullOrEmpty(cccd) )
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
                MessageBox.Show("Tên người dùng không được chứa dấu hoặc dấu cách");
                return false;
            }

            if (!dataValidator.HasNoDiacritics(password))
            {
                MessageBox.Show("Mật khẩu không được chứa dấu.");
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
