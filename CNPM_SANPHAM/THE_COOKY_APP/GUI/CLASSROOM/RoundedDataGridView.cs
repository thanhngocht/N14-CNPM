using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THE_COOKY_APP.GUI.CLASSROOM
{
    internal class RoundedDataGridView : DataGridView
    {
        // Bán kính của góc
        public int BorderRadius { get; set; } = 40;

        // Thiết lập hình dạng bo tròn cho DataGridView khi kích thước thay đổi
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            SetRoundedRegion();
        }

        // Phương thức thiết lập hình dạng bo tròn cho DataGridView
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

                // Thiết lập hình dạng cho DataGridView
                this.Region = new Region(path);
            }
        }

        // Phương thức vẽ DataGridView với góc bo tròn
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        }
    }
}
