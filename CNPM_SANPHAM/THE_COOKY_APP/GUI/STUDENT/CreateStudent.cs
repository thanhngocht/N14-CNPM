using System.Globalization;
using THE_COOKY_APP.BLL;
using THE_COOKY_APP.DTO;

namespace THE_COOKY_APP.GUI.STUDENT
{
    public partial class CreateStudent : Form
    {
        private readonly StudentBLL studentBLL = new StudentBLL();
        private readonly DataValidator dataValidator = new DataValidator();
        public CreateStudent()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nameStudent = txtNameStudent.Text.Trim();
            if (string.IsNullOrEmpty(nameStudent) || !dataValidator.IsValidName(nameStudent))
            {
                MessageBox.Show("Họ tên không hợp lệ.");
                return;
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
                return;
            }

            string gmail = txtGmail.Text;
            // Kiểm tra định dạng email
            if (!dataValidator.IsValidEmail(gmail))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ email hợp lệ.");
                return;
            }

            string phoneNumber = txtPhoneNumber.Text;
            // Kiểm tra định dạng số điện thoại
            if (!dataValidator.IsPhoneNumber(phoneNumber))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại hợp lệ.");
                return;
            }

            string birth = txtDateOfBirth.Text;
            // Kiểm tra định dạng ngày bắt đầu
            DateTime date;
            if (!DateTime.TryParseExact(birth, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                MessageBox.Show("Vui lòng nhập ngày bắt đầu hợp lệ theo định dạng dd/MM/yyyy.");
                return;
            }

            DateTime dateTime = date;

            studentBLL.AddStudent(nameStudent, dateTime, gender, 1, 0, 1, gmail, phoneNumber);
            this.Close();
        }
    }
}
