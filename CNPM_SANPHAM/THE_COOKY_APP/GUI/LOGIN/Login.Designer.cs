using System.Security.Principal;

namespace THE_COOKY_APP.GUI.LOGIN
{
    partial class Login
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pnLogin = new RoundedPanel();
            cbShowPassword = new CustomCheckBox();
            rpbPicture = new RoundedPictureBox();
            lblForgetPassword = new LinkLabel();
            btnLogin = new RoundedButton();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lblPassword = new Label();
            lblUsername = new Label();
            lblLogin = new Label();
            pnLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rpbPicture).BeginInit();
            SuspendLayout();
            // 
            // pnLogin
            // 
            pnLogin.BackColor = Color.White;
            pnLogin.BorderRadius = 40;
            pnLogin.Controls.Add(cbShowPassword);
            pnLogin.Controls.Add(rpbPicture);
            pnLogin.Controls.Add(lblForgetPassword);
            pnLogin.Controls.Add(btnLogin);
            pnLogin.Controls.Add(txtPassword);
            pnLogin.Controls.Add(txtUsername);
            pnLogin.Controls.Add(lblPassword);
            pnLogin.Controls.Add(lblUsername);
            pnLogin.Controls.Add(lblLogin);
            pnLogin.Location = new Point(312, 165);
            pnLogin.Margin = new Padding(2);
            pnLogin.Name = "pnLogin";
            pnLogin.Size = new Size(356, 392);
            pnLogin.TabIndex = 0;
            // 
            // cbShowPassword
            // 
            cbShowPassword.AutoSize = true;
            cbShowPassword.CheckBoxSize = 20;
            cbShowPassword.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbShowPassword.Location = new Point(21, 298);
            cbShowPassword.Margin = new Padding(2);
            cbShowPassword.Name = "cbShowPassword";
            cbShowPassword.Size = new Size(159, 25);
            cbShowPassword.TabIndex = 9;
            cbShowPassword.Text = "Hiển thị mật khẩu";
            cbShowPassword.UseVisualStyleBackColor = true;
            cbShowPassword.CheckedChanged += chk_HienThi_CheckedChanged;
            // 
            // rpbPicture
            // 
            rpbPicture.BackgroundImage = Properties.Resources.logo;
            rpbPicture.BackgroundImageLayout = ImageLayout.Stretch;
            rpbPicture.BorderRadius = 40;
            rpbPicture.Location = new Point(134, 8);
            rpbPicture.Margin = new Padding(2);
            rpbPicture.Name = "rpbPicture";
            rpbPicture.Size = new Size(90, 90);
            rpbPicture.TabIndex = 8;
            rpbPicture.TabStop = false;
            // 
            // lblForgetPassword
            // 
            lblForgetPassword.ActiveLinkColor = Color.Red;
            lblForgetPassword.AutoSize = true;
            lblForgetPassword.BackColor = Color.White;
            lblForgetPassword.Font = new Font("Arial", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblForgetPassword.ForeColor = Color.Red;
            lblForgetPassword.LinkColor = Color.DarkRed;
            lblForgetPassword.Location = new Point(220, 300);
            lblForgetPassword.Margin = new Padding(2, 0, 2, 0);
            lblForgetPassword.Name = "lblForgetPassword";
            lblForgetPassword.Size = new Size(124, 19);
            lblForgetPassword.TabIndex = 7;
            lblForgetPassword.TabStop = true;
            lblForgetPassword.Text = "Quên mật khẩu";
            lblForgetPassword.VisitedLinkColor = Color.DarkRed;
            lblForgetPassword.LinkClicked += lblForgetPassword_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.BorderRadius = 40;
            btnLogin.ButtonColor = Color.DarkRed;
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(26, 340);
            btnLogin.Margin = new Padding(2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(305, 39);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Đăng nhập";
            btnLogin.TextColor = Color.White;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(26, 255);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(305, 31);
            txtPassword.TabIndex = 4;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(26, 178);
            txtUsername.Margin = new Padding(2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(305, 31);
            txtUsername.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.White;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblPassword.ForeColor = Color.DarkRed;
            lblPassword.Location = new Point(14, 220);
            lblPassword.Margin = new Padding(2, 0, 2, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(93, 25);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Mật khẩu";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.White;
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.DarkRed;
            lblUsername.Location = new Point(14, 138);
            lblUsername.Margin = new Padding(2, 0, 2, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(138, 25);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Tên đăng nhập";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.White;
            lblLogin.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.DarkRed;
            lblLogin.Location = new Point(101, 90);
            lblLogin.Margin = new Padding(2, 0, 2, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(161, 38);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Đăng nhập";
            lblLogin.TextAlign = ContentAlignment.TopCenter;
            // 
            // Login
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.Account;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(978, 644);
            Controls.Add(pnLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            pnLogin.ResumeLayout(false);
            pnLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)rpbPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private THE_COOKY_APP.GUI.LOGIN.RoundedPanel pnLogin;
        private Label lblLogin;
        private Label lblPassword;
        private Label lblUsername;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private THE_COOKY_APP.GUI.LOGIN.RoundedButton btnLogin;
        private LinkLabel lblForgetPassword;
        private THE_COOKY_APP.GUI.LOGIN.RoundedPictureBox rpbPicture;
        private THE_COOKY_APP.GUI.LOGIN.CustomCheckBox cbShowPassword;
    }
}