namespace THE_COOKY_APP.GUI.CLASSROOM
{
    partial class ListClassroom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListClassroom));
            pnAction = new CHEF.RoundedPanel1();
            pnButton = new LOGIN.RoundedPanel();
            btnAdd = new RoundedButton();
            pnSearch = new LOGIN.RoundedPanel();
            lblFilter = new Label();
            cmbFilter = new LOGIN.RoundedComboBox();
            txtSearch = new LOGIN.RoundedTextBox();
            lblSearch = new Label();
            pnListClassroom = new LOGIN.RoundedPanel();
            dgvListClassroom = new RoundedDataGridView();
            ColNameClass = new DataGridViewTextBoxColumn();
            ColChef = new DataGridViewTextBoxColumn();
            ColFee = new DataGridViewTextBoxColumn();
            ColLocation = new DataGridViewTextBoxColumn();
            ColQuantity = new DataGridViewTextBoxColumn();
            ColQuantityDate = new DataGridViewTextBoxColumn();
            colIdClass = new DataGridViewTextBoxColumn();
            pnAction.SuspendLayout();
            pnButton.SuspendLayout();
            pnSearch.SuspendLayout();
            pnListClassroom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListClassroom).BeginInit();
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
            pnAction.TabIndex = 26;
            // 
            // pnButton
            // 
            pnButton.BorderRadius = 40;
            pnButton.Controls.Add(btnAdd);
            pnButton.Location = new Point(1018, 53);
            pnButton.Margin = new Padding(2);
            pnButton.Name = "pnButton";
            pnButton.Size = new Size(192, 99);
            pnButton.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BorderRadius = 40;
            btnAdd.ButtonColor = Color.DarkRed;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.Location = new Point(40, 30);
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
            // pnListClassroom
            // 
            pnListClassroom.BorderRadius = 40;
            pnListClassroom.Controls.Add(dgvListClassroom);
            pnListClassroom.Location = new Point(40, 248);
            pnListClassroom.Margin = new Padding(2);
            pnListClassroom.Name = "pnListClassroom";
            pnListClassroom.Size = new Size(1260, 480);
            pnListClassroom.TabIndex = 28;
            // 
            // dgvListClassroom
            // 
            dgvListClassroom.AllowUserToAddRows = false;
            dgvListClassroom.AllowUserToDeleteRows = false;
            dgvListClassroom.BackgroundColor = Color.FromArgb(255, 227, 232);
            dgvListClassroom.BorderRadius = 40;
            dgvListClassroom.BorderStyle = BorderStyle.None;
            dgvListClassroom.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvListClassroom.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.LightCoral;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListClassroom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListClassroom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListClassroom.Columns.AddRange(new DataGridViewColumn[] { ColNameClass, ColChef, ColFee, ColLocation, ColQuantity, ColQuantityDate, colIdClass });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 227, 232);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvListClassroom.DefaultCellStyle = dataGridViewCellStyle2;
            dgvListClassroom.EnableHeadersVisualStyles = false;
            dgvListClassroom.Location = new Point(50, 35);
            dgvListClassroom.Margin = new Padding(2);
            dgvListClassroom.Name = "dgvListClassroom";
            dgvListClassroom.ReadOnly = true;
            dgvListClassroom.RowHeadersVisible = false;
            dgvListClassroom.RowHeadersWidth = 62;
            dgvListClassroom.Size = new Size(1160, 410);
            dgvListClassroom.TabIndex = 1;
            dgvListClassroom.CellClick += dgvListClassroom_CellClick;
            dgvListClassroom.CellDoubleClick += dgvListClassroom_CellDoubleClick;
            // 
            // ColNameClass
            // 
            ColNameClass.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColNameClass.HeaderText = "Lớp học";
            ColNameClass.MinimumWidth = 8;
            ColNameClass.Name = "ColNameClass";
            ColNameClass.ReadOnly = true;
            // 
            // ColChef
            // 
            ColChef.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColChef.HeaderText = "Giáo viên";
            ColChef.MinimumWidth = 8;
            ColChef.Name = "ColChef";
            ColChef.ReadOnly = true;
            // 
            // ColFee
            // 
            ColFee.HeaderText = "Chi phí";
            ColFee.MinimumWidth = 8;
            ColFee.Name = "ColFee";
            ColFee.ReadOnly = true;
            ColFee.Visible = false;
            ColFee.Width = 155;
            // 
            // ColLocation
            // 
            ColLocation.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColLocation.HeaderText = "Địa điểm";
            ColLocation.MinimumWidth = 8;
            ColLocation.Name = "ColLocation";
            ColLocation.ReadOnly = true;
            // 
            // ColQuantity
            // 
            ColQuantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColQuantity.HeaderText = "Số lượng";
            ColQuantity.MinimumWidth = 8;
            ColQuantity.Name = "ColQuantity";
            ColQuantity.ReadOnly = true;
            // 
            // ColQuantityDate
            // 
            ColQuantityDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColQuantityDate.HeaderText = "Số ngày";
            ColQuantityDate.MinimumWidth = 8;
            ColQuantityDate.Name = "ColQuantityDate";
            ColQuantityDate.ReadOnly = true;
            // 
            // colIdClass
            // 
            colIdClass.HeaderText = "Mã lớp học";
            colIdClass.MinimumWidth = 8;
            colIdClass.Name = "colIdClass";
            colIdClass.ReadOnly = true;
            colIdClass.Visible = false;
            colIdClass.Width = 150;
            // 
            // ListClassroom
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            BackColor = Color.FromArgb(251, 236, 240);
            ClientSize = new Size(1338, 764);
            Controls.Add(pnListClassroom);
            Controls.Add(pnAction);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "ListClassroom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Danh sách lớp học";
            Load += ListClassroom_Load;
            pnAction.ResumeLayout(false);
            pnButton.ResumeLayout(false);
            pnSearch.ResumeLayout(false);
            pnSearch.PerformLayout();
            pnListClassroom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListClassroom).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CHEF.RoundedPanel1 pnAction;
        private LOGIN.RoundedPanel pnButton;
        private RoundedButton btnAdd;
        private LOGIN.RoundedPanel pnSearch;
        private Label lblFilter;
        private LOGIN.RoundedComboBox cmbFilter;
        private LOGIN.RoundedTextBox txtSearch;
        private Label lblSearch;
        private LOGIN.RoundedPanel pnListClassroom;
        private RoundedDataGridView dgvListClassroom;
        private DataGridViewTextBoxColumn ColNameClass;
        private DataGridViewTextBoxColumn ColChef;
        private DataGridViewTextBoxColumn ColFee;
        private DataGridViewTextBoxColumn ColLocation;
        private DataGridViewTextBoxColumn ColQuantity;
        private DataGridViewTextBoxColumn ColQuantityDate;
        private DataGridViewTextBoxColumn colIdClass;
    }
}