using System.Globalization;
using System.Text;
using THE_COOKY_APP.BLL;
using THE_COOKY_APP.DAO;
using THE_COOKY_APP.DTO;

namespace THE_COOKY_APP.GUI.ACCOUNT
{
    public partial class CreateAccount : Form
    {
        private AccountBLL accountBLL = new AccountBLL();
        private PersonalProfileBLL profileBLL = new PersonalProfileBLL();
        private RoleBLL roleBLL = new RoleBLL();
        private UserFunctionBLL userFunctionBLL = new UserFunctionBLL();
        private DataValidator dataValidator = new DataValidator();
        private string randomPassword = "";
        public CreateAccount()
        {
            InitializeComponent();
            this.Size = new Size(1200, 850);
            this.AutoScroll = true;
            this.Shown += new EventHandler(CreateChef_Shown); // Sử dụng sự kiện Shown
            randomPassword = GenerateRandomString(4);
            LoadRoles();
        }

        private void LoadRoles()
        {
            List<RoleDTO> roles = roleBLL.GetAllRoles();
            foreach (var role in roles)
            {
                cmbRole.Items.Add(role.NameRole);
            }
        }

        // Hàm sinh ra chuỗi ngẫu nhiên 4 ký tự
        private string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"; // Các ký tự có thể sử dụng
            StringBuilder result = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(chars.Length); // Lấy chỉ số ngẫu nhiên
                result.Append(chars[index]); // Thêm ký tự vào kết quả
            }

            return result.ToString(); // Trả về chuỗi ngẫu nhiên
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

            // Thiết lập AutoScrollMinSize và đặt vị trí cuộn về đầu trang
            this.AutoScrollMargin = new Size(0, 40); // Thêm khoảng trống sau phần tử cuối cùng
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các điều khiển trên form
            string phoneNumber = txtPhoneNumber.Text;
            string fullName = txtFullName.Text.Trim();
            string gmail = txtGmail.Text;

            if (string.IsNullOrEmpty(fullName) || !dataValidator.IsValidName(fullName))
            {
                MessageBox.Show("Họ tên không hợp lệ.");
                return;
            }

            // Kiểm tra định dạng email
            if (!dataValidator.IsValidEmail(gmail))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ email hợp lệ.");
                return;
            }

            // Kiểm tra định dạng số điện thoại
            if (!dataValidator.IsPhoneNumber(phoneNumber))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại hợp lệ.");
                return;
            }

            string cccd = txtCCCD.Text + "";
            string dateOfBirth = txtDateOfBirth.Text;
            string address = txtAddress.Text + "";
            string navivePlace = txtNativePlace.Text + "";

            // Kiểm tra định dạng CCCD
            if (!string.IsNullOrEmpty(cccd))
            {
                if (!dataValidator.IsNumeric(cccd) || cccd.Length != 10)
                {
                    MessageBox.Show("CCCD không hợp lệ.");
                    return;
                }
            }

            if (!string.IsNullOrEmpty(address))
            {
                if (!dataValidator.IsValidAddressOrNativePlace(address))
                {
                    MessageBox.Show("Vui lòng nhập địa chỉ hợp lệ.");
                    return;
                }
            }

            if (!string.IsNullOrEmpty(navivePlace))
            {
                if (!dataValidator.IsValidAddressOrNativePlace(navivePlace))
                {
                    MessageBox.Show("Vui lòng nhập nguyên quán hợp lệ.");
                    return;
                }
            }

            // Kiểm tra định dạng ngày sinh
            DateTime dateOfBirthAccount;
            if (!DateTime.TryParseExact(dateOfBirth, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, DateTimeStyles.None, out dateOfBirthAccount))
            {
                MessageBox.Show("Vui lòng nhập ngày sinh hợp lệ theo định dạng dd/MM/yyyy.");
                return;
            }

            DataValidator validator = new DataValidator();
            int age = validator.CalculateAge(dateOfBirthAccount);

            if (age < 18)
            {
                MessageBox.Show("Tuổi phải lớn hơn hoặc bằng 18.");
                return;
            }

            // Lấy thông tin từ các điều khiển trên form
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Kiểm tra xem tên người dùng và mật khẩu có chứa dấu hay không
            if (!dataValidator.HasNoDiacritics(username) || username.Contains(" ") || string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Tên người dùng không hợp lệ.");
                return;
            }

            if (accountBLL.IsUsernameExists(username))
            {
                MessageBox.Show("Tên tài khoản đã tồn tại.");
                return;
            }

            if (!dataValidator.HasNoDiacritics(password))
            {
                MessageBox.Show("Mật khẩu không được chứa dấu.");
                return;
            }

            string role = cmbRole.Text.Trim();
            if (string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Vui lòng chọn vai trò.");
                return;
            }

            // Tiếp tục xử lý nếu tất cả các điều kiện đều hợp lệ

            DateTime birth = dateOfBirthAccount;
            accountBLL.AddAccount(gmail, phoneNumber, fullName, username, password);
            AccountDTO accountDTO = accountBLL.FindAccount(username, password);
            string idAccount = accountDTO.IdAccount;
            string idChef = null;
            profileBLL.AddProfile(cccd, birth, address, navivePlace, idAccount, idChef);
            RoleDTO roleDTO = roleBLL.GetRoleByNameRole(cmbRole.Text);
            userFunctionBLL.AddDefaultUserFunction(accountDTO.IdAccount, roleDTO.IdRole);
            MessageBox.Show("Tài khoản đã được tạo thành công");
            await SendVerificationEmailAsync(gmail, username, password);
            this.Close();
        }

        private async Task SendVerificationEmailAsync(string gmail, string username, string password)
        {
            try
            {
                EmailAuto autoEmail = new EmailAuto(
                    receiver: gmail, topic: "[The Cooky]",
                    content: CreateEmailContent(gmail, username, password)


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

        private string CreateEmailContent(string gmail, string username, string password)
        {


            return $@"
             <div style='font-family: Arial, sans-serif; padding: 30px; background-color: #f0f8ff; border-radius: 8px; border: 1px solid #ccc; box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);'>
                    <h2 style='color: #e74c3c; text-align: center; font-size: 24px; margin-bottom: 20px;'>Bạn đã có tài khoản mới</h2>
                    <p>Chào Anh/Chị,<br>
                    Username của Anh/Chị: <b>{username}</b>.<br>
                    Password của Anh/Chị: <b>{password}</b>.<br>
      
                    </p>
                    <div style='margin-top: 20px; text-align: center;'>
                        <p style='font-size: 12px; color: #999;'>Trân trọng,<br>Đội ngũ hỗ trợ của The Cooky</p>
                    </div>
             </div>";


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

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            string text = txtUsername.Text + randomPassword;
            txtPassword.Text = text;
        }
    }
}
