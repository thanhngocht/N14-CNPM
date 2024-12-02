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
using THE_COOKY_APP.DAO;
using THE_COOKY_APP.DTO;
using THE_COOKY_APP.GUI.ACCOUNT;
using THE_COOKY_APP.GUI.LOCATION;
using THE_COOKY_APP.GUI.STUDENT;

namespace THE_COOKY_APP.GUI.CLASSROOM
{
    public partial class ListClassroom : Form
    {
        private readonly UserFunctionBLL userFunctionBLL = new UserFunctionBLL();
        private readonly AccountBLL accountBLL = new AccountBLL();
        private readonly UserFunctionDTO userFunctionDTO;
        private readonly AccountDTO accountDTO;
        private ClassroomBLL classroomBLL = new ClassroomBLL();
        private readonly NormalClassBLL normalClassBLL = new NormalClassBLL();
        private readonly FreeClassBLL freeClassBLL = new FreeClassBLL();
        private StudentClassBLL studentClassBLL = new StudentClassBLL();
        private string selectedClassroom = "";
        public ListClassroom(string accountId)
        {
            InitializeComponent();
            LoadClassrooms();
            LoadComboBoxFilter();
            if (accountId == "")
            {
                return;
            }
            userFunctionDTO = userFunctionBLL.GetPermissionsByAccountId(accountId);
            accountDTO = accountBLL.GetAccountById(accountId);
        }

        private void LoadClassrooms()
        {
            List<ClassroomDTO> classrooms = classroomBLL.GetAllClassrooms(); // Lấy danh sách lớp học

            dgvListClassroom.Rows.Clear(); // Xóa các dòng hiện tại trong DataGridView

            foreach (var classroom in classrooms)
            {
                NormalClassDTO normalClassDTO = normalClassBLL.GetNormalClassById(classroom.IdClass);
                FreeClassDTO freeClassDTO = freeClassBLL.GetFreeClassById(classroom.IdClass);
                int rowIndex = dgvListClassroom.Rows.Add(); // Thêm dòng mới
                dgvListClassroom.Rows[rowIndex].Cells[0].Value = classroom.NameClass; // Tên lớp
                dgvListClassroom.Rows[rowIndex].Cells[1].Value = classroom.NameChef; // Tên đầu bếp
                if (normalClassDTO != null)
                {
                    dgvListClassroom.Rows[rowIndex].Cells[2].Value = normalClassDTO.Fee.ToString("0");
                }
                else
                {
                    dgvListClassroom.Rows[rowIndex].Cells[2].Value = "0";
                }
                dgvListClassroom.Rows[rowIndex].Cells[3].Value = classroom.NameLocation; // Địa điểm
                dgvListClassroom.Rows[rowIndex].Cells[4].Value = classroom.QuantityArise; // Số lượng tối đa
                List<ClassroomDTO> classroomDTOs = classroomBLL.GetClassroomByPicture(classroom.Picture);
                dgvListClassroom.Rows[rowIndex].Cells[5].Value = classroomDTOs.Count; // Số lượng thực tế
                dgvListClassroom.Rows[rowIndex].Cells[6].Value = classroom.IdClass; // Id
            }
            CheckAndShowEmptyMessage();
        }

        private void LoadComboBoxFilter()
        {
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.Items.Clear();
            cmbFilter.Items.Add("Lớp học");
            cmbFilter.Items.Add("Giáo viên");
            cmbFilter.Items.Add("Địa điểm");
            cmbFilter.Items.Add("Số lượng");
            cmbFilter.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (userFunctionDTO.InsertClass) // Kiểm tra quyền truy cập
            {
                CreateClassroom createClassroom = new CreateClassroom();
                createClassroom.ShowDialog();
                LoadClassrooms();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CheckAndShowEmptyMessage()
        {
            if (dgvListClassroom.Rows.Count == 0)
            {
                int rowIndex = dgvListClassroom.Rows.Add();
                dgvListClassroom.Rows[rowIndex].Cells[0].Value = "Chưa có";
                dgvListClassroom.Rows[rowIndex].Cells[1].Value = "Chưa có";
                dgvListClassroom.Rows[rowIndex].Cells[2].Value = "Chưa có";
                dgvListClassroom.Rows[rowIndex].Cells[3].Value = "Chưa có";
                dgvListClassroom.Rows[rowIndex].Cells[4].Value = "Chưa có";
                dgvListClassroom.Rows[rowIndex].Cells[5].Value = "Chưa có";
                dgvListClassroom.Rows[rowIndex].Cells[6].Value = "Chưa có";
                // Thiết lập định dạng cho dòng thông báo
                dgvListClassroom.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Black;
                dgvListClassroom.Rows[rowIndex].DefaultCellStyle.Font = new Font(dgvListClassroom.Font.FontFamily, 10, FontStyle.Bold); // FontSize 10 và Semibold
                dgvListClassroom.Rows[rowIndex].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvListClassroom.Rows[rowIndex].ReadOnly = true; // Ngăn người dùng chỉnh sửa dòng thông báo 

            }
            else
            {
                // Nếu có dữ liệu, xóa dòng thông báo nếu tồn tại
                if (dgvListClassroom.Rows[0].Cells[0].Value.ToString() == "Chưa có")
                {
                    dgvListClassroom.Rows.RemoveAt(0);
                }
            }
        }

        private void ListClassroom_Load(object sender, EventArgs e)
        {
            CheckAndShowEmptyMessage();
            LoadClassrooms();
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
            var classrooms = classroomBLL.SearchClassrooms(searchTerm, propertyItem);
            dgvListClassroom.Rows.Clear(); // Xóa các dòng hiện tại trong DataGridView

            foreach (var classroom in classrooms)
            {
                NormalClassDTO normalClassDTO = normalClassBLL.GetNormalClassById(classroom.IdClass);
                FreeClassDTO freeClassDTO = freeClassBLL.GetFreeClassById(classroom.IdClass);
                int rowIndex = dgvListClassroom.Rows.Add(); // Thêm dòng mới
                dgvListClassroom.Rows[rowIndex].Cells[0].Value = classroom.NameClass; // Tên lớp
                dgvListClassroom.Rows[rowIndex].Cells[1].Value = classroom.NameChef; // Tên đầu bếp
                if (normalClassDTO != null)
                {
                    dgvListClassroom.Rows[rowIndex].Cells[2].Value = normalClassDTO.Fee.ToString("0");
                }
                else
                {
                    dgvListClassroom.Rows[rowIndex].Cells[2].Value = "0";
                }
                dgvListClassroom.Rows[rowIndex].Cells[3].Value = classroom.NameLocation; // Địa điểm
                dgvListClassroom.Rows[rowIndex].Cells[4].Value = classroom.QuantityArise; // Số lượng tối đa
                List<ClassroomDTO> classroomDTOs = classroomBLL.GetClassroomByPicture(classroom.Picture);
                dgvListClassroom.Rows[rowIndex].Cells[5].Value = classroomDTOs.Count; // Số lượng thực tế
                dgvListClassroom.Rows[rowIndex].Cells[6].Value = classroom.IdClass; // Id
            }

            selectedClassroom = "";
            CheckAndShowEmptyMessage();
        }

        private void dgvListClassroom_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có nhấp vào ô hợp lệ không
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy ID tài khoản từ dòng đã chọn
                string classroomId = dgvListClassroom.Rows[e.RowIndex].Cells[6].Value.ToString() + "";
                if (classroomId != "Chưa có")
                {
                    // Mở form DetailAccount và truyền ID tài khoản
                    DetailClassroom detailClassroom = new DetailClassroom(classroomId, accountDTO.IdAccount);
                    detailClassroom.ShowDialog();
                    LoadClassrooms();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (selectedClassroom == "")
            {
                return;
            }
            ClassroomDTO classroomDTO = classroomBLL.GetClassroomById(selectedClassroom);
            NormalClassDTO normalClassDTO = normalClassBLL.GetNormalClassById(selectedClassroom);
            FreeClassDTO freeClassDTO = freeClassBLL.GetFreeClassById(selectedClassroom);
            string imgPath = classroomDTO.Picture;
            studentClassBLL.DeleteStudentClass(selectedClassroom);
            if (normalClassDTO != null)
            {
                normalClassBLL.DeleteNormalClass(selectedClassroom);

            }
            else
            {
                freeClassBLL.DeleteFreeClass(selectedClassroom);
            }
            classroomBLL.DeleteClassroom(selectedClassroom);
            selectedClassroom = "";
            LoadClassrooms();
        }

        private void dgvListClassroom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvListClassroom.Rows[e.RowIndex].Cells[0].Value.ToString() != "Chưa có")
                {
                    selectedClassroom = dgvListClassroom.Rows[e.RowIndex].Cells[6].Value.ToString() + "";
                }
            }
        }
    }
}
