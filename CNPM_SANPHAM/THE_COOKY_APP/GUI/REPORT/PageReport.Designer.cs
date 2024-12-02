namespace THE_COOKY_APP.GUI.REPORT
{
    partial class PageReport
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnReportClassroom = new Button();
            btnReportMonth = new Button();
            SuspendLayout();
            // 
            // btnReportClassroom
            // 
            btnReportClassroom.BackColor = Color.LightCoral;
            btnReportClassroom.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportClassroom.ForeColor = Color.White;
            btnReportClassroom.Image = Properties.Resources.icons8_classroom_50;
            btnReportClassroom.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportClassroom.Location = new Point(841, 397);
            btnReportClassroom.Margin = new Padding(2);
            btnReportClassroom.Name = "btnReportClassroom";
            btnReportClassroom.Padding = new Padding(5, 0, 0, 0);
            btnReportClassroom.Size = new Size(195, 150);
            btnReportClassroom.TabIndex = 7;
            btnReportClassroom.Text = "LỚP HỌC  ";
            btnReportClassroom.TextAlign = ContentAlignment.MiddleRight;
            btnReportClassroom.UseVisualStyleBackColor = false;
            btnReportClassroom.Click += btnReportClassroom_Click;
            // 
            // btnReportMonth
            // 
            btnReportMonth.BackColor = Color.LightCoral;
            btnReportMonth.FlatAppearance.BorderColor = Color.DarkRed;
            btnReportMonth.FlatAppearance.BorderSize = 0;
            btnReportMonth.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportMonth.ForeColor = Color.White;
            btnReportMonth.Image = Properties.Resources.icons8_calendar_50;
            btnReportMonth.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportMonth.Location = new Point(323, 397);
            btnReportMonth.Name = "btnReportMonth";
            btnReportMonth.Padding = new Padding(5, 0, 0, 0);
            btnReportMonth.Size = new Size(195, 150);
            btnReportMonth.TabIndex = 6;
            btnReportMonth.Text = "TỔNG HỢP";
            btnReportMonth.TextAlign = ContentAlignment.MiddleRight;
            btnReportMonth.UseVisualStyleBackColor = false;
            btnReportMonth.Click += btnReportMonth_Click;
            // 
            // PageReport
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(251, 236, 240);
            Controls.Add(btnReportClassroom);
            Controls.Add(btnReportMonth);
            Margin = new Padding(2);
            Name = "PageReport";
            Size = new Size(1360, 945);
            ResumeLayout(false);
        }

        #endregion
        private Button btnReportClassroom;
        private Button btnReportMonth;
    }
}
