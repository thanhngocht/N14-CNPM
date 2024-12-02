using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace THE_COOKY_APP.GUI.CLASSROOM
{
    public class CirclePictureBox : PictureBox
    {
        // Kích thước cố định của CircleBox cho icon nút bấm
        private int fixedSize = 40;

        // Thiết lập hình dạng tròn cho PictureBox khi kích thước thay đổi
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            // Đảm bảo PictureBox luôn có kích thước nhỏ (40x40) và là hình tròn
            this.Width = this.Height = fixedSize;
            SetCircularRegion();
        }

        // Phương thức thiết lập hình dạng tròn cho PictureBox
        private void SetCircularRegion()
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                // Tạo hình tròn cho PictureBox
                path.AddEllipse(0, 0, this.Width, this.Height);
                this.Region = new Region(path);
            }
        }

        // Vẽ lại hình ảnh để đảm bảo nó nằm trong vùng hình tròn
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            if (Image != null)
            {
                // Đảm bảo hình ảnh được vẽ trong hình tròn
                pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                pevent.Graphics.SetClip(new Rectangle(0, 0, this.Width, this.Height));
                pevent.Graphics.DrawImage(Image, 0, 0, Width, Height);
            }
        }
    }
}
