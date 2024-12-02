namespace THE_COOKY_APP.GUI.TOPIC
{
    partial class ListTopic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListTopic));
            pnButton = new LOGIN.RoundedPanel();
            btnUpdate = new CLASSROOM.RoundedButton();
            btnCancel = new CLASSROOM.RoundedButton();
            btnAdd = new CLASSROOM.RoundedButton();
            pnDetailTopic = new CHEF.RoundedPanel1();
            pnTopic = new LOGIN.RoundedPanel();
            txtNameTopic = new LOGIN.RoundedTextBox();
            lblNameTopic = new Label();
            pnListTopic = new LOGIN.RoundedPanel();
            dgvListTopic = new CLASSROOM.RoundedDataGridView();
            ColNameTopic = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            pnAction = new CHEF.RoundedPanel1();
            pnSearch = new LOGIN.RoundedPanel();
            lblFilter = new Label();
            cmbFilter = new LOGIN.RoundedComboBox();
            txtSearch = new LOGIN.RoundedTextBox();
            lblSearch = new Label();
            pnButton.SuspendLayout();
            pnDetailTopic.SuspendLayout();
            pnTopic.SuspendLayout();
            pnListTopic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListTopic).BeginInit();
            pnAction.SuspendLayout();
            pnSearch.SuspendLayout();
            SuspendLayout();
            // 
            // pnButton
            // 
            pnButton.BorderRadius = 40;
            pnButton.Controls.Add(btnUpdate);
            pnButton.Controls.Add(btnCancel);
            pnButton.Controls.Add(btnAdd);
            pnButton.Location = new Point(20, 318);
            pnButton.Margin = new Padding(2);
            pnButton.Name = "pnButton";
            pnButton.Size = new Size(450, 80);
            pnButton.TabIndex = 0;
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
            // pnDetailTopic
            // 
            pnDetailTopic.BorderRadius = 40;
            pnDetailTopic.Controls.Add(pnTopic);
            pnDetailTopic.Controls.Add(pnButton);
            pnDetailTopic.Location = new Point(810, 50);
            pnDetailTopic.Margin = new Padding(2);
            pnDetailTopic.Name = "pnDetailTopic";
            pnDetailTopic.Size = new Size(490, 465);
            pnDetailTopic.TabIndex = 21;
            // 
            // pnTopic
            // 
            pnTopic.BorderRadius = 40;
            pnTopic.Controls.Add(txtNameTopic);
            pnTopic.Controls.Add(lblNameTopic);
            pnTopic.Location = new Point(65, 55);
            pnTopic.Margin = new Padding(2);
            pnTopic.Name = "pnTopic";
            pnTopic.Size = new Size(360, 151);
            pnTopic.TabIndex = 0;
            // 
            // txtNameTopic
            // 
            txtNameTopic.BackColor = Color.FromArgb(255, 227, 232);
            txtNameTopic.BackgroundColor = Color.FromArgb(255, 227, 232);
            txtNameTopic.BorderRadius = 15;
            txtNameTopic.BorderStyle = BorderStyle.None;
            txtNameTopic.Enabled = false;
            txtNameTopic.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNameTopic.Location = new Point(38, 85);
            txtNameTopic.Margin = new Padding(2);
            txtNameTopic.Multiline = true;
            txtNameTopic.Name = "txtNameTopic";
            txtNameTopic.Size = new Size(284, 36);
            txtNameTopic.TabIndex = 1;
            // 
            // lblNameTopic
            // 
            lblNameTopic.AutoSize = true;
            lblNameTopic.BackColor = Color.White;
            lblNameTopic.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNameTopic.ForeColor = Color.DarkRed;
            lblNameTopic.Location = new Point(38, 30);
            lblNameTopic.Margin = new Padding(2, 0, 2, 0);
            lblNameTopic.Name = "lblNameTopic";
            lblNameTopic.Size = new Size(115, 28);
            lblNameTopic.TabIndex = 1;
            lblNameTopic.Text = "Tên chủ đề";
            // 
            // pnListTopic
            // 
            pnListTopic.BorderRadius = 40;
            pnListTopic.Controls.Add(dgvListTopic);
            pnListTopic.Location = new Point(40, 254);
            pnListTopic.Margin = new Padding(2);
            pnListTopic.Name = "pnListTopic";
            pnListTopic.Size = new Size(712, 261);
            pnListTopic.TabIndex = 22;
            // 
            // dgvListTopic
            // 
            dgvListTopic.AllowUserToAddRows = false;
            dgvListTopic.AllowUserToDeleteRows = false;
            dgvListTopic.BackgroundColor = Color.FromArgb(255, 227, 232);
            dgvListTopic.BorderRadius = 40;
            dgvListTopic.BorderStyle = BorderStyle.None;
            dgvListTopic.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvListTopic.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.LightCoral;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListTopic.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListTopic.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListTopic.Columns.AddRange(new DataGridViewColumn[] { ColNameTopic, ID });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 227, 232);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvListTopic.DefaultCellStyle = dataGridViewCellStyle2;
            dgvListTopic.EnableHeadersVisualStyles = false;
            dgvListTopic.Location = new Point(58, 18);
            dgvListTopic.Margin = new Padding(2);
            dgvListTopic.Name = "dgvListTopic";
            dgvListTopic.ReadOnly = true;
            dgvListTopic.RowHeadersVisible = false;
            dgvListTopic.RowHeadersWidth = 62;
            dgvListTopic.Size = new Size(608, 225);
            dgvListTopic.TabIndex = 0;
            dgvListTopic.CellClick += dgvListTopic_CellClick;
            // 
            // ColNameTopic
            // 
            ColNameTopic.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColNameTopic.HeaderText = "Tên chủ đề";
            ColNameTopic.MinimumWidth = 8;
            ColNameTopic.Name = "ColNameTopic";
            ColNameTopic.ReadOnly = true;
            // 
            // ID
            // 
            ID.HeaderText = "Mã chủ đề";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            ID.Width = 125;
            // 
            // pnAction
            // 
            pnAction.BorderRadius = 40;
            pnAction.Controls.Add(pnSearch);
            pnAction.Location = new Point(40, 50);
            pnAction.Margin = new Padding(2);
            pnAction.Name = "pnAction";
            pnAction.Size = new Size(712, 205);
            pnAction.TabIndex = 29;
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
            // ListTopic
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(251, 236, 240);
            ClientSize = new Size(1338, 599);
            Controls.Add(pnAction);
            Controls.Add(pnListTopic);
            Controls.Add(pnDetailTopic);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "ListTopic";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách chủ đề";
            Load += ListTopic_Load;
            pnButton.ResumeLayout(false);
            pnDetailTopic.ResumeLayout(false);
            pnTopic.ResumeLayout(false);
            pnTopic.PerformLayout();
            pnListTopic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListTopic).EndInit();
            pnAction.ResumeLayout(false);
            pnSearch.ResumeLayout(false);
            pnSearch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private LOGIN.RoundedPanel pnButton;
        private CLASSROOM.RoundedButton btnUpdate;
        private CLASSROOM.RoundedButton btnCancel;
        private CLASSROOM.RoundedButton btnAdd;
        private CHEF.RoundedPanel1 pnDetailTopic;
        private LOGIN.RoundedPanel pnTopic;
        private LOGIN.RoundedTextBox txtNameTopic;
        private Label lblNameTopic;
        private LOGIN.RoundedPanel pnListTopic;
        private CLASSROOM.RoundedDataGridView dgvListTopic;
        private CHEF.RoundedPanel1 pnAction;
        private LOGIN.RoundedPanel pnSearch;
        private Label lblFilter;
        private LOGIN.RoundedComboBox cmbFilter;
        private LOGIN.RoundedTextBox txtSearch;
        private Label lblSearch;
        private DataGridViewTextBoxColumn ColNameTopic;
        private DataGridViewTextBoxColumn ID;
    }
}