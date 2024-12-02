using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THE_COOKY_APP.BLL;
using THE_COOKY_APP.DTO;
using THE_COOKY_APP.GUI.LOCATION;

namespace THE_COOKY_APP.GUI.TOPIC
{
    public partial class ListTopic : Form
    {
        private readonly UserFunctionBLL userFunctionBLL = new UserFunctionBLL();
        private readonly AccountBLL accountBLL = new AccountBLL();
        private readonly UserFunctionDTO userFunctionDTO;
        private readonly AccountDTO accountDTO;
        private TopicBLL topicBLL = new TopicBLL();
        private bool isEditing = false; // Biến để theo dõi trạng thái chỉnh sửa
        private string selectedTopic = "";
        private DataValidator dataValidator = new DataValidator();
        public ListTopic(string accountId)
        {
            InitializeComponent();
            LoadTopics();
            LoadComboBoxFilter();
            if (accountId == "")
            {
                return;
            }
            userFunctionDTO = userFunctionBLL.GetPermissionsByAccountId(accountId);
            accountDTO = accountBLL.GetAccountById(accountId);
        }

        public void LoadTopics()
        {
            List<TopicDTO> topics = topicBLL.GetAllTopics();
            dgvListTopic.Rows.Clear();

            foreach (var topic in topics)
            {
                int rowIndex = dgvListTopic.Rows.Add();
                dgvListTopic.Rows[rowIndex].Cells[0].Value = topic.NameTopic;
                dgvListTopic.Rows[rowIndex].Cells[1].Value = topic.IdTopic;
            }

            CheckAndShowEmptyMessage();
        }

        private void LoadComboBoxFilter()
        {
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.Items.Add("Tên chủ đề");
            cmbFilter.SelectedIndex = 0;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (userFunctionDTO.InsertTopic) // Kiểm tra quyền truy cập
            {
                CreateTopic createTopic = new CreateTopic();
                createTopic.ShowDialog();
                LoadTopics();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ListTopic_Load(object sender, EventArgs e)
        {
            CheckAndShowEmptyMessage();
            LoadTopics();
        }
        private void CheckAndShowEmptyMessage()
        {
            if (dgvListTopic.Rows.Count == 0)
            {
                int rowIndex = dgvListTopic.Rows.Add();
                dgvListTopic.Rows[rowIndex].Cells[0].Value = "Chưa có";
                dgvListTopic.Rows[rowIndex].Cells[1].Value = "Chưa có";
                // Thiết lập định dạng cho dòng thông báo
                dgvListTopic.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Black;
                dgvListTopic.Rows[rowIndex].DefaultCellStyle.Font = new Font(dgvListTopic.Font.FontFamily, 10, FontStyle.Bold); // FontSize 10 và Semibold
                dgvListTopic.Rows[rowIndex].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvListTopic.Rows[rowIndex].ReadOnly = true; // Ngăn người dùng chỉnh sửa dòng thông báo 

            }
            else
            {
                // Nếu có dữ liệu, xóa dòng thông báo nếu tồn tại
                if (dgvListTopic.Rows[0].Cells[0].Value.ToString() == "Chưa có")
                {
                    dgvListTopic.Rows.RemoveAt(0);
                }
            }
        }

        private void dgvListTopic_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có nhấp vào ô hợp lệ không
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 )
            {
                if (dgvListTopic.Rows[e.RowIndex].Cells[0].Value.ToString() != "Chưa có")
                {
                    // Lấy giá trị từ ô đã nhấp
                    selectedTopic = dgvListTopic.Rows[e.RowIndex].Cells[1].Value.ToString() + "";

                    // Cập nhật giá trị vào ô txtNameTopic
                    txtNameTopic.Text = dgvListTopic.Rows[e.RowIndex].Cells[0].Value.ToString();

                    if (isEditing)
                    {
                        EnableEditing(false);
                        btnUpdate.Text = "Sửa"; // Đổi chữ về "Sửa"
                        isEditing = false;
                    }
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (cmbFilter.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một thuộc tính để tìm kiếm.");
                return; // Thoát khỏi hàm nếu không có mục nào được chọn
            }
            var searchTerm = txtSearch.Text;
            var propertyItem = cmbFilter.SelectedItem.ToString();

            var topics = topicBLL.SearchTopics(searchTerm);

            dgvListTopic.Rows.Clear();

            foreach (var topic in topics)
            {
                int rowIndex = dgvListTopic.Rows.Add();
                dgvListTopic.Rows[rowIndex].Cells[0].Value = topic.NameTopic;
                dgvListTopic.Rows[rowIndex].Cells[1].Value = topic.IdTopic;
            }
            selectedTopic = "";
            CheckAndShowEmptyMessage();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (userFunctionDTO.UpdateTopic) // Kiểm tra quyền truy cập
            {
                if (selectedTopic != "")
                {
                    if (!isEditing)
                    {
                        // Bật chế độ chỉnh sửa
                        EnableEditing(true);
                        btnUpdate.Text = "Lưu"; // Đổi chữ thành "Lưu"
                        isEditing = true;
                    }
                    else
                    {
                        // Lưu thông tin
                        if (SaveTopic())
                        {
                            EnableEditing(false);
                            btnUpdate.Text = "Sửa"; // Đổi chữ về "Sửa"
                            isEditing = false;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EnableEditing(bool enable)
        {
            // Kích hoạt hoặc vô hiệu hóa các ô văn bản trong panelTopic
            txtNameTopic.Enabled = enable;
            // Thêm các ô khác nếu cần
        }

        private bool SaveTopic()
        {
            string nameTopic = txtNameTopic.Text.Trim(); // Loại bỏ khoảng trắng thừa

            // Kiểm tra nếu tên chủ đề rỗng
            if (string.IsNullOrEmpty(nameTopic) || !dataValidator.IsValidName(nameTopic))
            {
                MessageBox.Show("Tên chủ đề không hợp lệ.");
                return false;
            }

            // Kiểm tra độ dài tối đa (ví dụ: 100 ký tự)
            if (nameTopic.Length > 100)
            {
                MessageBox.Show("Tên chủ đề không được vượt quá 100 ký tự.");
                return false;
            }
            // Lưu thông tin vào BLL
            var topicToUpdate = new TopicDTO
            {
                NameTopic = txtNameTopic.Text,
                IdTopic = selectedTopic // Lấy ID từ dòng hiện tại
            };

            topicBLL.UpdateTopic(topicToUpdate); // Gọi phương thức cập nhật trong BLL
            LoadTopics(); // Tải lại danh sách để cập nhật
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (userFunctionDTO.DeleteTopic) // Kiểm tra quyền truy cập
            {
                if (dgvListTopic.CurrentCell != null && selectedTopic != "")
                {
                    DialogResult result = MessageBox.Show(
                        "Bạn có chắc chắn muốn xoá chủ đề này?",
                        "Xác nhận xóa chủ đề",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.OK)
                    {
                        string topictId = selectedTopic;
                        topicBLL.DeleteTopic(topictId);
                        selectedTopic = "";
                        LoadTopics();
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
