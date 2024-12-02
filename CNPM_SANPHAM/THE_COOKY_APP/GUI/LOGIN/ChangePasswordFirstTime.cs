using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THE_COOKY_APP.BLL;
using THE_COOKY_APP.DAO;
using THE_COOKY_APP.DTO;
using THE_COOKY_APP.GUI.HOME;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace THE_COOKY_APP.GUI.LOGIN
{
    public partial class ChangePasswordFirstTime : Form
    {
        private AccountBLL accountBLL = new AccountBLL();
        private AccountDTO accountDTO = new AccountDTO();
        private string username;
        private string password;
        private DataValidator dataValidator = new DataValidator();
        public ChangePasswordFirstTime(string username, string password)
        {
            InitializeComponent();
            accountDTO = accountBLL.FindAccount(username, password);
            accountDTO.Username = username;
            this.username = username;
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string password1 = txtPresentPassword.Text;
            string password2 = txtNewPassword.Text;

            if (string.IsNullOrEmpty(password1) || string.IsNullOrEmpty(password2))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }

            try
            {
                if (password1 != accountDTO.Password)
                {
                    MessageBox.Show("Mật khẩu hiện tại không đúng, vui lòng nhập lại");
                    return;
                }

                if (password2 == password1)
                {
                    MessageBox.Show("Mật khẩu mới không được giống mật khẩu hiện tại");
                    return;
                }
                if (dataValidator.HasNoDiacritics(password2) && password1 == accountDTO.Password)
                {

                    // Cập nhật mật khẩu mới
                    accountDTO.Password = password2;
                    accountBLL.UpdateAccount(accountDTO);

                    MessageBox.Show("Thành công!");
                    Home home = new Home(accountDTO.Username, password2);
                    this.Hide();
                    home.ShowDialog();
                    this.Close();
                }
                if (!dataValidator.HasNoDiacritics(password2) && password1 == accountDTO.Password)
                {
                    MessageBox.Show("Mật khẩu không được chứa dấu.");
                    return;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            accountBLL.Logout(username);
        }

    }
}