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

namespace THE_COOKY_APP.GUI.TOPIC
{
    public partial class CreateTopic : Form
    {
        private TopicBLL topicBLL = new TopicBLL();
        private DataValidator dataValidator = new DataValidator();
        public CreateTopic()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nameTopic = txtNameTopic.Text.Trim(); // Loại bỏ khoảng trắng thừa
            bool isActive = true;

            // Kiểm tra nếu tên chủ đề rỗng
            if (string.IsNullOrEmpty(nameTopic) || !dataValidator.IsValidName(nameTopic))
            {
                MessageBox.Show("Tên chủ đề không hợp lệ.");
                return;
            }

            // Kiểm tra độ dài tối đa (ví dụ: 100 ký tự)
            if (nameTopic.Length > 100)
            {
                MessageBox.Show("Tên chủ đề không được vượt quá 100 ký tự.");
                return;
            }

            // Thêm chủ đề vào cơ sở dữ liệu
            topicBLL.AddTopic(nameTopic, isActive);
            this.Close();
        }
    }
}
