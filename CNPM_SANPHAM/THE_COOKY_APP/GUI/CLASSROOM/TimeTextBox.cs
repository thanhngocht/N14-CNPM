using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace THE_COOKY_APP.GUI.CLASSROOM
{
    public class TimeTextBox : TextBox
    {
        public int BorderRadius { get; set; } = 15;
        public Color BackgroundColor { get; set; } = ColorTranslator.FromHtml("#FFE3E8");
        private Color placeholderColor = Color.Gray;

        public TimeTextBox()
        {
            this.Multiline = true;
            this.TextAlign = HorizontalAlignment.Center;
            this.MaxLength = 5; // Format "HH:mm" has 5 characters
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            SetRoundedRegion();
        }

        private void SetRoundedRegion()
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = BorderRadius;

                path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
                path.AddArc(new Rectangle(Width - radius, 0, radius, radius), 270, 90);
                path.AddArc(new Rectangle(Width - radius, Height - radius, radius, radius), 0, 90);
                path.AddArc(new Rectangle(0, Height - radius, radius, radius), 90, 90);
                path.CloseAllFigures();

                this.Region = new Region(path);
                this.Invalidate();
            }
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            base.OnPaintBackground(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

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

            // Draw placeholder if the textbox is empty
            if (string.IsNullOrEmpty(this.Text))
            {
                using (SolidBrush brush = new SolidBrush(placeholderColor))
                {
                    e.Graphics.DrawString(PlaceholderText, this.Font, brush, new PointF(2, (this.Height - this.Font.Height) / 2));
                }
            }
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            // Allow only numbers and backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);

            // Lấy văn bản hiện tại mà không có dấu ":"
            string newText = this.Text.Replace(":", "");

            // Giới hạn độ dài tối đa là 5 ký tự (HH:mm)
            if (newText.Length > 5)
            {
                newText = newText.Substring(0, 5);
            }

            // Thêm dấu ":" vào vị trí thích hợp
            if (newText.Length >= 2 && newText.Length < 5 && !newText.Contains(":"))
            {
                newText = newText.Insert(2, ":");
            }

            // Cập nhật văn bản nếu có thay đổi
            if (this.Text != newText)
            {
                // Lưu vị trí con trỏ hiện tại
                int selectionStart = this.SelectionStart;

                // Cập nhật văn bản mới
                this.Text = newText;

                // Di chuyển vị trí con trỏ dựa trên độ dài văn bản
                if (newText.Length >= 5)
                {
                    // Nếu văn bản đầy đủ, di chuyển con trỏ về sau dấu ":"
                    this.SelectionStart = 4;
                }
                else if (newText.Length == 4 && selectionStart >= 4)
                {
                    // Nếu đã nhập đủ 4 ký tự, di chuyển con trỏ về sau số thứ 4
                    this.SelectionStart = 4;
                }
                else if (newText.Length == 3)
                {
                    // Nếu đã nhập đủ 3 ký tự, di chuyển con trỏ về sau số thứ 3
                    this.SelectionStart = 3;
                }
                else if (newText.Length == 2)
                {
                    // Nếu đã nhập đủ 2 ký tự, di chuyển con trỏ về sau số thứ 1
                    this.SelectionStart = 2;
                }
                else
                {
                    // Nếu xóa hết, đặt con trỏ về đầu
                    this.SelectionStart = 0;
                }
            }
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);

            // Đảm bảo rằng dấu ":" được thêm và con trỏ nằm đúng vị trí khi mất focus
            if (this.Text.Length == 4) // Trường hợp người dùng có thể đã nhập HHmm
            {
                this.Text = this.Text.Insert(2, ":");
                this.SelectionStart = 4; // Di chuyển con trỏ sau dấu ":"
            }
        }





    }
}
