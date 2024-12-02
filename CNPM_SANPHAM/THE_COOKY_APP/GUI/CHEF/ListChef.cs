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
using THE_COOKY_APP.GUI.LOCATION;
using THE_COOKY_APP.GUI.PROFILE;

namespace THE_COOKY_APP.GUI.CHEF
{
    public partial class ListChef : Form
    {
        private readonly UserFunctionBLL userFunctionBLL = new UserFunctionBLL();
        private readonly AccountBLL accountBLL = new AccountBLL();
        private readonly UserFunctionDTO userFunctionDTO;
        private readonly AccountDTO accountDTO;
        private ChefBLL chefBLL = new ChefBLL();
        private TopicChefBLL topicChefBLL = new TopicChefBLL();
        PersonalProfileBLL personalProfileBLL = new PersonalProfileBLL();
        private string selectedChef = "";
        public ListChef(string accountId)
        {
            InitializeComponent();
            LoadChefs();
            LoadComboBoxFilter();
            if (accountId == "")
            {
                return;
            }
            userFunctionDTO = userFunctionBLL.GetPermissionsByAccountId(accountId);
            accountDTO = accountBLL.GetAccountById(accountId);
        }

        private void LoadChefs()
        {
            List<ChefDTO> chefs = chefBLL.GetAllChefs(); // Lấy danh sách đầu bếp từ BLL

            dgvListChef.Rows.Clear(); // Xóa các dòng hiện tại trong DataGridView

            foreach (var chef in chefs)
            {
                int rowIndex = dgvListChef.Rows.Add(); // Thêm dòng mới
                dgvListChef.Rows[rowIndex].Cells[0].Value = chef.FullName; // Tên đầy đủ
                dgvListChef.Rows[rowIndex].Cells[1].Value = chef.PhoneNumber; // Số điện thoại
                dgvListChef.Rows[rowIndex].Cells[2].Value = chef.Gmail; // Gmail
                dgvListChef.Rows[rowIndex].Cells[3].Value = chef.StartDate.ToString("dd/MM/yyyy"); // Ngày bắt đầu
                TopicChefDTO topicChefDTO = topicChefBLL.GetTopicsByChefId(chef.IdChef);
                dgvListChef.Rows[rowIndex].Cells[4].Value = topicChefDTO.NameSpeciality; // Chuyên môn
                dgvListChef.Rows[rowIndex].Cells[5].Value = chef.IdChef; // ID
            }

            CheckAndShowEmptyMessage(); // Kiểm tra và hiển thị thông báo nếu không có dữ liệu
        }

        private void LoadComboBoxFilter()
        {
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.Items.Clear();
            cmbFilter.Items.Add("Tên giáo viên");
            cmbFilter.Items.Add("Số điện thoại");
            cmbFilter.Items.Add("Gmail");
            cmbFilter.Items.Add("Ngày làm việc");
            cmbFilter.Items.Add("Chuyên môn");
            cmbFilter.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (userFunctionDTO.InsertChef) // Kiểm tra quyền truy cập
            {
                CreateChef createChef = new CreateChef();
                createChef.ShowDialog();
                LoadChefs();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void CheckAndShowEmptyMessage()
        {
            if (dgvListChef.Rows.Count == 0)
            {
                int rowIndex = dgvListChef.Rows.Add();
                dgvListChef.Rows[rowIndex].Cells[0].Value = "Chưa có";
                dgvListChef.Rows[rowIndex].Cells[1].Value = "Chưa có";
                dgvListChef.Rows[rowIndex].Cells[2].Value = "Chưa có";
                dgvListChef.Rows[rowIndex].Cells[3].Value = "Chưa có";
                dgvListChef.Rows[rowIndex].Cells[4].Value = "Chưa có";
                // Thiết lập định dạng cho dòng thông báo
                dgvListChef.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Black;
                dgvListChef.Rows[rowIndex].DefaultCellStyle.Font = new Font(dgvListChef.Font.FontFamily, 10, FontStyle.Bold); // FontSize 10 và Semibold
                dgvListChef.Rows[rowIndex].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvListChef.Rows[rowIndex].ReadOnly = true; // Ngăn người dùng chỉnh sửa dòng thông báo 

            }
            else
            {
                // Nếu có dữ liệu, xóa dòng thông báo nếu tồn tại
                if (dgvListChef.Rows[0].Cells[0].Value.ToString() == "Chưa có")
                {
                    dgvListChef.Rows.RemoveAt(0);
                }
            }
        }

        private void ListChef_Load(object sender, EventArgs e)
        {
            CheckAndShowEmptyMessage();
            LoadChefs();
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
            var chefs = chefBLL.SearchChefs(searchTerm, propertyItem);

            dgvListChef.Rows.Clear(); // Xóa các dòng hiện tại trong DataGridView

            foreach (var chef in chefs)
            {
                int rowIndex = dgvListChef.Rows.Add(); // Thêm dòng mới
                dgvListChef.Rows[rowIndex].Cells[0].Value = chef.FullName; // Tên đầy đủ
                dgvListChef.Rows[rowIndex].Cells[1].Value = chef.PhoneNumber; // Số điện thoại
                dgvListChef.Rows[rowIndex].Cells[2].Value = chef.Gmail; // Gmail
                dgvListChef.Rows[rowIndex].Cells[3].Value = chef.StartDate.ToString("dd/MM/yyyy"); // Ngày bắt đầu
                TopicChefDTO topicChefDTO = topicChefBLL.GetTopicsByChefId(chef.IdChef);
                dgvListChef.Rows[rowIndex].Cells[4].Value = topicChefDTO.NameSpeciality; // Chuyên môn
                dgvListChef.Rows[rowIndex].Cells[5].Value = chef.IdChef; // ID
            }
            selectedChef = "";
            CheckAndShowEmptyMessage();
        }

        private void dgvListChef_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có nhấp vào ô hợp lệ không
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy ID tài khoản từ dòng đã chọn
                string chefId = dgvListChef.Rows[e.RowIndex].Cells[5].Value.ToString() + "";
                if (chefId != "")
                {
                    // Mở form DetailAccount và truyền ID tài khoản
                    ChefProfile chefProfile = new ChefProfile(chefId, accountDTO.IdAccount);
                    chefProfile.ShowDialog();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (userFunctionDTO.DeleteChef) // Kiểm tra quyền truy cập
            {
                if (selectedChef != "")
                {
                    DialogResult result = MessageBox.Show(
                        "Bạn có chắc chắn muốn xoá giáo viên này?",
                        "Xác nhận xóa giáo viên",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.OK)
                    {
                        chefBLL.DeleteChef(selectedChef);
                        LoadChefs();
                        selectedChef = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void dgvListChef_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvListChef.Rows[e.RowIndex].Cells[0].Value.ToString() != "Chưa có")
                {
                    selectedChef = dgvListChef.Rows[e.RowIndex].Cells[5].Value.ToString() + "";
                }
            }
        }
    }
}
