using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace THE_COOKY_APP.GUI.CLASSROOM
{
    public class RoundedPictureBox : PictureBox
    {
        // Bán kính của góc bo tròn
        public int BorderRadius { get; set; } = 40;

        // Thiết lập hình dạng bo tròn cho PictureBox khi kích thước thay đổi
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            SetRoundedRegion();
        }

        // Phương thức thiết lập hình dạng bo tròn cho PictureBox
        private void SetRoundedRegion()
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = BorderRadius;

                // Tạo hình tròn cho PictureBox
                path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
                path.AddArc(new Rectangle(Width - radius, 0, radius, radius), 270, 90);
                path.AddArc(new Rectangle(Width - radius, Height - radius, radius, radius), 0, 90);
                path.AddArc(new Rectangle(0, Height - radius, radius, radius), 90, 90);
                path.CloseAllFigures();

                // Thiết lập hình dạng cho PictureBox
                this.Region = new Region(path);
            }
        }

        // Vẽ lại hình ảnh để đảm bảo nó nằm trong vùng bo tròn
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            if (Image != null)
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                pevent.Graphics.DrawImage(Image, 0, 0, Width, Height);
            }
        }
    }
}
