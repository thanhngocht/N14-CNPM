namespace THE_COOKY_APP.GUI.REPORT
{
    partial class ReportClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportClass));
            pnClassroomInformation = new CHEF.RoundedPanel1();
            lblClassroomInformation = new Label();
            pnClassroom = new LOGIN.RoundedPanel();
            txtQuantity = new LOGIN.RoundedTextBox();
            lblRealQuantity = new Label();
            txtClassroom = new LOGIN.RoundedTextBox();
            lblClassroom = new Label();
            pnListStudentInClass = new LOGIN.RoundedPanel();
            dgvListStudentInClass = new CLASSROOM.RoundedDataGridView();
            colIdStudent = new DataGridViewTextBoxColumn();
            ColNameStudent = new DataGridViewTextBoxColumn();
            ColQuantity = new DataGridViewTextBoxColumn();
            ColPayment = new DataGridViewTextBoxColumn();
            ColPaymentStatus = new DataGridViewTextBoxColumn();
            pnTotalExpenditure = new CHEF.RoundedPanel1();
            lblTotalExpenditure = new Label();
            pnExpenditure = new LOGIN.RoundedPanel();
            btnTotalExpenditure = new Button();
            panel1 = new Panel();
            lblChefCost = new Label();
            txtMaterialCost = new LOGIN.RoundedTextBox();
            txtAnotherCost = new LOGIN.RoundedTextBox();
            txtChefCost = new LOGIN.RoundedTextBox();
            lblMaterialCost = new Label();
            lblCashBack = new Label();
            txtCashBack = new LOGIN.RoundedTextBox();
            lblAnotherCost = new Label();
            pnTotalIncome = new CHEF.RoundedPanel1();
            lblTotalIncome = new Label();
            pnIncome = new LOGIN.RoundedPanel();
            btnTotalIncome = new Button();
            pnLine1 = new Panel();
            lblRemain = new Label();
            txtCredit = new LOGIN.RoundedTextBox();
            txtOnlinePayment = new LOGIN.RoundedTextBox();
            txtRemain = new LOGIN.RoundedTextBox();
            lblCredit = new Label();
            lblBankTransfer = new Label();
            txtBankTransfer = new LOGIN.RoundedTextBox();
            lblOnlinePayment = new Label();
            pnRevenue = new LOGIN.RoundedPanel();
            btnIncome = new Button();
            lblIncome = new Label();
            pnRevenue1 = new CHEF.RoundedPanel1();
            cmbFilter = new LOGIN.RoundedComboBox();
            pnFilter = new LOGIN.RoundedPanel();
            pnClassroomInformation.SuspendLayout();
            pnClassroom.SuspendLayout();
            pnListStudentInClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListStudentInClass).BeginInit();
            pnTotalExpenditure.SuspendLayout();
            pnExpenditure.SuspendLayout();
            pnTotalIncome.SuspendLayout();
            pnIncome.SuspendLayout();
            pnRevenue.SuspendLayout();
            pnRevenue1.SuspendLayout();
            pnFilter.SuspendLayout();
            SuspendLayout();
            // 
            // pnClassroomInformation
            // 
            pnClassroomInformation.BorderRadius = 40;
            pnClassroomInformation.Controls.Add(lblClassroomInformation);
            pnClassroomInformation.Controls.Add(pnClassroom);
            pnClassroomInformation.Location = new Point(30, 40);
            pnClassroomInformation.Margin = new Padding(2);
            pnClassroomInformation.Name = "pnClassroomInformation";
            pnClassroomInformation.Size = new Size(450, 361);
            pnClassroomInformation.TabIndex = 1;
            // 
            // lblClassroomInformation
            // 
            lblClassroomInformation.AutoSize = true;
            lblClassroomInformation.BackColor = Color.FromArgb(255, 227, 232);
            lblClassroomInformation.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClassroomInformation.ForeColor = Color.DarkRed;
            lblClassroomInformation.Location = new Point(75, 20);
            lblClassroomInformation.Margin = new Padding(2, 0, 2, 0);
            lblClassroomInformation.Name = "lblClassroomInformation";
            lblClassroomInformation.Size = new Size(300, 38);
            lblClassroomInformation.TabIndex = 24;
            lblClassroomInformation.Text = "THÔNG TIN LỚP HỌC";
            // 
            // pnClassroom
            // 
            pnClassroom.BorderRadius = 40;
            pnClassroom.Controls.Add(txtQuantity);
            pnClassroom.Controls.Add(lblRealQuantity);
            pnClassroom.Controls.Add(txtClassroom);
            pnClassroom.Controls.Add(lblClassroom);
            pnClassroom.Location = new Point(45, 75);
            pnClassroom.Margin = new Padding(2);
            pnClassroom.Name = "pnClassroom";
            pnClassroom.Size = new Size(360, 261);
            pnClassroom.TabIndex = 0;
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = Color.FromArgb(255, 227, 232);
            txtQuantity.BackgroundColor = Color.White;
            txtQuantity.BorderRadius = 15;
            txtQuantity.BorderStyle = BorderStyle.None;
            txtQuantity.Enabled = false;
            txtQuantity.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(38, 195);
            txtQuantity.Margin = new Padding(2);
            txtQuantity.Multiline = true;
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(284, 36);
            txtQuantity.TabIndex = 4;
            // 
            // lblRealQuantity
            // 
            lblRealQuantity.AutoSize = true;
            lblRealQuantity.BackColor = Color.White;
            lblRealQuantity.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRealQuantity.ForeColor = Color.DarkRed;
            lblRealQuantity.Location = new Point(38, 140);
            lblRealQuantity.Margin = new Padding(2, 0, 2, 0);
            lblRealQuantity.Name = "lblRealQuantity";
            lblRealQuantity.Size = new Size(175, 28);
            lblRealQuantity.TabIndex = 5;
            lblRealQuantity.Text = "Số lượng hiện tại";
            // 
            // txtClassroom
            // 
            txtClassroom.BackColor = Color.FromArgb(255, 227, 232);
            txtClassroom.BackgroundColor = Color.White;
            txtClassroom.BorderRadius = 15;
            txtClassroom.BorderStyle = BorderStyle.None;
            txtClassroom.Enabled = false;
            txtClassroom.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtClassroom.Location = new Point(38, 85);
            txtClassroom.Margin = new Padding(2);
            txtClassroom.Multiline = true;
            txtClassroom.Name = "txtClassroom";
            txtClassroom.Size = new Size(284, 36);
            txtClassroom.TabIndex = 2;
            // 
            // lblClassroom
            // 
            lblClassroom.AutoSize = true;
            lblClassroom.BackColor = Color.White;
            lblClassroom.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblClassroom.ForeColor = Color.DarkRed;
            lblClassroom.Location = new Point(38, 30);
            lblClassroom.Margin = new Padding(2, 0, 2, 0);
            lblClassroom.Name = "lblClassroom";
            lblClassroom.Size = new Size(122, 28);
            lblClassroom.TabIndex = 3;
            lblClassroom.Text = "Tên lớp học";
            // 
            // pnListStudentInClass
            // 
            pnListStudentInClass.BorderRadius = 40;
            pnListStudentInClass.Controls.Add(dgvListStudentInClass);
            pnListStudentInClass.Location = new Point(30, 435);
            pnListStudentInClass.Margin = new Padding(2);
            pnListStudentInClass.Name = "pnListStudentInClass";
            pnListStudentInClass.Size = new Size(850, 605);
            pnListStudentInClass.TabIndex = 5;
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
            dgvListStudentInClass.Columns.AddRange(new DataGridViewColumn[] { colIdStudent, ColNameStudent, ColQuantity, ColPayment, ColPaymentStatus });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 227, 232);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvListStudentInClass.DefaultCellStyle = dataGridViewCellStyle2;
            dgvListStudentInClass.EnableHeadersVisualStyles = false;
            dgvListStudentInClass.Location = new Point(42, 34);
            dgvListStudentInClass.Margin = new Padding(2);
            dgvListStudentInClass.Name = "dgvListStudentInClass";
            dgvListStudentInClass.ReadOnly = true;
            dgvListStudentInClass.RowHeadersVisible = false;
            dgvListStudentInClass.RowHeadersWidth = 62;
            dgvListStudentInClass.Size = new Size(766, 538);
            dgvListStudentInClass.TabIndex = 6;
            dgvListStudentInClass.CellClick += dgvListStudentInClass_CellClick;
            dgvListStudentInClass.CellDoubleClick += dgvListStudentInClass_CellDoubleClick;
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
            // ColNameStudent
            // 
            ColNameStudent.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColNameStudent.HeaderText = "Tên học viên";
            ColNameStudent.MinimumWidth = 8;
            ColNameStudent.Name = "ColNameStudent";
            ColNameStudent.ReadOnly = true;
            // 
            // ColQuantity
            // 
            ColQuantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColQuantity.HeaderText = "Số lượng đăng kí";
            ColQuantity.MinimumWidth = 8;
            ColQuantity.Name = "ColQuantity";
            ColQuantity.ReadOnly = true;
            // 
            // ColPayment
            // 
            ColPayment.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColPayment.HeaderText = "Tiền thanh toán";
            ColPayment.MinimumWidth = 8;
            ColPayment.Name = "ColPayment";
            ColPayment.ReadOnly = true;
            // 
            // ColPaymentStatus
            // 
            ColPaymentStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColPaymentStatus.HeaderText = "Trạng thái";
            ColPaymentStatus.MinimumWidth = 8;
            ColPaymentStatus.Name = "ColPaymentStatus";
            ColPaymentStatus.ReadOnly = true;
            // 
            // pnTotalExpenditure
            // 
            pnTotalExpenditure.BorderRadius = 40;
            pnTotalExpenditure.Controls.Add(lblTotalExpenditure);
            pnTotalExpenditure.Controls.Add(pnExpenditure);
            pnTotalExpenditure.Location = new Point(932, 40);
            pnTotalExpenditure.Margin = new Padding(2);
            pnTotalExpenditure.Name = "pnTotalExpenditure";
            pnTotalExpenditure.Size = new Size(490, 478);
            pnTotalExpenditure.TabIndex = 0;
            // 
            // lblTotalExpenditure
            // 
            lblTotalExpenditure.AutoSize = true;
            lblTotalExpenditure.BackColor = Color.FromArgb(255, 227, 232);
            lblTotalExpenditure.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalExpenditure.ForeColor = Color.DarkRed;
            lblTotalExpenditure.Location = new Point(178, 20);
            lblTotalExpenditure.Margin = new Padding(2, 0, 2, 0);
            lblTotalExpenditure.Name = "lblTotalExpenditure";
            lblTotalExpenditure.Size = new Size(151, 38);
            lblTotalExpenditure.TabIndex = 41;
            lblTotalExpenditure.Text = "TỔNG CHI";
            // 
            // pnExpenditure
            // 
            pnExpenditure.BorderRadius = 40;
            pnExpenditure.Controls.Add(btnTotalExpenditure);
            pnExpenditure.Controls.Add(panel1);
            pnExpenditure.Controls.Add(lblChefCost);
            pnExpenditure.Controls.Add(txtMaterialCost);
            pnExpenditure.Controls.Add(txtAnotherCost);
            pnExpenditure.Controls.Add(txtChefCost);
            pnExpenditure.Controls.Add(lblMaterialCost);
            pnExpenditure.Controls.Add(lblCashBack);
            pnExpenditure.Controls.Add(txtCashBack);
            pnExpenditure.Controls.Add(lblAnotherCost);
            pnExpenditure.Location = new Point(40, 75);
            pnExpenditure.Margin = new Padding(2);
            pnExpenditure.Name = "pnExpenditure";
            pnExpenditure.Size = new Size(410, 372);
            pnExpenditure.TabIndex = 40;
            // 
            // btnTotalExpenditure
            // 
            btnTotalExpenditure.BackColor = Color.IndianRed;
            btnTotalExpenditure.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTotalExpenditure.ForeColor = Color.White;
            btnTotalExpenditure.Location = new Point(130, 290);
            btnTotalExpenditure.Margin = new Padding(2);
            btnTotalExpenditure.Name = "btnTotalExpenditure";
            btnTotalExpenditure.Size = new Size(154, 54);
            btnTotalExpenditure.TabIndex = 103;
            btnTotalExpenditure.Text = "1000000";
            btnTotalExpenditure.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.Location = new Point(0, 259);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 6);
            panel1.TabIndex = 27;
            // 
            // lblChefCost
            // 
            lblChefCost.AutoSize = true;
            lblChefCost.BackColor = Color.White;
            lblChefCost.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChefCost.ForeColor = Color.DarkRed;
            lblChefCost.Location = new Point(38, 195);
            lblChefCost.Margin = new Padding(2, 0, 2, 0);
            lblChefCost.Name = "lblChefCost";
            lblChefCost.Size = new Size(101, 28);
            lblChefCost.TabIndex = 24;
            lblChefCost.Text = "Giáo viên";
            // 
            // txtMaterialCost
            // 
            txtMaterialCost.BackColor = Color.FromArgb(255, 227, 232);
            txtMaterialCost.BackgroundColor = Color.White;
            txtMaterialCost.BorderRadius = 15;
            txtMaterialCost.BorderStyle = BorderStyle.None;
            txtMaterialCost.Enabled = false;
            txtMaterialCost.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMaterialCost.Location = new Point(185, 140);
            txtMaterialCost.Margin = new Padding(2);
            txtMaterialCost.Multiline = true;
            txtMaterialCost.Name = "txtMaterialCost";
            txtMaterialCost.Size = new Size(200, 36);
            txtMaterialCost.TabIndex = 23;
            // 
            // txtAnotherCost
            // 
            txtAnotherCost.BackColor = Color.FromArgb(255, 227, 232);
            txtAnotherCost.BackgroundColor = Color.White;
            txtAnotherCost.BorderRadius = 15;
            txtAnotherCost.BorderStyle = BorderStyle.None;
            txtAnotherCost.Enabled = false;
            txtAnotherCost.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAnotherCost.Location = new Point(185, 30);
            txtAnotherCost.Margin = new Padding(2);
            txtAnotherCost.Multiline = true;
            txtAnotherCost.Name = "txtAnotherCost";
            txtAnotherCost.Size = new Size(200, 36);
            txtAnotherCost.TabIndex = 22;
            // 
            // txtChefCost
            // 
            txtChefCost.BackColor = Color.FromArgb(255, 227, 232);
            txtChefCost.BackgroundColor = Color.White;
            txtChefCost.BorderRadius = 15;
            txtChefCost.BorderStyle = BorderStyle.None;
            txtChefCost.Enabled = false;
            txtChefCost.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtChefCost.Location = new Point(185, 195);
            txtChefCost.Margin = new Padding(2);
            txtChefCost.Multiline = true;
            txtChefCost.Name = "txtChefCost";
            txtChefCost.Size = new Size(200, 36);
            txtChefCost.TabIndex = 21;
            // 
            // lblMaterialCost
            // 
            lblMaterialCost.AutoSize = true;
            lblMaterialCost.BackColor = Color.White;
            lblMaterialCost.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaterialCost.ForeColor = Color.DarkRed;
            lblMaterialCost.Location = new Point(38, 140);
            lblMaterialCost.Margin = new Padding(2, 0, 2, 0);
            lblMaterialCost.Name = "lblMaterialCost";
            lblMaterialCost.Size = new Size(127, 28);
            lblMaterialCost.TabIndex = 20;
            lblMaterialCost.Text = "Nguyên liệu";
            // 
            // lblCashBack
            // 
            lblCashBack.AutoSize = true;
            lblCashBack.BackColor = Color.White;
            lblCashBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCashBack.ForeColor = Color.DarkRed;
            lblCashBack.Location = new Point(38, 85);
            lblCashBack.Margin = new Padding(2, 0, 2, 0);
            lblCashBack.Name = "lblCashBack";
            lblCashBack.Size = new Size(95, 28);
            lblCashBack.TabIndex = 19;
            lblCashBack.Text = "Hoàn trả";
            // 
            // txtCashBack
            // 
            txtCashBack.BackColor = Color.FromArgb(255, 227, 232);
            txtCashBack.BackgroundColor = Color.White;
            txtCashBack.BorderRadius = 15;
            txtCashBack.BorderStyle = BorderStyle.None;
            txtCashBack.Enabled = false;
            txtCashBack.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCashBack.Location = new Point(185, 85);
            txtCashBack.Margin = new Padding(2);
            txtCashBack.Multiline = true;
            txtCashBack.Name = "txtCashBack";
            txtCashBack.Size = new Size(200, 36);
            txtCashBack.TabIndex = 18;
            // 
            // lblAnotherCost
            // 
            lblAnotherCost.AutoSize = true;
            lblAnotherCost.BackColor = Color.White;
            lblAnotherCost.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAnotherCost.ForeColor = Color.DarkRed;
            lblAnotherCost.Location = new Point(38, 30);
            lblAnotherCost.Margin = new Padding(2, 0, 2, 0);
            lblAnotherCost.Name = "lblAnotherCost";
            lblAnotherCost.Size = new Size(147, 28);
            lblAnotherCost.TabIndex = 17;
            lblAnotherCost.Text = "Tiền phát sinh";
            // 
            // pnTotalIncome
            // 
            pnTotalIncome.BorderRadius = 40;
            pnTotalIncome.Controls.Add(lblTotalIncome);
            pnTotalIncome.Controls.Add(pnIncome);
            pnTotalIncome.Location = new Point(932, 562);
            pnTotalIncome.Margin = new Padding(2);
            pnTotalIncome.Name = "pnTotalIncome";
            pnTotalIncome.Size = new Size(490, 478);
            pnTotalIncome.TabIndex = 6;
            // 
            // lblTotalIncome
            // 
            lblTotalIncome.AutoSize = true;
            lblTotalIncome.BackColor = Color.FromArgb(255, 227, 232);
            lblTotalIncome.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalIncome.ForeColor = Color.DarkRed;
            lblTotalIncome.Location = new Point(168, 25);
            lblTotalIncome.Margin = new Padding(2, 0, 2, 0);
            lblTotalIncome.Name = "lblTotalIncome";
            lblTotalIncome.Size = new Size(161, 38);
            lblTotalIncome.TabIndex = 42;
            lblTotalIncome.Text = "TỔNG THU";
            // 
            // pnIncome
            // 
            pnIncome.BorderRadius = 40;
            pnIncome.Controls.Add(btnTotalIncome);
            pnIncome.Controls.Add(pnLine1);
            pnIncome.Controls.Add(lblRemain);
            pnIncome.Controls.Add(txtCredit);
            pnIncome.Controls.Add(txtOnlinePayment);
            pnIncome.Controls.Add(txtRemain);
            pnIncome.Controls.Add(lblCredit);
            pnIncome.Controls.Add(lblBankTransfer);
            pnIncome.Controls.Add(txtBankTransfer);
            pnIncome.Controls.Add(lblOnlinePayment);
            pnIncome.Location = new Point(40, 75);
            pnIncome.Margin = new Padding(2);
            pnIncome.Name = "pnIncome";
            pnIncome.Size = new Size(410, 372);
            pnIncome.TabIndex = 43;
            // 
            // btnTotalIncome
            // 
            btnTotalIncome.BackColor = Color.IndianRed;
            btnTotalIncome.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTotalIncome.ForeColor = Color.White;
            btnTotalIncome.Location = new Point(128, 290);
            btnTotalIncome.Margin = new Padding(2);
            btnTotalIncome.Name = "btnTotalIncome";
            btnTotalIncome.Size = new Size(154, 54);
            btnTotalIncome.TabIndex = 102;
            btnTotalIncome.Text = "1000000";
            btnTotalIncome.UseVisualStyleBackColor = false;
            // 
            // pnLine1
            // 
            pnLine1.BackColor = Color.DarkRed;
            pnLine1.Location = new Point(0, 259);
            pnLine1.Margin = new Padding(2);
            pnLine1.Name = "pnLine1";
            pnLine1.Size = new Size(410, 6);
            pnLine1.TabIndex = 9;
            // 
            // lblRemain
            // 
            lblRemain.AutoSize = true;
            lblRemain.BackColor = Color.White;
            lblRemain.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRemain.ForeColor = Color.DarkRed;
            lblRemain.Location = new Point(38, 195);
            lblRemain.Margin = new Padding(2, 0, 2, 0);
            lblRemain.Name = "lblRemain";
            lblRemain.Size = new Size(77, 28);
            lblRemain.TabIndex = 16;
            lblRemain.Text = "Còn lại";
            // 
            // txtCredit
            // 
            txtCredit.BackColor = Color.FromArgb(255, 227, 232);
            txtCredit.BackgroundColor = Color.White;
            txtCredit.BorderRadius = 15;
            txtCredit.BorderStyle = BorderStyle.None;
            txtCredit.Enabled = false;
            txtCredit.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCredit.Location = new Point(185, 140);
            txtCredit.Margin = new Padding(2);
            txtCredit.Multiline = true;
            txtCredit.Name = "txtCredit";
            txtCredit.Size = new Size(200, 36);
            txtCredit.TabIndex = 15;
            // 
            // txtOnlinePayment
            // 
            txtOnlinePayment.BackColor = Color.FromArgb(255, 227, 232);
            txtOnlinePayment.BackgroundColor = Color.White;
            txtOnlinePayment.BorderRadius = 15;
            txtOnlinePayment.BorderStyle = BorderStyle.None;
            txtOnlinePayment.Enabled = false;
            txtOnlinePayment.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtOnlinePayment.Location = new Point(185, 30);
            txtOnlinePayment.Margin = new Padding(2);
            txtOnlinePayment.Multiline = true;
            txtOnlinePayment.Name = "txtOnlinePayment";
            txtOnlinePayment.Size = new Size(200, 36);
            txtOnlinePayment.TabIndex = 14;
            // 
            // txtRemain
            // 
            txtRemain.BackColor = Color.FromArgb(255, 227, 232);
            txtRemain.BackgroundColor = Color.White;
            txtRemain.BorderRadius = 15;
            txtRemain.BorderStyle = BorderStyle.None;
            txtRemain.Enabled = false;
            txtRemain.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRemain.Location = new Point(185, 195);
            txtRemain.Margin = new Padding(2);
            txtRemain.Multiline = true;
            txtRemain.Name = "txtRemain";
            txtRemain.Size = new Size(200, 36);
            txtRemain.TabIndex = 13;
            // 
            // lblCredit
            // 
            lblCredit.AutoSize = true;
            lblCredit.BackColor = Color.White;
            lblCredit.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCredit.ForeColor = Color.DarkRed;
            lblCredit.Location = new Point(38, 140);
            lblCredit.Margin = new Padding(2, 0, 2, 0);
            lblCredit.Name = "lblCredit";
            lblCredit.Size = new Size(69, 28);
            lblCredit.TabIndex = 12;
            lblCredit.Text = "Credit";
            // 
            // lblBankTransfer
            // 
            lblBankTransfer.AutoSize = true;
            lblBankTransfer.BackColor = Color.White;
            lblBankTransfer.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBankTransfer.ForeColor = Color.DarkRed;
            lblBankTransfer.Location = new Point(38, 85);
            lblBankTransfer.Margin = new Padding(2, 0, 2, 0);
            lblBankTransfer.Name = "lblBankTransfer";
            lblBankTransfer.Size = new Size(37, 28);
            lblBankTransfer.TabIndex = 10;
            lblBankTransfer.Text = "CK";
            // 
            // txtBankTransfer
            // 
            txtBankTransfer.BackColor = Color.FromArgb(255, 227, 232);
            txtBankTransfer.BackgroundColor = Color.White;
            txtBankTransfer.BorderRadius = 15;
            txtBankTransfer.BorderStyle = BorderStyle.None;
            txtBankTransfer.Enabled = false;
            txtBankTransfer.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBankTransfer.Location = new Point(185, 85);
            txtBankTransfer.Margin = new Padding(2);
            txtBankTransfer.Multiline = true;
            txtBankTransfer.Name = "txtBankTransfer";
            txtBankTransfer.Size = new Size(200, 36);
            txtBankTransfer.TabIndex = 9;
            // 
            // lblOnlinePayment
            // 
            lblOnlinePayment.AutoSize = true;
            lblOnlinePayment.BackColor = Color.White;
            lblOnlinePayment.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOnlinePayment.ForeColor = Color.DarkRed;
            lblOnlinePayment.Location = new Point(38, 30);
            lblOnlinePayment.Margin = new Padding(2, 0, 2, 0);
            lblOnlinePayment.Name = "lblOnlinePayment";
            lblOnlinePayment.Size = new Size(39, 28);
            lblOnlinePayment.TabIndex = 0;
            lblOnlinePayment.Text = "OP";
            // 
            // pnRevenue
            // 
            pnRevenue.BorderRadius = 40;
            pnRevenue.Controls.Add(btnIncome);
            pnRevenue.Controls.Add(lblIncome);
            pnRevenue.Location = new Point(35, 28);
            pnRevenue.Margin = new Padding(2);
            pnRevenue.Name = "pnRevenue";
            pnRevenue.Size = new Size(300, 180);
            pnRevenue.TabIndex = 38;
            // 
            // btnIncome
            // 
            btnIncome.BackColor = Color.IndianRed;
            btnIncome.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIncome.ForeColor = Color.White;
            btnIncome.Location = new Point(72, 100);
            btnIncome.Margin = new Padding(2);
            btnIncome.Name = "btnIncome";
            btnIncome.Size = new Size(154, 54);
            btnIncome.TabIndex = 101;
            btnIncome.Text = "1000000";
            btnIncome.UseVisualStyleBackColor = false;
            // 
            // lblIncome
            // 
            lblIncome.AutoSize = true;
            lblIncome.BackColor = Color.White;
            lblIncome.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblIncome.ForeColor = Color.DarkRed;
            lblIncome.Location = new Point(42, 30);
            lblIncome.Margin = new Padding(2, 0, 2, 0);
            lblIncome.Name = "lblIncome";
            lblIncome.Size = new Size(216, 30);
            lblIncome.TabIndex = 0;
            lblIncome.Text = "TỔNG DOANH THU";
            // 
            // pnRevenue1
            // 
            pnRevenue1.BorderRadius = 40;
            pnRevenue1.Controls.Add(pnRevenue);
            pnRevenue1.Location = new Point(510, 75);
            pnRevenue1.Margin = new Padding(2);
            pnRevenue1.Name = "pnRevenue1";
            pnRevenue1.Size = new Size(370, 236);
            pnRevenue1.TabIndex = 39;
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
            cmbFilter.Location = new Point(28, 18);
            cmbFilter.Margin = new Padding(2);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(316, 36);
            cmbFilter.TabIndex = 41;
            cmbFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
            // 
            // pnFilter
            // 
            pnFilter.BorderRadius = 40;
            pnFilter.Controls.Add(cmbFilter);
            pnFilter.Location = new Point(510, 334);
            pnFilter.Margin = new Padding(2);
            pnFilter.Name = "pnFilter";
            pnFilter.Size = new Size(368, 68);
            pnFilter.TabIndex = 40;
            // 
            // ReportClass
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            BackColor = Color.FromArgb(251, 236, 240);
            ClientSize = new Size(1478, 994);
            Controls.Add(pnFilter);
            Controls.Add(pnRevenue1);
            Controls.Add(pnTotalIncome);
            Controls.Add(pnListStudentInClass);
            Controls.Add(pnClassroomInformation);
            Controls.Add(pnTotalExpenditure);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "ReportClass";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Báo cáo lớp học";
            Load += ReportClass_Load;
            pnClassroomInformation.ResumeLayout(false);
            pnClassroomInformation.PerformLayout();
            pnClassroom.ResumeLayout(false);
            pnClassroom.PerformLayout();
            pnListStudentInClass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListStudentInClass).EndInit();
            pnTotalExpenditure.ResumeLayout(false);
            pnTotalExpenditure.PerformLayout();
            pnExpenditure.ResumeLayout(false);
            pnExpenditure.PerformLayout();
            pnTotalIncome.ResumeLayout(false);
            pnTotalIncome.PerformLayout();
            pnIncome.ResumeLayout(false);
            pnIncome.PerformLayout();
            pnRevenue.ResumeLayout(false);
            pnRevenue.PerformLayout();
            pnRevenue1.ResumeLayout(false);
            pnFilter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private CHEF.RoundedPanel1 pnClassroomInformation;
        private LOGIN.RoundedPanel pnClassroom;
        private LOGIN.RoundedTextBox txtClassroom;
        private Label lblClassroom;
        private LOGIN.RoundedTextBox txtQuantity;
        private Label lblRealQuantity;
        private Label lblClassroomInformation;
        private LOGIN.RoundedPanel pnListStudentInClass;
        private CLASSROOM.RoundedDataGridView dgvListStudentInClass;
        private DataGridViewTextBoxColumn colIdStudent;
        private DataGridViewTextBoxColumn ColNameStudent;
        private DataGridViewTextBoxColumn ColQuantity;
        private DataGridViewTextBoxColumn ColPayment;
        private DataGridViewTextBoxColumn ColPaymentStatus;
        private CHEF.RoundedPanel1 pnTotalExpenditure;
        private LOGIN.RoundedPanel pnExpenditure;
        private Button btnTotalExpenditure;
        private Panel panel1;
        private Label lblChefCost;
        private LOGIN.RoundedTextBox txtMaterialCost;
        private LOGIN.RoundedTextBox txtAnotherCost;
        private LOGIN.RoundedTextBox txtChefCost;
        private Label lblMaterialCost;
        private Label lblCashBack;
        private LOGIN.RoundedTextBox txtCashBack;
        private Label lblAnotherCost;
        private Label lblTotalExpenditure;
        private CHEF.RoundedPanel1 pnTotalIncome;
        private Label lblTotalIncome;
        private LOGIN.RoundedPanel pnIncome;
        private Button btnTotalIncome;
        private Panel pnLine1;
        private Label lblRemain;
        private LOGIN.RoundedTextBox txtCredit;
        private LOGIN.RoundedTextBox txtOnlinePayment;
        private LOGIN.RoundedTextBox txtRemain;
        private Label lblCredit;
        private Label lblBankTransfer;
        private LOGIN.RoundedTextBox txtBankTransfer;
        private Label lblOnlinePayment;
        private LOGIN.RoundedPanel pnRevenue;
        private Button btnIncome;
        private Label lblIncome;
        private CHEF.RoundedPanel1 pnRevenue1;
        private LOGIN.RoundedComboBox cmbFilter;
        private LOGIN.RoundedPanel pnFilter;
    }
}