namespace THE_COOKY_APP.GUI.REPORT
{
    partial class ReportMonth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportMonth));
            lblMonthStage = new Label();
            btnExport = new CLASSROOM.RoundedButton();
            pnMonthDetail = new CHEF.RoundedPanel1();
            cbMonth12 = new LOGIN.CustomCheckBox();
            cbMonth11 = new LOGIN.CustomCheckBox();
            cbMonth10 = new LOGIN.CustomCheckBox();
            cbMonth9 = new LOGIN.CustomCheckBox();
            cbMonth8 = new LOGIN.CustomCheckBox();
            cbMonth7 = new LOGIN.CustomCheckBox();
            cbMonth6 = new LOGIN.CustomCheckBox();
            cbMonth5 = new LOGIN.CustomCheckBox();
            cbMonth4 = new LOGIN.CustomCheckBox();
            pnAllMonth = new LOGIN.RoundedPanel();
            cbAllMonth = new LOGIN.CustomCheckBox();
            cbMonth3 = new LOGIN.CustomCheckBox();
            cbMonth1 = new LOGIN.CustomCheckBox();
            cbMonth2 = new LOGIN.CustomCheckBox();
            pnMonth = new LOGIN.RoundedPanel();
            cbMonth = new LOGIN.CustomCheckBox();
            cbLocation = new LOGIN.CustomCheckBox();
            pnMonthDetail.SuspendLayout();
            pnAllMonth.SuspendLayout();
            pnMonth.SuspendLayout();
            SuspendLayout();
            // 
            // lblMonthStage
            // 
            lblMonthStage.AutoSize = true;
            lblMonthStage.BackColor = Color.White;
            lblMonthStage.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMonthStage.ForeColor = Color.DarkRed;
            lblMonthStage.Location = new Point(314, 20);
            lblMonthStage.Margin = new Padding(2, 0, 2, 0);
            lblMonthStage.Name = "lblMonthStage";
            lblMonthStage.Size = new Size(216, 32);
            lblMonthStage.TabIndex = 26;
            lblMonthStage.Text = "CỘT MỐC THÁNG";
            // 
            // btnExport
            // 
            btnExport.BorderRadius = 40;
            btnExport.ButtonColor = Color.DarkRed;
            btnExport.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExport.Location = new Point(808, 502);
            btnExport.Margin = new Padding(2);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(112, 39);
            btnExport.TabIndex = 6;
            btnExport.Text = "Xuất file";
            btnExport.TextColor = Color.White;
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // pnMonthDetail
            // 
            pnMonthDetail.BorderRadius = 40;
            pnMonthDetail.Controls.Add(cbMonth12);
            pnMonthDetail.Controls.Add(cbMonth11);
            pnMonthDetail.Controls.Add(cbMonth10);
            pnMonthDetail.Controls.Add(cbMonth9);
            pnMonthDetail.Controls.Add(cbMonth8);
            pnMonthDetail.Controls.Add(cbMonth7);
            pnMonthDetail.Controls.Add(cbMonth6);
            pnMonthDetail.Controls.Add(cbMonth5);
            pnMonthDetail.Controls.Add(cbMonth4);
            pnMonthDetail.Controls.Add(pnAllMonth);
            pnMonthDetail.Controls.Add(cbMonth3);
            pnMonthDetail.Controls.Add(cbMonth1);
            pnMonthDetail.Controls.Add(cbMonth2);
            pnMonthDetail.Location = new Point(45, 75);
            pnMonthDetail.Margin = new Padding(2);
            pnMonthDetail.Name = "pnMonthDetail";
            pnMonthDetail.Size = new Size(782, 298);
            pnMonthDetail.TabIndex = 28;
            // 
            // cbMonth12
            // 
            cbMonth12.AutoSize = true;
            cbMonth12.BackColor = Color.FromArgb(255, 227, 232);
            cbMonth12.CheckBoxSize = 20;
            cbMonth12.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbMonth12.ForeColor = Color.Black;
            cbMonth12.Location = new Point(634, 215);
            cbMonth12.Margin = new Padding(2);
            cbMonth12.Name = "cbMonth12";
            cbMonth12.Size = new Size(101, 27);
            cbMonth12.TabIndex = 37;
            cbMonth12.Text = "Tháng 12";
            cbMonth12.UseVisualStyleBackColor = false;
            cbMonth12.CheckedChanged += MonthCheckBox_CheckedChanged;
            // 
            // cbMonth11
            // 
            cbMonth11.AutoSize = true;
            cbMonth11.BackColor = Color.FromArgb(255, 227, 232);
            cbMonth11.CheckBoxSize = 20;
            cbMonth11.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbMonth11.ForeColor = Color.Black;
            cbMonth11.Location = new Point(436, 215);
            cbMonth11.Margin = new Padding(2);
            cbMonth11.Name = "cbMonth11";
            cbMonth11.Size = new Size(99, 27);
            cbMonth11.TabIndex = 36;
            cbMonth11.Text = "Tháng 11";
            cbMonth11.UseVisualStyleBackColor = false;
            cbMonth11.CheckedChanged += MonthCheckBox_CheckedChanged;
            // 
            // cbMonth10
            // 
            cbMonth10.AutoSize = true;
            cbMonth10.BackColor = Color.FromArgb(255, 227, 232);
            cbMonth10.CheckBoxSize = 20;
            cbMonth10.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbMonth10.ForeColor = Color.Black;
            cbMonth10.Location = new Point(238, 215);
            cbMonth10.Margin = new Padding(2);
            cbMonth10.Name = "cbMonth10";
            cbMonth10.Size = new Size(101, 27);
            cbMonth10.TabIndex = 35;
            cbMonth10.Text = "Tháng 10";
            cbMonth10.UseVisualStyleBackColor = false;
            cbMonth10.CheckedChanged += MonthCheckBox_CheckedChanged;
            // 
            // cbMonth9
            // 
            cbMonth9.AutoSize = true;
            cbMonth9.BackColor = Color.FromArgb(255, 227, 232);
            cbMonth9.CheckBoxSize = 20;
            cbMonth9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbMonth9.ForeColor = Color.Black;
            cbMonth9.Location = new Point(40, 215);
            cbMonth9.Margin = new Padding(2);
            cbMonth9.Name = "cbMonth9";
            cbMonth9.Size = new Size(94, 27);
            cbMonth9.TabIndex = 34;
            cbMonth9.Text = "Tháng 9";
            cbMonth9.UseVisualStyleBackColor = false;
            cbMonth9.CheckedChanged += MonthCheckBox_CheckedChanged;
            // 
            // cbMonth8
            // 
            cbMonth8.AutoSize = true;
            cbMonth8.BackColor = Color.FromArgb(255, 227, 232);
            cbMonth8.CheckBoxSize = 20;
            cbMonth8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbMonth8.ForeColor = Color.Black;
            cbMonth8.Location = new Point(634, 155);
            cbMonth8.Margin = new Padding(2);
            cbMonth8.Name = "cbMonth8";
            cbMonth8.Size = new Size(94, 27);
            cbMonth8.TabIndex = 33;
            cbMonth8.Text = "Tháng 8";
            cbMonth8.UseVisualStyleBackColor = false;
            cbMonth8.CheckedChanged += MonthCheckBox_CheckedChanged;
            // 
            // cbMonth7
            // 
            cbMonth7.AutoSize = true;
            cbMonth7.BackColor = Color.FromArgb(255, 227, 232);
            cbMonth7.CheckBoxSize = 20;
            cbMonth7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbMonth7.ForeColor = Color.Black;
            cbMonth7.Location = new Point(436, 155);
            cbMonth7.Margin = new Padding(2);
            cbMonth7.Name = "cbMonth7";
            cbMonth7.Size = new Size(94, 27);
            cbMonth7.TabIndex = 32;
            cbMonth7.Text = "Tháng 7";
            cbMonth7.UseVisualStyleBackColor = false;
            cbMonth7.CheckedChanged += MonthCheckBox_CheckedChanged;
            // 
            // cbMonth6
            // 
            cbMonth6.AutoSize = true;
            cbMonth6.BackColor = Color.FromArgb(255, 227, 232);
            cbMonth6.CheckBoxSize = 20;
            cbMonth6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbMonth6.ForeColor = Color.Black;
            cbMonth6.Location = new Point(238, 155);
            cbMonth6.Margin = new Padding(2);
            cbMonth6.Name = "cbMonth6";
            cbMonth6.Size = new Size(94, 27);
            cbMonth6.TabIndex = 31;
            cbMonth6.Text = "Tháng 6";
            cbMonth6.UseVisualStyleBackColor = false;
            cbMonth6.CheckedChanged += MonthCheckBox_CheckedChanged;
            // 
            // cbMonth5
            // 
            cbMonth5.AutoSize = true;
            cbMonth5.BackColor = Color.FromArgb(255, 227, 232);
            cbMonth5.CheckBoxSize = 20;
            cbMonth5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbMonth5.ForeColor = Color.Black;
            cbMonth5.Location = new Point(40, 155);
            cbMonth5.Margin = new Padding(2);
            cbMonth5.Name = "cbMonth5";
            cbMonth5.Size = new Size(94, 27);
            cbMonth5.TabIndex = 30;
            cbMonth5.Text = "Tháng 5";
            cbMonth5.UseVisualStyleBackColor = false;
            cbMonth5.CheckedChanged += MonthCheckBox_CheckedChanged;
            // 
            // cbMonth4
            // 
            cbMonth4.AutoSize = true;
            cbMonth4.BackColor = Color.FromArgb(255, 227, 232);
            cbMonth4.CheckBoxSize = 20;
            cbMonth4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbMonth4.ForeColor = Color.Black;
            cbMonth4.Location = new Point(634, 95);
            cbMonth4.Margin = new Padding(2);
            cbMonth4.Name = "cbMonth4";
            cbMonth4.Size = new Size(95, 27);
            cbMonth4.TabIndex = 3;
            cbMonth4.Text = "Tháng 4";
            cbMonth4.UseVisualStyleBackColor = false;
            cbMonth4.CheckedChanged += MonthCheckBox_CheckedChanged;
            // 
            // pnAllMonth
            // 
            pnAllMonth.BorderRadius = 40;
            pnAllMonth.Controls.Add(cbAllMonth);
            pnAllMonth.Location = new Point(254, 26);
            pnAllMonth.Margin = new Padding(2);
            pnAllMonth.Name = "pnAllMonth";
            pnAllMonth.Size = new Size(300, 52);
            pnAllMonth.TabIndex = 0;
            // 
            // cbAllMonth
            // 
            cbAllMonth.AutoSize = true;
            cbAllMonth.BackColor = Color.White;
            cbAllMonth.CheckBoxSize = 20;
            cbAllMonth.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbAllMonth.ForeColor = Color.Black;
            cbAllMonth.Location = new Point(54, 10);
            cbAllMonth.Margin = new Padding(2);
            cbAllMonth.Name = "cbAllMonth";
            cbAllMonth.Size = new Size(162, 27);
            cbAllMonth.TabIndex = 3;
            cbAllMonth.Text = "Tất cả các tháng";
            cbAllMonth.UseVisualStyleBackColor = false;
            cbAllMonth.CheckedChanged += cbAllMonth_CheckedChanged;
            // 
            // cbMonth3
            // 
            cbMonth3.AutoSize = true;
            cbMonth3.BackColor = Color.FromArgb(255, 227, 232);
            cbMonth3.CheckBoxSize = 20;
            cbMonth3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbMonth3.ForeColor = Color.Black;
            cbMonth3.Location = new Point(436, 95);
            cbMonth3.Margin = new Padding(2);
            cbMonth3.Name = "cbMonth3";
            cbMonth3.Size = new Size(94, 27);
            cbMonth3.TabIndex = 2;
            cbMonth3.Text = "Tháng 3";
            cbMonth3.UseVisualStyleBackColor = false;
            cbMonth3.CheckedChanged += MonthCheckBox_CheckedChanged;
            // 
            // cbMonth1
            // 
            cbMonth1.AutoSize = true;
            cbMonth1.BackColor = Color.FromArgb(255, 227, 232);
            cbMonth1.CheckBoxSize = 20;
            cbMonth1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbMonth1.ForeColor = Color.Black;
            cbMonth1.Location = new Point(40, 95);
            cbMonth1.Margin = new Padding(2);
            cbMonth1.Name = "cbMonth1";
            cbMonth1.Size = new Size(92, 27);
            cbMonth1.TabIndex = 0;
            cbMonth1.Text = "Tháng 1";
            cbMonth1.UseVisualStyleBackColor = false;
            cbMonth1.CheckedChanged += MonthCheckBox_CheckedChanged;
            // 
            // cbMonth2
            // 
            cbMonth2.AutoSize = true;
            cbMonth2.BackColor = Color.FromArgb(255, 227, 232);
            cbMonth2.CheckBoxSize = 20;
            cbMonth2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbMonth2.ForeColor = Color.Black;
            cbMonth2.Location = new Point(238, 95);
            cbMonth2.Margin = new Padding(2);
            cbMonth2.Name = "cbMonth2";
            cbMonth2.Size = new Size(94, 27);
            cbMonth2.TabIndex = 1;
            cbMonth2.Text = "Tháng 2";
            cbMonth2.UseVisualStyleBackColor = false;
            cbMonth2.CheckedChanged += MonthCheckBox_CheckedChanged;
            // 
            // pnMonth
            // 
            pnMonth.BorderRadius = 40;
            pnMonth.Controls.Add(pnMonthDetail);
            pnMonth.Controls.Add(lblMonthStage);
            pnMonth.Location = new Point(50, 42);
            pnMonth.Margin = new Padding(2);
            pnMonth.Name = "pnMonth";
            pnMonth.Size = new Size(870, 434);
            pnMonth.TabIndex = 29;
            // 
            // cbMonth
            // 
            cbMonth.AutoSize = true;
            cbMonth.BackColor = Color.FromArgb(251, 236, 240);
            cbMonth.CheckBoxSize = 20;
            cbMonth.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbMonth.ForeColor = Color.Black;
            cbMonth.Location = new Point(288, 502);
            cbMonth.Margin = new Padding(2);
            cbMonth.Name = "cbMonth";
            cbMonth.Size = new Size(183, 27);
            cbMonth.TabIndex = 30;
            cbMonth.Text = "Báo cáo theo tháng";
            cbMonth.UseVisualStyleBackColor = false;
            // 
            // cbLocation
            // 
            cbLocation.AutoSize = true;
            cbLocation.BackColor = Color.FromArgb(251, 236, 240);
            cbLocation.CheckBoxSize = 20;
            cbLocation.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbLocation.ForeColor = Color.Black;
            cbLocation.Location = new Point(548, 502);
            cbLocation.Margin = new Padding(2);
            cbLocation.Name = "cbLocation";
            cbLocation.Size = new Size(204, 27);
            cbLocation.TabIndex = 31;
            cbLocation.Text = "Báo cáo theo địa điểm";
            cbLocation.UseVisualStyleBackColor = false;
            // 
            // ReportMonth
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(251, 236, 240);
            ClientSize = new Size(978, 571);
            Controls.Add(cbLocation);
            Controls.Add(cbMonth);
            Controls.Add(pnMonth);
            Controls.Add(btnExport);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "ReportMonth";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Báo cáo tháng";
            pnMonthDetail.ResumeLayout(false);
            pnMonthDetail.PerformLayout();
            pnAllMonth.ResumeLayout(false);
            pnAllMonth.PerformLayout();
            pnMonth.ResumeLayout(false);
            pnMonth.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblMonthStage;
        private CLASSROOM.RoundedButton btnExport;
        private CHEF.RoundedPanel1 pnMonthDetail;
        private LOGIN.RoundedPanel pnAllMonth;
        private LOGIN.CustomCheckBox cbAllMonth;
        private LOGIN.CustomCheckBox cbMonth3;
        private LOGIN.CustomCheckBox cbMonth1;
        private LOGIN.CustomCheckBox cbMonth2;
        private LOGIN.RoundedPanel pnMonth;
        private LOGIN.CustomCheckBox cbMonth12;
        private LOGIN.CustomCheckBox cbMonth11;
        private LOGIN.CustomCheckBox cbMonth10;
        private LOGIN.CustomCheckBox cbMonth9;
        private LOGIN.CustomCheckBox cbMonth8;
        private LOGIN.CustomCheckBox cbMonth7;
        private LOGIN.CustomCheckBox cbMonth6;
        private LOGIN.CustomCheckBox cbMonth5;
        private LOGIN.CustomCheckBox cbMonth4;
        private LOGIN.CustomCheckBox cbMonth;
        private LOGIN.CustomCheckBox cbLocation;
    }
}