namespace THE_COOKY_APP.GUI.PROFILE
{
    partial class ConfirmPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmPassword));
            roundedPanel11 = new CHEF.RoundedPanel1();
            roundedPanel1 = new LOGIN.RoundedPanel();
            txtPassword = new LOGIN.RoundedTextBox();
            lblPassword = new Label();
            btnConfirm = new CLASSROOM.RoundedButton();
            roundedPanel11.SuspendLayout();
            roundedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // roundedPanel11
            // 
            roundedPanel11.BorderRadius = 40;
            roundedPanel11.Controls.Add(roundedPanel1);
            roundedPanel11.Location = new Point(65, 33);
            roundedPanel11.Name = "roundedPanel11";
            roundedPanel11.Size = new Size(450, 241);
            roundedPanel11.TabIndex = 0;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BorderRadius = 40;
            roundedPanel1.Controls.Add(txtPassword);
            roundedPanel1.Controls.Add(lblPassword);
            roundedPanel1.Location = new Point(45, 45);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(360, 151);
            roundedPanel1.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(255, 227, 232);
            txtPassword.BackgroundColor = Color.White;
            txtPassword.BorderRadius = 15;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(38, 85);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(284, 36);
            txtPassword.TabIndex = 1;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.White;
            lblPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPassword.ForeColor = Color.DarkRed;
            lblPassword.Location = new Point(38, 30);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(180, 28);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Mật khẩu hiện tại";
            // 
            // btnConfirm
            // 
            btnConfirm.BorderRadius = 40;
            btnConfirm.ButtonColor = Color.DarkRed;
            btnConfirm.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnConfirm.Location = new Point(403, 301);
            btnConfirm.Margin = new Padding(2);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(112, 39);
            btnConfirm.TabIndex = 23;
            btnConfirm.Text = "Xác thực";
            btnConfirm.TextColor = Color.White;
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // ConfirmPassword
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(251, 236, 240);
            ClientSize = new Size(578, 366);
            Controls.Add(btnConfirm);
            Controls.Add(roundedPanel11);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ConfirmPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Xác thực mật khẩu";
            roundedPanel11.ResumeLayout(false);
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CHEF.RoundedPanel1 roundedPanel11;
        private LOGIN.RoundedPanel roundedPanel1;
        private LOGIN.RoundedTextBox txtPassword;
        private Label lblPassword;
        private CLASSROOM.RoundedButton btnConfirm;
    }
}