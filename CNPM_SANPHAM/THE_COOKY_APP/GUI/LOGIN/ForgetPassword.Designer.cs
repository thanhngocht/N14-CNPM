using System.Security.Principal;

namespace THE_COOKY_APP.GUI.LOGIN
{
    partial class ForgetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPassword));
            pnForgetPassword = new RoundedPanel();
            txtIdAccount = new TextBox();
            lblIdAccount = new Label();
            lblNote = new Label();
            rpcPicture = new RoundedPictureBox();
            btnConfirm = new RoundedButton();
            txtGmail = new TextBox();
            lblGmail = new Label();
            lblForgetPassword = new Label();
            pnForgetPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rpcPicture).BeginInit();
            SuspendLayout();
            // 
            // pnForgetPassword
            // 
            pnForgetPassword.BackColor = Color.White;
            pnForgetPassword.BorderRadius = 40;
            pnForgetPassword.Controls.Add(txtIdAccount);
            pnForgetPassword.Controls.Add(lblIdAccount);
            pnForgetPassword.Controls.Add(lblNote);
            pnForgetPassword.Controls.Add(rpcPicture);
            pnForgetPassword.Controls.Add(btnConfirm);
            pnForgetPassword.Controls.Add(txtGmail);
            pnForgetPassword.Controls.Add(lblGmail);
            pnForgetPassword.Controls.Add(lblForgetPassword);
            pnForgetPassword.Location = new Point(312, 165);
            pnForgetPassword.Margin = new Padding(2);
            pnForgetPassword.Name = "pnForgetPassword";
            pnForgetPassword.Size = new Size(356, 392);
            pnForgetPassword.TabIndex = 1;
            // 
            // txtIdAccount
            // 
            txtIdAccount.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdAccount.Location = new Point(26, 178);
            txtIdAccount.Margin = new Padding(2);
            txtIdAccount.Name = "txtIdAccount";
            txtIdAccount.Size = new Size(305, 31);
            txtIdAccount.TabIndex = 13;
            // 
            // lblIdAccount
            // 
            lblIdAccount.AutoSize = true;
            lblIdAccount.BackColor = Color.White;
            lblIdAccount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdAccount.ForeColor = Color.DarkRed;
            lblIdAccount.Location = new Point(14, 136);
            lblIdAccount.Margin = new Padding(2, 0, 2, 0);
            lblIdAccount.Name = "lblIdAccount";
            lblIdAccount.Size = new Size(128, 25);
            lblIdAccount.TabIndex = 12;
            lblIdAccount.Text = "Mã nhân viên";
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNote.Location = new Point(14, 299);
            lblNote.Margin = new Padding(2, 0, 2, 0);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(315, 21);
            lblNote.TabIndex = 11;
            lblNote.Text = "*Mail phải liên kết với tài khoản nhân viên";
            // 
            // rpcPicture
            // 
            rpcPicture.BackgroundImageLayout = ImageLayout.Stretch;
            rpcPicture.BorderRadius = 40;
            rpcPicture.Image = Properties.Resources.logo;
            rpcPicture.Location = new Point(136, 8);
            rpcPicture.Margin = new Padding(2);
            rpcPicture.Name = "rpcPicture";
            rpcPicture.Size = new Size(90, 90);
            rpcPicture.TabIndex = 8;
            rpcPicture.TabStop = false;
            // 
            // btnConfirm
            // 
            btnConfirm.BorderRadius = 40;
            btnConfirm.ButtonColor = Color.DarkRed;
            btnConfirm.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.Location = new Point(26, 338);
            btnConfirm.Margin = new Padding(2);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(305, 39);
            btnConfirm.TabIndex = 5;
            btnConfirm.Text = "Lấy mật khẩu mới";
            btnConfirm.TextColor = Color.White;
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // txtGmail
            // 
            txtGmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGmail.Location = new Point(26, 258);
            txtGmail.Margin = new Padding(2);
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(305, 31);
            txtGmail.TabIndex = 3;
            // 
            // lblGmail
            // 
            lblGmail.AutoSize = true;
            lblGmail.BackColor = Color.White;
            lblGmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGmail.ForeColor = Color.DarkRed;
            lblGmail.Location = new Point(14, 216);
            lblGmail.Margin = new Padding(2, 0, 2, 0);
            lblGmail.Name = "lblGmail";
            lblGmail.Size = new Size(111, 25);
            lblGmail.TabIndex = 1;
            lblGmail.Text = "Địa chỉ mail";
            // 
            // lblForgetPassword
            // 
            lblForgetPassword.AutoSize = true;
            lblForgetPassword.BackColor = Color.White;
            lblForgetPassword.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblForgetPassword.ForeColor = Color.DarkRed;
            lblForgetPassword.Location = new Point(74, 96);
            lblForgetPassword.Margin = new Padding(2, 0, 2, 0);
            lblForgetPassword.Name = "lblForgetPassword";
            lblForgetPassword.Size = new Size(220, 38);
            lblForgetPassword.TabIndex = 0;
            lblForgetPassword.Text = "Quên mật khẩu";
            lblForgetPassword.TextAlign = ContentAlignment.TopCenter;
            // 
            // ForgetPassword
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.Account;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(978, 644);
            Controls.Add(pnForgetPassword);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "ForgetPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quên mật khẩu";
            pnForgetPassword.ResumeLayout(false);
            pnForgetPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)rpcPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private THE_COOKY_APP.GUI.LOGIN.RoundedPanel pnForgetPassword;
        private THE_COOKY_APP.GUI.LOGIN.RoundedPictureBox rpcPicture;
        private TextBox txtGmail;
        private Label lblGmail;
        private Label lblForgetPassword;
        private THE_COOKY_APP.GUI.LOGIN.RoundedButton btnConfirm;
        private Label lblNote;
        private TextBox txtIdAccount;
        private Label lblIdAccount;
    }
}