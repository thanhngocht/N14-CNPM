namespace THE_COOKY_APP.GUI.CHEF
{
    partial class ListChef
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListChef));
            btnAdd = new CLASSROOM.RoundedButton();
            btnDelete = new CLASSROOM.RoundedButton();
            pnAction = new RoundedPanel1();
            pnButton = new LOGIN.RoundedPanel();
            pnSearch = new LOGIN.RoundedPanel();
            lblFilter = new Label();
            cmbFilter = new LOGIN.RoundedComboBox();
            txtSearch = new LOGIN.RoundedTextBox();
            lblSearch = new Label();
            pnListChef = new LOGIN.RoundedPanel();
            dgvListChef = new CLASSROOM.RoundedDataGridView();
            ColFullname = new DataGridViewTextBoxColumn();
            ColPhonenumber = new DataGridViewTextBoxColumn();
            ColGmail = new DataGridViewTextBoxColumn();
            ColStartDate = new DataGridViewTextBoxColumn();
            ColSpeciality = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            pnAction.SuspendLayout();
            pnButton.SuspendLayout();
            pnSearch.SuspendLayout();
            pnListChef.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListChef).BeginInit();
            SuspendLayout();
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
            btnAdd.TabIndex = 20;
            btnAdd.Text = "Thêm";
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BorderRadius = 40;
            btnDelete.ButtonColor = Color.DarkRed;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.Location = new Point(192, 40);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 39);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Xóa";
            btnDelete.TextColor = Color.White;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // pnAction
            // 
            pnAction.BorderRadius = 40;
            pnAction.Controls.Add(pnButton);
            pnAction.Controls.Add(pnSearch);
            pnAction.Location = new Point(40, 42);
            pnAction.Margin = new Padding(2);
            pnAction.Name = "pnAction";
            pnAction.Size = new Size(1260, 205);
            pnAction.TabIndex = 26;
            // 
            // pnButton
            // 
            pnButton.BorderRadius = 40;
            pnButton.Controls.Add(btnAdd);
            pnButton.Controls.Add(btnDelete);
            pnButton.Location = new Point(860, 42);
            pnButton.Margin = new Padding(2);
            pnButton.Name = "pnButton";
            pnButton.Size = new Size(350, 119);
            pnButton.TabIndex = 1;
            // 
            // pnSearch
            // 
            pnSearch.BorderRadius = 40;
            pnSearch.Controls.Add(lblFilter);
            pnSearch.Controls.Add(cmbFilter);
            pnSearch.Controls.Add(txtSearch);
            pnSearch.Controls.Add(lblSearch);
            pnSearch.Location = new Point(50, 28);
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
            // pnListChef
            // 
            pnListChef.BorderRadius = 40;
            pnListChef.Controls.Add(dgvListChef);
            pnListChef.Location = new Point(40, 248);
            pnListChef.Margin = new Padding(2);
            pnListChef.Name = "pnListChef";
            pnListChef.Size = new Size(1260, 480);
            pnListChef.TabIndex = 28;
            // 
            // dgvListChef
            // 
            dgvListChef.AllowUserToAddRows = false;
            dgvListChef.AllowUserToDeleteRows = false;
            dgvListChef.BackgroundColor = Color.FromArgb(255, 227, 232);
            dgvListChef.BorderRadius = 40;
            dgvListChef.BorderStyle = BorderStyle.None;
            dgvListChef.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvListChef.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.LightCoral;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListChef.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListChef.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListChef.Columns.AddRange(new DataGridViewColumn[] { ColFullname, ColPhonenumber, ColGmail, ColStartDate, ColSpeciality, ID });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 227, 232);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvListChef.DefaultCellStyle = dataGridViewCellStyle2;
            dgvListChef.EnableHeadersVisualStyles = false;
            dgvListChef.Location = new Point(50, 35);
            dgvListChef.Margin = new Padding(2);
            dgvListChef.Name = "dgvListChef";
            dgvListChef.ReadOnly = true;
            dgvListChef.RowHeadersVisible = false;
            dgvListChef.RowHeadersWidth = 62;
            dgvListChef.Size = new Size(1160, 410);
            dgvListChef.TabIndex = 0;
            dgvListChef.CellClick += dgvListChef_CellClick;
            dgvListChef.CellDoubleClick += dgvListChef_CellDoubleClick;
            // 
            // ColFullname
            // 
            ColFullname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColFullname.HeaderText = "Tên giáo viên";
            ColFullname.MinimumWidth = 6;
            ColFullname.Name = "ColFullname";
            ColFullname.ReadOnly = true;
            // 
            // ColPhonenumber
            // 
            ColPhonenumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColPhonenumber.HeaderText = "SĐT";
            ColPhonenumber.MinimumWidth = 6;
            ColPhonenumber.Name = "ColPhonenumber";
            ColPhonenumber.ReadOnly = true;
            // 
            // ColGmail
            // 
            ColGmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColGmail.HeaderText = "Gmail";
            ColGmail.MinimumWidth = 6;
            ColGmail.Name = "ColGmail";
            ColGmail.ReadOnly = true;
            // 
            // ColStartDate
            // 
            ColStartDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColStartDate.HeaderText = "Ngày làm việc";
            ColStartDate.MinimumWidth = 6;
            ColStartDate.Name = "ColStartDate";
            ColStartDate.ReadOnly = true;
            // 
            // ColSpeciality
            // 
            ColSpeciality.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColSpeciality.HeaderText = "Chuyên môn";
            ColSpeciality.MinimumWidth = 6;
            ColSpeciality.Name = "ColSpeciality";
            ColSpeciality.ReadOnly = true;
            // 
            // ID
            // 
            ID.HeaderText = "Mã giáo viên";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            ID.Width = 125;
            // 
            // ListChef
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(251, 236, 240);
            ClientSize = new Size(1338, 764);
            Controls.Add(pnListChef);
            Controls.Add(pnAction);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "ListChef";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách đầu bếp";
            Load += ListChef_Load;
            pnAction.ResumeLayout(false);
            pnButton.ResumeLayout(false);
            pnSearch.ResumeLayout(false);
            pnSearch.PerformLayout();
            pnListChef.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListChef).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private CLASSROOM.RoundedButton btnAdd;
        private CLASSROOM.RoundedButton btnDelete;
        private RoundedPanel1 pnAction;
        private LOGIN.RoundedPanel pnButton;
        private LOGIN.RoundedPanel pnSearch;
        private Label lblFilter;
        private LOGIN.RoundedComboBox cmbFilter;
        private LOGIN.RoundedTextBox txtSearch;
        private Label lblSearch;
        private LOGIN.RoundedPanel pnListChef;
        private CLASSROOM.RoundedDataGridView dgvListChef;
        private DataGridViewTextBoxColumn ColFullname;
        private DataGridViewTextBoxColumn ColPhonenumber;
        private DataGridViewTextBoxColumn ColGmail;
        private DataGridViewTextBoxColumn ColStartDate;
        private DataGridViewTextBoxColumn ColSpeciality;
        private DataGridViewTextBoxColumn ID;
    }
}