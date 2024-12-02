using Microsoft.Identity.Client;
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
using THE_COOKY_APP.GUI.LOCATION;

namespace THE_COOKY_APP.GUI.STUDENT
{
    public partial class ListStudentInClass : Form
    {
        private readonly UserFunctionBLL userFunctionBLL = new UserFunctionBLL();
        private readonly AccountBLL accountBLL = new AccountBLL();
        private readonly UserFunctionDTO userFunctionDTO;
        private readonly AccountDTO accountDTO;
        private readonly ClassroomBLL classroomBLL = new ClassroomBLL();
        private readonly StudentClassBLL studentClassBLL = new StudentClassBLL();
        private readonly NormalClassBLL normalClassBLL = new NormalClassBLL();
        private readonly FreeClassBLL freeClassBLL = new FreeClassBLL();
        private readonly StudentBLL studentBLL = new StudentBLL();
        private readonly ClassroomDTO classroomDTO;
        private readonly NormalClassDTO normalClassDTO;
        private readonly FreeClassDTO freeClassDTO;
        private string selectedStudentInClass = "";
        public ListStudentInClass(string classroomId, string accountId)
        {
            InitializeComponent();
            this.Size = new Size(1360, 850);
            this.AutoScroll = true;
            this.Shown += new EventHandler(ListStudentInClass_Shown);
            classroomDTO = classroomBLL.GetClassroomById(classroomId);
            normalClassDTO = normalClassBLL.GetNormalClassById(classroomId);
            freeClassDTO = freeClassBLL.GetFreeClassById(classroomId);
            LoadClassroom();
            LoadStudentClass();
            LoadComboBoxFilter();
            if (accountId == "")
            {
                return;
            }
            userFunctionDTO = userFunctionBLL.GetPermissionsByAccountId(accountId);
            accountDTO = accountBLL.GetAccountById(accountId);
        }

        private void LoadComboBoxFilter()
        {
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.Items.Clear();
            cmbFilter.Items.Add("Tên học viên");
            cmbFilter.Items.Add("Số lượng đăng kí");
            cmbFilter.Items.Add("Số điện thoại");
            cmbFilter.SelectedIndex = 0;
        }

        private void LoadClassroom()
        {
            if (classroomDTO != null)
            {
                txtNameClassroom.Text = classroomDTO.NameClass;
                if (normalClassDTO != null)
                {
                    txtFee.Text = ConvertToMoney(normalClassDTO.Fee.ToString("0"));
                }
                else
                {
                    txtFee.Text = "0";
                }
                txtPresentQuantity.Text = studentClassBLL.CountStudents(classroomDTO.IdClass).ToString();
            }
        }

        private void LoadStudentClass()
        {
            if (classroomDTO != null)
            {
                List<StudentClassDTO> students = studentClassBLL.GetAllStudents(classroomDTO.IdClass);
                dgvListStudentInClass.Rows.Clear();
                foreach (var student in students)
                {
                    StudentDTO studentDTO = studentBLL.GetStudentById(student.IdStudent);
                    if (studentDTO != null)
                    {
                        int rowIndex = dgvListStudentInClass.Rows.Add();
                        dgvListStudentInClass.Rows[rowIndex].Cells[0].Value = studentDTO.NameStudent;
                        dgvListStudentInClass.Rows[rowIndex].Cells[1].Value = studentDTO.PhoneNumber;
                        dgvListStudentInClass.Rows[rowIndex].Cells[2].Value = student.Quantity;
                        dgvListStudentInClass.Rows[rowIndex].Cells[3].Value = ConvertToMoney(CalTotalPaymentNeed(student).ToString("0"));
                        dgvListStudentInClass.Rows[rowIndex].Cells[4].Value = studentDTO.IdStudent;
                        dgvListStudentInClass.Rows[rowIndex].Cells[5].Value = ConvertToMoney(student.TotalPayment.ToString("0"));
                    }
                }
                CheckAndShowEmptyMessage();
            }
        }
        private void ListStudentInClass_Shown(object? sender, EventArgs e)
        {
            UpdateScrollPosition();
            this.AutoScrollPosition = new Point(0, 0);
        }

        private void UpdateScrollPosition()
        {
            int totalHeight = 0;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.Visible)
                {
                    totalHeight = Math.Max(totalHeight, ctrl.Bottom);
                }
            }

            this.AutoScrollMargin = new Size(0, 40);
        }

        private void CheckAndShowEmptyMessage()
        {
            if (dgvListStudentInClass.Rows.Count == 0)
            {
                int rowIndex = dgvListStudentInClass.Rows.Add();
                dgvListStudentInClass.Rows[rowIndex].Cells[0].Value = "Chưa có";
                dgvListStudentInClass.Rows[rowIndex].Cells[1].Value = "Chưa có";
                dgvListStudentInClass.Rows[rowIndex].Cells[2].Value = "Chưa có";
                dgvListStudentInClass.Rows[rowIndex].Cells[3].Value = "Chưa có";
                dgvListStudentInClass.Rows[rowIndex].Cells[4].Value = "Chưa có";
                dgvListStudentInClass.Rows[rowIndex].Cells[5].Value = "Chưa có";
                // Thiết lập định dạng cho dòng thông báo
                dgvListStudentInClass.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Black;
                dgvListStudentInClass.Rows[rowIndex].DefaultCellStyle.Font = new Font(dgvListStudentInClass.Font.FontFamily, 10, FontStyle.Bold); // FontSize 10 và Semibold
                dgvListStudentInClass.Rows[rowIndex].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvListStudentInClass.Rows[rowIndex].ReadOnly = true; // Ngăn người dùng chỉnh sửa dòng thông báo 

            }
            else
            {
                // Nếu có dữ liệu, xóa dòng thông báo nếu tồn tại
                if (dgvListStudentInClass.Rows[0].Cells[0].Value.ToString() == "Chưa có")
                {
                    dgvListStudentInClass.Rows.RemoveAt(0);
                }
            }
        }

        private void ListStudentInClass_Load(object sender, EventArgs e)
        {
            CheckAndShowEmptyMessage();
            LoadClassroom();
            LoadStudentClass();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (userFunctionDTO.InsertStudent) // Kiểm tra quyền truy cập
            {
                CreateStudentInClass createStudentInClass = new CreateStudentInClass(classroomDTO.IdClass);
                createStudentInClass.ShowDialog();
                LoadStudentClass();
                LoadClassroom();
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
                MessageBox.Show("Vui lòng chọn một thuộc tính để tìm kiếm.");
                return; // Thoát khỏi hàm nếu không có mục nào được chọn
            }
            var searchTerm = txtSearch.Text;
            var propertyItem = cmbFilter.SelectedItem.ToString();

            var students = studentClassBLL.SearchStudentClass(classroomDTO.IdClass, searchTerm, propertyItem);

            dgvListStudentInClass.Rows.Clear();

            foreach (var student in students)
            {
                StudentDTO studentDTO = studentBLL.GetStudentById(student.IdStudent);
                if (studentDTO != null)
                {
                    int rowIndex = dgvListStudentInClass.Rows.Add();
                    dgvListStudentInClass.Rows[rowIndex].Cells[0].Value = studentDTO.NameStudent;
                    dgvListStudentInClass.Rows[rowIndex].Cells[1].Value = studentDTO.PhoneNumber;
                    dgvListStudentInClass.Rows[rowIndex].Cells[2].Value = student.Quantity;
                    dgvListStudentInClass.Rows[rowIndex].Cells[3].Value = ConvertToMoney(CalTotalPaymentNeed(student).ToString("0"));
                    dgvListStudentInClass.Rows[rowIndex].Cells[4].Value = studentDTO.IdStudent;
                    dgvListStudentInClass.Rows[rowIndex].Cells[5].Value = ConvertToMoney(student.TotalPayment.ToString("0"));
                }
            }

            CheckAndShowEmptyMessage();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (userFunctionDTO.DeleteStudent) // Kiểm tra quyền truy cập
            {
                if (selectedStudentInClass == "")
                {
                    return;
                }
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xoá học viên này khỏi lớp?",
                    "Xác nhận xóa học viên",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.OK)
                {
                    studentClassBLL.DeleteStudent(classroomDTO.IdClass, selectedStudentInClass);
                    selectedStudentInClass = "";
                    LoadStudentClass();
                    LoadClassroom();
                }
                
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void dgvListStudentInClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedStudentInClass = dgvListStudentInClass.Rows[e.RowIndex].Cells[4].Value.ToString() + "";
            }
        }

        private void dgvListStudentInClass_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (selectedStudentInClass != "")
            {
                DetailStudentInClass detailStudentInClass = new DetailStudentInClass(classroomDTO.IdClass, selectedStudentInClass, accountDTO.IdAccount);
                detailStudentInClass.ShowDialog();
                LoadClassroom();
                LoadStudentClass();
                LoadComboBoxFilter();
            }
        }
        private int CalTotalPaymentNeed(StudentClassDTO studentClass)
        {
            int quantity = studentClass.Quantity;
            int fee = 0;
            if (normalClassDTO != null && freeClassDTO == null)
            {
                 fee = Convert.ToInt32(normalClassDTO.Fee);
            }
            else
            {
                return 0;
            }
            int code = studentClass.CodeMemberDiscount;
            int voucher = studentClass.VoucherDiscount;
            int app = studentClass.AppDiscount;
            int cash = studentClass.Cash;
            int deal = studentClass.DealDiscount;

            double discountRate = GetDiscountRate(quantity);
            double totalAmount = quantity * fee;
            double step1 = totalAmount - totalAmount * discountRate;

            if (step1 <= 0)
            {
                return 0;
            }

            double step2 = step1 - ((code + voucher + app) * 1.0 / 100) * step1 - cash;
            if (step2 <= 0)
            {
                return 0;
            }

            double step3 = step2 - step2 * deal;
            return step3 > 0 ? Convert.ToInt32(step3) : 0;
        }

        private int GetValueFromTextBox(TextBox textBox)
        {
            return string.IsNullOrWhiteSpace(textBox.Text) ? 0 : Convert.ToInt32(textBox.Text);
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


    }
}
