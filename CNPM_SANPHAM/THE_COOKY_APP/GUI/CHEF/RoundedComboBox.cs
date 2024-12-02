using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace THE_COOKY_APP.GUI.LOGIN
{
    public class RoundedComboBox : ComboBox
    {
        // Bán kính góc bo tròn
        public int BorderRadius { get; set; } = 15;

        // Màu nền cho ComboBox
        public Color BackgroundColor { get; set; } = Color.White; // Màu nền mặc định

        public RoundedComboBox()
        {
            // Thiết lập DropDownStyle
            this.DropDownStyle = ComboBoxStyle.DropDown;

            // Gọi SetRoundedRegion() để tạo góc bo tròn khi khởi tạo
            SetRoundedRegion();
        }

        // Thiết lập hình dạng bo tròn cho ComboBox khi kích thước thay đổi
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            SetRoundedRegion();
        }

        // Phương thức thiết lập hình dạng bo tròn cho ComboBox
        private void SetRoundedRegion()
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = BorderRadius;

                // Tạo các arc cho bốn góc của ComboBox
                path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
                path.AddArc(new Rectangle(Width - radius, 0, radius, radius), 270, 90);
                path.AddArc(new Rectangle(Width - radius, Height - radius, radius, radius), 0, 90);
                path.AddArc(new Rectangle(0, Height - radius, radius, radius), 90, 90);
                path.CloseAllFigures();

                // Thiết lập hình dạng cho ComboBox
                this.Region = new Region(path);
            }
        }

        // Phương thức vẽ nền với góc bo tròn
        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            // Không gọi base.OnPaintBackground() để tránh vẽ nền mặc định
            // Thay vào đó, vẽ nền của bạn
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Kiểm tra nếu Region không phải là null
            if (this.Region != null)
            {
                using (SolidBrush brush = new SolidBrush(BackgroundColor))
                {
                    pevent.Graphics.FillRegion(brush, this.Region);
                }
            }
        }

        // Ghi đè phương thức OnPaint để không vẽ border
        protected override void OnPaint(PaintEventArgs e)
        {
            // Không gọi base.OnPaint() để loại bỏ viền
            // Không vẽ gì ở đây để tránh viền
        }
    }
}