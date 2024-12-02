using GenerativeAI.Exceptions;
using GenerativeAI.Models;
using GenerativeAI.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THE_COOKY_APP.GUI.CLASSROOM
{
    public partial class AIDescription : Form
    {
        private string name;
        private string description;
        public string descrip { get; private set; }
        public AIDescription(string nameClass, string key)
        {
            InitializeComponent();
            name = nameClass;
            description = key;
            LoadDes();
        }

        private async void LoadDes()
        {
            string loading = "Bạn vui lòng chờ tí. Hệ thông đang đề xuất cho bạn";
            txtDescription.Text = loading;
            string text = $"Tạo một mô tả ngắn gần 20 chữ để giới thiệu về lớp học nấu ăn cho món ăn '{name}' với từ khóa '{description}'.";
            string respone = await GenerateDescription(name, description, text);
            txtDescription.Text = respone;
        }

        public async Task<string> GenerateDescription(string dishName, string keyword, string prompt)
        {
            try
            {
                string apiKey = "AIzaSyBx7G4CCK9RTW4D7pDPTT0UNWrDrDwbU4Q";
                var model = new GenerativeModel(apiKey); // Hoặc GeminiProModel(apiKey) nếu cần
                var chat = model.StartChat(new StartChatParams());

                // Gửi yêu cầu đầu tiên
                var result = await chat.SendMessageAsync(prompt);
                if (string.IsNullOrEmpty(result))
                {
                    return "Không có nội dung được tạo.";
                }

                return result;
            }
            catch (GenerativeAIException ex)
            {
                // Xử lý lỗi và hiển thị thông báo
                return $"Có lỗi xảy ra: {ex.Message}";
            }
            catch (Exception ex)
            {
                // Xử lý các lỗi khác
                return $"Có lỗi không xác định: {ex.Message}";
            }
        }

        private async void btnAnotherHint_Click(object sender, EventArgs e)
        {
            string loading = "Bạn vui lòng chờ tí. Hệ thông đang đề xuất cho bạn";
            string des = txtDescription.Text;
            txtDescription.Text = loading;
            string text = $"Tạo một mô tả ngắn gần 30 chữ để giới thiệu về lớp học nấu ăn cho món ăn '{name}' với từ khóa '{description}' khác ngoài {des}";
            string respone = await GenerateDescription(name, description, text);
            txtDescription.Text = respone;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Nếu không có lỗi, tiếp tục thực hiện
            descrip = txtDescription.Text;
            this.DialogResult = DialogResult.OK; // Đặt kết quả của Form là OK
            this.Close(); // Đóng Form
        }
    }
}
