using Microsoft.Identity.Client;
using THE_COOKY_APP.BLL;
using THE_COOKY_APP.DTO;


namespace THE_COOKY_APP.GUI.ACCOUNT
{
    public partial class ListAccount : Form
    {
        private AccountBLL accountBLL = new AccountBLL();
        private UserFunctionBLL userFunctionBLL = new UserFunctionBLL();
        private RoleBLL roleBLL = new RoleBLL();
        private string selectedAccount = "";
        public ListAccount()
        {
            InitializeComponent();
            LoadAccounts();
            LoadComboBoxFilter();
        }

        private void LoadAccounts()
        {
            List<AccountDTO> accounts = accountBLL.GetAllAccounts(); // Lấy danh sách tài khoản

            dgvListAccount.Rows.Clear(); // Xóa các dòng hiện tại trong DataGridView

            foreach (var account in accounts)
            {
                int rowIndex = dgvListAccount.Rows.Add(); // Thêm dòng mới
                dgvListAccount.Rows[rowIndex].Cells[0].Value = account.FullName; // Họ tên
                dgvListAccount.Rows[rowIndex].Cells[1].Value = account.Username; // Tên đăng nhập
                dgvListAccount.Rows[rowIndex].Cells[2].Value = "*********"; // Mật khẩu
                dgvListAccount.Rows[rowIndex].Cells[3].Value = account.PhoneNumber; // Số điện thoại
                dgvListAccount.Rows[rowIndex].Cells[4].Value = account.Gmail; // Email
                string idRole = userFunctionBLL.GetRoleIdByAccountId(account.IdAccount);
                if (idRole != null)
                {
                    RoleDTO roleDTO = roleBLL.GetRoleById(idRole);
                    dgvListAccount.Rows[rowIndex].Cells[5].Value = roleDTO.NameRole;
                }// Vai trò
                dgvListAccount.Rows[rowIndex].Cells[6].Value = account.IdAccount; // ID
            }
            CheckAndShowEmptyMessage();
        }

        private void LoadComboBoxFilter()
        {
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.Items.Clear();
            cmbFilter.Items.Add("Họ và tên");
            cmbFilter.Items.Add("Tài khoản");
            cmbFilter.Items.Add("Số điện thoại");
            cmbFilter.Items.Add("Gmail");
            cmbFilter.Items.Add("Chức vụ");
            cmbFilter.SelectedIndex = 0;
        }

        private void ListAccount_Load(object sender, EventArgs e)
        {
            LoadAccounts();
            CheckAndShowEmptyMessage();
        }
        private void CheckAndShowEmptyMessage()
        {   
            if (dgvListAccount.Rows.Count == 0)
            {
                int rowIndex = dgvListAccount.Rows.Add();
                dgvListAccount.Rows[rowIndex].Cells[0].Value = "Chưa có";
                dgvListAccount.Rows[rowIndex].Cells[1].Value = "Chưa có";
                dgvListAccount.Rows[rowIndex].Cells[2].Value = "Chưa có";
                dgvListAccount.Rows[rowIndex].Cells[3].Value = "Chưa có";
                dgvListAccount.Rows[rowIndex].Cells[4].Value = "Chưa có";
                dgvListAccount.Rows[rowIndex].Cells[5].Value = "Chưa có";
                dgvListAccount.Rows[rowIndex].Cells[6].Value = "Chưa có";
                // Thiết lập định dạng cho dòng thông báo
                dgvListAccount.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Black;
                dgvListAccount.Rows[rowIndex].DefaultCellStyle.Font = new Font(dgvListAccount.Font.FontFamily, 10, FontStyle.Bold); // FontSize 10 và Semibold
                dgvListAccount.Rows[rowIndex].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvListAccount.Rows[rowIndex].ReadOnly = true; // Ngăn người dùng chỉnh sửa dòng thông báo 

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
            var accounts = accountBLL.SearchAccounts(searchTerm, propertyItem);
            dgvListAccount.Rows.Clear(); // Xóa các dòng hiện tại trong DataGridView

            foreach (var account in accounts)
            {
                int rowIndex = dgvListAccount.Rows.Add(); // Thêm dòng mới
                dgvListAccount.Rows[rowIndex].Cells[0].Value = account.FullName; // Họ tên
                dgvListAccount.Rows[rowIndex].Cells[1].Value = account.Username; // Tên đăng nhập
                dgvListAccount.Rows[rowIndex].Cells[2].Value = "*********"; // Mật khẩu
                dgvListAccount.Rows[rowIndex].Cells[3].Value = account.PhoneNumber; // Số điện thoại
                dgvListAccount.Rows[rowIndex].Cells[4].Value = account.Gmail; // Email
                string idRole = userFunctionBLL.GetRoleIdByAccountId(account.IdAccount);
                RoleDTO roleDTO = roleBLL.GetRoleById(idRole);
                dgvListAccount.Rows[rowIndex].Cells[5].Value = roleDTO.NameRole; // Vai trò
                dgvListAccount.Rows[rowIndex].Cells[6].Value = account.IdAccount; // ID
            }
            selectedAccount = "";
            CheckAndShowEmptyMessage();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateAccount createAccount = new CreateAccount();
            createAccount.ShowDialog();
            LoadAccounts();
        }

        private void dgvListAccount_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có nhấp vào ô hợp lệ không
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy ID tài khoản từ dòng đã chọn
                string accountId = dgvListAccount.Rows[e.RowIndex].Cells[6].Value.ToString() + "";
                if (accountId != "Chưa có")
                {
                    // Mở form DetailAccount và truyền ID tài khoản
                    DetailAccount detailAccount = new DetailAccount(accountId);
                    detailAccount.ShowDialog();
                    LoadAccounts();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (dgvListAccount.CurrentCell != null)
            {
                
                if (selectedAccount != "")
                {
                    DialogResult result = MessageBox.Show(
                        "Bạn có chắc chắn muốn xoá tài khoản này?",
                        "Xác nhận xóa tài khoản",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.OK)
                    {
                        UserFunctionDTO userFunctionDTO = userFunctionBLL.GetPermissionsByAccountId(selectedAccount);
                        userFunctionBLL.DeleteUserFunction(userFunctionDTO.IdRole, selectedAccount);
                        accountBLL.DeleteAccount(selectedAccount);
                        LoadAccounts();
                        selectedAccount = "";
                    }
                }

            }

        }

        private void dgvListAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvListAccount.Rows[e.RowIndex].Cells[6].Value.ToString() != "Chưa có")
                {
                    selectedAccount = dgvListAccount.Rows[e.RowIndex].Cells[6].Value.ToString() + "";
                }
            }
        }
    }
}
