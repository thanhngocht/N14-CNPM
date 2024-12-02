using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace THE_COOKY_APP.GUI.CHEF
{
    internal class RoundedPanel1 : Panel
    {
        // Bán kính của góc
        public int BorderRadius { get; set; } = 40;

        // Thiết lập hình dạng bo tròn cho panel khi kích thước thay đổi
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            SetRoundedRegion();
        }

        // Phương thức thiết lập hình dạng bo tròn cho panel
        private void SetRoundedRegion()
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = BorderRadius;

                // Tạo các arc cho bốn góc
                path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
                path.AddArc(new Rectangle(Width - radius, 0, radius, radius), 270, 90);
                path.AddArc(new Rectangle(Width - radius, Height - radius, radius, radius), 0, 90);
                path.AddArc(new Rectangle(0, Height - radius, radius, radius), 90, 90);
                path.CloseAllFigures();

                // Thiết lập hình dạng cho panel
                this.Region = new Region(path);
            }
        }

        // Phương thức vẽ panel với góc bo tròn
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Màu từ mã hex
            Color customColor = ColorTranslator.FromHtml("#FFE3E8");

            // Vẽ màu nền với màu customColor
            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = BorderRadius;
                path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
                path.AddArc(new Rectangle(Width - radius, 0, radius, radius), 270, 90);
                path.AddArc(new Rectangle(Width - radius, Height - radius, radius, radius), 0, 90);
                path.AddArc(new Rectangle(0, Height - radius, radius, radius), 90, 90);
                path.CloseAllFigures();

                using (SolidBrush brush = new SolidBrush(customColor))
                {
                    e.Graphics.FillPath(brush, path);
                }
            }
        }
    }
}
