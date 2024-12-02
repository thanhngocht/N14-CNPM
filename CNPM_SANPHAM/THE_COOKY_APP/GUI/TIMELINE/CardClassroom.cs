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
using THE_COOKY_APP.GUI.CLASSROOM;
using THE_COOKY_APP.GUI.LOCATION;

namespace THE_COOKY_APP.GUI.TIMELINE
{
    public partial class CardClassroom : UserControl
    {
        private readonly UserFunctionBLL userFunctionBLL = new UserFunctionBLL();
        private readonly AccountBLL accountBLL = new AccountBLL();
        private readonly UserFunctionDTO userFunctionDTO;
        private readonly AccountDTO accountDTO;
        public CardClassroom(string accountId)
        {
            InitializeComponent();
            if (accountId == "")
            {
                return;
            }
            userFunctionDTO = userFunctionBLL.GetPermissionsByAccountId(accountId);
            accountDTO = accountBLL.GetAccountById(accountId);
        }

        public void SetClassroom(string imgPath, string nameChef, string price, string nameClass, DateTime startDate, string description, string classroomID)
        {
            lblNameChef.Text = nameChef;
            btnPrice.Text = "Chi tiết";
            lblNameClassroom.Text = nameClass;
            lblDescription.Text = description;
            lblClassID.Text = classroomID;
            lblClassID.Visible = false;
            if (!string.IsNullOrEmpty(imgPath) && File.Exists(imgPath))
            {
                rpbClassroom.Image = Image.FromFile(imgPath);
                rpbClassroom.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Refresh();
                // Chỉnh kích thước hình ảnh vừa với PictureBox
            }
            else
            {
                rpbClassroom.Image = null;
            }
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            if (userFunctionDTO.ListClass) // Kiểm tra quyền truy cập
            {
                // Lấy ID tài khoản từ dòng đã chọn
                string classroomId = lblClassID.Text;
                if (classroomId != "Chưa có")
                {
                    // Mở form DetailAccount và truyền ID tài khoản
                    DetailClassroom detailClassroom = new DetailClassroom(classroomId, accountDTO.IdAccount);
                    detailClassroom.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
