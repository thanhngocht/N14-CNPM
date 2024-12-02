namespace THE_COOKY_APP.GUI.LOCATION
{
    partial class ListLocation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListLocation));
            btnCancel = new CLASSROOM.RoundedButton();
            btnUpdate = new CLASSROOM.RoundedButton();
            btnAdd = new CLASSROOM.RoundedButton();
            lblSearch = new Label();
            pnListLocation = new LOGIN.RoundedPanel();
            dgvListLocation = new CLASSROOM.RoundedDataGridView();
            ColNameLocation = new DataGridViewTextBoxColumn();
            ColAddress = new DataGridViewTextBoxColumn();
            ColQuantity = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            IsActive = new DataGridViewTextBoxColumn();
            pnDetailLocation = new CHEF.RoundedPanel1();
            pnButton = new LOGIN.RoundedPanel();
            pnLocation = new LOGIN.RoundedPanel();
            txtDescription = new LOGIN.RoundedTextBox();
            txtQuantity = new LOGIN.RoundedTextBox();
            txtAddress = new LOGIN.RoundedTextBox();
            txtNameLocation = new LOGIN.RoundedTextBox();
            lblDiscription = new Label();
            lblQuantity = new Label();
            lblAddress = new Label();
            lblNameLocation = new Label();
            pnAction = new CHEF.RoundedPanel1();
            pnSearch = new LOGIN.RoundedPanel();
            lblFilter = new Label();
            cmbFilter = new LOGIN.RoundedComboBox();
            txtSearch = new LOGIN.RoundedTextBox();
            pnListLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListLocation).BeginInit();
            pnDetailLocation.SuspendLayout();
            pnButton.SuspendLayout();
            pnLocation.SuspendLayout();
            pnAction.SuspendLayout();
            pnSearch.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BorderRadius = 40;
            btnCancel.ButtonColor = Color.DarkRed;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.Location = new Point(164, 20);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 39);
            btnCancel.TabIndex = 28;
            btnCancel.Text = "Xóa";
            btnCancel.TextColor = Color.White;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BorderRadius = 40;
            btnUpdate.ButtonColor = Color.DarkRed;
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdate.Location = new Point(312, 20);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 39);
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "Sửa";
            btnUpdate.TextColor = Color.White;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BorderRadius = 40;
            btnAdd.ButtonColor = Color.DarkRed;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.Location = new Point(15, 20);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 39);
            btnAdd.TabIndex = 26;
            btnAdd.Text = "Thêm";
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
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
            // pnListLocation
            // 
            pnListLocation.BorderRadius = 40;
            pnListLocation.Controls.Add(dgvListLocation);
            pnListLocation.Location = new Point(40, 248);
            pnListLocation.Margin = new Padding(2);
            pnListLocation.Name = "pnListLocation";
            pnListLocation.Size = new Size(712, 538);
            pnListLocation.TabIndex = 13;
            // 
            // dgvListLocation
            // 
            dgvListLocation.AllowUserToAddRows = false;
            dgvListLocation.AllowUserToDeleteRows = false;
            dgvListLocation.BackgroundColor = Color.FromArgb(255, 227, 232);
            dgvListLocation.BorderRadius = 40;
            dgvListLocation.BorderStyle = BorderStyle.None;
            dgvListLocation.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvListLocation.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.LightCoral;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListLocation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListLocation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListLocation.Columns.AddRange(new DataGridViewColumn[] { ColNameLocation, ColAddress, ColQuantity, ID, Description, IsActive });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 227, 232);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvListLocation.DefaultCellStyle = dataGridViewCellStyle2;
            dgvListLocation.EnableHeadersVisualStyles = false;
            dgvListLocation.Location = new Point(28, 31);
            dgvListLocation.Margin = new Padding(2);
            dgvListLocation.Name = "dgvListLocation";
            dgvListLocation.ReadOnly = true;
            dgvListLocation.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvListLocation.RowHeadersVisible = false;
            dgvListLocation.RowHeadersWidth = 62;
            dgvListLocation.Size = new Size(658, 475);
            dgvListLocation.TabIndex = 0;
            dgvListLocation.CellClick += dgvListLocation_CellClick;
            // 
            // ColNameLocation
            // 
            ColNameLocation.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColNameLocation.HeaderText = "Tên địa điểm";
            ColNameLocation.MinimumWidth = 8;
            ColNameLocation.Name = "ColNameLocation";
            ColNameLocation.ReadOnly = true;
            // 
            // ColAddress
            // 
            ColAddress.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColAddress.HeaderText = "Địa chỉ";
            ColAddress.MinimumWidth = 8;
            ColAddress.Name = "ColAddress";
            ColAddress.ReadOnly = true;
            // 
            // ColQuantity
            // 
            ColQuantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColQuantity.HeaderText = "Sức chứa";
            ColQuantity.MinimumWidth = 8;
            ColQuantity.Name = "ColQuantity";
            ColQuantity.ReadOnly = true;
            // 
            // ID
            // 
            ID.HeaderText = "Mã địa điểm";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            ID.Width = 125;
            // 
            // Description
            // 
            Description.HeaderText = "Mô tả";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.ReadOnly = true;
            Description.Visible = false;
            Description.Width = 125;
            // 
            // IsActive
            // 
            IsActive.HeaderText = "Kích hoạt";
            IsActive.MinimumWidth = 6;
            IsActive.Name = "IsActive";
            IsActive.ReadOnly = true;
            IsActive.Visible = false;
            IsActive.Width = 125;
            // 
            // pnDetailLocation
            // 
            pnDetailLocation.BorderRadius = 40;
            pnDetailLocation.Controls.Add(pnButton);
            pnDetailLocation.Controls.Add(pnLocation);
            pnDetailLocation.Location = new Point(809, 42);
            pnDetailLocation.Margin = new Padding(2);
            pnDetailLocation.Name = "pnDetailLocation";
            pnDetailLocation.Size = new Size(490, 741);
            pnDetailLocation.TabIndex = 14;
            // 
            // pnButton
            // 
            pnButton.BorderRadius = 40;
            pnButton.Controls.Add(btnUpdate);
            pnButton.Controls.Add(btnCancel);
            pnButton.Controls.Add(btnAdd);
            pnButton.Location = new Point(20, 610);
            pnButton.Margin = new Padding(2);
            pnButton.Name = "pnButton";
            pnButton.Size = new Size(450, 80);
            pnButton.TabIndex = 0;
            // 
            // pnLocation
            // 
            pnLocation.BorderRadius = 40;
            pnLocation.Controls.Add(txtDescription);
            pnLocation.Controls.Add(txtQuantity);
            pnLocation.Controls.Add(txtAddress);
            pnLocation.Controls.Add(txtNameLocation);
            pnLocation.Controls.Add(lblDiscription);
            pnLocation.Controls.Add(lblQuantity);
            pnLocation.Controls.Add(lblAddress);
            pnLocation.Controls.Add(lblNameLocation);
            pnLocation.Location = new Point(65, 60);
            pnLocation.Margin = new Padding(2);
            pnLocation.Name = "pnLocation";
            pnLocation.Size = new Size(360, 508);
            pnLocation.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.FromArgb(255, 227, 232);
            txtDescription.BackgroundColor = Color.FromArgb(255, 227, 232);
            txtDescription.BorderRadius = 15;
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Enabled = false;
            txtDescription.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(38, 405);
            txtDescription.Margin = new Padding(2);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(284, 72);
            txtDescription.TabIndex = 4;
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = Color.FromArgb(255, 227, 232);
            txtQuantity.BackgroundColor = Color.FromArgb(255, 227, 232);
            txtQuantity.BorderRadius = 15;
            txtQuantity.BorderStyle = BorderStyle.None;
            txtQuantity.Enabled = false;
            txtQuantity.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(38, 305);
            txtQuantity.Margin = new Padding(2);
            txtQuantity.Multiline = true;
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(284, 36);
            txtQuantity.TabIndex = 3;
            txtQuantity.KeyPress += txtQuantity_KeyPress;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.FromArgb(255, 227, 232);
            txtAddress.BackgroundColor = Color.FromArgb(255, 227, 232);
            txtAddress.BorderRadius = 15;
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.Enabled = false;
            txtAddress.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(38, 195);
            txtAddress.Margin = new Padding(2);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(284, 36);
            txtAddress.TabIndex = 2;
            // 
            // txtNameLocation
            // 
            txtNameLocation.BackColor = Color.FromArgb(255, 227, 232);
            txtNameLocation.BackgroundColor = Color.FromArgb(255, 227, 232);
            txtNameLocation.BorderRadius = 15;
            txtNameLocation.BorderStyle = BorderStyle.None;
            txtNameLocation.Enabled = false;
            txtNameLocation.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNameLocation.Location = new Point(38, 85);
            txtNameLocation.Margin = new Padding(2);
            txtNameLocation.Multiline = true;
            txtNameLocation.Name = "txtNameLocation";
            txtNameLocation.Size = new Size(284, 36);
            txtNameLocation.TabIndex = 1;
            // 
            // lblDiscription
            // 
            lblDiscription.AutoSize = true;
            lblDiscription.BackColor = Color.White;
            lblDiscription.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiscription.ForeColor = Color.DarkRed;
            lblDiscription.Location = new Point(38, 360);
            lblDiscription.Margin = new Padding(2, 0, 2, 0);
            lblDiscription.Name = "lblDiscription";
            lblDiscription.Size = new Size(68, 28);
            lblDiscription.TabIndex = 4;
            lblDiscription.Text = "Mô tả";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.BackColor = Color.White;
            lblQuantity.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = Color.DarkRed;
            lblQuantity.Location = new Point(38, 250);
            lblQuantity.Margin = new Padding(2, 0, 2, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(98, 28);
            lblQuantity.TabIndex = 3;
            lblQuantity.Text = "Sức chứa";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.White;
            lblAddress.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddress.ForeColor = Color.DarkRed;
            lblAddress.Location = new Point(38, 140);
            lblAddress.Margin = new Padding(2, 0, 2, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(78, 28);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Địa chỉ";
            // 
            // lblNameLocation
            // 
            lblNameLocation.AutoSize = true;
            lblNameLocation.BackColor = Color.White;
            lblNameLocation.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNameLocation.ForeColor = Color.DarkRed;
            lblNameLocation.Location = new Point(38, 30);
            lblNameLocation.Margin = new Padding(2, 0, 2, 0);
            lblNameLocation.Name = "lblNameLocation";
            lblNameLocation.Size = new Size(135, 28);
            lblNameLocation.TabIndex = 1;
            lblNameLocation.Text = "Tên địa điểm";
            // 
            // pnAction
            // 
            pnAction.BorderRadius = 40;
            pnAction.Controls.Add(pnSearch);
            pnAction.Location = new Point(40, 42);
            pnAction.Margin = new Padding(2);
            pnAction.Name = "pnAction";
            pnAction.Size = new Size(712, 205);
            pnAction.TabIndex = 16;
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
            // ListLocation
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(251, 236, 240);
            ClientSize = new Size(1338, 859);
            Controls.Add(pnAction);
            Controls.Add(pnDetailLocation);
            Controls.Add(pnListLocation);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "ListLocation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách địa điểm";
            Load += ListLocation_Load;
            pnListLocation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListLocation).EndInit();
            pnDetailLocation.ResumeLayout(false);
            pnButton.ResumeLayout(false);
            pnLocation.ResumeLayout(false);
            pnLocation.PerformLayout();
            pnAction.ResumeLayout(false);
            pnSearch.ResumeLayout(false);
            pnSearch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private CLASSROOM.RoundedButton btnCancel;
        private CLASSROOM.RoundedButton btnUpdate;
        private CLASSROOM.RoundedButton btnAdd;
        private Label lblSearch;
        private LOGIN.RoundedPanel pnListLocation;
        private LOGIN.RoundedPanel pnLocation;
        private LOGIN.RoundedTextBox txtDescription;
        private LOGIN.RoundedTextBox txtQuantity;
        private LOGIN.RoundedTextBox txtAddress;
        private LOGIN.RoundedTextBox txtNameLocation;
        private Label lblDiscription;
        private Label lblQuantity;
        private Label lblAddress;
        private Label lblNameLocation;
        private CHEF.RoundedPanel1 pnDetailLocation;
        private LOGIN.RoundedPanel pnButton;
        private CHEF.RoundedPanel1 pnAction;
        private LOGIN.RoundedPanel pnSearch;
        private LOGIN.RoundedTextBox txtSearch;
        private CLASSROOM.RoundedDataGridView dgvListLocation;
        private LOGIN.RoundedComboBox cmbFilter;
        private Label lblFilter;
        private DataGridViewTextBoxColumn ColNameLocation;
        private DataGridViewTextBoxColumn ColAddress;
        private DataGridViewTextBoxColumn ColQuantity;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn IsActive;
    }
}