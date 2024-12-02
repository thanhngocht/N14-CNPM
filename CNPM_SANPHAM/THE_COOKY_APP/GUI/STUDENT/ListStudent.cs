using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using THE_COOKY_APP.BLL;
using THE_COOKY_APP.DAO;
using THE_COOKY_APP.DTO;

namespace THE_COOKY_APP.GUI.STUDENT
{
    public partial class ListStudent : Form
    {
        private readonly UserFunctionBLL userFunctionBLL = new UserFunctionBLL();
        private readonly AccountBLL accountBLL = new AccountBLL();
        private readonly UserFunctionDTO userFunctionDTO;
        private readonly AccountDTO accountDTO;
        private readonly StudentBLL studentBLL = new StudentBLL();
        private bool isEditing = false;  // Biến để theo dõi trạng thái chỉnh sử
        private StudentDTO selectedStudent = new StudentDTO();
        private DataValidator dataValidator = new DataValidator();
        public ListStudent(string accountId)
        {
            InitializeComponent();
            LoadStudent();
            LoadComboBoxFilter();
            if (accountId == "")
            {
                return;
            }
            userFunctionDTO = userFunctionBLL.GetPermissionsByAccountId(accountId);
            accountDTO = accountBLL.GetAccountById(accountId);
        }

        private void LoadStudent()
        {
            List<StudentDTO> students = studentBLL.GetAllStudents();
            dgvListStudent.Rows.Clear(); // Xóa các dòng hiện tại trong DataGridView

            foreach (var student in students)
            {
                int rowIndex = dgvListStudent.Rows.Add();
                dgvListStudent.Rows[rowIndex].Cells[0].Value = student.IdStudent;
                dgvListStudent.Rows[rowIndex].Cells[1].Value = student.NameStudent;
                dgvListStudent.Rows[rowIndex].Cells[2].Value = student.PhoneNumber;
                dgvListStudent.Rows[rowIndex].Cells[3].Value = student.Gmail;
            }
            CheckAndShowEmptyMessage();
        }

        private void LoadComboBoxFilter()
        {
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.Items.Clear();
            cmbFilter.Items.Add("Tên học viên");
            cmbFilter.Items.Add("Gmail");
            cmbFilter.Items.Add("Số điện thoại");
            cmbFilter.SelectedIndex = 0;
        }

        private void ListStudent_Load(object sender, EventArgs e)
        {
            LoadStudent();
        }

        private void CheckAndShowEmptyMessage()
        {
            if (dgvListStudent.Rows.Count == 0)
            {
                int rowIndex = dgvListStudent.Rows.Add();
                dgvListStudent.Rows[rowIndex].Cells[0].Value = "Chưa có";
                dgvListStudent.Rows[rowIndex].Cells[1].Value = "Chưa có";
                dgvListStudent.Rows[rowIndex].Cells[2].Value = "Chưa có";
                dgvListStudent.Rows[rowIndex].Cells[3].Value = "Chưa có";
                dgvListStudent.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Black;
                dgvListStudent.Rows[rowIndex].DefaultCellStyle.Font = new Font(dgvListStudent.Font.FontFamily, 10, FontStyle.Bold);
                dgvListStudent.Rows[rowIndex].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvListStudent.Rows[rowIndex].ReadOnly = true;
            }
            else
            {
                if (dgvListStudent.Rows[0].Cells[0].Value.ToString() == "Chưa có")
                {
                    dgvListStudent.Rows.RemoveAt(0);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addStudentForm = new CreateStudent();
            if (addStudentForm.ShowDialog() == DialogResult.OK)
            {
                LoadStudent(); // Tải lại danh sách sau khi thêm
            }
        }

        private void dgvListStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string idStudent = dgvListStudent.Rows[e.RowIndex].Cells[0].Value.ToString() + "";
                if (idStudent == "")
                {
                    return;
                }
                StudentDTO studentDTO = studentBLL.GetStudentById(idStudent);
                if (studentDTO != null)
                {
                    txtNameStudent.Text = studentDTO.NameStudent;
                    txtGender.Text = studentDTO.Gender;
                    dtpDateOfBirth.Text = studentDTO.DateOfBirth.ToString();
                    txtPhoneNumber.Text = studentDTO.PhoneNumber;
                    txtGmail.Text = studentDTO.Gmail;
                    selectedStudent = studentDTO;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (userFunctionDTO.UpdateStudent) // Kiểm tra quyền truy cập
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
                    if (SaveStudent())
                    {
                        EnableEditing(false);
                        btnUpdate.Text = "Sửa"; // Đổi chữ về "Sửa"
                        isEditing = false;
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
            txtNameStudent.Enabled = enable;
            txtGmail.Enabled = enable;
            txtPhoneNumber.Enabled = enable;
            txtGender.Enabled = enable;
            dtpDateOfBirth.Enabled = enable;
            // Thêm các ô khác nếu cần
        }

        private bool SaveStudent()
        {
            string nameStudent = txtNameStudent.Text.Trim();

            if (string.IsNullOrEmpty(nameStudent) || !dataValidator.IsValidName(nameStudent))
            {
                MessageBox.Show("Họ tên không hợp.");
                return false;
            }

            string gender = txtGender.Text.Trim(); // Get the text and trim any whitespace

            if (gender.Equals("Nam", StringComparison.OrdinalIgnoreCase) ||
                gender.Equals("Nữ", StringComparison.OrdinalIgnoreCase))
            {
            }
            else
            {
                // Gender is invalid
                MessageBox.Show("Giới tính chỉ có thể là 'Nam' hoặc 'Nữ'.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string gmail = txtGmail.Text;
            // Kiểm tra định dạng email
            if (!dataValidator.IsValidEmail(gmail))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ email hợp lệ.");
                return false;
            }

            string phoneNumber = txtPhoneNumber.Text;
            // Kiểm tra định dạng số điện thoại
            if (!dataValidator.IsPhoneNumber(phoneNumber))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại hợp lệ.");
                return false;
            }

            string birth = dtpDateOfBirth.Text;
            // Kiểm tra định dạng ngày bắt đầu
            DateTime date;
            if (!DateTime.TryParseExact(birth, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                MessageBox.Show("Vui lòng nhập ngày bắt đầu hợp lệ theo định dạng dd/MM/yyyy.");
                return false;
            }

            DateTime dateTime = date;

            // Lưu thông tin vào BLL
            var studentToUpdate = new StudentDTO
            {
                IdStudent = selectedStudent.IdStudent,
                NameStudent = nameStudent,
                DateOfBirth = date,
                Gender = gender,
                IsMember = selectedStudent.IsMember,
                TotalPayment = selectedStudent.TotalPayment,
                Gmail = gmail, // Lấy ID từ dòng hiện tại
                PhoneNumber = phoneNumber,
                IsActive = selectedStudent.IsActive,
            };

            studentBLL.UpdateStudent(studentToUpdate); // Gọi phương thức cập nhật trong BLL
            LoadStudent(); // Tải lại danh sách để cập nhật
            return true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (userFunctionDTO.DeleteStudent) // Kiểm tra quyền truy cập
            {
                if (selectedStudent != null)
                {
                    DialogResult result = MessageBox.Show(
                        "Bạn có chắc chắn muốn xoá học viên này?",
                        "Xác nhận xóa học viên",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.OK)
                    {
                        studentBLL.DeleteStudent(selectedStudent.IdStudent);
                        LoadStudent(); // Tải lại danh sách sau khi xóa
                        selectedStudent = null; // Đặt lại đối tượng đã chọn
                    }

                }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (cmbFilter.SelectedItem == null)
            {
                return;
            }
            string searchTerm = txtSearch.Text;
            string property = cmbFilter.SelectedItem.ToString(); // Giả sử bạn có một ComboBox để chọn thuộc tính tìm kiếm
            List<StudentDTO> filteredStudents = studentBLL.SearchStudents(searchTerm, property);

            // Cập nhật DataGridView với danh sách sinh viên đã lọc
            dgvListStudent.Rows.Clear();
            foreach (var student in filteredStudents)
            {
                int rowIndex = dgvListStudent.Rows.Add();
                dgvListStudent.Rows[rowIndex].Cells[0].Value = student.IdStudent;
                dgvListStudent.Rows[rowIndex].Cells[1].Value = student.NameStudent;
                dgvListStudent.Rows[rowIndex].Cells[2].Value = student.PhoneNumber;
                dgvListStudent.Rows[rowIndex].Cells[3].Value = student.Gmail;
            }
            CheckAndShowEmptyMessage();
        }
    }
}