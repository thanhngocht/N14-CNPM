namespace THE_COOKY_APP.GUI.STUDENT
{
    partial class ListStudent
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListStudent));
            lblGmail = new Label();
            lblDateOfBirth = new Label();
            lblGender = new Label();
            lblPhoneNumber = new Label();
            lblNameStudent = new Label();
            pnAction = new CHEF.RoundedPanel1();
            pnSearch = new LOGIN.RoundedPanel();
            lblFilter = new Label();
            cmbFilter = new LOGIN.RoundedComboBox();
            txtSearch = new LOGIN.RoundedTextBox();
            lblSearch = new Label();
            pnDetailStudent = new CHEF.RoundedPanel1();
            roundedPanel2 = new LOGIN.RoundedPanel();
            btnUpdate = new CLASSROOM.RoundedButton();
            btnCancel = new CLASSROOM.RoundedButton();
            pnStudent = new LOGIN.RoundedPanel();
            txtGender = new LOGIN.RoundedTextBox();
            txtGmail = new LOGIN.RoundedTextBox();
            dtpDateOfBirth = new CHEF.RoundedDateTimePicker();
            txtPhoneNumber = new LOGIN.RoundedTextBox();
            txtNameStudent = new LOGIN.RoundedTextBox();
            pnListStudent = new LOGIN.RoundedPanel();
            dgvListStudent = new CLASSROOM.RoundedDataGridView();
            colIdStudent = new DataGridViewTextBoxColumn();
            colNameStudent = new DataGridViewTextBoxColumn();
            colPhoneNumber = new DataGridViewTextBoxColumn();
            colGmail = new DataGridViewTextBoxColumn();
            lblComment = new Label();
            pnAction.SuspendLayout();
            pnSearch.SuspendLayout();
            pnDetailStudent.SuspendLayout();
            roundedPanel2.SuspendLayout();
            pnStudent.SuspendLayout();
            pnListStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListStudent).BeginInit();
            SuspendLayout();
            // 
            // lblGmail
            // 
            lblGmail.AutoSize = true;
            lblGmail.BackColor = Color.White;
            lblGmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblGmail.ForeColor = Color.DarkRed;
            lblGmail.Location = new Point(38, 360);
            lblGmail.Margin = new Padding(2, 0, 2, 0);
            lblGmail.Name = "lblGmail";
            lblGmail.Size = new Size(76, 28);
            lblGmail.TabIndex = 11;
            lblGmail.Text = "*Gmail";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.BackColor = Color.White;
            lblDateOfBirth.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDateOfBirth.ForeColor = Color.DarkRed;
            lblDateOfBirth.Location = new Point(38, 250);
            lblDateOfBirth.Margin = new Padding(2, 0, 2, 0);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(111, 28);
            lblDateOfBirth.TabIndex = 6;
            lblDateOfBirth.Text = "*Năm sinh";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.BackColor = Color.White;
            lblGender.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblGender.ForeColor = Color.DarkRed;
            lblGender.Location = new Point(38, 470);
            lblGender.Margin = new Padding(2, 0, 2, 0);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(104, 28);
            lblGender.TabIndex = 5;
            lblGender.Text = "*Giới tính";
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
            lblPhoneNumber.TabIndex = 4;
            lblPhoneNumber.Text = "*Số điện thoại";
            // 
            // lblNameStudent
            // 
            lblNameStudent.AutoSize = true;
            lblNameStudent.BackColor = Color.White;
            lblNameStudent.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNameStudent.ForeColor = Color.DarkRed;
            lblNameStudent.Location = new Point(38, 30);
            lblNameStudent.Margin = new Padding(2, 0, 2, 0);
            lblNameStudent.Name = "lblNameStudent";
            lblNameStudent.Size = new Size(140, 28);
            lblNameStudent.TabIndex = 3;
            lblNameStudent.Text = "*Tên học viên";
            // 
            // pnAction
            // 
            pnAction.BorderRadius = 40;
            pnAction.Controls.Add(pnSearch);
            pnAction.Location = new Point(40, 42);
            pnAction.Margin = new Padding(2);
            pnAction.Name = "pnAction";
            pnAction.Size = new Size(712, 205);
            pnAction.TabIndex = 17;
            // 
            // pnSearch
            // 
            pnSearch.BorderRadius = 40;
            pnSearch.Controls.Add(lblFilter);
            pnSearch.Controls.Add(cmbFilter);
            pnSearch.Controls.Add(txtSearch);
            pnSearch.Controls.Add(lblSearch);
            pnSearch.Location = new Point(28, 28);
            pnSearch.Margin = new Padding(2);
            pnSearch.Name = "pnSearch";
            pnSearch.Size = new Size(658, 151);
            pnSearch.TabIndex = 0;
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.BackColor = Color.White;
            lblFilter.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilter.ForeColor = Color.DarkRed;
            lblFilter.Location = new Point(352, 30);
            lblFilter.Margin = new Padding(2, 0, 2, 0);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(71, 28);
            lblFilter.TabIndex = 10;
            lblFilter.Text = "Bộ lọc";
            // 
            // cmbFilter
            // 
            cmbFilter.BackColor = Color.FromArgb(255, 227, 232);
            cmbFilter.BackgroundColor = Color.White;
            cmbFilter.BorderRadius = 15;
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.FlatStyle = FlatStyle.Flat;
            cmbFilter.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Location = new Point(352, 85);
            cmbFilter.Margin = new Padding(2);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(284, 36);
            cmbFilter.TabIndex = 9;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(255, 227, 232);
            txtSearch.BackgroundColor = Color.FromArgb(255, 227, 232);
            txtSearch.BorderRadius = 15;
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(20, 85);
            txtSearch.Margin = new Padding(2);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(284, 36);
            txtSearch.TabIndex = 8;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.BackColor = Color.White;
            lblSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSearch.ForeColor = Color.DarkRed;
            lblSearch.Location = new Point(20, 30);
            lblSearch.Margin = new Padding(2, 0, 2, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(100, 28);
            lblSearch.TabIndex = 7;
            lblSearch.Text = "Tìm kiếm";
            // 
            // pnDetailStudent
            // 
            pnDetailStudent.BorderRadius = 40;
            pnDetailStudent.Controls.Add(roundedPanel2);
            pnDetailStudent.Controls.Add(pnStudent);
            pnDetailStudent.Location = new Point(846, 42);
            pnDetailStudent.Margin = new Padding(2);
            pnDetailStudent.Name = "pnDetailStudent";
            pnDetailStudent.Size = new Size(450, 778);
            pnDetailStudent.TabIndex = 18;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BorderRadius = 40;
            roundedPanel2.Controls.Add(btnUpdate);
            roundedPanel2.Controls.Add(btnCancel);
            roundedPanel2.Location = new Point(45, 661);
            roundedPanel2.Margin = new Padding(2);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(360, 80);
            roundedPanel2.TabIndex = 19;
            // 
            // btnUpdate
            // 
            btnUpdate.BorderRadius = 40;
            btnUpdate.ButtonColor = Color.DarkRed;
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdate.Location = new Point(208, 20);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 39);
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "Sửa";
            btnUpdate.TextColor = Color.White;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.BorderRadius = 40;
            btnCancel.ButtonColor = Color.DarkRed;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.Location = new Point(40, 20);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 39);
            btnCancel.TabIndex = 28;
            btnCancel.Text = "Xóa";
            btnCancel.TextColor = Color.White;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnDelete_Click;
            // 
            // pnStudent
            // 
            pnStudent.BorderRadius = 40;
            pnStudent.Controls.Add(txtGender);
            pnStudent.Controls.Add(txtGmail);
            pnStudent.Controls.Add(lblGender);
            pnStudent.Controls.Add(dtpDateOfBirth);
            pnStudent.Controls.Add(lblGmail);
            pnStudent.Controls.Add(txtPhoneNumber);
            pnStudent.Controls.Add(txtNameStudent);
            pnStudent.Controls.Add(lblNameStudent);
            pnStudent.Controls.Add(lblDateOfBirth);
            pnStudent.Controls.Add(lblPhoneNumber);
            pnStudent.Location = new Point(45, 40);
            pnStudent.Margin = new Padding(2);
            pnStudent.Name = "pnStudent";
            pnStudent.Size = new Size(360, 591);
            pnStudent.TabIndex = 0;
            // 
            // txtGender
            // 
            txtGender.BackColor = Color.FromArgb(255, 227, 232);
            txtGender.BackgroundColor = Color.FromArgb(255, 227, 232);
            txtGender.BorderRadius = 15;
            txtGender.BorderStyle = BorderStyle.None;
            txtGender.Enabled = false;
            txtGender.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtGender.Location = new Point(38, 525);
            txtGender.Margin = new Padding(2);
            txtGender.Multiline = true;
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(284, 36);
            txtGender.TabIndex = 5;
            // 
            // txtGmail
            // 
            txtGmail.BackColor = Color.FromArgb(255, 227, 232);
            txtGmail.BackgroundColor = Color.FromArgb(255, 227, 232);
            txtGmail.BorderRadius = 15;
            txtGmail.BorderStyle = BorderStyle.None;
            txtGmail.Enabled = false;
            txtGmail.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtGmail.Location = new Point(38, 415);
            txtGmail.Margin = new Padding(2);
            txtGmail.Multiline = true;
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(284, 36);
            txtGmail.TabIndex = 4;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.BackgroundColor = Color.FromArgb(255, 227, 232);
            dtpDateOfBirth.BorderRadius = 15;
            dtpDateOfBirth.CustomFormat = "dd/MM/yyyy";
            dtpDateOfBirth.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDateOfBirth.Format = DateTimePickerFormat.Custom;
            dtpDateOfBirth.Location = new Point(38, 305);
            dtpDateOfBirth.Margin = new Padding(2);
            dtpDateOfBirth.MinimumSize = new Size(4, 36);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(284, 36);
            dtpDateOfBirth.TabIndex = 3;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = Color.FromArgb(255, 227, 232);
            txtPhoneNumber.BackgroundColor = Color.FromArgb(255, 227, 232);
            txtPhoneNumber.BorderRadius = 15;
            txtPhoneNumber.BorderStyle = BorderStyle.None;
            txtPhoneNumber.Enabled = false;
            txtPhoneNumber.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPhoneNumber.Location = new Point(38, 195);
            txtPhoneNumber.Margin = new Padding(2);
            txtPhoneNumber.Multiline = true;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(284, 36);
            txtPhoneNumber.TabIndex = 2;
            // 
            // txtNameStudent
            // 
            txtNameStudent.BackColor = Color.FromArgb(255, 227, 232);
            txtNameStudent.BackgroundColor = Color.FromArgb(255, 227, 232);
            txtNameStudent.BorderRadius = 15;
            txtNameStudent.BorderStyle = BorderStyle.None;
            txtNameStudent.Enabled = false;
            txtNameStudent.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNameStudent.Location = new Point(38, 85);
            txtNameStudent.Margin = new Padding(2);
            txtNameStudent.Multiline = true;
            txtNameStudent.Name = "txtNameStudent";
            txtNameStudent.Size = new Size(284, 36);
            txtNameStudent.TabIndex = 1;
            // 
            // pnListStudent
            // 
            pnListStudent.BorderRadius = 40;
            pnListStudent.Controls.Add(dgvListStudent);
            pnListStudent.Location = new Point(40, 248);
            pnListStudent.Margin = new Padding(2);
            pnListStudent.Name = "pnListStudent";
            pnListStudent.Size = new Size(712, 574);
            pnListStudent.TabIndex = 19;
            // 
            // dgvListStudent
            // 
            dgvListStudent.AllowUserToAddRows = false;
            dgvListStudent.AllowUserToDeleteRows = false;
            dgvListStudent.BackgroundColor = Color.FromArgb(255, 227, 232);
            dgvListStudent.BorderRadius = 40;
            dgvListStudent.BorderStyle = BorderStyle.None;
            dgvListStudent.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvListStudent.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.LightCoral;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListStudent.Columns.AddRange(new DataGridViewColumn[] { colIdStudent, colNameStudent, colPhoneNumber, colGmail });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 227, 232);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvListStudent.DefaultCellStyle = dataGridViewCellStyle2;
            dgvListStudent.EnableHeadersVisualStyles = false;
            dgvListStudent.Location = new Point(28, 31);
            dgvListStudent.Margin = new Padding(2);
            dgvListStudent.Name = "dgvListStudent";
            dgvListStudent.ReadOnly = true;
            dgvListStudent.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvListStudent.RowHeadersVisible = false;
            dgvListStudent.RowHeadersWidth = 62;
            dgvListStudent.Size = new Size(658, 512);
            dgvListStudent.TabIndex = 0;
            dgvListStudent.CellClick += dgvListStudent_CellClick;
            // 
            // colIdStudent
            // 
            colIdStudent.HeaderText = "Mã học viên";
            colIdStudent.MinimumWidth = 8;
            colIdStudent.Name = "colIdStudent";
            colIdStudent.ReadOnly = true;
            colIdStudent.Visible = false;
            colIdStudent.Width = 150;
            // 
            // colNameStudent
            // 
            colNameStudent.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNameStudent.HeaderText = "Tên học viên";
            colNameStudent.MinimumWidth = 8;
            colNameStudent.Name = "colNameStudent";
            colNameStudent.ReadOnly = true;
            // 
            // colPhoneNumber
            // 
            colPhoneNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPhoneNumber.HeaderText = "Số điện thoại";
            colPhoneNumber.MinimumWidth = 8;
            colPhoneNumber.Name = "colPhoneNumber";
            colPhoneNumber.ReadOnly = true;
            // 
            // colGmail
            // 
            colGmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colGmail.HeaderText = "Gmail";
            colGmail.MinimumWidth = 8;
            colGmail.Name = "colGmail";
            colGmail.ReadOnly = true;
            // 
            // lblComment
            // 
            lblComment.AutoSize = true;
            lblComment.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblComment.Location = new Point(975, 9);
            lblComment.Margin = new Padding(2, 0, 2, 0);
            lblComment.Name = "lblComment";
            lblComment.Size = new Size(321, 25);
            lblComment.TabIndex = 30;
            lblComment.Text = "Dấu * thể hiện trường dữ liệu bắt buộc";
            // 
            // ListStudent
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(251, 236, 240);
            ClientSize = new Size(1338, 859);
            Controls.Add(lblComment);
            Controls.Add(pnListStudent);
            Controls.Add(pnDetailStudent);
            Controls.Add(pnAction);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "ListStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách học viên";
            Load += ListStudent_Load;
            pnAction.ResumeLayout(false);
            pnSearch.ResumeLayout(false);
            pnSearch.PerformLayout();
            pnDetailStudent.ResumeLayout(false);
            roundedPanel2.ResumeLayout(false);
            pnStudent.ResumeLayout(false);
            pnStudent.PerformLayout();
            pnListStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblDateOfBirth;
        private Label lblGender;
        private Label lblPhoneNumber;
        private Label lblNameStudent;
        private Label lblGmail;
        private CHEF.RoundedPanel1 pnAction;
        private LOGIN.RoundedPanel pnSearch;
        private Label lblFilter;
        private LOGIN.RoundedComboBox cmbFilter;
        private LOGIN.RoundedTextBox txtSearch;
        private Label lblSearch;
        private CHEF.RoundedPanel1 pnDetailStudent;
        private LOGIN.RoundedPanel pnStudent;
        private LOGIN.RoundedTextBox txtNameStudent;
        private LOGIN.RoundedTextBox txtPhoneNumber;
        private LOGIN.RoundedTextBox txtGmail;
        private CHEF.RoundedDateTimePicker dtpDateOfBirth;
        private LOGIN.RoundedTextBox txtGender;
        private LOGIN.RoundedPanel roundedPanel2;
        private CLASSROOM.RoundedButton btnUpdate;
        private CLASSROOM.RoundedButton btnCancel;
        private LOGIN.RoundedPanel pnListStudent;
        private CLASSROOM.RoundedDataGridView dgvListStudent;
        private Label lblComment;
        private DataGridViewTextBoxColumn colIdStudent;
        private DataGridViewTextBoxColumn colNameStudent;
        private DataGridViewTextBoxColumn colPhoneNumber;
        private DataGridViewTextBoxColumn colGmail;
    }
}