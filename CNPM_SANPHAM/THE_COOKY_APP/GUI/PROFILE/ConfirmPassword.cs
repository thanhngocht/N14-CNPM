using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THE_COOKY_APP.BLL;
using THE_COOKY_APP.DTO;

namespace THE_COOKY_APP.GUI.PROFILE
{
    public partial class ConfirmPassword : Form
    {
        private readonly AccountBLL accountBLL = new AccountBLL();
        private readonly DataValidator validator = new DataValidator();
        private readonly AccountDTO accountDTO;
        public bool check { get; private set; }
        public ConfirmPassword(string accountId)
        {
            InitializeComponent();
            accountDTO = accountBLL.GetAccountById(accountId);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string pwd = txtPassword.Text;
            if (string.IsNullOrEmpty(pwd) || !validator.HasNoDiacritics(pwd) || accountDTO.Password != pwd)
            {
                MessageBox.Show("Mật khẩu không chính xác");
                return;
            }
            check = true;
            // Nếu không có lỗi, tiếp tục thực hiện
            this.DialogResult = DialogResult.OK; // Đặt kết quả của Form là OK
            this.Close(); // Đóng Form
        }
    }
}
