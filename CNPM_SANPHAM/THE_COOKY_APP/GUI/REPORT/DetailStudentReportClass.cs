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

namespace THE_COOKY_APP.GUI.REPORT
{
    public partial class DetailStudentReportClass : Form
    {
        private readonly ClassroomBLL classroomBLL = new ClassroomBLL();
        private readonly NormalClassBLL normalClassBLL = new NormalClassBLL();
        private readonly FreeClassBLL freeClassBLL = new FreeClassBLL();
        private readonly StudentBLL studentBLL = new StudentBLL();
        private readonly StudentClassBLL studentClassBLL = new StudentClassBLL();
        private readonly ClassroomDTO classroomDTO;
        private readonly NormalClassDTO normalClassDTO;
        private readonly FreeClassDTO freeClassDTO;
        private readonly StudentDTO studentDTO;
        private readonly StudentClassDTO studentClassDTO;
        public DetailStudentReportClass(string classroomId, string studentId)
        {
            InitializeComponent();
            classroomDTO = classroomBLL.GetClassroomById(classroomId);
            normalClassDTO = normalClassBLL.GetNormalClassById(classroomId);
            freeClassDTO = freeClassBLL.GetFreeClassById(classroomId);
            studentDTO = studentBLL.GetStudentById(studentId);
            studentClassDTO = studentClassBLL.GetStudentClassByClassIdAndStudentId(classroomId, studentId);
            LoadClassroom();
            LoadStudent();
            CalTotalPaymentNeed();
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
            }
        }

        private void LoadStudent()
        {
            if (studentDTO != null)
            {
                txtNameStudent.Text = studentDTO.NameStudent;
                txtPhoneNumber.Text = studentDTO.PhoneNumber;
                txtQuantity.Text = studentClassDTO.Quantity.ToString();
            }
        }

        private void CalTotalPaymentNeed()
        {
            int quantity = studentClassDTO.Quantity;
            int fee = Convert.ToInt32(normalClassDTO.Fee);
            int code = studentClassDTO.CodeMemberDiscount;
            int voucher = studentClassDTO.VoucherDiscount;
            int app = studentClassDTO.AppDiscount;
            int cash = studentClassDTO.Cash;
            int deal = studentClassDTO.DealDiscount;
            double discountRate = GetDiscountRate(quantity);

            txtCbo.Text = ConvertToMoney((discountRate * 100).ToString("0"));
            txtCodeMember.Text = code.ToString("0");
            txtVoucher.Text = voucher.ToString("0");
            txtApp.Text = app.ToString("0");
            txtCash.Text = ConvertToMoney(cash.ToString("0"));
            txtDiscountForPayFirst.Text = deal.ToString("0");

            double totalAmount = quantity * fee;
            double step1 = totalAmount - totalAmount * discountRate;
            btnFeeDefualt.Text = ConvertToMoney(totalAmount.ToString("0"));
            if (step1 <= 0)
            {
                btnFeeAfterStep1.Text = "0";
            }
            btnFeeAfterStep1.Text = ConvertToMoney(step1.ToString("0"));
            double step2 = step1 - ((code + voucher + app) * 1.0 / 100) * step1 - cash;
            if (step2 <= 0)
            {
                btnFeeAfterStep2.Text = "0";
            }
            btnFeeAfterStep2.Text = ConvertToMoney(step2.ToString("0"));
            double step3 = step2 - step2 * ((deal) * 1.0 / 100);
            btnFinalFee.Text = ConvertToMoney(step3 > 0 ? step3.ToString("0") : "0");
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
