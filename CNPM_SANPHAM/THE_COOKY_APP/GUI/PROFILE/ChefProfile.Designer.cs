namespace THE_COOKY_APP.GUI.PROFILE
{
    partial class ChefProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChefProfile));
            btnUpdate = new CLASSROOM.RoundedButton();
            panelFormAdd = new CHEF.RoundedPanel1();
            lblProfile = new Label();
            lblBasicInformation = new Label();
            panelBasicInformation = new LOGIN.RoundedPanel();
            cmbSpeciality = new LOGIN.RoundedComboBox();
            dtpStartDate = new CHEF.RoundedDateTimePicker();
            txtGmail = new LOGIN.RoundedTextBox();
            lblGmail = new Label();
            txtPhoneNumber = new LOGIN.RoundedTextBox();
            lblSpeciality = new Label();
            lblStartDate = new Label();
            lblPhoneNumber = new Label();
            lblFullName = new Label();
            txtFullName = new LOGIN.RoundedTextBox();
            panelPersonalProfile = new LOGIN.RoundedPanel();
            txtAddress = new LOGIN.RoundedTextBox();
            txtDateOfBirth = new LOGIN.RoundedTextBox();
            lblAddress = new Label();
            txtNativePlace = new LOGIN.RoundedTextBox();
            lblNativePlace = new Label();
            lblCCCD = new Label();
            txtCCCD = new LOGIN.RoundedTextBox();
            lblDateOfBirth = new Label();
            lblComment = new Label();
            panelFormAdd.SuspendLayout();
            panelBasicInformation.SuspendLayout();
            panelPersonalProfile.SuspendLayout();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.BorderRadius = 40;
            btnUpdate.ButtonColor = Color.DarkRed;
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdate.Location = new Point(906, 918);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 39);
            btnUpdate.TabIndex = 22;
            btnUpdate.Text = "Sửa";
            btnUpdate.TextColor = Color.White;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // panelFormAdd
            // 
            panelFormAdd.BorderRadius = 40;
            panelFormAdd.Controls.Add(lblProfile);
            panelFormAdd.Controls.Add(lblBasicInformation);
            panelFormAdd.Controls.Add(panelBasicInformation);
            panelFormAdd.Controls.Add(panelPersonalProfile);
            panelFormAdd.Location = new Point(168, 55);
            panelFormAdd.Margin = new Padding(2);
            panelFormAdd.Name = "panelFormAdd";
            panelFormAdd.Size = new Size(850, 828);
            panelFormAdd.TabIndex = 23;
            // 
            // lblProfile
            // 
            lblProfile.AutoSize = true;
            lblProfile.BackColor = Color.FromArgb(255, 227, 232);
            lblProfile.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProfile.ForeColor = Color.DarkRed;
            lblProfile.Location = new Point(291, 479);
            lblProfile.Margin = new Padding(2, 0, 2, 0);
            lblProfile.Name = "lblProfile";
            lblProfile.Size = new Size(268, 38);
            lblProfile.TabIndex = 23;
            lblProfile.Text = "THÔNG TIN HỒ SƠ";
            // 
            // lblBasicInformation
            // 
            lblBasicInformation.AutoSize = true;
            lblBasicInformation.BackColor = Color.FromArgb(255, 227, 232);
            lblBasicInformation.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBasicInformation.ForeColor = Color.DarkRed;
            lblBasicInformation.Location = new Point(282, 30);
            lblBasicInformation.Margin = new Padding(2, 0, 2, 0);
            lblBasicInformation.Name = "lblBasicInformation";
            lblBasicInformation.Size = new Size(287, 38);
            lblBasicInformation.TabIndex = 22;
            lblBasicInformation.Text = "THÔNG TIN CƠ BẢN";
            // 
            // panelBasicInformation
            // 
            panelBasicInformation.BorderRadius = 40;
            panelBasicInformation.Controls.Add(cmbSpeciality);
            panelBasicInformation.Controls.Add(dtpStartDate);
            panelBasicInformation.Controls.Add(txtGmail);
            panelBasicInformation.Controls.Add(lblGmail);
            panelBasicInformation.Controls.Add(txtPhoneNumber);
            panelBasicInformation.Controls.Add(lblSpeciality);
            panelBasicInformation.Controls.Add(lblStartDate);
            panelBasicInformation.Controls.Add(lblPhoneNumber);
            panelBasicInformation.Controls.Add(lblFullName);
            panelBasicInformation.Controls.Add(txtFullName);
            panelBasicInformation.Location = new Point(50, 90);
            panelBasicInformation.Margin = new Padding(2);
            panelBasicInformation.Name = "panelBasicInformation";
            panelBasicInformation.Size = new Size(750, 369);
            panelBasicInformation.TabIndex = 0;
            // 
            // cmbSpeciality
            // 
            cmbSpeciality.BackColor = Color.FromArgb(255, 227, 232);
            cmbSpeciality.BackgroundColor = Color.FromArgb(255, 227, 232);
            cmbSpeciality.BorderRadius = 15;
            cmbSpeciality.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSpeciality.Enabled = false;
            cmbSpeciality.FlatStyle = FlatStyle.Flat;
            cmbSpeciality.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbSpeciality.FormattingEnabled = true;
            cmbSpeciality.Location = new Point(38, 294);
            cmbSpeciality.Margin = new Padding(2);
            cmbSpeciality.Name = "cmbSpeciality";
            cmbSpeciality.Size = new Size(284, 36);
            cmbSpeciality.TabIndex = 5;
            // 
            // dtpStartDate
            // 
            dtpStartDate.BackgroundColor = Color.FromArgb(255, 227, 232);
            dtpStartDate.BorderRadius = 15;
            dtpStartDate.CustomFormat = "dd/MM/yyyy";
            dtpStartDate.Enabled = false;
            dtpStartDate.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.Location = new Point(432, 85);
            dtpStartDate.Margin = new Padding(2);
            dtpStartDate.MinimumSize = new Size(4, 36);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(284, 36);
            dtpStartDate.TabIndex = 2;
            // 
            // txtGmail
            // 
            txtGmail.BackColor = Color.FromArgb(255, 227, 232);
            txtGmail.BackgroundColor = Color.White;
            txtGmail.BorderRadius = 15;
            txtGmail.BorderStyle = BorderStyle.None;
            txtGmail.Enabled = false;
            txtGmail.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtGmail.Location = new Point(432, 195);
            txtGmail.Margin = new Padding(2);
            txtGmail.Multiline = true;
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(284, 36);
            txtGmail.TabIndex = 4;
            // 
            // lblGmail
            // 
            lblGmail.AutoSize = true;
            lblGmail.BackColor = Color.White;
            lblGmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblGmail.ForeColor = Color.DarkRed;
            lblGmail.Location = new Point(432, 140);
            lblGmail.Margin = new Padding(2, 0, 2, 0);
            lblGmail.Name = "lblGmail";
            lblGmail.Size = new Size(76, 28);
            lblGmail.TabIndex = 4;
            lblGmail.Text = "*Gmail";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = Color.FromArgb(255, 227, 232);
            txtPhoneNumber.BackgroundColor = Color.White;
            txtPhoneNumber.BorderRadius = 15;
            txtPhoneNumber.BorderStyle = BorderStyle.None;
            txtPhoneNumber.Enabled = false;
            txtPhoneNumber.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPhoneNumber.Location = new Point(38, 195);
            txtPhoneNumber.Margin = new Padding(2);
            txtPhoneNumber.Multiline = true;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(284, 36);
            txtPhoneNumber.TabIndex = 3;
            txtPhoneNumber.KeyPress += txtPhoneNumber_KeyPress;
            // 
            // lblSpeciality
            // 
            lblSpeciality.AutoSize = true;
            lblSpeciality.BackColor = Color.White;
            lblSpeciality.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSpeciality.ForeColor = Color.DarkRed;
            lblSpeciality.Location = new Point(38, 250);
            lblSpeciality.Margin = new Padding(2, 0, 2, 0);
            lblSpeciality.Name = "lblSpeciality";
            lblSpeciality.Size = new Size(139, 28);
            lblSpeciality.TabIndex = 5;
            lblSpeciality.Text = "*Chuyên môn";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.BackColor = Color.White;
            lblStartDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStartDate.ForeColor = Color.DarkRed;
            lblStartDate.Location = new Point(432, 30);
            lblStartDate.Margin = new Padding(2, 0, 2, 0);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(152, 28);
            lblStartDate.TabIndex = 2;
            lblStartDate.Text = "*Ngày vào làm";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.BackColor = Color.White;
            lblPhoneNumber.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPhoneNumber.ForeColor = Color.DarkRed;
            lblPhoneNumber.Location = new Point(38, 140);
            lblPhoneNumber.Margin = new Padding(2, 0, 2, 0);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(147, 28);
            lblPhoneNumber.TabIndex = 3;
            lblPhoneNumber.Text = "*Số điện thoại";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.BackColor = Color.White;
            lblFullName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFullName.ForeColor = Color.DarkRed;
            lblFullName.Location = new Point(38, 30);
            lblFullName.Margin = new Padding(2, 0, 2, 0);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(147, 28);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "*Tên giáo viên";
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.FromArgb(255, 227, 232);
            txtFullName.BackgroundColor = Color.White;
            txtFullName.BorderRadius = 15;
            txtFullName.BorderStyle = BorderStyle.None;
            txtFullName.Enabled = false;
            txtFullName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(38, 85);
            txtFullName.Margin = new Padding(2);
            txtFullName.Multiline = true;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(284, 36);
            txtFullName.TabIndex = 1;
            // 
            // panelPersonalProfile
            // 
            panelPersonalProfile.BorderRadius = 40;
            panelPersonalProfile.Controls.Add(txtAddress);
            panelPersonalProfile.Controls.Add(txtDateOfBirth);
            panelPersonalProfile.Controls.Add(lblAddress);
            panelPersonalProfile.Controls.Add(txtNativePlace);
            panelPersonalProfile.Controls.Add(lblNativePlace);
            panelPersonalProfile.Controls.Add(lblCCCD);
            panelPersonalProfile.Controls.Add(txtCCCD);
            panelPersonalProfile.Controls.Add(lblDateOfBirth);
            panelPersonalProfile.Location = new Point(59, 539);
            panelPersonalProfile.Margin = new Padding(2);
            panelPersonalProfile.Name = "panelPersonalProfile";
            panelPersonalProfile.Size = new Size(750, 259);
            panelPersonalProfile.TabIndex = 6;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.FromArgb(255, 227, 232);
            txtAddress.BackgroundColor = Color.White;
            txtAddress.BorderRadius = 15;
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.Enabled = false;
            txtAddress.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(432, 195);
            txtAddress.Margin = new Padding(2);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(284, 36);
            txtAddress.TabIndex = 9;
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.BackColor = Color.FromArgb(255, 227, 232);
            txtDateOfBirth.BackgroundColor = Color.White;
            txtDateOfBirth.BorderRadius = 15;
            txtDateOfBirth.BorderStyle = BorderStyle.None;
            txtDateOfBirth.Enabled = false;
            txtDateOfBirth.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDateOfBirth.Location = new Point(432, 85);
            txtDateOfBirth.Margin = new Padding(2);
            txtDateOfBirth.Multiline = true;
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.Size = new Size(284, 36);
            txtDateOfBirth.TabIndex = 7;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.White;
            lblAddress.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAddress.ForeColor = Color.DarkRed;
            lblAddress.Location = new Point(432, 140);
            lblAddress.Margin = new Padding(2, 0, 2, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(78, 28);
            lblAddress.TabIndex = 10;
            lblAddress.Text = "Địa chỉ";
            // 
            // txtNativePlace
            // 
            txtNativePlace.BackColor = Color.FromArgb(255, 227, 232);
            txtNativePlace.BackgroundColor = Color.White;
            txtNativePlace.BorderRadius = 15;
            txtNativePlace.BorderStyle = BorderStyle.None;
            txtNativePlace.Enabled = false;
            txtNativePlace.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNativePlace.Location = new Point(38, 195);
            txtNativePlace.Margin = new Padding(2);
            txtNativePlace.Multiline = true;
            txtNativePlace.Name = "txtNativePlace";
            txtNativePlace.Size = new Size(284, 36);
            txtNativePlace.TabIndex = 8;
            // 
            // lblNativePlace
            // 
            lblNativePlace.AutoSize = true;
            lblNativePlace.BackColor = Color.White;
            lblNativePlace.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNativePlace.ForeColor = Color.DarkRed;
            lblNativePlace.Location = new Point(38, 140);
            lblNativePlace.Margin = new Padding(2, 0, 2, 0);
            lblNativePlace.Name = "lblNativePlace";
            lblNativePlace.Size = new Size(139, 28);
            lblNativePlace.TabIndex = 9;
            lblNativePlace.Text = "Nguyên quán";
            // 
            // lblCCCD
            // 
            lblCCCD.AutoSize = true;
            lblCCCD.BackColor = Color.White;
            lblCCCD.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCCCD.ForeColor = Color.DarkRed;
            lblCCCD.Location = new Point(38, 30);
            lblCCCD.Margin = new Padding(2, 0, 2, 0);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(61, 28);
            lblCCCD.TabIndex = 7;
            lblCCCD.Text = "CCCD";
            // 
            // txtCCCD
            // 
            txtCCCD.BackColor = Color.FromArgb(255, 227, 232);
            txtCCCD.BackgroundColor = Color.White;
            txtCCCD.BorderRadius = 15;
            txtCCCD.BorderStyle = BorderStyle.None;
            txtCCCD.Enabled = false;
            txtCCCD.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCCCD.Location = new Point(38, 85);
            txtCCCD.Margin = new Padding(2);
            txtCCCD.Multiline = true;
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(284, 36);
            txtCCCD.TabIndex = 6;
            txtCCCD.KeyPress += txtCCCD_KeyPress;
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.BackColor = Color.White;
            lblDateOfBirth.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDateOfBirth.ForeColor = Color.DarkRed;
            lblDateOfBirth.Location = new Point(432, 30);
            lblDateOfBirth.Margin = new Padding(2, 0, 2, 0);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(116, 28);
            lblDateOfBirth.TabIndex = 8;
            lblDateOfBirth.Text = "*Ngày sinh";
            // 
            // lblComment
            // 
            lblComment.AutoSize = true;
            lblComment.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblComment.Location = new Point(698, 18);
            lblComment.Margin = new Padding(2, 0, 2, 0);
            lblComment.Name = "lblComment";
            lblComment.Size = new Size(321, 25);
            lblComment.TabIndex = 30;
            lblComment.Text = "Dấu * thể hiện trường dữ liệu bắt buộc";
            // 
            // ChefProfile
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(251, 236, 240);
            ClientSize = new Size(1178, 994);
            Controls.Add(lblComment);
            Controls.Add(panelFormAdd);
            Controls.Add(btnUpdate);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "ChefProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hồ sơ giáo viên";
            panelFormAdd.ResumeLayout(false);
            panelFormAdd.PerformLayout();
            panelBasicInformation.ResumeLayout(false);
            panelBasicInformation.PerformLayout();
            panelPersonalProfile.ResumeLayout(false);
            panelPersonalProfile.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CLASSROOM.RoundedButton btnUpdate;
        private CHEF.RoundedPanel1 panelFormAdd;
        private Label lblProfile;
        private Label lblBasicInformation;
        private LOGIN.RoundedPanel panelBasicInformation;
        private CHEF.RoundedDateTimePicker dtpStartDate;
        private LOGIN.RoundedTextBox txtGmail;
        private Label lblGmail;
        private LOGIN.RoundedTextBox txtPhoneNumber;
        private Label lblSpeciality;
        private Label lblStartDate;
        private Label lblPhoneNumber;
        private Label lblFullName;
        private LOGIN.RoundedTextBox txtFullName;
        private LOGIN.RoundedPanel panelPersonalProfile;
        private LOGIN.RoundedTextBox txtAddress;
        private LOGIN.RoundedTextBox txtDateOfBirth;
        private Label lblAddress;
        private LOGIN.RoundedTextBox txtNativePlace;
        private Label lblNativePlace;
        private Label lblCCCD;
        private LOGIN.RoundedTextBox txtCCCD;
        private Label lblDateOfBirth;
        private Label lblComment;
        private LOGIN.RoundedComboBox cmbSpeciality;
    }
}