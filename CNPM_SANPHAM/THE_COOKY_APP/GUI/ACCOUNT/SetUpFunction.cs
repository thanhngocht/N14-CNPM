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

namespace THE_COOKY_APP.GUI.ACCOUNT
{
    public partial class SetUpFunction : Form
    {
        private UserFunctionBLL userFunctionBLL = new UserFunctionBLL();
        private RoleBLL roleBLL = new RoleBLL();
        private AccountBLL accountBLL = new AccountBLL();
        private UserFunctionDTO userFunctionDTO;
        private AccountDTO accountDTO;
        public SetUpFunction(string accountId)
        {
            InitializeComponent();
            this.Size = new Size(1360, 850);
            this.AutoScroll = true;
            this.Shown += new EventHandler(CreateChef_Shown); // Sử dụng sự kiện Shown
            accountDTO = accountBLL.GetAccountById(accountId);
            userFunctionDTO = userFunctionBLL.GetPermissionsByAccountId(accountId);
            LoadAccounts();
            LoadUserFunctions();
            CheckFuntion();
        }


        private void LoadAccounts()
        {
            txtUsername.Text = accountDTO.Username;
            txtFullName.Text = accountDTO.FullName;
            RoleDTO roleDTO = roleBLL.GetRoleById(userFunctionDTO.IdRole);
            cmbRole.Items.Add(roleDTO.NameRole);
            cmbRole.SelectedItem = roleDTO.NameRole;
        }

        private void LoadUserFunctions()
        {
            // Cập nhật trạng thái cho các ô checkbox dựa trên quyền của người dùng
            cbAddChef.Checked = userFunctionDTO.InsertChef;
            cbUpdateChef.Checked = userFunctionDTO.UpdateChef;
            cbDeleteChef.Checked = userFunctionDTO.DeleteChef;

            cbAddStudent.Checked = userFunctionDTO.InsertStudent;
            cbUpdateStudent.Checked = userFunctionDTO.UpdateStudent;
            cbDeleteStudent.Checked = userFunctionDTO.DeleteStudent;

            cbAddClassroom.Checked = userFunctionDTO.InsertClass;
            cbUpdateClassroom.Checked = userFunctionDTO.UpdateClass;
            cbDeleteClassroom.Checked = userFunctionDTO.DeleteClass;

            cbAddLocation.Checked = userFunctionDTO.InsertLocation;
            cbUpdateLocation.Checked = userFunctionDTO.UpdateLocation;
            cbDeleteLocation.Checked = userFunctionDTO.DeleteLocation;

            cbAddTopic.Checked = userFunctionDTO.InsertTopic;
            cbUpdateTopic.Checked = userFunctionDTO.UpdateTopic;
            cbDeleteTopic.Checked = userFunctionDTO.DeleteTopic;

            cbReportClassroom.Checked = userFunctionDTO.ReportClass;
            cbDataReality.Checked = userFunctionDTO.DataReality;
            cbReportSummary.Checked = userFunctionDTO.Summary;
            cbReportLocation.Checked = userFunctionDTO.ReportLocation;
            cbReportMonth.Checked = userFunctionDTO.ReportMonth;
            cbTimeTableSummary.Checked = userFunctionDTO.TimeTableOverall;
            cbDataPlan.Checked = userFunctionDTO.DataPlan;
            cbReportKPI.Checked = userFunctionDTO.GeneralKpi;
            cbTimeTablePlan.Checked = userFunctionDTO.TimeTablePlan;

            cbListClassroom.Checked = userFunctionDTO.ListClass;
            cbListChef.Checked = userFunctionDTO.ListChef;
            cbListLocation.Checked = userFunctionDTO.ListLocation;
            cbListTopic.Checked = userFunctionDTO.ListTopic;
            cbListStudent.Checked = userFunctionDTO.ListStudent;
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

        private void cbListClassroom_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCheckBoxes(cbListClassroom.Checked, cbAddClassroom, cbUpdateClassroom, cbDeleteClassroom);
        }

        private void cbListLocation_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCheckBoxes(cbListLocation.Checked, cbAddLocation, cbUpdateLocation, cbDeleteLocation);
        }

        private void cbListChef_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCheckBoxes(cbListChef.Checked, cbAddChef, cbUpdateChef, cbDeleteChef);
        }

        private void cbListTopic_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCheckBoxes(cbListTopic.Checked, cbAddTopic, cbUpdateTopic, cbDeleteTopic);
        }

        private void cbListStudent_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCheckBoxes(cbListStudent.Checked, cbAddStudent, cbUpdateStudent, cbDeleteStudent);
        }

        private void CheckFuntion()
        {
            EnableCheckBox(cbListClassroom.Checked, cbAddClassroom, cbUpdateClassroom, cbDeleteClassroom);
            EnableCheckBox(cbListLocation.Checked, cbAddLocation, cbUpdateLocation, cbDeleteLocation);
            EnableCheckBox(cbListChef.Checked, cbAddChef, cbUpdateChef, cbDeleteChef);
            EnableCheckBox(cbListTopic.Checked, cbAddTopic, cbUpdateTopic, cbDeleteTopic);
            EnableCheckBox(cbListStudent.Checked, cbAddStudent, cbUpdateStudent, cbDeleteStudent);
        }

        private void EnableCheckBox(bool isEnabled, params LOGIN.CustomCheckBox[] checkBoxes)
        {
            if (isEnabled == false)
            {
                foreach (var checkBox in checkBoxes)
                {
                    checkBox.Checked = false;
                    checkBox.Enabled = isEnabled; // Kích hoạt hoặc vô hiệu hóa
                }
            }
        }

        private void UpdateCheckBoxes(bool isEnabled, params LOGIN.CustomCheckBox[] checkBoxes)
        {
            foreach (var checkBox in checkBoxes)
            {
                if (isEnabled == false)
                {
                    checkBox.Checked = false;
                }// Đặt trạng thái là false
                checkBox.Enabled = isEnabled; // Kích hoạt hoặc vô hiệu hóa
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Tạo một đối tượng UserFunctionDTO mới
            UserFunctionDTO userFunction = new UserFunctionDTO
            {
                InsertStudent = cbAddStudent.Checked,
                UpdateStudent = cbUpdateStudent.Checked,
                DeleteStudent = cbDeleteStudent.Checked,

                InsertClass = cbAddClassroom.Checked,
                UpdateClass = cbUpdateClassroom.Checked,
                DeleteClass = cbDeleteClassroom.Checked,

                InsertChef = cbAddChef.Checked,
                UpdateChef = cbUpdateChef.Checked,
                DeleteChef = cbDeleteChef.Checked,

                InsertLocation = cbAddLocation.Checked,
                UpdateLocation = cbUpdateLocation.Checked,
                DeleteLocation = cbDeleteLocation.Checked,

                InsertTopic = cbAddTopic.Checked,
                UpdateTopic = cbUpdateTopic.Checked,
                DeleteTopic = cbDeleteTopic.Checked,

                ReportClass = cbReportClassroom.Checked,
                DataReality = cbDataReality.Checked,
                Summary = cbReportSummary.Checked,
                ReportLocation = cbReportLocation.Checked,
                ReportMonth = cbReportMonth.Checked,
                TimeTableOverall = cbTimeTableSummary.Checked,
                DataPlan = cbDataPlan.Checked,
                GeneralKpi = cbReportKPI.Checked,
                TimeTablePlan = cbTimeTablePlan.Checked,

                ListClass = cbListClassroom.Checked,
                ListChef = cbListChef.Checked,
                ListLocation = cbListLocation.Checked,
                ListTopic = cbListTopic.Checked,
                ListStudent = cbListStudent.Checked,

                IdRole = userFunctionDTO.IdRole/* Gán giá trị IdRole từ đâu đó, có thể từ cơ sở dữ liệu hoặc input */,
                IdAccount = userFunctionDTO.IdAccount /* Gán giá trị IdAccount từ đâu đó, có thể từ cơ sở dữ liệu hoặc input */
            };

            // Gọi BLL để lưu thông tin
            UserFunctionBLL userFunctionBLL = new UserFunctionBLL();
            userFunctionBLL.UpdateUserFunction(userFunction);
            MessageBox.Show("Cập nhật thông tin thành công");
        }

    }
}
