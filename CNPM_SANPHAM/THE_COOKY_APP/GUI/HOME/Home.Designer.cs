namespace THE_COOKY_APP.GUI.HOME
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            panel1 = new Panel();
            pSide = new Panel();
            lblLine = new Label();
            btnReport = new Button();
            pnUsername = new LOGIN.RoundedPanel();
            lblUsername = new Label();
            btnLogOut = new Button();
            btnTimeTable = new Button();
            roundedPanel1 = new LOGIN.RoundedPanel();
            lblLogo = new Label();
            rpbLogo = new LOGIN.RoundedPictureBox();
            btnCategory = new Button();
            btnProfile = new Button();
            panelContainer = new Panel();
            panel1.SuspendLayout();
            pnUsername.SuspendLayout();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rpbLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(251, 236, 240);
            panel1.Controls.Add(pSide);
            panel1.Controls.Add(lblLine);
            panel1.Controls.Add(btnReport);
            panel1.Controls.Add(pnUsername);
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(btnTimeTable);
            panel1.Controls.Add(roundedPanel1);
            panel1.Controls.Add(btnCategory);
            panel1.Controls.Add(btnProfile);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(290, 945);
            panel1.TabIndex = 0;
            // 
            // pSide
            // 
            pSide.BackColor = Color.DarkRed;
            pSide.Location = new Point(0, 158);
            pSide.Margin = new Padding(2);
            pSide.Name = "pSide";
            pSide.Size = new Size(15, 80);
            pSide.TabIndex = 7;
            // 
            // lblLine
            // 
            lblLine.BackColor = Color.DarkRed;
            lblLine.Location = new Point(2, 682);
            lblLine.Margin = new Padding(2, 0, 2, 0);
            lblLine.Name = "lblLine";
            lblLine.Size = new Size(289, 2);
            lblLine.TabIndex = 9;
            // 
            // btnReport
            // 
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReport.ForeColor = Color.DarkRed;
            btnReport.Image = Properties.Resources.icons8_report_50;
            btnReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnReport.Location = new Point(0, 398);
            btnReport.Margin = new Padding(2);
            btnReport.Name = "btnReport";
            btnReport.Padding = new Padding(30, 0, 60, 0);
            btnReport.Size = new Size(290, 80);
            btnReport.TabIndex = 1;
            btnReport.Text = "BÁO CÁO";
            btnReport.TextAlign = ContentAlignment.MiddleRight;
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // pnUsername
            // 
            pnUsername.BorderRadius = 40;
            pnUsername.Controls.Add(lblUsername);
            pnUsername.Location = new Point(30, 738);
            pnUsername.Margin = new Padding(2);
            pnUsername.Name = "pnUsername";
            pnUsername.Size = new Size(230, 55);
            pnUsername.TabIndex = 3;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.White;
            lblUsername.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = SystemColors.WindowText;
            lblUsername.Location = new Point(35, 12);
            lblUsername.Margin = new Padding(2, 0, 2, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(161, 30);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Nguyễn Văn A";
            // 
            // btnLogOut
            // 
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = Color.DarkRed;
            btnLogOut.Image = (Image)resources.GetObject("btnLogOut.Image");
            btnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogOut.Location = new Point(0, 835);
            btnLogOut.Margin = new Padding(2);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Padding = new Padding(30, 0, 30, 0);
            btnLogOut.Size = new Size(290, 80);
            btnLogOut.TabIndex = 10;
            btnLogOut.Text = "ĐĂNG XUẤT";
            btnLogOut.TextAlign = ContentAlignment.MiddleRight;
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnTimeTable
            // 
            btnTimeTable.FlatAppearance.BorderSize = 0;
            btnTimeTable.FlatStyle = FlatStyle.Flat;
            btnTimeTable.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimeTable.ForeColor = Color.DarkRed;
            btnTimeTable.Image = Properties.Resources.icons8_timetable_50;
            btnTimeTable.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimeTable.Location = new Point(0, 158);
            btnTimeTable.Margin = new Padding(2);
            btnTimeTable.Name = "btnTimeTable";
            btnTimeTable.Padding = new Padding(30, 0, 65, 0);
            btnTimeTable.Size = new Size(290, 80);
            btnTimeTable.TabIndex = 9;
            btnTimeTable.Text = "LỚP HỌC";
            btnTimeTable.TextAlign = ContentAlignment.MiddleRight;
            btnTimeTable.UseVisualStyleBackColor = true;
            btnTimeTable.Click += btnTimeTable_Click;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BorderRadius = 25;
            roundedPanel1.Controls.Add(lblLogo);
            roundedPanel1.Controls.Add(rpbLogo);
            roundedPanel1.Location = new Point(20, 30);
            roundedPanel1.Margin = new Padding(2);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(250, 95);
            roundedPanel1.TabIndex = 2;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.BackColor = Color.White;
            lblLogo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblLogo.ForeColor = Color.DarkRed;
            lblLogo.Location = new Point(96, 29);
            lblLogo.Margin = new Padding(2, 0, 2, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(148, 32);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "THE COOKY";
            // 
            // rpbLogo
            // 
            rpbLogo.BackgroundImage = Properties.Resources.logo;
            rpbLogo.BackgroundImageLayout = ImageLayout.Stretch;
            rpbLogo.BorderRadius = 40;
            rpbLogo.Location = new Point(15, 10);
            rpbLogo.Margin = new Padding(2);
            rpbLogo.Name = "rpbLogo";
            rpbLogo.Size = new Size(75, 75);
            rpbLogo.TabIndex = 0;
            rpbLogo.TabStop = false;
            // 
            // btnCategory
            // 
            btnCategory.FlatAppearance.BorderSize = 0;
            btnCategory.FlatStyle = FlatStyle.Flat;
            btnCategory.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCategory.ForeColor = Color.DarkRed;
            btnCategory.Image = (Image)resources.GetObject("btnCategory.Image");
            btnCategory.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategory.Location = new Point(0, 278);
            btnCategory.Margin = new Padding(2);
            btnCategory.Name = "btnCategory";
            btnCategory.Padding = new Padding(30, 0, 65, 0);
            btnCategory.Size = new Size(290, 80);
            btnCategory.TabIndex = 2;
            btnCategory.Text = "PHỤ LỤC";
            btnCategory.TextAlign = ContentAlignment.MiddleRight;
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += btnCategory_Click;
            // 
            // btnProfile
            // 
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfile.ForeColor = Color.DarkRed;
            btnProfile.Image = Properties.Resources.icons8_male_user_50;
            btnProfile.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfile.Location = new Point(0, 518);
            btnProfile.Margin = new Padding(2);
            btnProfile.Name = "btnProfile";
            btnProfile.Padding = new Padding(30, 0, 90, 0);
            btnProfile.Size = new Size(290, 80);
            btnProfile.TabIndex = 3;
            btnProfile.Text = "HỒ SƠ";
            btnProfile.TextAlign = ContentAlignment.MiddleRight;
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.FromArgb(251, 236, 240);
            panelContainer.Location = new Point(368, 0);
            panelContainer.Margin = new Padding(2);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1360, 945);
            panelContainer.TabIndex = 1;
            // 
            // Home
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1728, 944);
            Controls.Add(panelContainer);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang trung tâm";
            FormClosing += Home_FormClosing;
            panel1.ResumeLayout(false);
            pnUsername.ResumeLayout(false);
            pnUsername.PerformLayout();
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)rpbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblLogo;
        private Button btnReport;
        private Button btnTimeTable;
        private Button btnCategory;
        private Panel pSide;
        private LOGIN.RoundedPictureBox rpbLogo;
        private LOGIN.RoundedPanel roundedPanel1;
        private Panel panelContainer;
        private Label lblUsername;
        private Button btnLogOut;
        private Label lblLine;
        private LOGIN.RoundedPanel pnUsername;
        private Button btnProfile;
        private CATEGORY.PageCategory pageCategory;
        private REPORT.PageReport pageReport;
        private PROFILE.Profile profile;
        private TIMELINE.ListClassroomView pageTimeLine;
    }
}