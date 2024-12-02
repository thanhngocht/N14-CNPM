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
using THE_COOKY_APP.GUI.ACCOUNT;
using THE_COOKY_APP.GUI.CHEF;
using THE_COOKY_APP.GUI.CLASSROOM;
using THE_COOKY_APP.GUI.HOME;
using THE_COOKY_APP.GUI.LOCATION;
using THE_COOKY_APP.GUI.STUDENT;
using THE_COOKY_APP.GUI.TOPIC;

namespace THE_COOKY_APP.GUI.CATEGORY
{
    public partial class PageCategory : UserControl
    {
        private readonly UserFunctionBLL userFunctionBLL = new UserFunctionBLL();
        private readonly AccountBLL accountBLL = new AccountBLL();
        private readonly UserFunctionDTO userFunctionDTO;
        private readonly AccountDTO accountDTO;

        public PageCategory(string accountId)
        {
            InitializeComponent();
            if (accountId == "")
            {
                return;
            }
            userFunctionDTO = userFunctionBLL.GetPermissionsByAccountId(accountId);
            accountDTO = accountBLL.GetAccountById(accountId);
        }

        private void btnChef_Click(object sender, EventArgs e)
        {
            if (userFunctionDTO.ListChef) // Kiểm tra quyền truy cập
            {
                ListChef listChef = new ListChef(accountDTO.IdAccount);
                listChef.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            if (userFunctionDTO.ListLocation) // Kiểm tra quyền truy cập
            {
                ListLocation listLocation = new ListLocation(accountDTO.IdAccount);
                listLocation.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            if (accountDTO.Username == "admin") // Kiểm tra quyền truy cập
            {
                ListAccount listAccount = new ListAccount();
                listAccount.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTopic_Click(object sender, EventArgs e)
        {
            if (userFunctionDTO.ListTopic) // Kiểm tra quyền truy cập
            {
                ListTopic listTopic = new ListTopic(accountDTO.IdAccount);
                listTopic.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClassroom_Click(object sender, EventArgs e)
        {
            if (userFunctionDTO.ListClass) // Kiểm tra quyền truy cập
            {
                ListClassroom listClassroom = new ListClassroom(accountDTO.IdAccount);
                listClassroom.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            if (userFunctionDTO.ListStudent) // Kiểm tra quyền truy cập
            {
                ListStudent listStudent = new ListStudent(accountDTO.IdAccount);
                listStudent.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}