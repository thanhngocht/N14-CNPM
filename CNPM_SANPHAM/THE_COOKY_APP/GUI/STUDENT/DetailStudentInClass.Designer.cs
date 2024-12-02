namespace THE_COOKY_APP.GUI.STUDENT
{
    partial class DetailStudentInClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailStudentInClass));
            lblComment = new Label();
            cmbFormPayment = new LOGIN.RoundedComboBox();
            pnLine = new Panel();
            lblExtra = new Label();
            lnRegister = new Label();
            pnRegister = new LOGIN.RoundedPanel();
            txtTotalPayment = new LOGIN.RoundedTextBox();
            lblTotalPayment = new Label();
            txtTotalPaymentNeed = new LOGIN.RoundedTextBox();
            lblTotalPaymentNeed = new Label();
            txtQuantityRegister = new LOGIN.RoundedTextBox();
            lblQuantityRegister = new Label();
            lblFormPayment = new Label();
            txtCodeMember = new LOGIN.RoundedTextBox();
            txtVoucher = new LOGIN.RoundedTextBox();
            txtCash = new LOGIN.RoundedTextBox();
            txtApp = new LOGIN.RoundedTextBox();
            pnExtra = new LOGIN.RoundedPanel();
            txtDeal = new LOGIN.RoundedTextBox();
            lblDeal = new Label();
            lblCodeMember = new Label();
            lblApp = new Label();
            lblVoucher = new Label();
            lblCash = new Label();
            pnFormAddRegister = new CHEF.RoundedPanel1();
            txtPhoneNumber = new LOGIN.RoundedTextBox();
            txtNameStudent = new LOGIN.RoundedTextBox();
            pnStudent = new LOGIN.RoundedPanel();
            lblNameStudent = new Label();
            lblPhoneNumber = new Label();
            btnSave = new CLASSROOM.RoundedButton();
            lblNameClassroom = new Label();
            lblPresentQuantity = new Label();
            lblFee = new Label();
            lblStudent = new Label();
            lblClassroom = new Label();
            pnClassroom = new LOGIN.RoundedPanel();
            txtPresentQuantity = new LOGIN.RoundedTextBox();
            txtFee = new LOGIN.RoundedTextBox();
            txtNameClassroom = new LOGIN.RoundedTextBox();
            pnBasicInformation = new CHEF.RoundedPanel1();
            pnRegister.SuspendLayout();
            pnExtra.SuspendLayout();
            pnFormAddRegister.SuspendLayout();
            pnStudent.SuspendLayout();
            pnClassroom.SuspendLayout();
            pnBasicInformation.SuspendLayout();
            SuspendLayout();
            // 
            // lblComment
            // 
            lblComment.AutoSize = true;
            lblComment.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblComment.Location = new Point(1109, 22);
            lblComment.Margin = new Padding(2, 0, 2, 0);
            lblComment.Name = "lblComment";
            lblComment.Size = new Size(275, 20);
            lblComment.TabIndex = 32;
            lblComment.Text = "Dấu * thể hiện trường dữ liệu bắt buộc";
            // 
            // cmbFormPayment
            // 
            cmbFormPayment.BackColor = Color.FromArgb(255, 227, 232);
            cmbFormPayment.BackgroundColor = Color.FromArgb(255, 227, 232);
            cmbFormPayment.BorderRadius = 15;
            cmbFormPayment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFormPayment.Enabled = false;
            cmbFormPayment.FlatStyle = FlatStyle.Flat;
            cmbFormPayment.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbFormPayment.FormattingEnabled = true;
            cmbFormPayment.Location = new Point(432, 85);
            cmbFormPayment.Margin = new Padding(2);
            cmbFormPayment.Name = "cmbFormPayment";
            cmbFormPayment.Size = new Size(284, 31);
            cmbFormPayment.TabIndex = 30;
            // 
            // pnLine
            // 
            pnLine.BackColor = Color.DarkRed;
            pnLine.Location = new Point(0, 374);
            pnLine.Margin = new Padding(2);
            pnLine.Name = "pnLine";
            pnLine.Size = new Size(850, 4);
            pnLine.TabIndex = 29;
            // 
            // lblExtra
            // 
            lblExtra.AutoSize = true;
            lblExtra.BackColor = Color.FromArgb(255, 227, 232);
            lblExtra.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExtra.ForeColor = Color.DarkRed;
            lblExtra.Location = new Point(279, 392);
            lblExtra.Margin = new Padding(2, 0, 2, 0);
            lblExtra.Name = "lblExtra";
            lblExtra.Size = new Size(241, 32);
            lblExtra.TabIndex = 28;
            lblExtra.Text = "THÔNG TIN ƯU ĐÃI";
            // 
            // lnRegister
            // 
            lnRegister.AutoSize = true;
            lnRegister.BackColor = Color.FromArgb(255, 227, 232);
            lnRegister.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnRegister.ForeColor = Color.DarkRed;
            lnRegister.Location = new Point(264, 30);
            lnRegister.Margin = new Padding(2, 0, 2, 0);
            lnRegister.Name = "lnRegister";
            lnRegister.Size = new Size(277, 32);
            lnRegister.TabIndex = 27;
            lnRegister.Text = "THÔNG TIN GHI DANH";
            // 
            // pnRegister
            // 
            pnRegister.BorderRadius = 40;
            pnRegister.Controls.Add(txtTotalPayment);
            pnRegister.Controls.Add(lblTotalPayment);
            pnRegister.Controls.Add(txtTotalPaymentNeed);
            pnRegister.Controls.Add(cmbFormPayment);
            pnRegister.Controls.Add(lblTotalPaymentNeed);
            pnRegister.Controls.Add(txtQuantityRegister);
            pnRegister.Controls.Add(lblQuantityRegister);
            pnRegister.Controls.Add(lblFormPayment);
            pnRegister.Location = new Point(50, 90);
            pnRegister.Margin = new Padding(2);
            pnRegister.Name = "pnRegister";
            pnRegister.Size = new Size(750, 261);
            pnRegister.TabIndex = 0;
            // 
            // txtTotalPayment
            // 
            txtTotalPayment.BackColor = Color.FromArgb(255, 227, 232);
            txtTotalPayment.BackgroundColor = Color.White;
            txtTotalPayment.BorderRadius = 15;
            txtTotalPayment.BorderStyle = BorderStyle.None;
            txtTotalPayment.Enabled = false;
            txtTotalPayment.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotalPayment.Location = new Point(432, 195);
            txtTotalPayment.Margin = new Padding(2);
            txtTotalPayment.Multiline = true;
            txtTotalPayment.Name = "txtTotalPayment";
            txtTotalPayment.Size = new Size(284, 36);
            txtTotalPayment.TabIndex = 7;
            txtTotalPayment.TextChanged += txtTotalPayment_TextChanged;
            txtTotalPayment.KeyPress += txtTotalPayment_KeyPress;
            // 
            // lblTotalPayment
            // 
            lblTotalPayment.AutoSize = true;
            lblTotalPayment.BackColor = Color.White;
            lblTotalPayment.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalPayment.ForeColor = Color.DarkRed;
            lblTotalPayment.Location = new Point(432, 140);
            lblTotalPayment.Margin = new Padding(2, 0, 2, 0);
            lblTotalPayment.Name = "lblTotalPayment";
            lblTotalPayment.Size = new Size(158, 23);
            lblTotalPayment.TabIndex = 35;
            lblTotalPayment.Text = "Số tiền thanh toán";
            // 
            // txtTotalPaymentNeed
            // 
            txtTotalPaymentNeed.BackColor = Color.FromArgb(255, 227, 232);
            txtTotalPaymentNeed.BackgroundColor = Color.White;
            txtTotalPaymentNeed.BorderRadius = 15;
            txtTotalPaymentNeed.BorderStyle = BorderStyle.None;
            txtTotalPaymentNeed.Enabled = false;
            txtTotalPaymentNeed.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotalPaymentNeed.Location = new Point(38, 195);
            txtTotalPaymentNeed.Margin = new Padding(2);
            txtTotalPaymentNeed.Multiline = true;
            txtTotalPaymentNeed.Name = "txtTotalPaymentNeed";
            txtTotalPaymentNeed.Size = new Size(284, 36);
            txtTotalPaymentNeed.TabIndex = 34;
            // 
            // lblTotalPaymentNeed
            // 
            lblTotalPaymentNeed.AutoSize = true;
            lblTotalPaymentNeed.BackColor = Color.White;
            lblTotalPaymentNeed.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalPaymentNeed.ForeColor = Color.DarkRed;
            lblTotalPaymentNeed.Location = new Point(38, 140);
            lblTotalPaymentNeed.Margin = new Padding(2, 0, 2, 0);
            lblTotalPaymentNeed.Name = "lblTotalPaymentNeed";
            lblTotalPaymentNeed.Size = new Size(130, 23);
            lblTotalPaymentNeed.TabIndex = 33;
            lblTotalPaymentNeed.Text = "Số tiền học phí";
            // 
            // txtQuantityRegister
            // 
            txtQuantityRegister.BackColor = Color.FromArgb(255, 227, 232);
            txtQuantityRegister.BackgroundColor = Color.White;
            txtQuantityRegister.BorderRadius = 15;
            txtQuantityRegister.BorderStyle = BorderStyle.None;
            txtQuantityRegister.Enabled = false;
            txtQuantityRegister.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtQuantityRegister.Location = new Point(38, 85);
            txtQuantityRegister.Margin = new Padding(2);
            txtQuantityRegister.Multiline = true;
            txtQuantityRegister.Name = "txtQuantityRegister";
            txtQuantityRegister.Size = new Size(284, 36);
            txtQuantityRegister.TabIndex = 1;
            txtQuantityRegister.TextChanged += txtQuantityRegister_TextChanged;
            txtQuantityRegister.KeyPress += txtQuantityRegister_KeyPress;
            // 
            // lblQuantityRegister
            // 
            lblQuantityRegister.AutoSize = true;
            lblQuantityRegister.BackColor = Color.White;
            lblQuantityRegister.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblQuantityRegister.ForeColor = Color.DarkRed;
            lblQuantityRegister.Location = new Point(38, 30);
            lblQuantityRegister.Margin = new Padding(2, 0, 2, 0);
            lblQuantityRegister.Name = "lblQuantityRegister";
            lblQuantityRegister.Size = new Size(157, 23);
            lblQuantityRegister.TabIndex = 28;
            lblQuantityRegister.Text = "*Số lượng đăng kí";
            // 
            // lblFormPayment
            // 
            lblFormPayment.AutoSize = true;
            lblFormPayment.BackColor = Color.White;
            lblFormPayment.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFormPayment.ForeColor = Color.DarkRed;
            lblFormPayment.Location = new Point(432, 30);
            lblFormPayment.Margin = new Padding(2, 0, 2, 0);
            lblFormPayment.Name = "lblFormPayment";
            lblFormPayment.Size = new Size(181, 23);
            lblFormPayment.TabIndex = 29;
            lblFormPayment.Text = "Hình thức thanh toán";
            // 
            // txtCodeMember
            // 
            txtCodeMember.BackColor = Color.FromArgb(255, 227, 232);
            txtCodeMember.BackgroundColor = Color.White;
            txtCodeMember.BorderRadius = 15;
            txtCodeMember.BorderStyle = BorderStyle.None;
            txtCodeMember.Enabled = false;
            txtCodeMember.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCodeMember.Location = new Point(38, 85);
            txtCodeMember.Margin = new Padding(2);
            txtCodeMember.Multiline = true;
            txtCodeMember.Name = "txtCodeMember";
            txtCodeMember.Size = new Size(284, 36);
            txtCodeMember.TabIndex = 2;
            txtCodeMember.TextAlign = HorizontalAlignment.Center;
            txtCodeMember.KeyPress += txtCodeMember_KeyPress;
            txtCodeMember.Leave += txtCodeMember_Leave;
            // 
            // txtVoucher
            // 
            txtVoucher.BackColor = Color.FromArgb(255, 227, 232);
            txtVoucher.BackgroundColor = Color.White;
            txtVoucher.BorderRadius = 15;
            txtVoucher.BorderStyle = BorderStyle.None;
            txtVoucher.Enabled = false;
            txtVoucher.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtVoucher.Location = new Point(432, 85);
            txtVoucher.Margin = new Padding(2);
            txtVoucher.Multiline = true;
            txtVoucher.Name = "txtVoucher";
            txtVoucher.Size = new Size(284, 36);
            txtVoucher.TabIndex = 3;
            txtVoucher.TextAlign = HorizontalAlignment.Center;
            txtVoucher.KeyPress += txtVoucher_KeyPress;
            txtVoucher.Leave += txtVoucher_Leave;
            // 
            // txtCash
            // 
            txtCash.BackColor = Color.FromArgb(255, 227, 232);
            txtCash.BackgroundColor = Color.White;
            txtCash.BorderRadius = 15;
            txtCash.BorderStyle = BorderStyle.None;
            txtCash.Enabled = false;
            txtCash.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCash.Location = new Point(432, 195);
            txtCash.Margin = new Padding(2);
            txtCash.Multiline = true;
            txtCash.Name = "txtCash";
            txtCash.Size = new Size(284, 36);
            txtCash.TabIndex = 5;
            txtCash.TextAlign = HorizontalAlignment.Center;
            txtCash.TextChanged += txtCash_TextChanged;
            txtCash.KeyPress += txtCash_KeyPress;
            txtCash.Leave += txtCash_Leave;
            // 
            // txtApp
            // 
            txtApp.BackColor = Color.FromArgb(255, 227, 232);
            txtApp.BackgroundColor = Color.White;
            txtApp.BorderRadius = 15;
            txtApp.BorderStyle = BorderStyle.None;
            txtApp.Enabled = false;
            txtApp.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtApp.Location = new Point(38, 195);
            txtApp.Margin = new Padding(2);
            txtApp.Multiline = true;
            txtApp.Name = "txtApp";
            txtApp.Size = new Size(284, 36);
            txtApp.TabIndex = 4;
            txtApp.TextAlign = HorizontalAlignment.Center;
            txtApp.KeyPress += txtApp_KeyPress;
            txtApp.Leave += txtApp_Leave;
            // 
            // pnExtra
            // 
            pnExtra.BorderRadius = 40;
            pnExtra.Controls.Add(txtDeal);
            pnExtra.Controls.Add(txtCodeMember);
            pnExtra.Controls.Add(lblDeal);
            pnExtra.Controls.Add(txtVoucher);
            pnExtra.Controls.Add(lblCodeMember);
            pnExtra.Controls.Add(txtCash);
            pnExtra.Controls.Add(txtApp);
            pnExtra.Controls.Add(lblApp);
            pnExtra.Controls.Add(lblVoucher);
            pnExtra.Controls.Add(lblCash);
            pnExtra.Location = new Point(50, 441);
            pnExtra.Margin = new Padding(2);
            pnExtra.Name = "pnExtra";
            pnExtra.Size = new Size(750, 371);
            pnExtra.TabIndex = 30;
            // 
            // txtDeal
            // 
            txtDeal.BackColor = Color.FromArgb(255, 227, 232);
            txtDeal.BackgroundColor = Color.White;
            txtDeal.BorderRadius = 15;
            txtDeal.BorderStyle = BorderStyle.None;
            txtDeal.Enabled = false;
            txtDeal.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDeal.Location = new Point(38, 305);
            txtDeal.Margin = new Padding(2);
            txtDeal.Multiline = true;
            txtDeal.Name = "txtDeal";
            txtDeal.Size = new Size(284, 36);
            txtDeal.TabIndex = 6;
            txtDeal.TextAlign = HorizontalAlignment.Center;
            txtDeal.KeyPress += txtDeal_KeyPress;
            txtDeal.Leave += txtDeal_Leave;
            // 
            // lblDeal
            // 
            lblDeal.AutoSize = true;
            lblDeal.BackColor = Color.White;
            lblDeal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDeal.ForeColor = Color.DarkRed;
            lblDeal.Location = new Point(38, 250);
            lblDeal.Margin = new Padding(2, 0, 2, 0);
            lblDeal.Name = "lblDeal";
            lblDeal.Size = new Size(172, 23);
            lblDeal.TabIndex = 39;
            lblDeal.Text = "Ưu đãi trả trước (%)";
            // 
            // lblCodeMember
            // 
            lblCodeMember.AutoSize = true;
            lblCodeMember.BackColor = Color.White;
            lblCodeMember.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCodeMember.ForeColor = Color.DarkRed;
            lblCodeMember.Location = new Point(38, 30);
            lblCodeMember.Margin = new Padding(2, 0, 2, 0);
            lblCodeMember.Name = "lblCodeMember";
            lblCodeMember.Size = new Size(130, 23);
            lblCodeMember.TabIndex = 35;
            lblCodeMember.Text = "Code / Thẻ (%)";
            // 
            // lblApp
            // 
            lblApp.AutoSize = true;
            lblApp.BackColor = Color.White;
            lblApp.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblApp.ForeColor = Color.DarkRed;
            lblApp.Location = new Point(38, 140);
            lblApp.Margin = new Padding(2, 0, 2, 0);
            lblApp.Name = "lblApp";
            lblApp.Size = new Size(79, 23);
            lblApp.TabIndex = 29;
            lblApp.Text = "APP (%) ";
            // 
            // lblVoucher
            // 
            lblVoucher.AutoSize = true;
            lblVoucher.BackColor = Color.White;
            lblVoucher.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblVoucher.ForeColor = Color.DarkRed;
            lblVoucher.Location = new Point(432, 30);
            lblVoucher.Margin = new Padding(2, 0, 2, 0);
            lblVoucher.Name = "lblVoucher";
            lblVoucher.Size = new Size(106, 23);
            lblVoucher.TabIndex = 34;
            lblVoucher.Text = "Voucher (%)";
            // 
            // lblCash
            // 
            lblCash.AutoSize = true;
            lblCash.BackColor = Color.White;
            lblCash.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCash.ForeColor = Color.DarkRed;
            lblCash.Location = new Point(432, 140);
            lblCash.Margin = new Padding(2, 0, 2, 0);
            lblCash.Name = "lblCash";
            lblCash.Size = new Size(47, 23);
            lblCash.TabIndex = 33;
            lblCash.Text = "Cash";
            // 
            // pnFormAddRegister
            // 
            pnFormAddRegister.BorderRadius = 40;
            pnFormAddRegister.Controls.Add(pnExtra);
            pnFormAddRegister.Controls.Add(pnLine);
            pnFormAddRegister.Controls.Add(lblExtra);
            pnFormAddRegister.Controls.Add(lnRegister);
            pnFormAddRegister.Controls.Add(pnRegister);
            pnFormAddRegister.Location = new Point(580, 70);
            pnFormAddRegister.Margin = new Padding(2);
            pnFormAddRegister.Name = "pnFormAddRegister";
            pnFormAddRegister.Size = new Size(850, 842);
            pnFormAddRegister.TabIndex = 31;
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
            txtPhoneNumber.TabIndex = 32;
            // 
            // txtNameStudent
            // 
            txtNameStudent.BackColor = Color.FromArgb(255, 227, 232);
            txtNameStudent.BackgroundColor = Color.White;
            txtNameStudent.BorderRadius = 15;
            txtNameStudent.BorderStyle = BorderStyle.None;
            txtNameStudent.Enabled = false;
            txtNameStudent.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNameStudent.Location = new Point(38, 85);
            txtNameStudent.Margin = new Padding(2);
            txtNameStudent.Multiline = true;
            txtNameStudent.Name = "txtNameStudent";
            txtNameStudent.Size = new Size(284, 36);
            txtNameStudent.TabIndex = 31;
            // 
            // pnStudent
            // 
            pnStudent.BorderRadius = 40;
            pnStudent.Controls.Add(txtPhoneNumber);
            pnStudent.Controls.Add(txtNameStudent);
            pnStudent.Controls.Add(lblNameStudent);
            pnStudent.Controls.Add(lblPhoneNumber);
            pnStudent.Location = new Point(65, 551);
            pnStudent.Margin = new Padding(2);
            pnStudent.Name = "pnStudent";
            pnStudent.Size = new Size(360, 261);
            pnStudent.TabIndex = 28;
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
            lblNameStudent.Size = new Size(116, 23);
            lblNameStudent.TabIndex = 24;
            lblNameStudent.Text = "*Tên học viên";
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
            lblPhoneNumber.Size = new Size(124, 23);
            lblPhoneNumber.TabIndex = 25;
            lblPhoneNumber.Text = "*Số điện thoại";
            // 
            // btnSave
            // 
            btnSave.BorderRadius = 40;
            btnSave.ButtonColor = Color.DarkRed;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.Location = new Point(1318, 941);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 39);
            btnSave.TabIndex = 8;
            btnSave.Text = "Sửa";
            btnSave.TextColor = Color.White;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
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
            lblNameClassroom.Size = new Size(102, 23);
            lblNameClassroom.TabIndex = 4;
            lblNameClassroom.Text = "Tên lớp học";
            // 
            // lblPresentQuantity
            // 
            lblPresentQuantity.AutoSize = true;
            lblPresentQuantity.BackColor = Color.White;
            lblPresentQuantity.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPresentQuantity.ForeColor = Color.DarkRed;
            lblPresentQuantity.Location = new Point(38, 250);
            lblPresentQuantity.Margin = new Padding(2, 0, 2, 0);
            lblPresentQuantity.Name = "lblPresentQuantity";
            lblPresentQuantity.Size = new Size(148, 23);
            lblPresentQuantity.TabIndex = 27;
            lblPresentQuantity.Text = "Số lượng hiện tại";
            // 
            // lblFee
            // 
            lblFee.AutoSize = true;
            lblFee.BackColor = Color.White;
            lblFee.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFee.ForeColor = Color.DarkRed;
            lblFee.Location = new Point(38, 140);
            lblFee.Margin = new Padding(2, 0, 2, 0);
            lblFee.Name = "lblFee";
            lblFee.Size = new Size(67, 23);
            lblFee.TabIndex = 23;
            lblFee.Text = "Chi phí";
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.BackColor = Color.FromArgb(255, 227, 232);
            lblStudent.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudent.ForeColor = Color.DarkRed;
            lblStudent.Location = new Point(89, 491);
            lblStudent.Margin = new Padding(2, 0, 2, 0);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(269, 32);
            lblStudent.TabIndex = 27;
            lblStudent.Text = "THÔNG TIN HỌC VIÊN";
            // 
            // lblClassroom
            // 
            lblClassroom.AutoSize = true;
            lblClassroom.BackColor = Color.FromArgb(255, 227, 232);
            lblClassroom.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClassroom.ForeColor = Color.DarkRed;
            lblClassroom.Location = new Point(95, 30);
            lblClassroom.Margin = new Padding(2, 0, 2, 0);
            lblClassroom.Name = "lblClassroom";
            lblClassroom.Size = new Size(259, 32);
            lblClassroom.TabIndex = 26;
            lblClassroom.Text = "THÔNG TIN LỚP HỌC";
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
            pnClassroom.Location = new Point(65, 90);
            pnClassroom.Margin = new Padding(2);
            pnClassroom.Name = "pnClassroom";
            pnClassroom.Size = new Size(360, 371);
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
            txtPresentQuantity.Location = new Point(38, 305);
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
            txtFee.Location = new Point(38, 195);
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
            // pnBasicInformation
            // 
            pnBasicInformation.BorderRadius = 40;
            pnBasicInformation.Controls.Add(pnStudent);
            pnBasicInformation.Controls.Add(lblStudent);
            pnBasicInformation.Controls.Add(lblClassroom);
            pnBasicInformation.Controls.Add(pnClassroom);
            pnBasicInformation.Location = new Point(50, 70);
            pnBasicInformation.Margin = new Padding(2);
            pnBasicInformation.Name = "pnBasicInformation";
            pnBasicInformation.Size = new Size(490, 842);
            pnBasicInformation.TabIndex = 30;
            // 
            // DetailStudentInClass
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            BackColor = Color.FromArgb(251, 236, 240);
            ClientSize = new Size(1478, 954);
            Controls.Add(lblComment);
            Controls.Add(pnFormAddRegister);
            Controls.Add(btnSave);
            Controls.Add(pnBasicInformation);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "DetailStudentInClass";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chi tiết thông tin ghi danh";
            pnRegister.ResumeLayout(false);
            pnRegister.PerformLayout();
            pnExtra.ResumeLayout(false);
            pnExtra.PerformLayout();
            pnFormAddRegister.ResumeLayout(false);
            pnFormAddRegister.PerformLayout();
            pnStudent.ResumeLayout(false);
            pnStudent.PerformLayout();
            pnClassroom.ResumeLayout(false);
            pnClassroom.PerformLayout();
            pnBasicInformation.ResumeLayout(false);
            pnBasicInformation.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblComment;
        private LOGIN.RoundedComboBox cmbFormPayment;
        private Panel pnLine;
        private Label lblExtra;
        private Label lnRegister;
        private LOGIN.RoundedPanel pnRegister;
        private LOGIN.RoundedTextBox txtQuantityRegister;
        private Label lblQuantityRegister;
        private Label lblFormPayment;
        private LOGIN.RoundedTextBox txtCodeMember;
        private LOGIN.RoundedTextBox txtVoucher;
        private LOGIN.RoundedTextBox txtCash;
        private LOGIN.RoundedTextBox txtApp;
        private LOGIN.RoundedPanel pnExtra;
        private Label lblCodeMember;
        private Label lblApp;
        private Label lblVoucher;
        private Label lblCash;
        private CHEF.RoundedPanel1 pnFormAddRegister;
        private LOGIN.RoundedTextBox txtPhoneNumber;
        private LOGIN.RoundedTextBox txtNameStudent;
        private LOGIN.RoundedPanel pnStudent;
        private Label lblNameStudent;
        private Label lblPhoneNumber;
        private CLASSROOM.RoundedButton btnSave;
        private Label lblNameClassroom;
        private Label lblPresentQuantity;
        private Label lblFee;
        private Label lblStudent;
        private Label lblClassroom;
        private LOGIN.RoundedPanel pnClassroom;
        private LOGIN.RoundedTextBox txtPresentQuantity;
        private LOGIN.RoundedTextBox txtFee;
        private LOGIN.RoundedTextBox txtNameClassroom;
        private CHEF.RoundedPanel1 pnBasicInformation;
        private LOGIN.RoundedTextBox txtTotalPaymentNeed;
        private Label lblTotalPaymentNeed;
        private LOGIN.RoundedTextBox txtDeal;
        private Label lblDeal;
        private LOGIN.RoundedTextBox txtTotalPayment;
        private Label lblTotalPayment;
    }
}