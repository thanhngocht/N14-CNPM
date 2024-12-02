namespace THE_COOKY_APP.GUI.STUDENT
{
    partial class ListStudentInClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListStudentInClass));
            pnClassroomInformation = new CHEF.RoundedPanel1();
            pnClassroom = new LOGIN.RoundedPanel();
            txtPresentQuantity = new LOGIN.RoundedTextBox();
            txtFee = new LOGIN.RoundedTextBox();
            txtNameClassroom = new LOGIN.RoundedTextBox();
            lblNameClassroom = new Label();
            lblPresentQuantity = new Label();
            lblFee = new Label();
            pnAction = new CHEF.RoundedPanel1();
            pnButton = new LOGIN.RoundedPanel();
            btnCancel = new CLASSROOM.RoundedButton();
            btnAdd = new CLASSROOM.RoundedButton();
            pnSearch = new LOGIN.RoundedPanel();
            lblFilter = new Label();
            cmbFilter = new LOGIN.RoundedComboBox();
            txtSearch = new LOGIN.RoundedTextBox();
            lblSearch = new Label();
            pnListStudentInClass = new LOGIN.RoundedPanel();
            dgvListStudentInClass = new CLASSROOM.RoundedDataGridView();
            colNameStudent = new DataGridViewTextBoxColumn();
            colPhoneNumber = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colTotalPaymentNeed = new DataGridViewTextBoxColumn();
            colIdStudent = new DataGridViewTextBoxColumn();
            ColTotalPayment = new DataGridViewTextBoxColumn();
            pnClassroomInformation.SuspendLayout();
            pnClassroom.SuspendLayout();
            pnAction.SuspendLayout();
            pnButton.SuspendLayout();
            pnSearch.SuspendLayout();
            pnListStudentInClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListStudentInClass).BeginInit();
            SuspendLayout();
            // 
            // pnClassroomInformation
            // 
            pnClassroomInformation.BorderRadius = 40;
            pnClassroomInformation.Controls.Add(pnClassroom);
            pnClassroomInformation.Location = new Point(62, 30);
            pnClassroomInformation.Margin = new Padding(2);
            pnClassroomInformation.Name = "pnClassroomInformation";
            pnClassroomInformation.Size = new Size(1210, 210);
            pnClassroomInformation.TabIndex = 27;
            // 
            // pnClassroom
            // 
            pnClassroom.BorderRadius = 40;
            pnClassroom.Controls.Add(txtPresentQuantity);
            pnClassroom.Controls.Add(txtFee);
            pnClassroom.Controls.Add(txtNameClassroom);
            pnClassroom.Controls.Add(lblNameClassroom);
            pnClassroom.Controls.Add(lblPresentQuantity);
            pnClassroom.Controls.Add(lblFee);
            pnClassroom.Location = new Point(29, 28);
            pnClassroom.Margin = new Padding(2);
            pnClassroom.Name = "pnClassroom";
            pnClassroom.Size = new Size(1148, 151);
            pnClassroom.TabIndex = 25;
            // 
            // txtPresentQuantity
            // 
            txtPresentQuantity.BackColor = Color.FromArgb(255, 227, 232);
            txtPresentQuantity.BackgroundColor = Color.White;
            txtPresentQuantity.BorderRadius = 15;
            txtPresentQuantity.BorderStyle = BorderStyle.None;
            txtPresentQuantity.Enabled = false;
            txtPresentQuantity.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPresentQuantity.Location = new Point(825, 85);
            txtPresentQuantity.Margin = new Padding(2);
            txtPresentQuantity.Multiline = true;
            txtPresentQuantity.Name = "txtPresentQuantity";
            txtPresentQuantity.Size = new Size(284, 36);
            txtPresentQuantity.TabIndex = 30;
            // 
            // txtFee
            // 
            txtFee.BackColor = Color.FromArgb(255, 227, 232);
            txtFee.BackgroundColor = Color.White;
            txtFee.BorderRadius = 15;
            txtFee.BorderStyle = BorderStyle.None;
            txtFee.Enabled = false;
            txtFee.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFee.Location = new Point(432, 85);
            txtFee.Margin = new Padding(2);
            txtFee.Multiline = true;
            txtFee.Name = "txtFee";
            txtFee.Size = new Size(284, 36);
            txtFee.TabIndex = 29;
            // 
            // txtNameClassroom
            // 
            txtNameClassroom.BackColor = Color.FromArgb(255, 227, 232);
            txtNameClassroom.BackgroundColor = Color.White;
            txtNameClassroom.BorderRadius = 15;
            txtNameClassroom.BorderStyle = BorderStyle.None;
            txtNameClassroom.Enabled = false;
            txtNameClassroom.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNameClassroom.Location = new Point(38, 85);
            txtNameClassroom.Margin = new Padding(2);
            txtNameClassroom.Multiline = true;
            txtNameClassroom.Name = "txtNameClassroom";
            txtNameClassroom.Size = new Size(284, 36);
            txtNameClassroom.TabIndex = 28;
            // 
            // lblNameClassroom
            // 
            lblNameClassroom.AutoSize = true;
            lblNameClassroom.BackColor = Color.White;
            lblNameClassroom.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNameClassroom.ForeColor = Color.DarkRed;
            lblNameClassroom.Location = new Point(38, 30);
            lblNameClassroom.Margin = new Padding(2, 0, 2, 0);
            lblNameClassroom.Name = "lblNameClassroom";
            lblNameClassroom.Size = new Size(122, 28);
            lblNameClassroom.TabIndex = 4;
            lblNameClassroom.Text = "Tên lớp học";
            // 
            // lblPresentQuantity
            // 
            lblPresentQuantity.AutoSize = true;
            lblPresentQuantity.BackColor = Color.White;
            lblPresentQuantity.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPresentQuantity.ForeColor = Color.DarkRed;
            lblPresentQuantity.Location = new Point(825, 30);
            lblPresentQuantity.Margin = new Padding(2, 0, 2, 0);
            lblPresentQuantity.Name = "lblPresentQuantity";
            lblPresentQuantity.Size = new Size(175, 28);
            lblPresentQuantity.TabIndex = 27;
            lblPresentQuantity.Text = "Số lượng hiện tại";
            // 
            // lblFee
            // 
            lblFee.AutoSize = true;
            lblFee.BackColor = Color.White;
            lblFee.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFee.ForeColor = Color.DarkRed;
            lblFee.Location = new Point(432, 30);
            lblFee.Margin = new Padding(2, 0, 2, 0);
            lblFee.Name = "lblFee";
            lblFee.Size = new Size(78, 28);
            lblFee.TabIndex = 23;
            lblFee.Text = "Chi phí";
            // 
            // pnAction
            // 
            pnAction.BorderRadius = 40;
            pnAction.Controls.Add(pnButton);
            pnAction.Controls.Add(pnSearch);
            pnAction.Location = new Point(62, 268);
            pnAction.Margin = new Padding(2);
            pnAction.Name = "pnAction";
            pnAction.Size = new Size(1210, 205);
            pnAction.TabIndex = 28;
            // 
            // pnButton
            // 
            pnButton.BorderRadius = 40;
            pnButton.Controls.Add(btnCancel);
            pnButton.Controls.Add(btnAdd);
            pnButton.Location = new Point(810, 42);
            pnButton.Margin = new Padding(2);
            pnButton.Name = "pnButton";
            pnButton.Size = new Size(350, 119);
            pnButton.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.BorderRadius = 40;
            btnCancel.ButtonColor = Color.DarkRed;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.Location = new Point(192, 40);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 39);
            btnCancel.TabIndex = 29;
            btnCancel.Text = "Xóa";
            btnCancel.TextColor = Color.White;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.BorderRadius = 40;
            btnAdd.ButtonColor = Color.DarkRed;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.Location = new Point(40, 40);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 39);
            btnAdd.TabIndex = 27;
            btnAdd.Text = "Thêm";
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // pnSearch
            // 
            pnSearch.BorderRadius = 40;
            pnSearch.Controls.Add(lblFilter);
            pnSearch.Controls.Add(cmbFilter);
            pnSearch.Controls.Add(txtSearch);
            pnSearch.Controls.Add(lblSearch);
            pnSearch.Location = new Point(48, 28);
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
            // pnListStudentInClass
            // 
            pnListStudentInClass.BorderRadius = 40;
            pnListStudentInClass.Controls.Add(dgvListStudentInClass);
            pnListStudentInClass.Location = new Point(62, 472);
            pnListStudentInClass.Margin = new Padding(2);
            pnListStudentInClass.Name = "pnListStudentInClass";
            pnListStudentInClass.Size = new Size(1210, 612);
            pnListStudentInClass.TabIndex = 29;
            // 
            // dgvListStudentInClass
            // 
            dgvListStudentInClass.AllowUserToAddRows = false;
            dgvListStudentInClass.AllowUserToDeleteRows = false;
            dgvListStudentInClass.BackgroundColor = Color.FromArgb(255, 227, 232);
            dgvListStudentInClass.BorderRadius = 40;
            dgvListStudentInClass.BorderStyle = BorderStyle.None;
            dgvListStudentInClass.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvListStudentInClass.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.LightCoral;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListStudentInClass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListStudentInClass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListStudentInClass.Columns.AddRange(new DataGridViewColumn[] { colNameStudent, colPhoneNumber, colQuantity, colTotalPaymentNeed, colIdStudent, ColTotalPayment });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 227, 232);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvListStudentInClass.DefaultCellStyle = dataGridViewCellStyle2;
            dgvListStudentInClass.EnableHeadersVisualStyles = false;
            dgvListStudentInClass.Location = new Point(41, 35);
            dgvListStudentInClass.Margin = new Padding(2);
            dgvListStudentInClass.Name = "dgvListStudentInClass";
            dgvListStudentInClass.ReadOnly = true;
            dgvListStudentInClass.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvListStudentInClass.RowHeadersVisible = false;
            dgvListStudentInClass.RowHeadersWidth = 62;
            dgvListStudentInClass.Size = new Size(1128, 540);
            dgvListStudentInClass.TabIndex = 0;
            dgvListStudentInClass.CellClick += dgvListStudentInClass_CellClick;
            dgvListStudentInClass.CellDoubleClick += dgvListStudentInClass_CellDoubleClick;
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
            // colQuantity
            // 
            colQuantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colQuantity.HeaderText = "Số lượng";
            colQuantity.MinimumWidth = 8;
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            // 
            // colTotalPaymentNeed
            // 
            colTotalPaymentNeed.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTotalPaymentNeed.HeaderText = "Tiền học phí";
            colTotalPaymentNeed.MinimumWidth = 8;
            colTotalPaymentNeed.Name = "colTotalPaymentNeed";
            colTotalPaymentNeed.ReadOnly = true;
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
            // ColTotalPayment
            // 
            ColTotalPayment.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColTotalPayment.HeaderText = "Tiền thanh toán";
            ColTotalPayment.MinimumWidth = 6;
            ColTotalPayment.Name = "ColTotalPayment";
            ColTotalPayment.ReadOnly = true;
            // 
            // ListStudentInClass
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(251, 236, 240);
            ClientSize = new Size(1338, 1050);
            Controls.Add(pnListStudentInClass);
            Controls.Add(pnAction);
            Controls.Add(pnClassroomInformation);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "ListStudentInClass";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách học viên trong lớp";
            Load += ListStudentInClass_Load;
            pnClassroomInformation.ResumeLayout(false);
            pnClassroom.ResumeLayout(false);
            pnClassroom.PerformLayout();
            pnAction.ResumeLayout(false);
            pnButton.ResumeLayout(false);
            pnSearch.ResumeLayout(false);
            pnSearch.PerformLayout();
            pnListStudentInClass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListStudentInClass).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CHEF.RoundedPanel1 pnClassroomInformation;
        private LOGIN.RoundedPanel pnClassroom;
        private LOGIN.RoundedTextBox txtPresentQuantity;
        private LOGIN.RoundedTextBox txtFee;
        private LOGIN.RoundedTextBox txtNameClassroom;
        private Label lblNameClassroom;
        private Label lblPresentQuantity;
        private Label lblFee;
        private CHEF.RoundedPanel1 pnAction;
        private LOGIN.RoundedPanel pnSearch;
        private Label lblFilter;
        private LOGIN.RoundedComboBox cmbFilter;
        private LOGIN.RoundedTextBox txtSearch;
        private Label lblSearch;
        private LOGIN.RoundedPanel pnListStudentInClass;
        private CLASSROOM.RoundedDataGridView dgvListStudentInClass;
        private LOGIN.RoundedPanel pnButton;
        private CLASSROOM.RoundedButton btnCancel;
        private CLASSROOM.RoundedButton btnAdd;
        private DataGridViewTextBoxColumn colNameStudent;
        private DataGridViewTextBoxColumn colPhoneNumber;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colTotalPaymentNeed;
        private DataGridViewTextBoxColumn colIdStudent;
        private DataGridViewTextBoxColumn ColTotalPayment;
    }
}