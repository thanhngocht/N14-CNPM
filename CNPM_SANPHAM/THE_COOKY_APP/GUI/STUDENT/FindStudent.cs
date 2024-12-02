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

namespace THE_COOKY_APP.GUI.STUDENT
{
    public partial class FindStudent : Form
    {
        private readonly StudentBLL studentBLL = new StudentBLL();
        private readonly StudentClassBLL studentClassBLL = new StudentClassBLL();
        public string IdStudent { get; private set; }
        private readonly string idClassroom;
        public FindStudent(string classroomId)
        {
            InitializeComponent();
            LoadComboBoxFilter();
            LoadStudent();
            idClassroom = classroomId;
            IdStudent = "";
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
            if (dgvListStudent.Rows.Count > 0)
            {
                IdStudent = dgvListStudent.Rows[0].Cells[0].Value.ToString() + "";
            }
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

        private void rpbAdd_Click(object sender, EventArgs e)
        {
            CreateStudent createStudent = new CreateStudent();
            createStudent.ShowDialog();
            LoadStudent();
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
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvListStudent.Rows.Count == 0 || IdStudent == "")
            {
                MessageBox.Show("Vui lòng chọn học viên");
                return;
            }
            if (studentClassBLL.IsStudentInClass(idClassroom, IdStudent)){
                MessageBox.Show("Học viên này đã có trong lớp");
                return;
            }
            this.DialogResult = DialogResult.OK; // Đặt kết quả của Form là OK
            this.Close(); // Đóng Form
        }

        private void dgvListStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                IdStudent = dgvListStudent.Rows[e.RowIndex].Cells[0].Value.ToString() + "";
            }
        }
    }
}
