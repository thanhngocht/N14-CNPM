using THE_COOKY_APP.BLL;
using THE_COOKY_APP.DTO;

namespace THE_COOKY_APP.GUI.LOCATION
{
    public partial class CreateLocation : Form
    {
        private readonly LocationBLL locationBLL = new LocationBLL();
        private readonly DataValidator validator = new DataValidator();
        public CreateLocation()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các ô nhập liệu
            string nameLocation = txtNameLocation.Text.Trim();

            if (locationBLL.IsLocationNameExists(nameLocation))
            {
                MessageBox.Show("Tên địa chỉ đã tồn tại.");
                return;
            }

            string address = txtAddress.Text.Trim();
            string description = txtDiscription.Text.Trim();
            int quantity;

            // Kiểm tra xem tên địa điểm có hợp lệ không
            if (string.IsNullOrEmpty(nameLocation) || !validator.IsValidName(nameLocation))
            {
                MessageBox.Show("Tên địa điểm không hợp lệ.");
                return;
            }

            // Kiểm tra xem địa chỉ có hợp lệ không
            if (string.IsNullOrEmpty(address) || !validator.IsValidAddressOrNativePlace(address))
            {
                MessageBox.Show("Địa chỉ không hợp lệ.");
                return;
            }

            // Kiểm tra xem giá trị số lượng có hợp lệ không
            if (!int.TryParse(txtQuantity.Text, out quantity))
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ.");
                return;
            }

            // Kiểm tra xem số lượng có lớn hơn 0 không
            if (quantity <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0.");
                return;
            }

            // Giả sử isActive là 1 (hoạt động) hoặc 0 (không hoạt động), bạn có thể thay đổi theo yêu cầu
            bool isActive = true;

            // Gọi phương thức để thêm location
            try
            {
                locationBLL.AddLocation(nameLocation, address, description, quantity, isActive);
                MessageBox.Show("Thêm địa điểm thành công!");

                // Có thể gọi lại LoadData() nếu bạn có phương thức này để cập nhật danh sách địa điểm
                this.Close(); // Giả sử bạn có phương thức LoadData để tải lại dữ liệu
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi thêm địa điểm: {ex.Message}");
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
