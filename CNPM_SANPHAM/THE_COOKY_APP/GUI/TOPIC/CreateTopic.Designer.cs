namespace THE_COOKY_APP.GUI.TOPIC
{
    partial class CreateTopic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTopic));
            btnAdd = new CLASSROOM.RoundedButton();
            pnTopicInformation = new CHEF.RoundedPanel1();
            pnTopic = new LOGIN.RoundedPanel();
            txtNameTopic = new LOGIN.RoundedTextBox();
            lblNameTopic = new Label();
            lblTopic = new Label();
            pnTopicInformation.SuspendLayout();
            pnTopic.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BorderRadius = 40;
            btnAdd.ButtonColor = Color.DarkRed;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.Location = new Point(458, 354);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 39);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Thêm";
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // pnTopicInformation
            // 
            pnTopicInformation.BorderRadius = 40;
            pnTopicInformation.Controls.Add(pnTopic);
            pnTopicInformation.Controls.Add(lblTopic);
            pnTopicInformation.Location = new Point(80, 50);
            pnTopicInformation.Name = "pnTopicInformation";
            pnTopicInformation.Size = new Size(490, 271);
            pnTopicInformation.TabIndex = 20;
            // 
            // pnTopic
            // 
            pnTopic.BorderRadius = 40;
            pnTopic.Controls.Add(txtNameTopic);
            pnTopic.Controls.Add(lblNameTopic);
            pnTopic.Location = new Point(65, 90);
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
            txtNameTopic.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNameTopic.Location = new Point(38, 85);
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
            lblNameTopic.Name = "lblNameTopic";
            lblNameTopic.Size = new Size(115, 28);
            lblNameTopic.TabIndex = 1;
            lblNameTopic.Text = "Tên chủ đề";
            // 
            // lblTopic
            // 
            lblTopic.AutoSize = true;
            lblTopic.BackColor = Color.FromArgb(255, 227, 232);
            lblTopic.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTopic.ForeColor = Color.DarkRed;
            lblTopic.Location = new Point(104, 30);
            lblTopic.Name = "lblTopic";
            lblTopic.Size = new Size(282, 38);
            lblTopic.TabIndex = 2;
            lblTopic.Text = "THÔNG TIN CHỦ ĐỀ";
            // 
            // CreateTopic
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(251, 236, 240);
            ClientSize = new Size(648, 434);
            Controls.Add(pnTopicInformation);
            Controls.Add(btnAdd);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreateTopic";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tạo chủ đề";
            pnTopicInformation.ResumeLayout(false);
            pnTopicInformation.PerformLayout();
            pnTopic.ResumeLayout(false);
            pnTopic.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CLASSROOM.RoundedButton btnAdd;
        private CHEF.RoundedPanel1 pnTopicInformation;
        private Label lblTopic;
        private LOGIN.RoundedPanel pnTopic;
        private LOGIN.RoundedTextBox txtNameTopic;
        private Label lblNameTopic;
    }
}