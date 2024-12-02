using THE_COOKY_APP.BLL;
using THE_COOKY_APP.DTO;

namespace THE_COOKY_APP.GUI.LOCATION
{
    public partial class ListLocation : Form
    {
        private readonly UserFunctionBLL userFunctionBLL = new UserFunctionBLL();
        private readonly DataValidator validator = new DataValidator();
        private readonly AccountBLL accountBLL = new AccountBLL();
        private readonly UserFunctionDTO userFunctionDTO;
        private readonly AccountDTO accountDTO;
        LocationBLL locationBLL = new LocationBLL();
        private bool isEditing = false;  // Biến để theo dõi trạng thái chỉnh sử
        private string selectedLocation = "";
        public ListLocation(string accountId)
        {
            InitializeComponent();
            LoadLocations();
            LoadComboBoxFilter();
            if (accountId == "")
            {
                return;
            }
            userFunctionDTO = userFunctionBLL.GetPermissionsByAccountId(accountId);
            accountDTO = accountBLL.GetAccountById(accountId);
        }

        private void LoadLocations()
        {
            List<LocationDTO> locations = locationBLL.GetAllLocations();

            dgvListLocation.Rows.Clear();

            foreach (var location in locations)
            {
                int rowIndex = dgvListLocation.Rows.Add(); // Thêm dòng mới
                dgvListLocation.Rows[rowIndex].Cells[0].Value = location.NameLocation;
                dgvListLocation.Rows[rowIndex].Cells[1].Value = location.Address;
                dgvListLocation.Rows[rowIndex].Cells[2].Value = location.MaxLocationQuantity;
                dgvListLocation.Rows[rowIndex].Cells[3].Value = location.IdLocation;
                dgvListLocation.Rows[rowIndex].Cells[4].Value = location.Description;
                dgvListLocation.Rows[rowIndex].Cells[5].Value = location.IsActive;
            }

            CheckAndShowEmptyMessage(); // Kiểm tra và hiển thị thông báo nếu không có dữ liệu
        }

        private void LoadComboBoxFilter()
        {
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.Items.Clear();
            cmbFilter.Items.Add("Tên địa điểm");
            cmbFilter.Items.Add("Địa chỉ");
            cmbFilter.Items.Add("Sức chứa");
            cmbFilter.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (userFunctionDTO.InsertLocation) // Kiểm tra quyền truy cập
            {
                CreateLocation createLocation = new CreateLocation();
                createLocation.ShowDialog();
                LoadLocations();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void ListLocation_Load(object sender, EventArgs e)
        {
            CheckAndShowEmptyMessage();
            LoadLocations();
        }
        private void CheckAndShowEmptyMessage()
        {
            if (dgvListLocation.Rows.Count == 0)
            {
                int rowIndex = dgvListLocation.Rows.Add();
                dgvListLocation.Rows[rowIndex].Cells[0].Value = "Chưa có";
                dgvListLocation.Rows[rowIndex].Cells[1].Value = "Chưa có";
                dgvListLocation.Rows[rowIndex].Cells[2].Value = "Chưa có";
                // Thiết lập định dạng cho dòng thông báo
                dgvListLocation.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Black;
                dgvListLocation.Rows[rowIndex].DefaultCellStyle.Font = new Font(dgvListLocation.Font.FontFamily, 10, FontStyle.Bold); // FontSize 10 và Semibold
                dgvListLocation.Rows[rowIndex].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvListLocation.Rows[rowIndex].ReadOnly = true; // Ngăn người dùng chỉnh sửa dòng thông báo 

            }
            else
            {
                // Nếu có dữ liệu, xóa dòng thông báo nếu tồn tại
                if (dgvListLocation.Rows[0].Cells[0].Value.ToString() == "Chưa có")
                {
                    dgvListLocation.Rows.RemoveAt(0);
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

            var locations = locationBLL.SearchLocations(searchTerm, propertyItem);

            dgvListLocation.Rows.Clear();

            foreach (var location in locations)
            {
                int rowIndex = dgvListLocation.Rows.Add(); // Thêm dòng mới
                dgvListLocation.Rows[rowIndex].Cells[0].Value = location.NameLocation;
                dgvListLocation.Rows[rowIndex].Cells[1].Value = location.Address;
                dgvListLocation.Rows[rowIndex].Cells[2].Value = location.MaxLocationQuantity;
                dgvListLocation.Rows[rowIndex].Cells[3].Value = location.IdLocation;
                dgvListLocation.Rows[rowIndex].Cells[4].Value = location.Description;
                dgvListLocation.Rows[rowIndex].Cells[5].Value = location.IsActive;
            }
            selectedLocation = "";
            CheckAndShowEmptyMessage();
        }

        private void dgvListLocation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có nhấp vào ô hợp lệ không
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvListLocation.Rows[e.RowIndex].Cells[0].Value.ToString() != "Chưa có")
            {
                // Lấy giá trị từ ô đã nhấp
                selectedLocation = dgvListLocation.Rows[e.RowIndex].Cells[3].Value.ToString() + "";
                // Cập nhật giá trị vào ô txtNameTopic
                txtNameLocation.Text = dgvListLocation.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtAddress.Text = dgvListLocation.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtQuantity.Text = dgvListLocation.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDescription.Text = dgvListLocation.Rows[e.RowIndex].Cells[4].Value.ToString();
                if (isEditing)
                {
                    EnableEditing(false);
                    btnUpdate.Text = "Sửa"; // Đổi chữ về "Sửa"
                    isEditing = false;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (userFunctionDTO.UpdateLocation) // Kiểm tra quyền truy cập
            {
                if (selectedLocation != "")
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
                        if (SaveLocation())
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
            txtNameLocation.Enabled = enable;
            txtAddress.Enabled = enable;
            txtQuantity.Enabled = enable;
            txtDescription.Enabled = enable;
            // Thêm các ô khác nếu cần
        }

        private bool SaveLocation()
        {
            // Lấy dữ liệu từ các ô nhập liệu
            string nameLocation = txtNameLocation.Text.Trim();

            string address = txtAddress.Text.Trim();
            string description = txtDescription.Text.Trim();
            int quantity;

            // Kiểm tra xem tên địa điểm có hợp lệ không
            if (string.IsNullOrEmpty(nameLocation) || !validator.IsValidName(nameLocation))
            {
                MessageBox.Show("Tên địa điểm không hợp lệ.");
                return false;
            }

            // Kiểm tra xem địa chỉ có hợp lệ không
            if (string.IsNullOrEmpty(address) || !validator.IsValidAddressOrNativePlace(address))
            {
                MessageBox.Show("Địa chỉ không hợp lệ.");
                return false;
            }

            // Kiểm tra xem giá trị số lượng có hợp lệ không
            if (!int.TryParse(txtQuantity.Text, out quantity))
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ.");
                return false;
            }

            // Kiểm tra xem số lượng có lớn hơn 0 không
            if (quantity <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0.");
                return false;
            }

            // Lưu thông tin vào BLL
            var locationToUpdate = new LocationDTO
            {
                NameLocation = nameLocation,
                Address =  address,
                MaxLocationQuantity = quantity,
                Description = description,
                IdLocation = selectedLocation, // Lấy ID từ dòng hiện tại
                IsActive = Convert.ToBoolean(dgvListLocation.CurrentRow.Cells[5].Value.ToString())
            };

            locationBLL.UpdateLocation(locationToUpdate); // Gọi phương thức cập nhật trong BLL
            LoadLocations(); // Tải lại danh sách để cập nhật
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (userFunctionDTO.DeleteLocation) // Kiểm tra quyền truy cập
            {
                if (selectedLocation != "")
                {
                    DialogResult result = MessageBox.Show(
                        "Bạn có chắc chắn muốn xoá địa điểm này?",
                        "Xác nhận xóa địa điểm",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.OK)
                    {
                        int selectedRowIndex = dgvListLocation.CurrentCell.RowIndex;
                        string locationtId = selectedLocation;
                        locationBLL.DeleteLocation(locationtId);
                        selectedLocation = "";
                        LoadLocations();
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự nhập vào có phải là số hay không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Nếu không phải số, ngăn không cho nhập
            }

        }
    }
}
