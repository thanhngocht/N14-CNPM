namespace THE_COOKY_APP.GUI.STUDENT
{
    partial class FindStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindStudent));
            pnListStudent = new LOGIN.RoundedPanel();
            dgvListStudent = new CLASSROOM.RoundedDataGridView();
            colIdStudent = new DataGridViewTextBoxColumn();
            colNameStudent = new DataGridViewTextBoxColumn();
            colPhoneNumber = new DataGridViewTextBoxColumn();
            colGmail = new DataGridViewTextBoxColumn();
            pnAction = new CHEF.RoundedPanel1();
            pnSearch = new LOGIN.RoundedPanel();
            rpbAdd = new LOGIN.RoundedPictureBox();
            lblFilter = new Label();
            cmbFilter = new LOGIN.RoundedComboBox();
            txtSearch = new LOGIN.RoundedTextBox();
            lblSearch = new Label();
            btnAdd = new LOGIN.RoundedButton();
            pnListStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListStudent).BeginInit();
            pnAction.SuspendLayout();
            pnSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rpbAdd).BeginInit();
            SuspendLayout();
            // 
            // pnListStudent
            // 
            pnListStudent.BorderRadius = 40;
            pnListStudent.Controls.Add(dgvListStudent);
            pnListStudent.Location = new Point(44, 241);
            pnListStudent.Margin = new Padding(2);
            pnListStudent.Name = "pnListStudent";
            pnListStudent.Size = new Size(712, 574);
            pnListStudent.TabIndex = 21;
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
            // pnAction
            // 
            pnAction.BorderRadius = 40;
            pnAction.Controls.Add(pnSearch);
            pnAction.Location = new Point(44, 38);
            pnAction.Margin = new Padding(2);
            pnAction.Name = "pnAction";
            pnAction.Size = new Size(712, 205);
            pnAction.TabIndex = 20;
            // 
            // pnSearch
            // 
            pnSearch.BorderRadius = 40;
            pnSearch.Controls.Add(rpbAdd);
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
            // rpbAdd
            // 
            rpbAdd.BackColor = Color.White;
            rpbAdd.BackgroundImage = (Image)resources.GetObject("rpbAdd.BackgroundImage");
            rpbAdd.BackgroundImageLayout = ImageLayout.Stretch;
            rpbAdd.BorderRadius = 40;
            rpbAdd.Location = new Point(608, 0);
            rpbAdd.Margin = new Padding(2);
            rpbAdd.Name = "rpbAdd";
            rpbAdd.Size = new Size(48, 48);
            rpbAdd.TabIndex = 34;
            rpbAdd.TabStop = false;
            rpbAdd.Click += rpbAdd_Click;
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
            // btnAdd
            // 
            btnAdd.BorderRadius = 40;
            btnAdd.ButtonColor = Color.DarkRed;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(645, 838);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "Thêm";
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // FindStudent
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(251, 236, 240);
            ClientSize = new Size(800, 884);
            Controls.Add(btnAdd);
            Controls.Add(pnListStudent);
            Controls.Add(pnAction);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "FindStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tra cứu học viên";
            pnListStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListStudent).EndInit();
            pnAction.ResumeLayout(false);
            pnSearch.ResumeLayout(false);
            pnSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)rpbAdd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private LOGIN.RoundedPanel pnListStudent;
        private CLASSROOM.RoundedDataGridView dgvListStudent;
        private DataGridViewTextBoxColumn colIdStudent;
        private DataGridViewTextBoxColumn colNameStudent;
        private DataGridViewTextBoxColumn colPhoneNumber;
        private DataGridViewTextBoxColumn colGmail;
        private CHEF.RoundedPanel1 pnAction;
        private LOGIN.RoundedPanel pnSearch;
        private Label lblFilter;
        private LOGIN.RoundedComboBox cmbFilter;
        private LOGIN.RoundedTextBox txtSearch;
        private Label lblSearch;
        private LOGIN.RoundedButton btnAdd;
        private LOGIN.RoundedPictureBox rpbAdd;
    }
}