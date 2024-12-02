namespace THE_COOKY_APP.GUI.ACCOUNT
{
    partial class ListAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListAccount));
            pnAction = new CHEF.RoundedPanel1();
            pnButton = new LOGIN.RoundedPanel();
            btnDelete = new CLASSROOM.RoundedButton();
            btnAdd = new CLASSROOM.RoundedButton();
            pnSearch = new LOGIN.RoundedPanel();
            lblFilter = new Label();
            cmbFilter = new LOGIN.RoundedComboBox();
            txtSearch = new LOGIN.RoundedTextBox();
            lblSearch = new Label();
            pnListAccount = new LOGIN.RoundedPanel();
            dgvListAccount = new CLASSROOM.RoundedDataGridView();
            ColFullname = new DataGridViewTextBoxColumn();
            ColUsername = new DataGridViewTextBoxColumn();
            ColPassword = new DataGridViewTextBoxColumn();
            ColPhonenumber = new DataGridViewTextBoxColumn();
            ColGmail = new DataGridViewTextBoxColumn();
            ColRole = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            pnAction.SuspendLayout();
            pnButton.SuspendLayout();
            pnSearch.SuspendLayout();
            pnListAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListAccount).BeginInit();
            SuspendLayout();
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
            pnAction.TabIndex = 25;
            // 
            // pnButton
            // 
            pnButton.BorderRadius = 40;
            pnButton.Controls.Add(btnDelete);
            pnButton.Controls.Add(btnAdd);
            pnButton.Location = new Point(860, 42);
            pnButton.Margin = new Padding(2);
            pnButton.Name = "pnButton";
            pnButton.Size = new Size(350, 119);
            pnButton.TabIndex = 4;
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
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Xóa";
            btnDelete.TextColor = Color.White;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnCancel_Click;
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
            btnAdd.TabIndex = 5;
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
            pnSearch.Location = new Point(50, 28);
            pnSearch.Margin = new Padding(2);
            pnSearch.Name = "pnSearch";
            pnSearch.Size = new Size(658, 151);
            pnSearch.TabIndex = 1;
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
            lblFilter.TabIndex = 3;
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
            cmbFilter.TabIndex = 3;
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
            txtSearch.TabIndex = 2;
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
            lblSearch.TabIndex = 2;
            lblSearch.Text = "Tìm kiếm";
            // 
            // pnListAccount
            // 
            pnListAccount.BorderRadius = 40;
            pnListAccount.Controls.Add(dgvListAccount);
            pnListAccount.Location = new Point(40, 248);
            pnListAccount.Margin = new Padding(2);
            pnListAccount.Name = "pnListAccount";
            pnListAccount.Size = new Size(1260, 480);
            pnListAccount.TabIndex = 0;
            // 
            // dgvListAccount
            // 
            dgvListAccount.AllowUserToAddRows = false;
            dgvListAccount.AllowUserToDeleteRows = false;
            dgvListAccount.BackgroundColor = Color.FromArgb(255, 227, 232);
            dgvListAccount.BorderRadius = 40;
            dgvListAccount.BorderStyle = BorderStyle.None;
            dgvListAccount.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvListAccount.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.LightCoral;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListAccount.Columns.AddRange(new DataGridViewColumn[] { ColFullname, ColUsername, ColPassword, ColPhonenumber, ColGmail, ColRole, ID });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 227, 232);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvListAccount.DefaultCellStyle = dataGridViewCellStyle2;
            dgvListAccount.EnableHeadersVisualStyles = false;
            dgvListAccount.Location = new Point(50, 35);
            dgvListAccount.Margin = new Padding(2);
            dgvListAccount.Name = "dgvListAccount";
            dgvListAccount.ReadOnly = true;
            dgvListAccount.RowHeadersVisible = false;
            dgvListAccount.RowHeadersWidth = 62;
            dgvListAccount.Size = new Size(1160, 410);
            dgvListAccount.TabIndex = 0;
            dgvListAccount.CellClick += dgvListAccount_CellClick;
            dgvListAccount.CellDoubleClick += dgvListAccount_CellDoubleClick;
            // 
            // ColFullname
            // 
            ColFullname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColFullname.HeaderText = "Họ và tên";
            ColFullname.MinimumWidth = 8;
            ColFullname.Name = "ColFullname";
            ColFullname.ReadOnly = true;
            // 
            // ColUsername
            // 
            ColUsername.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColUsername.HeaderText = "Tài khoản";
            ColUsername.MinimumWidth = 8;
            ColUsername.Name = "ColUsername";
            ColUsername.ReadOnly = true;
            // 
            // ColPassword
            // 
            ColPassword.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColPassword.HeaderText = "Mật khẩu";
            ColPassword.MinimumWidth = 8;
            ColPassword.Name = "ColPassword";
            ColPassword.ReadOnly = true;
            // 
            // ColPhonenumber
            // 
            ColPhonenumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColPhonenumber.HeaderText = "SĐT";
            ColPhonenumber.MinimumWidth = 8;
            ColPhonenumber.Name = "ColPhonenumber";
            ColPhonenumber.ReadOnly = true;
            // 
            // ColGmail
            // 
            ColGmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColGmail.HeaderText = "Gmail";
            ColGmail.MinimumWidth = 8;
            ColGmail.Name = "ColGmail";
            ColGmail.ReadOnly = true;
            // 
            // ColRole
            // 
            ColRole.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColRole.HeaderText = "Chức vụ";
            ColRole.MinimumWidth = 8;
            ColRole.Name = "ColRole";
            ColRole.ReadOnly = true;
            // 
            // ID
            // 
            ID.HeaderText = "Mã tài khoản";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            ID.Width = 125;
            // 
            // ListAccount
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(251, 236, 240);
            ClientSize = new Size(1338, 764);
            Controls.Add(pnListAccount);
            Controls.Add(pnAction);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "ListAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách tài khoản";
            Load += ListAccount_Load;
            pnAction.ResumeLayout(false);
            pnButton.ResumeLayout(false);
            pnSearch.ResumeLayout(false);
            pnSearch.PerformLayout();
            pnListAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListAccount).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private CHEF.RoundedPanel1 pnAction;
        private LOGIN.RoundedPanel pnSearch;
        private Label lblFilter;
        private LOGIN.RoundedComboBox cmbFilter;
        private LOGIN.RoundedTextBox txtSearch;
        private Label lblSearch;
        private LOGIN.RoundedPanel pnListAccount;
        private CLASSROOM.RoundedDataGridView dgvListAccount;
        private CLASSROOM.RoundedButton btnDelete;
        private CLASSROOM.RoundedButton btnAdd;
        private LOGIN.RoundedPanel pnButton;
        private DataGridViewTextBoxColumn ColFullname;
        private DataGridViewTextBoxColumn ColUsername;
        private DataGridViewTextBoxColumn ColPassword;
        private DataGridViewTextBoxColumn ColPhonenumber;
        private DataGridViewTextBoxColumn ColGmail;
        private DataGridViewTextBoxColumn ColRole;
        private DataGridViewTextBoxColumn ID;
    }
}