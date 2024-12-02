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

namespace THE_COOKY_APP.GUI.REPORT
{
    public partial class PageReport : UserControl
    {
        private readonly UserFunctionBLL userFunctionBLL = new UserFunctionBLL();
        private readonly AccountBLL accountBLL = new AccountBLL();
        private readonly UserFunctionDTO userFunctionDTO;
        private readonly AccountDTO accountDTO;
        public PageReport(string accountId)
        {
            InitializeComponent();
            if (accountId == "")
            {
                return;
            }
            userFunctionDTO = userFunctionBLL.GetPermissionsByAccountId(accountId);
            accountDTO = accountBLL.GetAccountById(accountId);
        }

        private void btnReportClassroom_Click(object sender, EventArgs e)
        {
            if (userFunctionDTO.ReportClass) // Kiểm tra quyền truy cập
            {
                ListReportClass listReportClass = new ListReportClass();
                listReportClass.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnReportLocation_Click(object sender, EventArgs e)
        {
        }

        private void btnReportMonth_Click(object sender, EventArgs e)
        {
            if (userFunctionDTO.ReportMonth) // Kiểm tra quyền truy cập
            {
                ReportMonth reportMonth = new ReportMonth();
                reportMonth.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
