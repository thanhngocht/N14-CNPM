namespace THE_COOKY_APP.GUI.ACCOUNT
{
    partial class CreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            lblRole = new Label();
            btnAdd = new CLASSROOM.RoundedButton();
            pnFormAddAccount = new CHEF.RoundedPanel1();
            lblEmployeeInformation = new Label();
            lblAccountInformation = new Label();
            pnEmployeeInformation = new LOGIN.RoundedPanel();
            txtAddress = new LOGIN.RoundedTextBox();
            cmbRole = new LOGIN.RoundedComboBox();
            lblAddress = new Label();
            txtDateOfBirth = new LOGIN.RoundedTextBox();
            txtGmail = new LOGIN.RoundedTextBox();
            txtPhoneNumber = new LOGIN.RoundedTextBox();
            lblDateOfBirth = new Label();
            txtNativePlace = new LOGIN.RoundedTextBox();
            lblNativePlace = new Label();
            txtFullName = new LOGIN.RoundedTextBox();
            lblCCCD = new Label();
            txtCCCD = new LOGIN.RoundedTextBox();
            lblFullName = new Label();
            lblGmail = new Label();
            lblPhoneNumber = new Label();
            pnAccountInformation = new LOGIN.RoundedPanel();
            lblUsername = new Label();
            txtUsername = new LOGIN.RoundedTextBox();
            txtPassword = new LOGIN.RoundedTextBox();
            lblPassword = new Label();
            lblComment = new Label();
            pnFormAddAccount.SuspendLayout();
            pnEmployeeInformation.SuspendLayout();
            pnAccountInformation.SuspendLayout();
            SuspendLayout();
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.BackColor = Color.White;
            lblRole.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRole.ForeColor = Color.DarkRed;
            lblRole.Location = new Point(38, 140);
            lblRole.Margin = new Padding(2, 0, 2, 0);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(97, 28);
            lblRole.TabIndex = 6;
            lblRole.Text = "*Chức vụ";
            // 
            // btnAdd
            // 
            btnAdd.BorderRadius = 40;
            btnAdd.ButtonColor = Color.DarkRed;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.Location = new Point(906, 918);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 39);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Thêm";
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // pnFormAddAccount
            // 
            pnFormAddAccount.BorderRadius = 40;
            pnFormAddAccount.Controls.Add(lblEmployeeInformation);
            pnFormAddAccount.Controls.Add(lblAccountInformation);
            pnFormAddAccount.Controls.Add(pnEmployeeInformation);
            pnFormAddAccount.Controls.Add(pnAccountInformation);
            pnFormAddAccount.Location = new Point(168, 55);
            pnFormAddAccount.Margin = new Padding(2);
            pnFormAddAccount.Name = "pnFormAddAccount";
            pnFormAddAccount.Size = new Size(850, 834);
            pnFormAddAccount.TabIndex = 22;
            // 
            // lblEmployeeInformation
            // 
            lblEmployeeInformation.AutoSize = true;
            lblEmployeeInformation.BackColor = Color.FromArgb(255, 227, 232);
            lblEmployeeInformation.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmployeeInformation.ForeColor = Color.DarkRed;
            lblEmployeeInformation.Location = new Point(256, 262);
            lblEmployeeInformation.Margin = new Padding(2, 0, 2, 0);
            lblEmployeeInformation.Name = "lblEmployeeInformation";
            lblEmployeeInformation.Size = new Size(338, 38);
            lblEmployeeInformation.TabIndex = 23;
            lblEmployeeInformation.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // lblAccountInformation
            // 
            lblAccountInformation.AutoSize = true;
            lblAccountInformation.BackColor = Color.FromArgb(255, 227, 232);
            lblAccountInformation.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccountInformation.ForeColor = Color.DarkRed;
            lblAccountInformation.Location = new Point(259, 30);
            lblAccountInformation.Margin = new Padding(2, 0, 2, 0);
            lblAccountInformation.Name = "lblAccountInformation";
            lblAccountInformation.Size = new Size(333, 38);
            lblAccountInformation.TabIndex = 22;
            lblAccountInformation.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // pnEmployeeInformation
            // 
            pnEmployeeInformation.BorderRadius = 40;
            pnEmployeeInformation.Controls.Add(txtAddress);
            pnEmployeeInformation.Controls.Add(cmbRole);
            pnEmployeeInformation.Controls.Add(lblAddress);
            pnEmployeeInformation.Controls.Add(txtDateOfBirth);
            pnEmployeeInformation.Controls.Add(txtGmail);
            pnEmployeeInformation.Controls.Add(txtPhoneNumber);
            pnEmployeeInformation.Controls.Add(lblDateOfBirth);
            pnEmployeeInformation.Controls.Add(txtNativePlace);
            pnEmployeeInformation.Controls.Add(lblNativePlace);
            pnEmployeeInformation.Controls.Add(txtFullName);
            pnEmployeeInformation.Controls.Add(lblCCCD);
            pnEmployeeInformation.Controls.Add(lblRole);
            pnEmployeeInformation.Controls.Add(txtCCCD);
            pnEmployeeInformation.Controls.Add(lblFullName);
            pnEmployeeInformation.Controls.Add(lblGmail);
            pnEmployeeInformation.Controls.Add(lblPhoneNumber);
            pnEmployeeInformation.Location = new Point(50, 322);
            pnEmployeeInformation.Margin = new Padding(2);
            pnEmployeeInformation.Name = "pnEmployeeInformation";
            pnEmployeeInformation.Size = new Size(750, 481);
            pnEmployeeInformation.TabIndex = 3;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.FromArgb(255, 227, 232);
            txtAddress.BackgroundColor = Color.White;
            txtAddress.BorderRadius = 15;
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(38, 305);
            txtAddress.Margin = new Padding(2);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(284, 36);
            txtAddress.TabIndex = 8;
            // 
            // cmbRole
            // 
            cmbRole.BackColor = Color.FromArgb(255, 227, 232);
            cmbRole.BackgroundColor = Color.FromArgb(255, 227, 232);
            cmbRole.BorderRadius = 15;
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.FlatStyle = FlatStyle.Flat;
            cmbRole.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(38, 195);
            cmbRole.Margin = new Padding(2);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(284, 36);
            cmbRole.TabIndex = 6;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.White;
            lblAddress.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAddress.ForeColor = Color.DarkRed;
            lblAddress.Location = new Point(38, 250);
            lblAddress.Margin = new Padding(2, 0, 2, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(78, 28);
            lblAddress.TabIndex = 8;
            lblAddress.Text = "Địa chỉ";
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.BackColor = Color.FromArgb(255, 227, 232);
            txtDateOfBirth.BackgroundColor = Color.White;
            txtDateOfBirth.BorderRadius = 15;
            txtDateOfBirth.BorderStyle = BorderStyle.None;
            txtDateOfBirth.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDateOfBirth.Location = new Point(432, 305);
            txtDateOfBirth.Margin = new Padding(2);
            txtDateOfBirth.Multiline = true;
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.Size = new Size(284, 36);
            txtDateOfBirth.TabIndex = 9;
            // 
            // txtGmail
            // 
            txtGmail.BackColor = Color.FromArgb(255, 227, 232);
            txtGmail.BackgroundColor = Color.White;
            txtGmail.BorderRadius = 15;
            txtGmail.BorderStyle = BorderStyle.None;
            txtGmail.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtGmail.Location = new Point(432, 195);
            txtGmail.Margin = new Padding(2);
            txtGmail.Multiline = true;
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(284, 36);
            txtGmail.TabIndex = 7;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = Color.FromArgb(255, 227, 232);
            txtPhoneNumber.BackgroundColor = Color.White;
            txtPhoneNumber.BorderRadius = 15;
            txtPhoneNumber.BorderStyle = BorderStyle.None;
            txtPhoneNumber.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPhoneNumber.Location = new Point(432, 85);
            txtPhoneNumber.Margin = new Padding(2);
            txtPhoneNumber.Multiline = true;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(284, 36);
            txtPhoneNumber.TabIndex = 5;
            txtPhoneNumber.KeyPress += txtPhoneNumber_KeyPress;
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.BackColor = Color.White;
            lblDateOfBirth.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDateOfBirth.ForeColor = Color.DarkRed;
            lblDateOfBirth.Location = new Point(432, 250);
            lblDateOfBirth.Margin = new Padding(2, 0, 2, 0);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(107, 28);
            lblDateOfBirth.TabIndex = 9;
            lblDateOfBirth.Text = "Ngày sinh";
            // 
            // txtNativePlace
            // 
            txtNativePlace.BackColor = Color.FromArgb(255, 227, 232);
            txtNativePlace.BackgroundColor = Color.White;
            txtNativePlace.BorderRadius = 15;
            txtNativePlace.BorderStyle = BorderStyle.None;
            txtNativePlace.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNativePlace.Location = new Point(432, 415);
            txtNativePlace.Margin = new Padding(2);
            txtNativePlace.Multiline = true;
            txtNativePlace.Name = "txtNativePlace";
            txtNativePlace.Size = new Size(284, 36);
            txtNativePlace.TabIndex = 11;
            // 
            // lblNativePlace
            // 
            lblNativePlace.AutoSize = true;
            lblNativePlace.BackColor = Color.White;
            lblNativePlace.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNativePlace.ForeColor = Color.DarkRed;
            lblNativePlace.Location = new Point(432, 360);
            lblNativePlace.Margin = new Padding(2, 0, 2, 0);
            lblNativePlace.Name = "lblNativePlace";
            lblNativePlace.Size = new Size(139, 28);
            lblNativePlace.TabIndex = 11;
            lblNativePlace.Text = "Nguyên quán";
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.FromArgb(255, 227, 232);
            txtFullName.BackgroundColor = Color.White;
            txtFullName.BorderRadius = 15;
            txtFullName.BorderStyle = BorderStyle.None;
            txtFullName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(38, 85);
            txtFullName.Margin = new Padding(2);
            txtFullName.Multiline = true;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(284, 36);
            txtFullName.TabIndex = 4;
            // 
            // lblCCCD
            // 
            lblCCCD.AutoSize = true;
            lblCCCD.BackColor = Color.White;
            lblCCCD.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCCCD.ForeColor = Color.DarkRed;
            lblCCCD.Location = new Point(38, 360);
            lblCCCD.Margin = new Padding(2, 0, 2, 0);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(61, 28);
            lblCCCD.TabIndex = 10;
            lblCCCD.Text = "CCCD";
            // 
            // txtCCCD
            // 
            txtCCCD.BackColor = Color.FromArgb(255, 227, 232);
            txtCCCD.BackgroundColor = Color.White;
            txtCCCD.BorderRadius = 15;
            txtCCCD.BorderStyle = BorderStyle.None;
            txtCCCD.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCCCD.Location = new Point(38, 415);
            txtCCCD.Margin = new Padding(2);
            txtCCCD.Multiline = true;
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(284, 36);
            txtCCCD.TabIndex = 10;
            txtCCCD.KeyPress += txtCCCD_KeyPress;
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
            lblFullName.Size = new Size(113, 28);
            lblFullName.TabIndex = 4;
            lblFullName.Text = "*Họ và tên";
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
            lblGmail.TabIndex = 7;
            lblGmail.Text = "*Gmail";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.BackColor = Color.White;
            lblPhoneNumber.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPhoneNumber.ForeColor = Color.DarkRed;
            lblPhoneNumber.Location = new Point(432, 30);
            lblPhoneNumber.Margin = new Padding(2, 0, 2, 0);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(147, 28);
            lblPhoneNumber.TabIndex = 5;
            lblPhoneNumber.Text = "*Số điện thoại";
            // 
            // pnAccountInformation
            // 
            pnAccountInformation.BorderRadius = 40;
            pnAccountInformation.Controls.Add(lblUsername);
            pnAccountInformation.Controls.Add(txtUsername);
            pnAccountInformation.Controls.Add(txtPassword);
            pnAccountInformation.Controls.Add(lblPassword);
            pnAccountInformation.Location = new Point(50, 90);
            pnAccountInformation.Margin = new Padding(2);
            pnAccountInformation.Name = "pnAccountInformation";
            pnAccountInformation.Size = new Size(750, 151);
            pnAccountInformation.TabIndex = 0;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.White;
            lblUsername.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsername.ForeColor = Color.DarkRed;
            lblUsername.Location = new Point(38, 30);
            lblUsername.Margin = new Padding(2, 0, 2, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(112, 28);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "*Tài khoản";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(255, 227, 232);
            txtUsername.BackgroundColor = Color.White;
            txtUsername.BorderRadius = 15;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(38, 85);
            txtUsername.Margin = new Padding(2);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(284, 36);
            txtUsername.TabIndex = 1;
            txtUsername.TextAlign = HorizontalAlignment.Center;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(255, 227, 232);
            txtPassword.BackgroundColor = Color.White;
            txtPassword.BorderRadius = 15;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Enabled = false;
            txtPassword.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(432, 85);
            txtPassword.Margin = new Padding(2);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(284, 36);
            txtPassword.TabIndex = 2;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.White;
            lblPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPassword.ForeColor = Color.DarkRed;
            lblPassword.Location = new Point(432, 30);
            lblPassword.Margin = new Padding(2, 0, 2, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(111, 28);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "*Mật khẩu";
            // 
            // lblComment
            // 
            lblComment.AutoSize = true;
            lblComment.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblComment.Location = new Point(698, 14);
            lblComment.Margin = new Padding(2, 0, 2, 0);
            lblComment.Name = "lblComment";
            lblComment.Size = new Size(321, 25);
            lblComment.TabIndex = 29;
            lblComment.Text = "Dấu * thể hiện trường dữ liệu bắt buộc";
            // 
            // CreateAccount
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(251, 236, 240);
            ClientSize = new Size(1178, 994);
            Controls.Add(lblComment);
            Controls.Add(pnFormAddAccount);
            Controls.Add(btnAdd);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "CreateAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tạo tài khoản";
            pnFormAddAccount.ResumeLayout(false);
            pnFormAddAccount.PerformLayout();
            pnEmployeeInformation.ResumeLayout(false);
            pnEmployeeInformation.PerformLayout();
            pnAccountInformation.ResumeLayout(false);
            pnAccountInformation.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblPassword;
        private Label lblUsername;
        private Label lblPhoneNumber;
        private CLASSROOM.RoundedButton btnAdd;
        private Label lblRole;
        private CHEF.RoundedPanel1 pnFormAddAccount;
        private Label lblEmployeeInformation;
        private Label lblAccountInformation;
        private LOGIN.RoundedPanel pnEmployeeInformation;
        private Label lblFullName;
        private LOGIN.RoundedPanel pnAccountInformation;
        private LOGIN.RoundedTextBox txtAddress;
        private LOGIN.RoundedTextBox txtDateOfBirth;
        private Label lblAddress;
        private LOGIN.RoundedTextBox txtNativePlace;
        private Label lblNativePlace;
        private Label lblCCCD;
        private LOGIN.RoundedTextBox txtCCCD;
        private Label lblDateOfBirth;
        private Label lblGmail;
        private LOGIN.RoundedTextBox txtPassword;
        private LOGIN.RoundedTextBox txtUsername;
        private LOGIN.RoundedTextBox txtFullName;
        private LOGIN.RoundedTextBox txtGmail;
        private LOGIN.RoundedTextBox txtPhoneNumber;
        private LOGIN.RoundedComboBox cmbRole;
        private Label lblComment;
    }
}