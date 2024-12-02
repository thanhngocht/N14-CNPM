namespace THE_COOKY_APP.GUI.STUDENT
{
    partial class CreateStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateStudent));
            btnAdd = new CLASSROOM.RoundedButton();
            pnFormAddStudent = new CHEF.RoundedPanel1();
            pnStudentInformation = new LOGIN.RoundedPanel();
            txtGmail = new LOGIN.RoundedTextBox();
            lblGmail = new Label();
            txtGender = new LOGIN.RoundedTextBox();
            txtDateOfBirth = new LOGIN.RoundedTextBox();
            txtPhoneNumber = new LOGIN.RoundedTextBox();
            txtNameStudent = new LOGIN.RoundedTextBox();
            lblGender = new Label();
            lblDateOfBirth = new Label();
            lblPhoneNumber = new Label();
            lblNameStudent = new Label();
            lblStudent = new Label();
            lblComment = new Label();
            pnFormAddStudent.SuspendLayout();
            pnStudentInformation.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BorderRadius = 40;
            btnAdd.ButtonColor = Color.DarkRed;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(802, 586);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 39);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Thêm";
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // pnFormAddStudent
            // 
            pnFormAddStudent.BorderRadius = 40;
            pnFormAddStudent.Controls.Add(pnStudentInformation);
            pnFormAddStudent.Controls.Add(lblStudent);
            pnFormAddStudent.Location = new Point(65, 50);
            pnFormAddStudent.Margin = new Padding(2);
            pnFormAddStudent.Name = "pnFormAddStudent";
            pnFormAddStudent.Size = new Size(850, 506);
            pnFormAddStudent.TabIndex = 20;
            // 
            // pnStudentInformation
            // 
            pnStudentInformation.BorderRadius = 40;
            pnStudentInformation.Controls.Add(txtGmail);
            pnStudentInformation.Controls.Add(lblGmail);
            pnStudentInformation.Controls.Add(txtGender);
            pnStudentInformation.Controls.Add(txtDateOfBirth);
            pnStudentInformation.Controls.Add(txtPhoneNumber);
            pnStudentInformation.Controls.Add(txtNameStudent);
            pnStudentInformation.Controls.Add(lblGender);
            pnStudentInformation.Controls.Add(lblDateOfBirth);
            pnStudentInformation.Controls.Add(lblPhoneNumber);
            pnStudentInformation.Controls.Add(lblNameStudent);
            pnStudentInformation.Location = new Point(50, 90);
            pnStudentInformation.Margin = new Padding(2);
            pnStudentInformation.Name = "pnStudentInformation";
            pnStudentInformation.Size = new Size(750, 371);
            pnStudentInformation.TabIndex = 2;
            // 
            // txtGmail
            // 
            txtGmail.BackColor = Color.FromArgb(255, 227, 232);
            txtGmail.BackgroundColor = Color.FromArgb(255, 227, 232);
            txtGmail.BorderRadius = 15;
            txtGmail.BorderStyle = BorderStyle.None;
            txtGmail.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtGmail.Location = new Point(38, 305);
            txtGmail.Margin = new Padding(2);
            txtGmail.Multiline = true;
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(284, 36);
            txtGmail.TabIndex = 5;
            // 
            // lblGmail
            // 
            lblGmail.AutoSize = true;
            lblGmail.BackColor = Color.White;
            lblGmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGmail.ForeColor = Color.DarkRed;
            lblGmail.Location = new Point(38, 250);
            lblGmail.Margin = new Padding(2, 0, 2, 0);
            lblGmail.Name = "lblGmail";
            lblGmail.Size = new Size(76, 28);
            lblGmail.TabIndex = 6;
            lblGmail.Text = "*Gmail";
            // 
            // txtGender
            // 
            txtGender.BackColor = Color.FromArgb(255, 227, 232);
            txtGender.BackgroundColor = Color.FromArgb(255, 227, 232);
            txtGender.BorderRadius = 15;
            txtGender.BorderStyle = BorderStyle.None;
            txtGender.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtGender.Location = new Point(432, 195);
            txtGender.Margin = new Padding(2);
            txtGender.Multiline = true;
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(284, 36);
            txtGender.TabIndex = 4;
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.BackColor = Color.FromArgb(255, 227, 232);
            txtDateOfBirth.BackgroundColor = Color.FromArgb(255, 227, 232);
            txtDateOfBirth.BorderRadius = 15;
            txtDateOfBirth.BorderStyle = BorderStyle.None;
            txtDateOfBirth.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDateOfBirth.Location = new Point(432, 85);
            txtDateOfBirth.Margin = new Padding(2);
            txtDateOfBirth.Multiline = true;
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.Size = new Size(284, 36);
            txtDateOfBirth.TabIndex = 2;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = Color.FromArgb(255, 227, 232);
            txtPhoneNumber.BackgroundColor = Color.FromArgb(255, 227, 232);
            txtPhoneNumber.BorderRadius = 15;
            txtPhoneNumber.BorderStyle = BorderStyle.None;
            txtPhoneNumber.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPhoneNumber.Location = new Point(38, 195);
            txtPhoneNumber.Margin = new Padding(2);
            txtPhoneNumber.Multiline = true;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(284, 36);
            txtPhoneNumber.TabIndex = 3;
            // 
            // txtNameStudent
            // 
            txtNameStudent.BackColor = Color.FromArgb(255, 227, 232);
            txtNameStudent.BackgroundColor = Color.FromArgb(255, 227, 232);
            txtNameStudent.BorderRadius = 15;
            txtNameStudent.BorderStyle = BorderStyle.None;
            txtNameStudent.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNameStudent.Location = new Point(38, 85);
            txtNameStudent.Margin = new Padding(2);
            txtNameStudent.Multiline = true;
            txtNameStudent.Name = "txtNameStudent";
            txtNameStudent.Size = new Size(284, 36);
            txtNameStudent.TabIndex = 1;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.BackColor = Color.White;
            lblGender.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGender.ForeColor = Color.DarkRed;
            lblGender.Location = new Point(432, 140);
            lblGender.Margin = new Padding(2, 0, 2, 0);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(104, 28);
            lblGender.TabIndex = 4;
            lblGender.Text = "*Giới tính";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.BackColor = Color.White;
            lblDateOfBirth.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateOfBirth.ForeColor = Color.DarkRed;
            lblDateOfBirth.Location = new Point(432, 30);
            lblDateOfBirth.Margin = new Padding(2, 0, 2, 0);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(111, 28);
            lblDateOfBirth.TabIndex = 3;
            lblDateOfBirth.Text = "*Năm sinh";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.BackColor = Color.White;
            lblPhoneNumber.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhoneNumber.ForeColor = Color.DarkRed;
            lblPhoneNumber.Location = new Point(38, 140);
            lblPhoneNumber.Margin = new Padding(2, 0, 2, 0);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(147, 28);
            lblPhoneNumber.TabIndex = 2;
            lblPhoneNumber.Text = "*Số điện thoại";
            // 
            // lblNameStudent
            // 
            lblNameStudent.AutoSize = true;
            lblNameStudent.BackColor = Color.White;
            lblNameStudent.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNameStudent.ForeColor = Color.DarkRed;
            lblNameStudent.Location = new Point(38, 30);
            lblNameStudent.Margin = new Padding(2, 0, 2, 0);
            lblNameStudent.Name = "lblNameStudent";
            lblNameStudent.Size = new Size(140, 28);
            lblNameStudent.TabIndex = 1;
            lblNameStudent.Text = "*Tên học viên";
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.BackColor = Color.FromArgb(255, 227, 232);
            lblStudent.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudent.ForeColor = Color.DarkRed;
            lblStudent.Location = new Point(269, 30);
            lblStudent.Margin = new Padding(2, 0, 2, 0);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(312, 38);
            lblStudent.TabIndex = 1;
            lblStudent.Text = "THÔNG TIN HỌC VIÊN";
            // 
            // lblComment
            // 
            lblComment.AutoSize = true;
            lblComment.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblComment.Location = new Point(594, 12);
            lblComment.Margin = new Padding(2, 0, 2, 0);
            lblComment.Name = "lblComment";
            lblComment.Size = new Size(321, 25);
            lblComment.TabIndex = 29;
            lblComment.Text = "Dấu * thể hiện trường dữ liệu bắt buộc";
            // 
            // CreateStudent
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(251, 236, 240);
            ClientSize = new Size(978, 664);
            Controls.Add(lblComment);
            Controls.Add(pnFormAddStudent);
            Controls.Add(btnAdd);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "CreateStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm học viên";
            pnFormAddStudent.ResumeLayout(false);
            pnFormAddStudent.PerformLayout();
            pnStudentInformation.ResumeLayout(false);
            pnStudentInformation.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CLASSROOM.RoundedButton btnAdd;
        private CHEF.RoundedPanel1 pnFormAddStudent;
        private LOGIN.RoundedPanel pnStudentInformation;
        private LOGIN.RoundedTextBox txtPhoneNumber;
        private LOGIN.RoundedTextBox txtNameStudent;
        private Label lblDateOfBirth;
        private Label lblPhoneNumber;
        private Label lblStudent;
        private Label lblNameStudent;
        private LOGIN.RoundedTextBox txtGmail;
        private Label lblGmail;
        private LOGIN.RoundedTextBox txtGender;
        private LOGIN.RoundedTextBox txtDateOfBirth;
        private Label lblGender;
        private Label lblComment;
    }
}