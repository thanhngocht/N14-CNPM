using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THE_COOKY_APP.BLL;
using THE_COOKY_APP.DTO;
using THE_COOKY_APP.DAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace THE_COOKY_APP.GUI.LOGIN
{


    public partial class ForgetPassword : Form
    {
        private string otp;
        private string email;
        private string username;
        private AccountBLL accountBLL;
        bool check = Login.Check;

        public ForgetPassword()
        {
            InitializeComponent();
            accountBLL = new AccountBLL();
        }



        private string EmailSecurity(string email)
        {
            const int startVisibleLength = 3; // Số ký tự đầu muốn giữ lại
            const int endVisibleLength = 3; // Số ký tự cuối muốn giữ lại

            int atIndex = email.IndexOf('@');

            // Nếu không tìm thấy ký tự '@' hoặc email quá ngắn để ẩn
            if (atIndex == -1 || atIndex <= startVisibleLength + endVisibleLength)
            {
                return email; // Trả về nguyên chuỗi
            }

            // Lấy các ký tự muốn giữ lại và ẩn các ký tự ở giữa
            string visibleStart = email.Substring(0, startVisibleLength); // 3 ký tự đầu
            string visibleEnd = email.Substring(atIndex + 1 - endVisibleLength); // 4 ký tự cuối trước '@'
            string hiddenString = new string('*', atIndex + 1 - startVisibleLength - endVisibleLength); // Ẩn các ký tự giữa

            return visibleStart + hiddenString + visibleEnd;
        }




        private string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }





        private bool ValidateInput(string username, string email)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return false;
            }

            else if (!KiemTraEmailHopLe(email))
            {
                MessageBox.Show("Cấu hình email không hợp lệ");
                return false;
            }
            else
            {

                return true;
            }
        }

        public static bool KiemTraEmailHopLe(string emailAddress)
        {
            try
            {
                // Tạo một đối tượng MailAddress để kiểm tra định dạng email
                var mailAddress = new MailAddress(emailAddress);
                return true; // Nếu tạo thành công, email hợp lệ
            }
            catch
            {
                return false; // Nếu có lỗi, email không hợp lệ
            }
        }


        private bool IsAccountValid(AccountDTO account, string username)
        {
            return account != null && account.Username.Equals(username, StringComparison.OrdinalIgnoreCase);
        }

        private void GenerateAndSendVerificationCode(AccountDTO account)
        {
            this.email = account.Gmail;
            this.otp = account.Username + GenerateRandomString(4);
            this.username = account.Username;

            account.Password = this.otp;
            accountBLL.UpdateAccount(account);

            SendVerificationEmailAsync();
        }

        private async Task SendVerificationEmailAsync()
        {
            try
            {
                // Tạo đối tượng EmailAuto với thông tin người nhận, chủ đề, và nội dung email
                //EmailAuto autoEmail1 = new EmailAuto(
                //    receiver: "vtkimyen.bb@gmail.com",
                //    topic: "[The Cooky]",
                //    content: CreateEmailContentForAdmin(this.otp, this.username, this.email)
                //);
                EmailAuto autoEmail = new EmailAuto(
                    receiver: this.email,
                    topic: "[The Cooky]",
                    content: CreateEmailContent()
                );


                // Gọi hàm gửi email và đợi cho đến khi hoàn thành
                await Task.Run(() => autoEmail.Letter("html"));
                //await Task.Run(() => autoEmail1.Letter("html"));

                // Nếu không xảy ra exception, coi như gửi email thành công
                MessageBox.Show("Mã xác thực đã được gửi về email của anh/chị:\n" + EmailSecurity(this.email));
                Login loginForm = new Login();
                this.Hide();
                loginForm.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có vấn đề xảy ra khi gửi email
                MessageBox.Show("Đã xảy ra lỗi khi gửi email: " + ex.Message);
            }
        }





        private string CreateEmailContent()
        {
            return @"
        <div style='font-family: Arial, sans-serif; padding: 30px; background-color: #f0f8ff; border-radius: 8px; border: 1px solid #ccc; box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);'>
            <h2 style='color: #2E8BC0; text-align: center; font-size: 24px; margin-bottom: 20px;'>Khôi phục mật khẩu tài khoản</h2>
            <p style='font-size: 16px; color: #333;'>Chào Anh/Chị,<br>
            Anh/Chị vừa tạo yêu cầu khôi phục mật khẩu từ hệ thống.<br>
            Mã khôi phục của anh/chị là: <b style='color: #e74c3c; font-size: 22px; font-weight: bold;'>" + otp + @"</b><br>
            Vui lòng không thoát ứng dụng trước khi nhập mã khôi phục này.</p>
            <p style='font-size: 14px; color: #555;'>Nếu anh/chị không yêu cầu khôi phục mật khẩu, vui lòng bỏ qua email này.</p>
            <div style='margin-top: 20px; text-align: center;'>
                <p style='font-size: 12px; color: #999;'>Trân trọng,<br>Đội ngũ hỗ trợ của The Cooky</p>
            </div>
        </div>";
        }


        private string CreateEmailContentForAdmin(string otp, string username, string email)
        {
            return $@"
         <div style='font-family: Arial, sans-serif; padding: 30px; background-color: #f0f8ff; border-radius: 8px; border: 1px solid #ccc; box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);'>
                <h2 style='color: #e74c3c; text-align: center; font-size: 24px; margin-bottom: 20px;'>Khôi phục mật khẩu tài khoản</h2>
                <p>Chào Anh/Chị,<br>
                Người dùng <b style='color: #e74c3c;'>{username}</b> vừa tạo yêu cầu khôi phục mật khẩu từ hệ thống.<br>
                Email của chủ tài khoản là <b style='color: #e74c3c;'>{email}</b>.<br>
                Mã khôi phục mới của người dùng <b style='color: #e74c3c;'>{username}</b> là: 
                <b style='color: #e74c3c; font-size: 22px; font-weight: bold;'>{otp}</b>.</p>
                <div style='margin-top: 20px; text-align: center;'>
                    <p style='font-size: 12px; color: #999;'>Trân trọng,<br>Đội ngũ hỗ trợ của The Cooky</p>
                </div>
         </div>";
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string username = txtIdAccount.Text;
            string email = txtGmail.Text;
            check = true;
            if (!ValidateInput(username, email)) return;

            AccountDTO account = accountBLL.GetAccountByEmail(username,email);

            if (account == null)
            {
                MessageBox.Show("Tên đăng nhập và email không khớp");
                return;
            }

            GenerateAndSendVerificationCode(account);

        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}


