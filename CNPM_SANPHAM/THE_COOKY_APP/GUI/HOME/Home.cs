using THE_COOKY_APP.BLL;
using THE_COOKY_APP.DTO;
using THE_COOKY_APP.GUI.LOGIN;
using THE_COOKY_APP.GUI.PROFILE;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace THE_COOKY_APP.GUI.HOME
{
    public partial class Home : Form
    {
        private AccountBLL accountBLL = new AccountBLL();
        private AccountDTO accountDTO;
        private bool isLoggingOut = false;
        public Home(string username, string password)
        {
            InitializeComponent();
            pSide.Height = btnTimeTable.Height;
            pSide.Top = btnTimeTable.Top;
            accountDTO = accountBLL.FindAccount(username, password);
            lblUsername.Text = accountDTO.FullName;
            pageTimeLine = new TIMELINE.ListClassroomView(accountDTO.IdAccount);
            ShowUserControl(pageTimeLine);
            profile = new Profile(accountDTO.IdAccount);
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            pSide.Height = btnReport.Height;
            pSide.Top = btnReport.Top;
            pageReport = new REPORT.PageReport(accountDTO.IdAccount);
            ShowUserControl(pageReport);
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            pageCategory = new CATEGORY.PageCategory(accountDTO.IdAccount);
            pSide.Height = btnCategory.Height;
            pSide.Top = btnCategory.Top;
            ShowUserControl(pageCategory);
        }

        private void btnTimeTable_Click(object sender, EventArgs e)
        {
            pSide.Height = btnTimeTable.Height;
            pSide.Top = btnTimeTable.Top;
            pageTimeLine = new TIMELINE.ListClassroomView(accountDTO.IdAccount);
            ShowUserControl(pageTimeLine);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            pSide.Height = btnProfile.Height;
            pSide.Top = btnProfile.Top;
            ShowUserControl(profile);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận đăng xuất
            var result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                isLoggingOut = true;
                accountBLL.Logout(accountDTO.Username);
                // Tạo một đối tượng mới của form đăng nhập
                Login loginForm = new Login(); // Giả sử bạn có một form đăng nhập tên là LoginForm
                this.Hide(); // Ẩn form hiện tại
                loginForm.ShowDialog(); // Hiển thị form đăng nhập
                this.Close(); // Đóng form hiện tại
            }
        }

        private void ShowUserControl(UserControl userControl)
        {
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isLoggingOut)
            {
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát?",    // Nội dung thông báo
                "Xác nhận thoát",                  // Tiêu đề hộp thoại
                MessageBoxButtons.YesNo,           // Các nút Yes và No
                MessageBoxIcon.Question            // Biểu tượng dấu hỏi
            );
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                accountBLL.Logout(accountDTO.Username);
                this.Hide();
                this.FormClosing -= new FormClosingEventHandler(Home_FormClosing);
            }
        }
    }
}
