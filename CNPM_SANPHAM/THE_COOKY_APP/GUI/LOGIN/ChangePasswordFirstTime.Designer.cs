using System.Windows.Forms;

namespace THE_COOKY_APP.GUI.LOGIN
{
    partial class ChangePasswordFirstTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordFirstTime));
            pnClassroomInformation = new CHEF.RoundedPanel1();
            lblChangePassword = new Label();
            pnClassroom = new RoundedPanel();
            txtNewPassword = new RoundedTextBox();
            lblNewPassword = new Label();
            txtPresentPassword = new RoundedTextBox();
            lblPresentPassword = new Label();
            btnUpdate = new CLASSROOM.RoundedButton();
            pnClassroomInformation.SuspendLayout();
            pnClassroom.SuspendLayout();
            SuspendLayout();
            // 
            // pnClassroomInformation
            // 
            pnClassroomInformation.BorderRadius = 40;
            pnClassroomInformation.Controls.Add(lblChangePassword);
            pnClassroomInformation.Controls.Add(pnClassroom);
            pnClassroomInformation.Location = new Point(40, 45);
            pnClassroomInformation.Margin = new Padding(2);
            pnClassroomInformation.Name = "pnClassroomInformation";
            pnClassroomInformation.Size = new Size(450, 361);
            pnClassroomInformation.TabIndex = 2;
            // 
            // lblChangePassword
            // 
            lblChangePassword.AutoSize = true;
            lblChangePassword.BackColor = Color.FromArgb(255, 227, 232);
            lblChangePassword.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChangePassword.ForeColor = Color.DarkRed;
            lblChangePassword.Location = new Point(75, 20);
            lblChangePassword.Margin = new Padding(2, 0, 2, 0);
            lblChangePassword.Name = "lblChangePassword";
            lblChangePassword.Size = new Size(316, 38);
            lblChangePassword.TabIndex = 24;
            lblChangePassword.Text = "CẬP NHẬT MẬT KHẨU";
            // 
            // pnClassroom
            // 
            pnClassroom.BorderRadius = 40;
            pnClassroom.Controls.Add(txtNewPassword);
            pnClassroom.Controls.Add(lblNewPassword);
            pnClassroom.Controls.Add(txtPresentPassword);
            pnClassroom.Controls.Add(lblPresentPassword);
            pnClassroom.Location = new Point(45, 75);
            pnClassroom.Margin = new Padding(2);
            pnClassroom.Name = "pnClassroom";
            pnClassroom.Size = new Size(360, 261);
            pnClassroom.TabIndex = 0;
            // 
            // txtNewPassword
            // 
            txtNewPassword.BackColor = Color.FromArgb(255, 227, 232);
            txtNewPassword.BackgroundColor = Color.White;
            txtNewPassword.BorderRadius = 15;
            txtNewPassword.BorderStyle = BorderStyle.None;
            txtNewPassword.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNewPassword.Location = new Point(38, 195);
            txtNewPassword.Margin = new Padding(2);
            txtNewPassword.Multiline = true;
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(284, 36);
            txtNewPassword.TabIndex = 4;
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.BackColor = Color.White;
            lblNewPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNewPassword.ForeColor = Color.DarkRed;
            lblNewPassword.Location = new Point(38, 140);
            lblNewPassword.Margin = new Padding(2, 0, 2, 0);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(145, 28);
            lblNewPassword.TabIndex = 5;
            lblNewPassword.Text = "Mật khẩu mới";
            // 
            // txtPresentPassword
            // 
            txtPresentPassword.BackColor = Color.FromArgb(255, 227, 232);
            txtPresentPassword.BackgroundColor = Color.White;
            txtPresentPassword.BorderRadius = 15;
            txtPresentPassword.BorderStyle = BorderStyle.None;
            txtPresentPassword.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPresentPassword.Location = new Point(38, 85);
            txtPresentPassword.Margin = new Padding(2);
            txtPresentPassword.Multiline = true;
            txtPresentPassword.Name = "txtPresentPassword";
            txtPresentPassword.Size = new Size(284, 36);
            txtPresentPassword.TabIndex = 2;
            // 
            // lblPresentPassword
            // 
            lblPresentPassword.AutoSize = true;
            lblPresentPassword.BackColor = Color.White;
            lblPresentPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPresentPassword.ForeColor = Color.DarkRed;
            lblPresentPassword.Location = new Point(38, 30);
            lblPresentPassword.Margin = new Padding(2, 0, 2, 0);
            lblPresentPassword.Name = "lblPresentPassword";
            lblPresentPassword.Size = new Size(180, 28);
            lblPresentPassword.TabIndex = 3;
            lblPresentPassword.Text = "Mật khẩu hiện tại";
            // 
            // btnUpdate
            // 
            btnUpdate.BorderRadius = 40;
            btnUpdate.ButtonColor = Color.DarkRed;
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdate.Location = new Point(378, 430);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 39);
            btnUpdate.TabIndex = 28;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.TextColor = Color.White;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // ChangePasswordFirstTime
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(251, 236, 240);
            ClientSize = new Size(528, 499);
            Controls.Add(btnUpdate);
            Controls.Add(pnClassroomInformation);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "ChangePasswordFirstTime";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cập nhật mật khẩu";
            pnClassroomInformation.ResumeLayout(false);
            pnClassroomInformation.PerformLayout();
            pnClassroom.ResumeLayout(false);
            pnClassroom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CHEF.RoundedPanel1 pnClassroomInformation;
        private Label lblChangePassword;
        private RoundedPanel pnClassroom;
        private RoundedTextBox txtNewPassword;
        private Label lblNewPassword;
        private RoundedTextBox txtPresentPassword;
        private Label lblPresentPassword;
        private CLASSROOM.RoundedButton btnUpdate;
    }
}