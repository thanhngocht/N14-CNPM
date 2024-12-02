using THE_COOKY_APP.BLL;
using THE_COOKY_APP.DTO;
using THE_COOKY_APP.GUI.CLASSROOM;

namespace THE_COOKY_APP.GUI.STUDENT
{
    public partial class CreateStudentInClass : Form
    {
        private ClassroomBLL classroomBLL = new ClassroomBLL();
        private readonly NormalClassBLL normalClassBLL = new NormalClassBLL();
        private readonly FreeClassBLL freeClassBLL = new FreeClassBLL();
        private StudentClassBLL studentClassBLL = new StudentClassBLL();
        private StudentBLL studentBLL = new StudentBLL();
        private readonly LocationBLL locationBLL = new LocationBLL();
        private ClassroomDTO classroomDTO;
        private readonly NormalClassDTO normalClassDTO;
        private readonly FreeClassDTO freeClassDTO;
        private StudentDTO studentDTO;
        private string? idStudent = null;
        private int fee = 0;
        public CreateStudentInClass(string classroomId)
        {
            InitializeComponent();
            this.Size = new Size(1500, 820);
            this.AutoScroll = true;
            this.Shown += new EventHandler(CreateStudentInClass_Scroll);
            classroomDTO = classroomBLL.GetClassroomById(classroomId);
            normalClassDTO = normalClassBLL.GetNormalClassById(classroomId);
            freeClassDTO = freeClassBLL.GetFreeClassById(classroomId);
            cmbFormPayment.Enabled = false;
            LoadClassroom();
            LoadComboBox();
        }

        private void LoadClassroom()
        {
            if (classroomDTO != null)
            {
                txtNameClassroom.Text = classroomDTO.NameClass;
                if (freeClassDTO == null)
                {
                    fee = Convert.ToInt32(normalClassDTO.Fee);
                    txtFee.Text = ConvertToMoney(fee.ToString("0"));
                }
                else
                {
                    txtFee.Text = "0";
                }
                txtPresentQuantity.Text = studentClassBLL.CountStudents(classroomDTO.IdClass).ToString();
            }
        }

        private void LoadComboBox()
        {
            cmbFormPayment.Items.Clear();
            cmbFormPayment.Items.Add("Chuyển khoản");
            cmbFormPayment.Items.Add("Tiền mặt");
            cmbFormPayment.Items.Add("Online Payment");
            cmbFormPayment.Items.Add("Credit");
        }
        private void CreateStudentInClass_Scroll(object? sender, EventArgs e)
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

        private void rpbAdd_Click(object sender, EventArgs e)
        {
            using (FindStudent findStudent = new FindStudent(classroomDTO.IdClass))
            {
                // Hiển thị Form PickTime và kiểm tra kết quả
                if (findStudent.ShowDialog() == DialogResult.OK)
                {
                    // Nhận thời gian đã chọn từ Form PickTime
                    idStudent = findStudent.IdStudent;
                    if (idStudent != null)
                    {
                        studentDTO = studentBLL.GetStudentById(idStudent);
                        txtNameStudent.Text = studentDTO.NameStudent;
                        txtPhoneNumber.Text = studentDTO.PhoneNumber;
                    }
                }
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (idStudent == null)
            {
                MessageBox.Show("Bạn vui lòng chọn học viên.");
                return;
            }

            int quantity = GetValueFromTextBox(txtQuantityRegister);
            string form = cmbFormPayment.Text + "";
            string totalpayment = txtTotalPayment.Text;
            int app = GetValueFromTextBox(txtApp);
            int voucher = GetValueFromTextBox(txtVoucher);
            int cash = GetValueFromTextBox(txtCash);
            int code = GetValueFromTextBox(txtCodeMember);
            int deal = GetValueFromTextBox(txtDeal);

            string status = "Đã thanh toán";
            if (string.IsNullOrWhiteSpace(txtTotalPayment.Text))
            {
                status = "Chưa thanh toán";
                totalpayment = "0";
            }
            int totalNeed = ConvertToInt(txtTotalPaymentNeed.Text);

            int total = ConvertToInt(totalpayment);

            if (total < totalNeed)
            {
                status = "Chưa thanh toán";
            }

            var studentClassDTO = new StudentClassDTO()
            {
                StatusPayment = status,
                Quantity = quantity,
                FormPayment = form,
                AppDiscount = app,
                VoucherDiscount = voucher,
                CodeMemberDiscount = code,
                Cash = cash,
                DealDiscount = deal,
                TotalPayment = total,
                IdClass = classroomDTO.IdClass,
                IdStudent = studentDTO.IdStudent,
            };
            studentClassBLL.AddStudent(studentClassDTO);
            this.Close();
        }

        private void txtTotalPayment_TextChanged(object? sender, EventArgs e)
        {
            // Kiểm tra xem ô textbox có rỗng hoặc chỉ chứa khoảng trắng không
            if (string.IsNullOrWhiteSpace(txtTotalPayment.Text))
            {
                // Nếu rỗng, tắt cmbFormPayment
                cmbFormPayment.Enabled = false;
                cmbFormPayment.SelectedIndex = -1;
            }
            else
            {
                // Nếu không rỗng, bật cmbFormPayment
                if (!cmbFormPayment.Enabled)
                {
                    cmbFormPayment.SelectedIndex = 0;
                }
                cmbFormPayment.Enabled = true;
                // Tắt sự kiện để tránh vòng lặp vô hạn
                txtTotalPayment.TextChanged -= txtTotalPayment_TextChanged;

                // Xóa tất cả ký tự không phải số
                string input = new string(txtTotalPayment.Text.Where(char.IsDigit).ToArray());

                // Chuyển đổi chuỗi thành số và định dạng
                if (long.TryParse(input, out long number))
                {
                    // Định dạng số với dấu phân cách
                    txtTotalPayment.Text = string.Format("{0:N0}", number).Replace(",", ".");
                }

                // Đặt con trỏ về cuối TextBox
                txtTotalPayment.SelectionStart = txtTotalPayment.Text.Length;

                // Đăng ký lại sự kiện
                txtTotalPayment.TextChanged += txtTotalPayment_TextChanged;
            }
        }

        private void txtTotalPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự nhập vào có phải là số hay không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Nếu không phải số, ngăn không cho nhập
            }
        }

        private void txtApp_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự nhập vào có phải là số hay không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Nếu không phải số, ngăn không cho nhập
            }
        }

        private void txtVoucher_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự nhập vào có phải là số hay không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Nếu không phải số, ngăn không cho nhập
            }
        }

        private void txtApp_Leave(object sender, EventArgs e)
        {
            ValidateInput(txtApp);
        }

        private void txtCash_Leave(object sender, EventArgs e)
        {
            // Kiểm tra giá trị nhập vào
            if (int.TryParse(txtCash.Text, out int value))
            {
                if (value < 0)
                {
                    MessageBox.Show("Vui lòng nhập số trong khoảng từ 0 đến 100.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCash.Clear(); // Xóa ô nếu giá trị không hợp lệ
                    txtCash.Focus(); // Đặt lại tiêu điểm vào ô nhập
                }
                else
                {
                    CalTotalPaymentNeed();
                }
            }
            if (string.IsNullOrWhiteSpace(txtCash.Text))
            {
                txtCash.Text = "0";
            }
        }

        private void txtCodeMember_Leave(object sender, EventArgs e)
        {
            ValidateInput(txtCodeMember);
        }

        // Hàm kiểm tra giá trị nhập vào chung
        private void ValidateInput(Control control)
        {
            // Kiểm tra xem control có phải là TextBox không
            if (control is System.Windows.Forms.TextBox textBox)
            {
                // Kiểm tra giá trị nhập vào
                if (int.TryParse(textBox.Text, out int value))
                {
                    if (value < 0 || value > 100)
                    {
                        MessageBox.Show("Vui lòng nhập số trong khoảng từ 0 đến 100.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBox.Clear(); // Xóa ô nếu giá trị không hợp lệ
                        textBox.Focus(); // Đặt lại tiêu điểm vào ô nhập
                    }
                    else
                    {
                        CalTotalPaymentNeed();
                    }
                }
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = "0";
                }
            }
            else
            {
                MessageBox.Show("Control không phải là TextBox.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void txtCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự nhập vào có phải là số hay không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Nếu không phải số, ngăn không cho nhập
            }
        }

        private void txtCodeMember_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự nhập vào có phải là số hay không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Nếu không phải số, ngăn không cho nhập
            }
        }

        private void txtVoucher_Leave(object sender, EventArgs e)
        {
            ValidateInput(txtVoucher);
        }

        private void txtDeal_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự nhập vào có phải là số hay không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Nếu không phải số, ngăn không cho nhập
            }
        }

        private void txtDeal_Leave(object sender, EventArgs e)
        {
            ValidateInput(txtDeal);
        }

        private void txtQuantityRegister_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự nhập vào có phải là số hay không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Nếu không phải số, ngăn không cho nhập
            }
        }

        private void txtQuantityRegister_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem giá trị trong txtQuantityRegister có phải là số hay không
            if (int.TryParse(txtQuantityRegister.Text, out int quantity))
            {
                // Lấy giá trị từ txtFee
                if (decimal.TryParse(txtFee.Text, out decimal fee))
                {
                    // Tính toán tổng số tiền cần thanh toán
                    // Hiển thị kết quả trong txtTotalPaymentNeed
                    CalTotalPaymentNeed();
                }
                else
                {
                    // Nếu txtFee không phải là số, có thể xóa txtTotalPaymentNeed
                    txtTotalPaymentNeed.Text = "0";
                }
            }
            else
            {
                // Nếu giá trị không hợp lệ, có thể xóa txtTotalPaymentNeed
                txtTotalPaymentNeed.Text = "0";
            }
        }

        private void CalTotalPaymentNeed()
        {
            int quantity = GetValueFromTextBox(txtQuantityRegister);
            int realQuantity = studentClassBLL.CountStudents(classroomDTO.IdClass);
            string idLocation = locationBLL.GetLocationIdByName(classroomDTO.NameLocation);
            LocationDTO locationDTO = locationBLL.GetLocationById(idLocation);

            if (quantity + realQuantity > locationDTO.MaxLocationQuantity)
            {
                MessageBox.Show("Số lượng vượt quá sức chứa cả địa điểm");
                return;
            }


            int fee = GetValueFromTextBox(txtFee);
            int code = GetValueFromTextBox(txtCodeMember);
            int voucher = GetValueFromTextBox(txtVoucher);
            int app = GetValueFromTextBox(txtApp);
            int cash = GetValueFromTextBox(txtCash);
            int deal = GetValueFromTextBox(txtDeal);

            double discountRate = GetDiscountRate(quantity);
            double totalAmount = quantity * fee;
            double step1 = totalAmount - totalAmount * discountRate;

            if (step1 <= 0)
            {
                txtTotalPaymentNeed.Text = "0";
                return;
            }

            double step2 = step1 - ((code + voucher + app) * 1.0 / 100) * step1 - cash;
            if (step2 <= 0)
            {
                txtTotalPaymentNeed.Text = "0";
                return;
            }

            double step3 = step2 - step2 * ((deal) * 1.0 / 100);
            txtTotalPaymentNeed.Text = ConvertToMoney(step3 > 0 ? step3.ToString("0") : "0").ToString();
        }

        private int GetValueFromTextBox(TextBox textBox)
        {

            string cleanedInput = new string(textBox.Text.Where(char.IsDigit).ToArray());
            return string.IsNullOrWhiteSpace(cleanedInput) ? 0 : Convert.ToInt32(cleanedInput);
        }

        private double GetDiscountRate(int quantity)
        {
            if (quantity >= 4) return 0.2;
            if (quantity == 3) return 0.15;
            if (quantity == 2) return 0.1;
            return 0;
        }

        private string ConvertToMoney(string inputInt)
        {
            // Xóa tất cả ký tự không phải số
            string input = new string(inputInt.Where(char.IsDigit).ToArray());

            // Chuyển đổi chuỗi thành số và định dạng
            if (long.TryParse(input, out long number))
            {
                // Định dạng số với dấu phân cách
                return string.Format("{0:N0}", number).Replace(",", ".");
            }
            return "0";
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

        private void txtCash_TextChanged(object? sender, EventArgs e)
        {
            // Tắt sự kiện để tránh vòng lặp vô hạn
            txtCash.TextChanged -= txtCash_TextChanged;

            // Xóa tất cả ký tự không phải số
            string input = new string(txtCash.Text.Where(char.IsDigit).ToArray());

            // Chuyển đổi chuỗi thành số và định dạng
            if (long.TryParse(input, out long number))
            {
                // Định dạng số với dấu phân cách
                txtCash.Text = string.Format("{0:N0}", number).Replace(",", ".");
            }

            // Đặt con trỏ về cuối TextBox
            txtCash.SelectionStart = txtCash.Text.Length;

            // Đăng ký lại sự kiện
            txtCash.TextChanged += txtCash_TextChanged;
        }
    }
}
