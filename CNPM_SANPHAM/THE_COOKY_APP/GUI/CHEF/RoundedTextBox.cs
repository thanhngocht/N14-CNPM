using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace THE_COOKY_APP.GUI.LOGIN
{
    public class RoundedTextBox : TextBox
    {
        // Bán kính góc bo tròn
        public int BorderRadius { get; set; } = 15;

        // Màu nền cho TextBox
        public Color BackgroundColor { get; set; } = ColorTranslator.FromHtml("#FFE3E8");

        public RoundedTextBox()
        {
            // Thiết lập thuộc tính Multiline để có thể thay đổi kích thước TextBox theo chiều cao
            this.Multiline = true;
        }

        // Thiết lập hình dạng bo tròn cho TextBox khi kích thước thay đổi
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            SetRoundedRegion();
        }

        // Phương thức thiết lập hình dạng bo tròn cho TextBox
        private void SetRoundedRegion()
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = BorderRadius;

                // Tạo các arc cho bốn góc của TextBox
                path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
                path.AddArc(new Rectangle(Width - radius, 0, radius, radius), 270, 90);
                path.AddArc(new Rectangle(Width - radius, Height - radius, radius, radius), 0, 90);
                path.AddArc(new Rectangle(0, Height - radius, radius, radius), 90, 90);
                path.CloseAllFigures();

                // Thiết lập hình dạng cho TextBox
                this.Region = new Region(path);
                this.Invalidate();  // Vẽ lại TextBox với góc bo tròn
            }
        }

        // Phương thức vẽ nền với góc bo tròn
        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            base.OnPaintBackground(pevent);

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

        protected override void OnPaint(PaintEventArgs e)
        {
            // Không gọi base.OnPaint() để loại bỏ border
        }

    }
}
