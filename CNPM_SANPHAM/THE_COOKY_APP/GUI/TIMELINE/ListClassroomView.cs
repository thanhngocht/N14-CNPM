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

namespace THE_COOKY_APP.GUI.TIMELINE
{
    public partial class ListClassroomView : UserControl
    {
        private readonly ClassroomBLL classroomBLL = new ClassroomBLL();
        private readonly NormalClassBLL normalClassBLL = new NormalClassBLL();
        private readonly UserFunctionBLL userFunctionBLL = new UserFunctionBLL();
        private readonly AccountBLL accountBLL = new AccountBLL();
        private readonly UserFunctionDTO userFunctionDTO;
        private readonly AccountDTO accountDTO;
        public ListClassroomView(string accountId)
        {
            InitializeComponent();
            if (accountId == "")
            {
                return;
            }
            userFunctionDTO = userFunctionBLL.GetPermissionsByAccountId(accountId);
            accountDTO = accountBLL.GetAccountById(accountId);
            LoadClassroom();
        }

        private void LoadClassroom()
        {
            List<ClassroomDTO> classroomDTOs = classroomBLL.GetAllClassrooms();
            int cardWidth = 660; // Chiều rộng của thẻ CardClassroom
            int cardHeight = 660; // Chiều cao của thẻ CardClassroom
            int spacing = 0; // Khoảng cách giữa các thẻ
            int startX = 15; // Vị trí X ban đầu
            int startY = 0; // Vị trí Y ban đầu

            for (int i = 0; i < classroomDTOs.Count; i++)
            {
                var classroomDTO = classroomDTOs[i];
                NormalClassDTO normalClassDTO = normalClassBLL.GetNormalClassById(classroomDTO.IdClass);
                string fee = "0";
                if (normalClassDTO != null )
                {
                    fee = normalClassDTO.Fee.ToString("0");
                }
                // Tạo thẻ CardClassroom
                CardClassroom card = new CardClassroom(accountDTO.IdAccount);
                card.SetClassroom(classroomDTO.Picture, classroomDTO.NameChef, fee,
                                  classroomDTO.NameClass, classroomDTO.StartDate, classroomDTO.Description, classroomDTO.IdClass);

                // Tính toán vị trí cho thẻ
                int currentX = startX + (i % 2) * (cardWidth + spacing); // Vị trí X
                int currentY = startY + (i / 2) * (cardHeight + spacing); // Vị trí Y

                // Đặt vị trí cho thẻ
                card.Location = new Point(currentX, currentY);
                card.Size = new Size(660, 660); // Đặt kích thước cho thẻ

                // Thêm thẻ vào form hoặc panel chứa thẻ
                this.Controls.Add(card);
            }
        }

        private void ListClassroomView_Load(object sender, EventArgs e)
        {
            LoadClassroom();
        }
    }
}
