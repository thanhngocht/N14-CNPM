using System.Security.Principal;
using System.Windows.Forms;

namespace THE_COOKY_APP.GUI.CLASSROOM
{
    partial class CreateClassroom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateClassroom));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnFormAddClassroom = new CHEF.RoundedPanel1();
            pnBasicInformation2 = new LOGIN.RoundedPanel();
            rdpAI = new LOGIN.RoundedPictureBox();
            txtDescription = new LOGIN.RoundedTextBox();
            lblDescription = new Label();
            pnBasicInformation1 = new LOGIN.RoundedPanel();
            cmbSponsor = new LOGIN.RoundedComboBox();
            cmbForm = new LOGIN.RoundedComboBox();
            cmbTopic = new LOGIN.RoundedComboBox();
            cmbLocation = new LOGIN.RoundedComboBox();
            cmbChef = new LOGIN.RoundedComboBox();
            lblSponsor = new Label();
            lblLocation = new Label();
            lblForm = new Label();
            lblChef = new Label();
            lblTopic = new Label();
            pnBasicInformation = new LOGIN.RoundedPanel();
            btnAddPicture = new LOGIN.RoundedPictureBox();
            txtQuantity = new LOGIN.RoundedTextBox();
            lblQuantity = new Label();
            rpbPicture = new LOGIN.RoundedPictureBox();
            txtClassroom = new LOGIN.RoundedTextBox();
            lblClassroom = new Label();
            lblClassroomInformation = new Label();
            pnExtraInformation = new LOGIN.RoundedPanel();
            dgvListTime = new RoundedDataGridView();
            ColOrganizationDay = new DataGridViewTextBoxColumn();
            ColStartHour = new DataGridViewTextBoxColumn();
            ColEndHour = new DataGridViewTextBoxColumn();
            ColFee = new DataGridViewTextBoxColumn();
            ColFee1 = new DataGridViewTextBoxColumn();
            ColFee2 = new DataGridViewTextBoxColumn();
            ColFee3 = new DataGridViewTextBoxColumn();
            ColComment = new DataGridViewTextBoxColumn();
            btnAddTime = new LOGIN.RoundedPictureBox();
            lblExtraInformation = new Label();
            btnAdd = new RoundedButton();
            lblComment = new Label();
            pnFormAddClassroom1 = new CHEF.RoundedPanel1();
            pnFormAddClassroom.SuspendLayout();
            pnBasicInformation2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rdpAI).BeginInit();
            pnBasicInformation1.SuspendLayout();
            pnBasicInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAddPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rpbPicture).BeginInit();
            pnExtraInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAddTime).BeginInit();
            pnFormAddClassroom1.SuspendLayout();
            SuspendLayout();
            // 
            // pnFormAddClassroom
            // 
            pnFormAddClassroom.BorderRadius = 40;
            pnFormAddClassroom.Controls.Add(pnBasicInformation2);
            pnFormAddClassroom.Controls.Add(pnBasicInformation1);
            pnFormAddClassroom.Controls.Add(pnBasicInformation);
            pnFormAddClassroom.Controls.Add(lblClassroomInformation);
            pnFormAddClassroom.Location = new Point(218, 74);
            pnFormAddClassroom.Margin = new Padding(2);
            pnFormAddClassroom.Name = "pnFormAddClassroom";
            pnFormAddClassroom.Size = new Size(850, 1042);
            pnFormAddClassroom.TabIndex = 20;
            // 
            // pnBasicInformation2
            // 
            pnBasicInformation2.BorderRadius = 40;
            pnBasicInformation2.Controls.Add(rdpAI);
            pnBasicInformation2.Controls.Add(txtDescription);
            pnBasicInformation2.Controls.Add(lblDescription);
            pnBasicInformation2.Location = new Point(50, 826);
            pnBasicInformation2.Margin = new Padding(2);
            pnBasicInformation2.Name = "pnBasicInformation2";
            pnBasicInformation2.Size = new Size(750, 188);
            pnBasicInformation2.TabIndex = 10;
            // 
            // rdpAI
            // 
            rdpAI.BackColor = Color.White;
            rdpAI.BackgroundImage = (Image)resources.GetObject("rdpAI.BackgroundImage");
            rdpAI.BackgroundImageLayout = ImageLayout.Stretch;
            rdpAI.BorderRadius = 40;
            rdpAI.Location = new Point(668, 9);
            rdpAI.Margin = new Padding(2);
            rdpAI.Name = "rdpAI";
            rdpAI.Size = new Size(50, 50);
            rdpAI.TabIndex = 36;
            rdpAI.TabStop = false;
            rdpAI.Click += rdpAI_Click;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.FromArgb(255, 227, 232);
            txtDescription.BackgroundColor = Color.White;
            txtDescription.BorderRadius = 15;
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(38, 85);
            txtDescription.Margin = new Padding(2);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(678, 72);
            txtDescription.TabIndex = 8;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.White;
            lblDescription.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDescription.ForeColor = Color.DarkRed;
            lblDescription.Location = new Point(38, 30);
            lblDescription.Margin = new Padding(2, 0, 2, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(68, 28);
            lblDescription.TabIndex = 11;
            lblDescription.Text = "Mô tả";
            // 
            // pnBasicInformation1
            // 
            pnBasicInformation1.BorderRadius = 40;
            pnBasicInformation1.Controls.Add(cmbSponsor);
            pnBasicInformation1.Controls.Add(cmbForm);
            pnBasicInformation1.Controls.Add(cmbTopic);
            pnBasicInformation1.Controls.Add(cmbLocation);
            pnBasicInformation1.Controls.Add(cmbChef);
            pnBasicInformation1.Controls.Add(lblSponsor);
            pnBasicInformation1.Controls.Add(lblLocation);
            pnBasicInformation1.Controls.Add(lblForm);
            pnBasicInformation1.Controls.Add(lblChef);
            pnBasicInformation1.Controls.Add(lblTopic);
            pnBasicInformation1.Location = new Point(50, 438);
            pnBasicInformation1.Margin = new Padding(2);
            pnBasicInformation1.Name = "pnBasicInformation1";
            pnBasicInformation1.Size = new Size(750, 368);
            pnBasicInformation1.TabIndex = 3;
            // 
            // cmbSponsor
            // 
            cmbSponsor.BackColor = Color.FromArgb(255, 227, 232);
            cmbSponsor.BackgroundColor = Color.FromArgb(255, 227, 232);
            cmbSponsor.BorderRadius = 15;
            cmbSponsor.Enabled = false;
            cmbSponsor.FlatStyle = FlatStyle.Flat;
            cmbSponsor.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbSponsor.FormattingEnabled = true;
            cmbSponsor.Location = new Point(432, 195);
            cmbSponsor.Margin = new Padding(2);
            cmbSponsor.Name = "cmbSponsor";
            cmbSponsor.Size = new Size(284, 36);
            cmbSponsor.TabIndex = 6;
            // 
            // cmbForm
            // 
            cmbForm.BackColor = Color.FromArgb(255, 227, 232);
            cmbForm.BackgroundColor = Color.FromArgb(255, 227, 232);
            cmbForm.BorderRadius = 15;
            cmbForm.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbForm.FlatStyle = FlatStyle.Flat;
            cmbForm.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbForm.FormattingEnabled = true;
            cmbForm.Location = new Point(38, 195);
            cmbForm.Margin = new Padding(2);
            cmbForm.Name = "cmbForm";
            cmbForm.Size = new Size(284, 36);
            cmbForm.TabIndex = 5;
            cmbForm.SelectedIndexChanged += cmbForm_SelectedIndexChanged;
            // 
            // cmbTopic
            // 
            cmbTopic.BackColor = Color.FromArgb(255, 227, 232);
            cmbTopic.BackgroundColor = Color.FromArgb(255, 227, 232);
            cmbTopic.BorderRadius = 15;
            cmbTopic.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTopic.FlatStyle = FlatStyle.Flat;
            cmbTopic.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbTopic.FormattingEnabled = true;
            cmbTopic.Location = new Point(38, 305);
            cmbTopic.Margin = new Padding(2);
            cmbTopic.Name = "cmbTopic";
            cmbTopic.Size = new Size(284, 36);
            cmbTopic.TabIndex = 7;
            cmbTopic.SelectedIndexChanged += cmbTopic_SelectedIndexChanged;
            // 
            // cmbLocation
            // 
            cmbLocation.BackColor = Color.FromArgb(255, 227, 232);
            cmbLocation.BackgroundColor = Color.FromArgb(255, 227, 232);
            cmbLocation.BorderRadius = 15;
            cmbLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLocation.FlatStyle = FlatStyle.Flat;
            cmbLocation.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbLocation.FormattingEnabled = true;
            cmbLocation.Location = new Point(432, 85);
            cmbLocation.Margin = new Padding(2);
            cmbLocation.Name = "cmbLocation";
            cmbLocation.Size = new Size(284, 36);
            cmbLocation.TabIndex = 4;
            cmbLocation.SelectedIndexChanged += cmbLocation_SelectedIndexChanged;
            // 
            // cmbChef
            // 
            cmbChef.BackColor = Color.FromArgb(255, 227, 232);
            cmbChef.BackgroundColor = Color.FromArgb(255, 227, 232);
            cmbChef.BorderRadius = 15;
            cmbChef.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbChef.FlatStyle = FlatStyle.Flat;
            cmbChef.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbChef.FormattingEnabled = true;
            cmbChef.Location = new Point(38, 85);
            cmbChef.Margin = new Padding(2);
            cmbChef.Name = "cmbChef";
            cmbChef.Size = new Size(284, 36);
            cmbChef.TabIndex = 3;
            cmbChef.SelectedIndexChanged += cmbChef_SelectedIndexChanged;
            // 
            // lblSponsor
            // 
            lblSponsor.AutoSize = true;
            lblSponsor.BackColor = Color.White;
            lblSponsor.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSponsor.ForeColor = Color.DarkRed;
            lblSponsor.Location = new Point(432, 140);
            lblSponsor.Margin = new Padding(2, 0, 2, 0);
            lblSponsor.Name = "lblSponsor";
            lblSponsor.Size = new Size(117, 28);
            lblSponsor.TabIndex = 8;
            lblSponsor.Text = "Nhà tài trợ";
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.BackColor = Color.White;
            lblLocation.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLocation.ForeColor = Color.DarkRed;
            lblLocation.Location = new Point(432, 30);
            lblLocation.Margin = new Padding(2, 0, 2, 0);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(107, 28);
            lblLocation.TabIndex = 6;
            lblLocation.Text = "*Địa điểm";
            // 
            // lblForm
            // 
            lblForm.AutoSize = true;
            lblForm.BackColor = Color.White;
            lblForm.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblForm.ForeColor = Color.DarkRed;
            lblForm.Location = new Point(38, 140);
            lblForm.Margin = new Padding(2, 0, 2, 0);
            lblForm.Name = "lblForm";
            lblForm.Size = new Size(192, 28);
            lblForm.TabIndex = 7;
            lblForm.Text = "*Hình thức lớp học";
            // 
            // lblChef
            // 
            lblChef.AutoSize = true;
            lblChef.BackColor = Color.White;
            lblChef.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblChef.ForeColor = Color.DarkRed;
            lblChef.Location = new Point(38, 30);
            lblChef.Margin = new Padding(2, 0, 2, 0);
            lblChef.Name = "lblChef";
            lblChef.Size = new Size(110, 28);
            lblChef.TabIndex = 5;
            lblChef.Text = "*Giáo viên";
            // 
            // lblTopic
            // 
            lblTopic.AutoSize = true;
            lblTopic.BackColor = Color.White;
            lblTopic.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTopic.ForeColor = Color.DarkRed;
            lblTopic.Location = new Point(38, 250);
            lblTopic.Margin = new Padding(2, 0, 2, 0);
            lblTopic.Name = "lblTopic";
            lblTopic.Size = new Size(87, 28);
            lblTopic.TabIndex = 9;
            lblTopic.Text = "*Chủ đề";
            // 
            // pnBasicInformation
            // 
            pnBasicInformation.BorderRadius = 40;
            pnBasicInformation.Controls.Add(btnAddPicture);
            pnBasicInformation.Controls.Add(txtQuantity);
            pnBasicInformation.Controls.Add(lblQuantity);
            pnBasicInformation.Controls.Add(rpbPicture);
            pnBasicInformation.Controls.Add(txtClassroom);
            pnBasicInformation.Controls.Add(lblClassroom);
            pnBasicInformation.Location = new Point(50, 90);
            pnBasicInformation.Margin = new Padding(2);
            pnBasicInformation.Name = "pnBasicInformation";
            pnBasicInformation.Size = new Size(750, 325);
            pnBasicInformation.TabIndex = 0;
            // 
            // btnAddPicture
            // 
            btnAddPicture.BackColor = Color.White;
            btnAddPicture.BackgroundImage = (Image)resources.GetObject("btnAddPicture.BackgroundImage");
            btnAddPicture.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddPicture.BorderRadius = 40;
            btnAddPicture.Location = new Point(500, 80);
            btnAddPicture.Margin = new Padding(2);
            btnAddPicture.Name = "btnAddPicture";
            btnAddPicture.Size = new Size(50, 50);
            btnAddPicture.TabIndex = 14;
            btnAddPicture.TabStop = false;
            btnAddPicture.Click += btnAddPicture_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = Color.FromArgb(255, 227, 232);
            txtQuantity.BackgroundColor = Color.White;
            txtQuantity.BorderRadius = 15;
            txtQuantity.BorderStyle = BorderStyle.None;
            txtQuantity.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(432, 260);
            txtQuantity.Margin = new Padding(2);
            txtQuantity.Multiline = true;
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(284, 36);
            txtQuantity.TabIndex = 2;
            txtQuantity.KeyPress += txtQuantity_KeyPress;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.BackColor = Color.White;
            lblQuantity.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = Color.DarkRed;
            lblQuantity.Location = new Point(432, 205);
            lblQuantity.Margin = new Padding(2, 0, 2, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(183, 28);
            lblQuantity.TabIndex = 2;
            lblQuantity.Text = "*Số lượng dự kiến";
            // 
            // rpbPicture
            // 
            rpbPicture.BackColor = Color.FromArgb(255, 227, 232);
            rpbPicture.BorderRadius = 40;
            rpbPicture.Location = new Point(300, 30);
            rpbPicture.Margin = new Padding(2);
            rpbPicture.Name = "rpbPicture";
            rpbPicture.Size = new Size(150, 150);
            rpbPicture.TabIndex = 9;
            rpbPicture.TabStop = false;
            // 
            // txtClassroom
            // 
            txtClassroom.BackColor = Color.FromArgb(255, 227, 232);
            txtClassroom.BackgroundColor = Color.White;
            txtClassroom.BorderRadius = 15;
            txtClassroom.BorderStyle = BorderStyle.None;
            txtClassroom.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtClassroom.Location = new Point(38, 260);
            txtClassroom.Margin = new Padding(2);
            txtClassroom.Multiline = true;
            txtClassroom.Name = "txtClassroom";
            txtClassroom.Size = new Size(284, 36);
            txtClassroom.TabIndex = 1;
            // 
            // lblClassroom
            // 
            lblClassroom.AutoSize = true;
            lblClassroom.BackColor = Color.White;
            lblClassroom.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblClassroom.ForeColor = Color.DarkRed;
            lblClassroom.Location = new Point(38, 205);
            lblClassroom.Margin = new Padding(2, 0, 2, 0);
            lblClassroom.Name = "lblClassroom";
            lblClassroom.Size = new Size(131, 28);
            lblClassroom.TabIndex = 1;
            lblClassroom.Text = "*Tên lớp học";
            // 
            // lblClassroomInformation
            // 
            lblClassroomInformation.AutoSize = true;
            lblClassroomInformation.BackColor = Color.FromArgb(255, 227, 232);
            lblClassroomInformation.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClassroomInformation.ForeColor = Color.DarkRed;
            lblClassroomInformation.Location = new Point(282, 30);
            lblClassroomInformation.Margin = new Padding(2, 0, 2, 0);
            lblClassroomInformation.Name = "lblClassroomInformation";
            lblClassroomInformation.Size = new Size(287, 38);
            lblClassroomInformation.TabIndex = 23;
            lblClassroomInformation.Text = "THÔNG TIN CƠ BẢN";
            // 
            // pnExtraInformation
            // 
            pnExtraInformation.BorderRadius = 40;
            pnExtraInformation.Controls.Add(dgvListTime);
            pnExtraInformation.Location = new Point(26, 82);
            pnExtraInformation.Margin = new Padding(2);
            pnExtraInformation.Name = "pnExtraInformation";
            pnExtraInformation.Size = new Size(1160, 302);
            pnExtraInformation.TabIndex = 12;
            // 
            // dgvListTime
            // 
            dgvListTime.AllowUserToAddRows = false;
            dgvListTime.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListTime.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvListTime.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvListTime.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvListTime.BackgroundColor = Color.FromArgb(255, 227, 232);
            dgvListTime.BorderRadius = 40;
            dgvListTime.BorderStyle = BorderStyle.None;
            dgvListTime.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvListTime.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.LightCoral;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(10);
            dataGridViewCellStyle2.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvListTime.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvListTime.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListTime.Columns.AddRange(new DataGridViewColumn[] { ColOrganizationDay, ColStartHour, ColEndHour, ColFee, ColFee1, ColFee2, ColFee3, ColComment });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 227, 232);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvListTime.DefaultCellStyle = dataGridViewCellStyle3;
            dgvListTime.EnableHeadersVisualStyles = false;
            dgvListTime.GridColor = Color.FromArgb(255, 227, 232);
            dgvListTime.Location = new Point(20, 31);
            dgvListTime.Margin = new Padding(2);
            dgvListTime.Name = "dgvListTime";
            dgvListTime.ReadOnly = true;
            dgvListTime.RowHeadersVisible = false;
            dgvListTime.RowHeadersWidth = 62;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 227, 232);
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgvListTime.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvListTime.RowTemplate.Height = 50;
            dgvListTime.RowTemplate.Resizable = DataGridViewTriState.True;
            dgvListTime.Size = new Size(1120, 241);
            dgvListTime.TabIndex = 13;
            // 
            // ColOrganizationDay
            // 
            ColOrganizationDay.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColOrganizationDay.HeaderText = "*Ngày";
            ColOrganizationDay.MinimumWidth = 8;
            ColOrganizationDay.Name = "ColOrganizationDay";
            ColOrganizationDay.ReadOnly = true;
            // 
            // ColStartHour
            // 
            ColStartHour.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColStartHour.HeaderText = "*Giờ bắt đầu";
            ColStartHour.MinimumWidth = 8;
            ColStartHour.Name = "ColStartHour";
            ColStartHour.ReadOnly = true;
            // 
            // ColEndHour
            // 
            ColEndHour.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColEndHour.HeaderText = "*Giờ kết thúc";
            ColEndHour.MinimumWidth = 8;
            ColEndHour.Name = "ColEndHour";
            ColEndHour.ReadOnly = true;
            // 
            // ColFee
            // 
            ColFee.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColFee.FillWeight = 95F;
            ColFee.HeaderText = "*Học phí";
            ColFee.MinimumWidth = 8;
            ColFee.Name = "ColFee";
            ColFee.ReadOnly = true;
            // 
            // ColFee1
            // 
            ColFee1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColFee1.FillWeight = 95F;
            ColFee1.HeaderText = "Chi phí 1";
            ColFee1.MinimumWidth = 8;
            ColFee1.Name = "ColFee1";
            ColFee1.ReadOnly = true;
            // 
            // ColFee2
            // 
            ColFee2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColFee2.FillWeight = 95F;
            ColFee2.HeaderText = "Chi phí 2";
            ColFee2.MinimumWidth = 8;
            ColFee2.Name = "ColFee2";
            ColFee2.ReadOnly = true;
            // 
            // ColFee3
            // 
            ColFee3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColFee3.FillWeight = 95F;
            ColFee3.HeaderText = "Chi phí 3";
            ColFee3.MinimumWidth = 8;
            ColFee3.Name = "ColFee3";
            ColFee3.ReadOnly = true;
            // 
            // ColComment
            // 
            ColComment.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColComment.HeaderText = "Ghi chú";
            ColComment.MinimumWidth = 8;
            ColComment.Name = "ColComment";
            ColComment.ReadOnly = true;
            // 
            // btnAddTime
            // 
            btnAddTime.BackColor = Color.FromArgb(255, 227, 232);
            btnAddTime.BackgroundImage = (Image)resources.GetObject("btnAddTime.BackgroundImage");
            btnAddTime.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddTime.BorderRadius = 40;
            btnAddTime.Location = new Point(745, 22);
            btnAddTime.Margin = new Padding(2);
            btnAddTime.Name = "btnAddTime";
            btnAddTime.Size = new Size(46, 38);
            btnAddTime.TabIndex = 31;
            btnAddTime.TabStop = false;
            btnAddTime.Click += btnAddTime_Click;
            // 
            // lblExtraInformation
            // 
            lblExtraInformation.AutoSize = true;
            lblExtraInformation.BackColor = Color.FromArgb(255, 227, 232);
            lblExtraInformation.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExtraInformation.ForeColor = Color.DarkRed;
            lblExtraInformation.Location = new Point(394, 22);
            lblExtraInformation.Margin = new Padding(2, 0, 2, 0);
            lblExtraInformation.Name = "lblExtraInformation";
            lblExtraInformation.Size = new Size(321, 38);
            lblExtraInformation.TabIndex = 30;
            lblExtraInformation.Text = "THÔNG TIN ĐÍNH KÈM";
            // 
            // btnAdd
            // 
            btnAdd.BorderRadius = 40;
            btnAdd.ButtonColor = Color.DarkRed;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.Location = new Point(1132, 1598);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 39);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Thêm";
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblComment
            // 
            lblComment.AutoSize = true;
            lblComment.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblComment.Location = new Point(748, 22);
            lblComment.Margin = new Padding(2, 0, 2, 0);
            lblComment.Name = "lblComment";
            lblComment.Size = new Size(321, 25);
            lblComment.TabIndex = 30;
            lblComment.Text = "Dấu * thể hiện trường dữ liệu bắt buộc";
            // 
            // pnFormAddClassroom1
            // 
            pnFormAddClassroom1.BorderRadius = 40;
            pnFormAddClassroom1.Controls.Add(pnExtraInformation);
            pnFormAddClassroom1.Controls.Add(lblExtraInformation);
            pnFormAddClassroom1.Controls.Add(btnAddTime);
            pnFormAddClassroom1.Location = new Point(35, 1148);
            pnFormAddClassroom1.Margin = new Padding(2);
            pnFormAddClassroom1.Name = "pnFormAddClassroom1";
            pnFormAddClassroom1.Size = new Size(1210, 416);
            pnFormAddClassroom1.TabIndex = 33;
            // 
            // CreateClassroom
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            BackColor = Color.FromArgb(251, 236, 240);
            ClientSize = new Size(1278, 1050);
            Controls.Add(pnFormAddClassroom1);
            Controls.Add(lblComment);
            Controls.Add(btnAdd);
            Controls.Add(pnFormAddClassroom);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "CreateClassroom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tạo lớp học";
            Load += CreateClassroom_Load;
            pnFormAddClassroom.ResumeLayout(false);
            pnFormAddClassroom.PerformLayout();
            pnBasicInformation2.ResumeLayout(false);
            pnBasicInformation2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)rdpAI).EndInit();
            pnBasicInformation1.ResumeLayout(false);
            pnBasicInformation1.PerformLayout();
            pnBasicInformation.ResumeLayout(false);
            pnBasicInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnAddPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)rpbPicture).EndInit();
            pnExtraInformation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAddTime).EndInit();
            pnFormAddClassroom1.ResumeLayout(false);
            pnFormAddClassroom1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblQuantity;
        private LOGIN.RoundedPictureBox rpbPicture;
        private RoundedButton btnAdd;
        private CHEF.RoundedPanel1 pnFormAddClassroom;
        private Label lblClassroomInformation;
        private LOGIN.RoundedPanel pnBasicInformation;
        private LOGIN.RoundedTextBox txtClassroom;
        private Label lblClassroom;
        private LOGIN.RoundedTextBox txtQuantity;
        private LOGIN.RoundedPictureBox btnAddPicture;
        private LOGIN.RoundedPanel pnBasicInformation1;
        private Label lblSponsor;
        private Label lblLocation;
        private Label lblForm;
        private Label lblChef;
        private Label lblTopic;
        private LOGIN.RoundedComboBox cmbChef;
        private LOGIN.RoundedComboBox cmbTopic;
        private LOGIN.RoundedComboBox cmbLocation;
        private LOGIN.RoundedComboBox cmbForm;
        private LOGIN.RoundedComboBox cmbSponsor;
        private LOGIN.RoundedPanel pnBasicInformation2;
        private LOGIN.RoundedTextBox txtDescription;
        private Label lblDescription;
        private LOGIN.RoundedPanel pnExtraInformation;
        private RoundedDataGridView dgvListTime;
        private LOGIN.RoundedPictureBox btnAddTime;
        private Label lblExtraInformation;
        private Label lblComment;
        private CHEF.RoundedPanel1 pnFormAddClassroom1;
        private DataGridViewTextBoxColumn ColOrganizationDay;
        private DataGridViewTextBoxColumn ColStartHour;
        private DataGridViewTextBoxColumn ColEndHour;
        private DataGridViewTextBoxColumn ColFee;
        private DataGridViewTextBoxColumn ColFee1;
        private DataGridViewTextBoxColumn ColFee2;
        private DataGridViewTextBoxColumn ColFee3;
        private DataGridViewTextBoxColumn ColComment;
        private LOGIN.RoundedPictureBox rdpAI;
    }
}