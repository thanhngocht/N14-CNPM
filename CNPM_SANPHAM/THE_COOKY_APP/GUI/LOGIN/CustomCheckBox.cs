using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace THE_COOKY_APP.GUI.LOGIN
{
    public class CustomCheckBox : CheckBox
    {
        // Kích thước mặc định của hộp kiểm
        private const int DefaultCheckBoxSize = 20;

        // Kích thước hiện tại của hộp kiểm, ban đầu đặt bằng kích thước mặc định
        public int CheckBoxSize { get; set; } = DefaultCheckBoxSize;

        public CustomCheckBox()
        {
            // Tăng hiệu suất vẽ bằng cách sử dụng các thuộc tính của ControlStyles
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);

            // Đặt kích thước ban đầu của CheckBox
            this.Size = new Size(CheckBoxSize + 20, CheckBoxSize);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            // Xóa nền hiện tại của CheckBox
            pevent.Graphics.Clear(this.BackColor);

            // Điều chỉnh kích thước và vị trí của hộp kiểm
            Rectangle checkBoxRect = new Rectangle(0, (Height - CheckBoxSize) / 2, CheckBoxSize, CheckBoxSize);

            // Tạo GraphicsPath để vẽ các góc bo tròn
            using (GraphicsPath path = CreateRoundedRectanglePath(checkBoxRect, CheckBoxSize / 3))
            {
                // Thiết lập chế độ vẽ mượt
                pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                // Vẽ viền hộp kiểm với màu DarkRed
                using (Pen borderPen = new Pen(Color.DarkRed, 2))
                {
                    pevent.Graphics.DrawPath(borderPen, path);
                }
            }

            // Nếu CheckBox được chọn, vẽ nền bên trong và dấu tích
            if (this.Checked)
            {
                using (Brush redBrush = new SolidBrush(Color.DarkRed))
                {
                    pevent.Graphics.FillRectangle(redBrush, checkBoxRect);
                }

                // Tính toán vị trí và kích thước của dấu tích
                int checkMarkOffset = CheckBoxSize / 5; // Lệch từ góc để căn giữa dấu tích
                int checkMarkWidth = CheckBoxSize / 3; // Độ dài của dấu tích

                // Vẽ dấu tích màu trắng
                using (Pen whitePen = new Pen(Color.White, 2))
                {
                    pevent.Graphics.DrawLine(whitePen,
                        new Point(checkBoxRect.Left + checkMarkOffset, checkBoxRect.Top + checkBoxRect.Height - checkMarkOffset),  // Điểm bắt đầu
                        new Point(checkBoxRect.Left + (CheckBoxSize / 2), checkBoxRect.Top + (CheckBoxSize / 2)));     // Điểm giữa
                    pevent.Graphics.DrawLine(whitePen,
                        new Point(checkBoxRect.Left + (CheckBoxSize / 2), checkBoxRect.Top + (CheckBoxSize / 2)),    // Điểm giữa
                        new Point(checkBoxRect.Left + checkBoxRect.Width - checkMarkOffset, checkBoxRect.Top + checkMarkOffset)); // Điểm kết thúc
                }
            }

            // Vẽ lại văn bản của CheckBox với font và màu hiện tại
            pevent.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor),
                                       CheckBoxSize + 5, (Height - this.Font.Height) / 2);
        }

        // Phương thức để tạo GraphicsPath với góc bo tròn
        private GraphicsPath CreateRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90); // Góc trên bên trái
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90); // Góc trên bên phải
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90); // Góc dưới bên phải
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90); // Góc dưới bên trái
            path.CloseAllFigures();
            return path;
        }

        // Phương thức dùng để thay đổi kích thước hộp kiểm dựa trên tỷ lệ form
        public void ResizeCheckBox(float scale)
        {
            // Điều chỉnh kích thước dựa trên tỷ lệ, nhưng giới hạn kích thước tối thiểu và tối đa
            CheckBoxSize = (int)(DefaultCheckBoxSize * scale); // Điều chỉnh kích thước dựa trên tỷ lệ
            CheckBoxSize = Math.Max(CheckBoxSize, 20); // Đảm bảo kích thước tối thiểu
            CheckBoxSize = Math.Min(CheckBoxSize, 50); // Đảm bảo kích thước tối đa (thay đổi 50 theo nhu cầu)

            // Cập nhật lại kích thước cho hộp kiểm
            this.Size = new Size(CheckBoxSize + 20, CheckBoxSize); // Cập nhật lại kích thước cho hộp kiểm
            this.Invalidate(); // Đánh dấu để vẽ lại
        }
    }
}
