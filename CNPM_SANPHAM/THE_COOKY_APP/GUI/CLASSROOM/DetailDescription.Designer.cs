namespace THE_COOKY_APP.GUI.CLASSROOM
{
    partial class DetailDescription
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailDescription));
            pnDetailDescription = new CHEF.RoundedPanel1();
            pnKeyWord = new LOGIN.RoundedPanel();
            txtKeyWord = new LOGIN.RoundedTextBox();
            lblKeyWord = new Label();
            lblDescription = new Label();
            btnHint = new RoundedButton();
            pnDetailDescription.SuspendLayout();
            pnKeyWord.SuspendLayout();
            SuspendLayout();
            // 
            // pnDetailDescription
            // 
            pnDetailDescription.BorderRadius = 40;
            pnDetailDescription.Controls.Add(pnKeyWord);
            pnDetailDescription.Location = new Point(65, 85);
            pnDetailDescription.Name = "pnDetailDescription";
            pnDetailDescription.Size = new Size(450, 287);
            pnDetailDescription.TabIndex = 0;
            // 
            // pnKeyWord
            // 
            pnKeyWord.BorderRadius = 40;
            pnKeyWord.Controls.Add(txtKeyWord);
            pnKeyWord.Controls.Add(lblKeyWord);
            pnKeyWord.Location = new Point(45, 50);
            pnKeyWord.Name = "pnKeyWord";
            pnKeyWord.Size = new Size(360, 187);
            pnKeyWord.TabIndex = 0;
            // 
            // txtKeyWord
            // 
            txtKeyWord.BackColor = Color.FromArgb(255, 227, 232);
            txtKeyWord.BackgroundColor = Color.White;
            txtKeyWord.BorderRadius = 15;
            txtKeyWord.BorderStyle = BorderStyle.None;
            txtKeyWord.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtKeyWord.Location = new Point(38, 85);
            txtKeyWord.Multiline = true;
            txtKeyWord.Name = "txtKeyWord";
            txtKeyWord.Size = new Size(284, 72);
            txtKeyWord.TabIndex = 25;
            // 
            // lblKeyWord
            // 
            lblKeyWord.AutoSize = true;
            lblKeyWord.BackColor = Color.White;
            lblKeyWord.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblKeyWord.ForeColor = Color.DarkRed;
            lblKeyWord.Location = new Point(38, 30);
            lblKeyWord.Name = "lblKeyWord";
            lblKeyWord.Size = new Size(89, 28);
            lblKeyWord.TabIndex = 24;
            lblKeyWord.Text = "Từ khóa";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.FromArgb(251, 236, 240);
            lblDescription.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.DarkRed;
            lblDescription.Location = new Point(236, 30);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(109, 38);
            lblDescription.TabIndex = 23;
            lblDescription.Text = "MÔ TẢ";
            // 
            // btnHint
            // 
            btnHint.BorderRadius = 40;
            btnHint.ButtonColor = Color.DarkRed;
            btnHint.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnHint.Location = new Point(403, 404);
            btnHint.Name = "btnHint";
            btnHint.Size = new Size(112, 39);
            btnHint.TabIndex = 24;
            btnHint.Text = "Gợi ý";
            btnHint.TextColor = Color.White;
            btnHint.UseVisualStyleBackColor = true;
            btnHint.Click += btnHint_Click;
            // 
            // DetailDescription
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(251, 236, 240);
            ClientSize = new Size(578, 469);
            Controls.Add(btnHint);
            Controls.Add(lblDescription);
            Controls.Add(pnDetailDescription);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DetailDescription";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mô tả";
            pnDetailDescription.ResumeLayout(false);
            pnKeyWord.ResumeLayout(false);
            pnKeyWord.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CHEF.RoundedPanel1 pnDetailDescription;
        private Label lblDescription;
        private LOGIN.RoundedPanel pnKeyWord;
        private Label lblKeyWord;
        private LOGIN.RoundedTextBox txtKeyWord;
        private RoundedButton btnHint;
    }
}