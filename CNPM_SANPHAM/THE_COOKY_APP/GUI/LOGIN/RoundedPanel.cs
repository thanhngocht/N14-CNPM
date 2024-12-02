using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace THE_COOKY_APP.GUI.LOGIN
{
    public class RoundedPanel : Panel
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

            // Màu trắng
            Color whiteColor = Color.White;

            // Màu từ mã hex
            Color customColor = ColorTranslator.FromHtml("#A98E7D");

            // Vẽ màu nền với gradient
            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = BorderRadius;
                path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
                path.AddArc(new Rectangle(Width - radius, 0, radius, radius), 270, 90);
                path.AddArc(new Rectangle(Width - radius, Height - radius, radius, radius), 0, 90);
                path.AddArc(new Rectangle(0, Height - radius, radius, radius), 90, 90);
                path.CloseAllFigures();

                //using (LinearGradientBrush brush = new LinearGradientBrush(ClientRectangle, whiteColor, customColor, 95F))
                //{
                //    e.Graphics.FillPath(brush, path);
                //}
                using (SolidBrush brush = new SolidBrush(whiteColor))
                {
                    e.Graphics.FillPath(brush, path);
                }
            }
        }
    }
}
