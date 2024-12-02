using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace THE_COOKY_APP.GUI.CHEF
{
    public class RoundedDateTimePicker : DateTimePicker
    {
        // Bán kính góc bo tròn
        public int BorderRadius { get; set; } = 15;

        // Màu nền cho DateTimePicker
        public Color BackgroundColor { get; set; } = ColorTranslator.FromHtml("#FFE3E8");

        // Chiều cao cố định
        private const int FixedHeight = 36;

        public RoundedDateTimePicker()
        {
            // Set custom date format
            this.Format = DateTimePickerFormat.Custom;
            this.CustomFormat = "dd/MM/yyyy";

            // Set height to 36
            this.Height = FixedHeight;

            // Enable custom painting
            this.SetStyle(ControlStyles.UserPaint, true);

            // Initialize rounded region
            SetRoundedRegion();

            // Subscribe to ValueChanged event to force repaint on date change
            this.ValueChanged += (s, e) => this.Invalidate();
        }

        public override Size MinimumSize
        {
            get => new Size(base.MinimumSize.Width, FixedHeight);
            set => base.MinimumSize = new Size(value.Width, FixedHeight);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            // Ensure the height remains 36 on resize
            if (this.Height != FixedHeight)
            {
                this.Height = FixedHeight;
            }

            SetRoundedRegion();
        }

        private void SetRoundedRegion()
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = BorderRadius;

                // Define rounded corners
                path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
                path.AddArc(new Rectangle(Width - radius, 0, radius, radius), 270, 90);
                path.AddArc(new Rectangle(Width - radius, Height - radius, radius, radius), 0, 90);
                path.AddArc(new Rectangle(0, Height - radius, radius, radius), 90, 90);
                path.CloseAllFigures();

                // Set the region for rounded corners
                this.Region = new Region(path);
            }
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            base.OnPaintBackground(pevent);

            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Only fill the region if it is not null
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
            base.OnPaint(e);

            // Draw the date text with center alignment
            TextRenderer.DrawText(
                e.Graphics,
                this.Text,
                this.Font,
                this.ClientRectangle,
                this.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            );
        }
    }
}
