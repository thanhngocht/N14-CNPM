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
    public partial class PickTime : Form
    {
        public string OrganizationDay { get; private set; }
        public int Fee { get; private set; }
        public string? StartHour { get; private set; }
        public string? EndHour { get; private set; }
        public int MaterialCost { get; private set; }
        public int FreelancerCost { get; private set; }
        public int AnotherCost { get; private set; }
        public string? Note { get; private set; }

        public PickTime()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ các điều khiển
            DateTime organizationDay = dtpOrganizationDay.Value; // Lấy giá trị DateTime từ DateTimePicker
            Fee = ConvertToInt(txtFee.Text);
            MaterialCost = ConvertToInt(txtMaterialCost.Text);
            FreelancerCost = ConvertToInt(txtFreelancerCost.Text);
            AnotherCost = ConvertToInt(txtAnotherCost.Text);
            Note = txtNote.Text;

            // Chuyển đổi StartHour và EndHour thành TimeSpan
            TimeSpan startHour;
            TimeSpan endHour;

            // Kiểm tra và chuyển đổi StartHour
            if (!TimeSpan.TryParse(ttbStartHour.Text, out startHour))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng thời gian cho thời gian bắt đầu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng thực hiện nếu định dạng không hợp lệ
            }

            // Kiểm tra và chuyển đổi EndHour
            if (!TimeSpan.TryParse(ttbEndHour.Text, out endHour))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng thời gian cho thời gian kết thúc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng thực hiện nếu định dạng không hợp lệ
            }

            // Kiểm tra StartHour và EndHour không được là 00:00
            if (startHour == TimeSpan.Zero || endHour == TimeSpan.Zero)
            {
                MessageBox.Show("StartHour và EndHour không được là 00:00.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng thực hiện nếu có lỗi
            }

            // Kiểm tra EndHour có lớn hơn StartHour không
            if (endHour <= startHour)
            {
                MessageBox.Show("Thời gian kết thúc phải lớn hơn thời gian bắt đầu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng thực hiện nếu có lỗi
            }

            // Kiểm tra ngày tổ chức
            DateTime currentDateTime = DateTime.UtcNow; // Lấy thời gian hiện tại
            if (organizationDay.Date < currentDateTime.Date)
            {
                MessageBox.Show("Ngày tổ chức phải lớn hơn ngày hiện tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng thực hiện nếu có lỗi
            }

            // Nếu ngày tổ chức bằng ngày hiện tại, kiểm tra thời gian
            if (organizationDay.Date == currentDateTime.Date)
            {
                TimeSpan currentTime = currentDateTime.TimeOfDay; // Lấy thời gian hiện tại
                TimeSpan timeDifference = startHour - currentTime; // Tính khoảng cách thời gian

                if (timeDifference.TotalHours < 2)
                {
                    MessageBox.Show("Thời gian tổ chức phải cách thời gian hiện tại hơn 2 tiếng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Dừng thực hiện nếu có lỗi
                }
            }
            OrganizationDay = dtpOrganizationDay.Text;
            StartHour = ttbStartHour.Text;
            EndHour = ttbEndHour.Text;
            // Nếu không có lỗi, tiếp tục thực hiện
            this.DialogResult = DialogResult.OK; // Đặt kết quả của Form là OK
            this.Close(); // Đóng Form
        }

        private int ConvertToInt(string input)
        {
            // Xóa tất cả ký tự không phải số
            string cleanedInput = new string(input.Where(char.IsDigit).ToArray());

            // Chuyển đổi chuỗi thành số
            if (int.TryParse(cleanedInput, out int result))
            {
                return result;
            }
            return 0; // Trả về 0 nếu không thể chuyển đổi
        }

        private void txtMaterialCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự nhập vào có phải là số hay không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Nếu không phải số, ngăn không cho nhập
            }
        }

        private void txtFreelancerCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự nhập vào có phải là số hay không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Nếu không phải số, ngăn không cho nhập
            }
        }

        private void txtAnotherCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự nhập vào có phải là số hay không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Nếu không phải số, ngăn không cho nhập
            }
        }

        private void txtMaterialCost_TextChanged(object? sender, EventArgs e)
        {
            // Tắt sự kiện để tránh vòng lặp vô hạn
            txtMaterialCost.TextChanged -= txtMaterialCost_TextChanged;

            // Xóa tất cả ký tự không phải số
            string input = new string(txtMaterialCost.Text.Where(char.IsDigit).ToArray());

            // Chuyển đổi chuỗi thành số và định dạng
            if (long.TryParse(input, out long number))
            {
                // Định dạng số với dấu phân cách
                txtMaterialCost.Text = string.Format("{0:N0}", number).Replace(",", ".");
            }

            // Đặt con trỏ về cuối TextBox
            txtMaterialCost.SelectionStart = txtMaterialCost.Text.Length;

            // Đăng ký lại sự kiện
            txtMaterialCost.TextChanged += txtMaterialCost_TextChanged;
        }

        private void txtFreelancerCost_TextChanged(object? sender, EventArgs e)
        {
            // Tắt sự kiện để tránh vòng lặp vô hạn
            txtFreelancerCost.TextChanged -= txtFreelancerCost_TextChanged;

            // Xóa tất cả ký tự không phải số
            string input = new string(txtFreelancerCost.Text.Where(char.IsDigit).ToArray());

            // Chuyển đổi chuỗi thành số và định dạng
            if (long.TryParse(input, out long number))
            {
                // Định dạng số với dấu phân cách
                txtFreelancerCost.Text = string.Format("{0:N0}", number).Replace(",", ".");
            }

            // Đặt con trỏ về cuối TextBox
            txtFreelancerCost.SelectionStart = txtFreelancerCost.Text.Length;

            // Đăng ký lại sự kiện
            txtFreelancerCost.TextChanged += txtFreelancerCost_TextChanged;
        }

        private void txtAnotherCost_TextChanged(object? sender, EventArgs e)
        {
            // Tắt sự kiện để tránh vòng lặp vô hạn
            txtAnotherCost.TextChanged -= txtAnotherCost_TextChanged;

            // Xóa tất cả ký tự không phải số
            string input = new string(txtAnotherCost.Text.Where(char.IsDigit).ToArray());

            // Chuyển đổi chuỗi thành số và định dạng
            if (long.TryParse(input, out long number))
            {
                // Định dạng số với dấu phân cách
                txtAnotherCost.Text = string.Format("{0:N0}", number).Replace(",", ".");
            }

            // Đặt con trỏ về cuối TextBox
            txtAnotherCost.SelectionStart = txtAnotherCost.Text.Length;

            // Đăng ký lại sự kiện
            txtAnotherCost.TextChanged += txtAnotherCost_TextChanged;
        }

        private void txtFee_TextChanged(object? sender, EventArgs e)
        {
            // Tắt sự kiện để tránh vòng lặp vô hạn
            txtFee.TextChanged -= txtFee_TextChanged;

            // Xóa tất cả ký tự không phải số
            string input = new string(txtFee.Text.Where(char.IsDigit).ToArray());

            // Chuyển đổi chuỗi thành số và định dạng
            if (long.TryParse(input, out long number))
            {
                // Định dạng số với dấu phân cách
                txtFee.Text = string.Format("{0:N0}", number).Replace(",", ".");
            }

            // Đặt con trỏ về cuối TextBox
            txtFee.SelectionStart = txtFee.Text.Length;

            // Đăng ký lại sự kiện
            txtFee.TextChanged += txtFee_TextChanged;
        }

        private void txtFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự nhập vào có phải là số hay không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Nếu không phải số, ngăn không cho nhập
            }
        }
    }
}
