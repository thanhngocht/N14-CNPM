using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using THE_COOKY_APP.BLL;
using THE_COOKY_APP.DTO;
using THE_COOKY_APP.GUI.TOPIC;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace THE_COOKY_APP.GUI.CHEF
{
    public partial class CreateChef : Form
    {
        private ChefBLL chefBLL = new ChefBLL();
        private PersonalProfileBLL profileBLL = new PersonalProfileBLL();
        private TopicBLL topicBLL = new TopicBLL();
        private TopicChefBLL topicChefBLL = new TopicChefBLL();
        private DataValidator dataValidator = new DataValidator();

        public CreateChef()
        {
            InitializeComponent();
            this.Size = new Size(1200, 850);
            this.AutoScroll = true;
            this.Shown += new EventHandler(CreateChef_Shown); // Sử dụng sự kiện Shown
            LoadComboBoxSpeciality();
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

        private void LoadComboBoxSpeciality()
        {
            cmbSpeciality.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSpeciality.Items.Clear();
            List<TopicDTO> list = topicBLL.GetAllTopics();
            cmbSpeciality.Items.Add("Thêm mới");
            if (list != null && list.Count > 0)
            {
                foreach (var item in list)
                {
                    cmbSpeciality.Items.Add(item.NameTopic);
                }
                cmbSpeciality.SelectedIndex = 1;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các điều khiển trên form
            string phoneNumber = txtPhoneNumber.Text;
            string fullName = txtFullName.Text.Trim();
            string startDate = dtpStartDate.Text;
            string gmailChef = txtGmail.Text;
            bool isActive = true;

            if (string.IsNullOrEmpty(fullName) || !dataValidator.IsValidName(fullName))
            {
                MessageBox.Show("Họ tên không hợp lệ.");
                return;
            }

            // Kiểm tra định dạng email
            if (!dataValidator.IsValidEmail(gmailChef))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ email hợp lệ.");
                return;
            }

            // Kiểm tra định dạng số điện thoại
            if (!dataValidator.IsPhoneNumber(phoneNumber))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại hợp lệ.");
                return;
            }

            // Kiểm tra định dạng ngày bắt đầu
            DateTime startDateChef;
            if (!DateTime.TryParseExact(startDate, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, DateTimeStyles.None, out startDateChef))
            {
                MessageBox.Show("Vui lòng nhập ngày bắt đầu hợp lệ theo định dạng dd/MM/yyyy.");
                return;
            }

            string cccd = txtCCCD.Text;
            string dateOfBirth = txtDateOfBirth.Text;
            string address = txtAddress.Text;
            string navivePlace = txtNativePlace.Text;

            if (!string.IsNullOrEmpty(address))
            {
                if (!dataValidator.IsValidAddressOrNativePlace(address))
                {
                    MessageBox.Show("Vui lòng nhập địa chỉ hợp lệ.");
                    return;
                }
            }

            if (!string.IsNullOrEmpty(navivePlace))
            {
                if (!dataValidator.IsValidAddressOrNativePlace(navivePlace))
                {
                    MessageBox.Show("Vui lòng nhập nguyên quán hợp lệ.");
                    return;
                }
            }

            // Kiểm tra định dạng CCCD
            if (!string.IsNullOrEmpty(cccd))
            {
                if (!dataValidator.IsNumeric(cccd) || cccd.Length != 10)
                {
                    MessageBox.Show("CCCD không hợp lệ.");
                    return;
                }
            }

            // Kiểm tra định dạng ngày sinh
            DateTime dateOfBirthChef;
            if (!DateTime.TryParseExact(dateOfBirth, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, DateTimeStyles.None, out dateOfBirthChef))
            {
                MessageBox.Show("Vui lòng nhập ngày sinh hợp lệ theo định dạng dd/MM/yyyy.");
                return;
            }

            DataValidator validator = new DataValidator();
            int age = validator.CalculateAge(dateOfBirthChef);

            if (age < 18)
            {
                MessageBox.Show("Tuổi phải lớn hơn hoặc bằng 18.");
                return;
            }

            string? idAccount = null;

            string speciality = cmbSpeciality.SelectedItem?.ToString() ?? "";

            // Kiểm tra nếu speciality không được chọn
            if (string.IsNullOrEmpty(speciality))
            {
                MessageBox.Show("Vui lòng chọn chuyên môn.");
                return;
            }

            // Thêm đầu bếp
            chefBLL.AddChef(phoneNumber, fullName, startDateChef, gmailChef, isActive);
            ChefDTO chef = chefBLL.FindChef(phoneNumber, fullName, startDateChef, gmailChef, isActive);
            string idChef = chef.IdChef;
            // Thêm thông tin hồ sơ
            profileBLL.AddProfile(cccd, dateOfBirthChef, address, navivePlace, idAccount, idChef);

            // Lấy ID chủ đề từ chuyên môn đã chọn
            string topicId = topicBLL.GetTopicIdByName(speciality);

            TopicChefDTO topicChef = new TopicChefDTO
            {
                NameSpeciality = speciality,
                IdChef = idChef,
                IdTopic = topicId,
            };

            // Thêm thông tin chủ đề đầu bếp
            topicChefBLL.AddTopicChef(topicChef);

            // Đóng form sau khi hoàn tất
            this.Close();
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự nhập vào có phải là số hay không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Nếu không phải số, ngăn không cho nhập
            }

            // Kiểm tra số ký tự đã nhập
            if (txtPhoneNumber.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Nếu đã nhập đủ 10 ký tự, ngăn không cho nhập thêm
            }
        }

        private void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự nhập vào có phải là số hay không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Nếu không phải số, ngăn không cho nhập
            }

            // Kiểm tra số ký tự đã nhập
            if (txtCCCD.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Nếu đã nhập đủ 10 ký tự, ngăn không cho nhập thêm
            }
        }

        private void cmbSpeciality_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSpeciality.SelectedIndex == 0)
            {
                CreateTopic createTopic = new CreateTopic();
                createTopic.ShowDialog();
                LoadComboBoxSpeciality();
            }
        }
    }
}
