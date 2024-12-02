using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace THE_COOKY_APP.GUI.CLASSROOM
{
    public class RoundedButton : Button
    {
        // Bán kính của góc
        public int BorderRadius { get; set; } = 40;

        // Màu nền
        public Color ButtonColor { get; set; } = Color.DarkRed; // Thay đổi màu nền mặc định

        // Màu chữ
        public Color TextColor { get; set; } = Color.White;

        // Thiết lập hình dạng bo tròn cho button khi kích thước thay đổi
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            SetRoundedRegion();
        }

        // Phương thức thiết lập hình dạng bo tròn cho button
        private void SetRoundedRegion()
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = BorderRadius;

                // Tạo hình tròn cho button
                path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
                path.AddArc(new Rectangle(Width - radius, 0, radius, radius), 270, 90);
                path.AddArc(new Rectangle(Width - radius, Height - radius, radius, radius), 0, 90);
                path.AddArc(new Rectangle(0, Height - radius, radius, radius), 90, 90);
                path.CloseAllFigures();

                // Thiết lập hình dạng cho button
                this.Region = new Region(path);
            }
        }

        // Phương thức vẽ button với góc bo tròn
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Vẽ màu nền
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(new Rectangle(0, 0, BorderRadius, BorderRadius), 180, 90);
                path.AddArc(new Rectangle(Width - BorderRadius, 0, BorderRadius, BorderRadius), 270, 90);
                path.AddArc(new Rectangle(Width - BorderRadius, Height - BorderRadius, BorderRadius, BorderRadius), 0, 90);
                path.AddArc(new Rectangle(0, Height - BorderRadius, BorderRadius, BorderRadius), 90, 90);
                path.CloseAllFigures();

                using (SolidBrush brush = new SolidBrush(ButtonColor))
                {
                    pevent.Graphics.FillPath(brush, path);
                }
            }

            // Vẽ chữ
            using (SolidBrush brush = new SolidBrush(TextColor))
            {
                // Trung tâm chữ
                SizeF textSize = pevent.Graphics.MeasureString(Text, Font);
                pevent.Graphics.DrawString(Text, Font, brush,
                    new PointF(Width / 2 - textSize.Width / 2,
                               Height / 2 - textSize.Height / 2));
            }
        }
    }
}
