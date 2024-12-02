using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THE_COOKY_APP.BLL;
using THE_COOKY_APP.DAO;
using THE_COOKY_APP.DTO;

namespace THE_COOKY_APP.GUI.REPORT
{
    public partial class ReportClass : Form
    {
        private readonly ClassroomBLL classroomBLL = new ClassroomBLL();
        private readonly NormalClassBLL normalClassBLL = new NormalClassBLL();
        private readonly FreeClassBLL freeClassBLL = new FreeClassBLL();
        private readonly StudentClassBLL studentClassBLL = new StudentClassBLL();
        private readonly StudentBLL studentBLL = new StudentBLL();
        private readonly ChefBLL chefBLL = new ChefBLL();
        private readonly LocationBLL locationBLL = new LocationBLL();
        private readonly TopicBLL topicBLL = new TopicBLL();
        private readonly ClassroomDTO classroomDTO;
        private readonly NormalClassDTO normalClassDTO;
        private readonly FreeClassDTO freeClassDTO;
        private string selectedStudent = "";
        private string selectedClass = "";
        private int cashBack = 0;
        private int oP = 0;
        private int cK = 0;
        private int credit = 0;
        private int cash = 0;
        private int totalExpenditure = 0;
        private int totalIncome = 0;
        private int fee = 0;
        public ReportClass(string classroomId)
        {
            InitializeComponent();
            this.Size = new Size(1500, 850);
            this.AutoScroll = true;
            this.Shown += new EventHandler(ReportClass_Shown); // Sử dụng sự kiện Shown
            classroomDTO = classroomBLL.GetClassroomById(classroomId);
            normalClassDTO = normalClassBLL.GetNormalClassById(classroomId);
            freeClassDTO = freeClassBLL.GetFreeClassById(classroomId);
            LoadComboBoxFilter();
            LoadClassroomDetails();
            LoadStudentClass();
            LoadTotalExpenditure();
            CalPayment();

        }

        private void CalPayment()
        {
            totalExpenditure = ConvertToInt(txtAnotherCost.Text) + ConvertToInt(txtCashBack.Text) + ConvertToInt(txtMaterialCost.Text) + ConvertToInt(txtChefCost.Text);
            totalIncome = ConvertToInt(txtOnlinePayment.Text) + ConvertToInt(txtBankTransfer.Text) + ConvertToInt(txtCredit.Text) + ConvertToInt(txtRemain.Text);

            FreeClassDTO free = freeClassBLL.GetFreeClassById(selectedClass);
            NormalClassDTO normal = normalClassBLL.GetNormalClassById(selectedClass);
            if (free != null)
            {
                totalIncome += Convert.ToInt32(normal.Fee);
            }
            btnTotalExpenditure.Text = ConvertToMoney(totalExpenditure.ToString());
            btnTotalIncome.Text = ConvertToMoney(totalIncome.ToString());
            int incom = totalIncome - totalExpenditure;
            if (incom < 0)
            {
                incom = 0;
            }
            btnIncome.Text = ConvertToMoney(incom.ToString());
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

        private void LoadComboBoxFilter()
        {
            List<ClassroomDTO> classroomDTOs = classroomBLL.GetClassroomByPicture(classroomDTO.Picture);
            cmbFilter.Items.Clear();
            foreach (ClassroomDTO classroomDTO in classroomDTOs)
            {
                cmbFilter.Items.Add(classroomDTO.StartDate.ToString("dd/MM/yyyy") + " " + classroomDTO.StartHour.ToString());
                cmbFilter.SelectedIndex = 0;
            }
            if (cmbFilter.SelectedIndex == 0)
            {
                string dateString = cmbFilter.Text;
                string[] date = dateString.Split(" ");
                if (date.Length == 2)
                {
                    // Parse the string into DateTime
                    DateTime startDate = DateTime.ParseExact(date[0], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                    // Extract the StartHour as TimeSpan
                    TimeSpan startHour = TimeSpan.Parse(date[1]);
                    ClassroomDTO classroom = classroomBLL.GetClassroomByCriteria(classroomDTO.Picture, startDate, startHour);
                    if (classroom != null)
                    {
                        selectedClass = classroom.IdClass;
                    }
                }
            }

        }

        private void LoadClassroomDetails()
        {
            if (selectedClass != "")
            {
                ClassroomDTO classroom = classroomBLL.GetClassroomById(selectedClass);
                if (classroom != null)
                {
                    cashBack = 0;
                    oP = 0;
                    cK = 0;
                    credit = 0;
                    cash = 0;
                    totalExpenditure = 0;
                    totalIncome = 0;

                    txtClassroom.Text = classroom.NameClass;
                    txtQuantity.Text = studentClassBLL.CountStudents(classroom.IdClass).ToString();
                    txtOnlinePayment.Text = ConvertToMoney(studentClassBLL.CalculateTotalPaymentByFormPayment(classroom.IdClass, "Online Payment").ToString());
                    txtBankTransfer.Text = ConvertToMoney(studentClassBLL.CalculateTotalPaymentByFormPayment(classroom.IdClass, "Chuyển khoản").ToString());
                    txtCredit.Text = ConvertToMoney(studentClassBLL.CalculateTotalPaymentByFormPayment(classroom.IdClass, "Credit").ToString());
                    txtRemain.Text = ConvertToMoney(studentClassBLL.CalculateTotalPaymentByFormPayment(classroom.IdClass, "Tiền mặt").ToString());
                }
            }

        }

        private void LoadStudentClass()
        {
            if (selectedClass != "")
            {
                ClassroomDTO classroom = classroomBLL.GetClassroomById(selectedClass);
                if (classroom != null)
                {
                    
                    List<StudentClassDTO> students = studentClassBLL.GetAllStudents(classroom.IdClass);
                    dgvListStudentInClass.Rows.Clear();
                    foreach (var student in students)
                    {
                        StudentDTO studentDTO = studentBLL.GetStudentById(student.IdStudent);
                        if (studentDTO != null)
                        {
                            int rowIndex = dgvListStudentInClass.Rows.Add();
                            dgvListStudentInClass.Rows[rowIndex].Cells[0].Value = studentDTO.IdStudent;
                            dgvListStudentInClass.Rows[rowIndex].Cells[1].Value = studentDTO.NameStudent;
                            dgvListStudentInClass.Rows[rowIndex].Cells[2].Value = student.Quantity.ToString();
                            dgvListStudentInClass.Rows[rowIndex].Cells[3].Value = ConvertToMoney(student.TotalPayment.ToString("0"));
                            dgvListStudentInClass.Rows[rowIndex].Cells[4].Value = student.StatusPayment;
                            cashBack += student.TotalPayment - CalTotalPaymentNeed(student);
                        }
                    }
                    txtCashBack.Text = ConvertToMoney(cashBack.ToString());
                    txtAnotherCost.Text = ConvertToMoney(classroom.AnotherCost.ToString());
                }
            }
            CheckAndShowEmptyMessage();
        }

        private int CalTotalPaymentNeed(StudentClassDTO studentClass)
        {
            if (selectedClass != "")
            {
                NormalClassDTO normalClass = normalClassBLL.GetNormalClassById(selectedClass);
                FreeClassDTO freeClass = freeClassBLL.GetFreeClassById(selectedClass);

                int quantity = studentClass.Quantity;
                int fee = 0;
                if (normalClass != null && freeClass == null)
                {
                    fee = Convert.ToInt32(normalClass.Fee);
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

                double step3 = step2 - step2 * ((deal) * 1.0 / 100);
                return step3 > 0 ? Convert.ToInt32(step3) : 0;
            }
            return 0;
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

        private void LoadTotalExpenditure()
        {
            if (selectedClass != "")
            {
                ClassroomDTO classroom = classroomBLL.GetClassroomById(selectedClass);
                var (totalQuantity, totalPayment) = studentClassBLL.CalculateTotalPaymentAndQuantity(classroom.IdClass);
                NormalClassDTO normalClass = normalClassBLL.GetNormalClassById(selectedClass);
                if (normalClass != null)
                {
                    txtChefCost.Text = ConvertToMoney((totalQuantity * 0.25 * Convert.ToInt32(normalClass.Fee)).ToString("0"));
                }
                txtMaterialCost.Text = ConvertToMoney(classroom.MaterialCost.ToString());
            }
        }

        private void ReportClass_Shown(object? sender, EventArgs e)
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

        private void ReportClass_Load(object sender, EventArgs e)
        {
            CheckAndShowEmptyMessage();
        }

        private void dgvListStudentInClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedStudent = dgvListStudentInClass.Rows[e.RowIndex].Cells[0].Value.ToString() + "";
            }
        }

        private void dgvListStudentInClass_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (selectedStudent != "" && selectedClass != "")
            {
                DetailStudentReportClass detailStudentReportClass = new DetailStudentReportClass(selectedClass, selectedStudent);
                detailStudentReportClass.ShowDialog();
            }
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilter.SelectedItem != null)
            {
                string dateString = cmbFilter.Text;
                string[] date = dateString.Split(" ");
                if (date.Length == 2)
                {
                    // Parse the string into DateTime
                    DateTime startDate = DateTime.ParseExact(date[0], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                    // Extract the StartHour as TimeSpan
                    TimeSpan startHour = TimeSpan.Parse(date[1]);
                    ClassroomDTO classroom = classroomBLL.GetClassroomByCriteria(classroomDTO.Picture, startDate, startHour);
                    if (classroom != null)
                    {
                        selectedClass = classroom.IdClass;
                        LoadClassroomDetails();
                        LoadStudentClass();
                        LoadTotalExpenditure();
                        CalPayment();
                    }
                }
            }
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
