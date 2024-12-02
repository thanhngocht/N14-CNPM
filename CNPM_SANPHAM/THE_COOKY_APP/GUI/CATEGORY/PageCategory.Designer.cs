namespace THE_COOKY_APP.GUI.CATEGORY
{
    partial class PageCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageCategory));
            btnClassroom = new Button();
            btnChef = new Button();
            btnLocation = new Button();
            btnAccount = new Button();
            btnTopic = new Button();
            btnStudent = new Button();
            SuspendLayout();
            // 
            // btnClassroom
            // 
            btnClassroom.BackColor = Color.LightCoral;
            btnClassroom.FlatAppearance.BorderColor = Color.DarkRed;
            btnClassroom.FlatAppearance.BorderSize = 0;
            btnClassroom.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClassroom.ForeColor = Color.White;
            btnClassroom.Image = Properties.Resources.icons8_classroom_50;
            btnClassroom.ImageAlign = ContentAlignment.MiddleLeft;
            btnClassroom.Location = new Point(175, 228);
            btnClassroom.Name = "btnClassroom";
            btnClassroom.Padding = new Padding(5, 0, 0, 0);
            btnClassroom.Size = new Size(195, 150);
            btnClassroom.TabIndex = 0;
            btnClassroom.Text = "LỚP HỌC  ";
            btnClassroom.TextAlign = ContentAlignment.MiddleRight;
            btnClassroom.UseVisualStyleBackColor = false;
            btnClassroom.Click += btnClassroom_Click;
            // 
            // btnChef
            // 
            btnChef.BackColor = Color.LightCoral;
            btnChef.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChef.ForeColor = Color.White;
            btnChef.Image = (Image)resources.GetObject("btnChef.Image");
            btnChef.ImageAlign = ContentAlignment.MiddleLeft;
            btnChef.Location = new Point(990, 228);
            btnChef.Name = "btnChef";
            btnChef.Padding = new Padding(5, 0, 0, 0);
            btnChef.Size = new Size(195, 150);
            btnChef.TabIndex = 1;
            btnChef.Text = "GIÁO VIÊN ";
            btnChef.TextAlign = ContentAlignment.MiddleRight;
            btnChef.UseVisualStyleBackColor = false;
            btnChef.Click += btnChef_Click;
            // 
            // btnLocation
            // 
            btnLocation.BackColor = Color.LightCoral;
            btnLocation.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLocation.ForeColor = Color.White;
            btnLocation.Image = (Image)resources.GetObject("btnLocation.Image");
            btnLocation.ImageAlign = ContentAlignment.MiddleLeft;
            btnLocation.Location = new Point(580, 568);
            btnLocation.Name = "btnLocation";
            btnLocation.Padding = new Padding(5, 0, 0, 0);
            btnLocation.Size = new Size(195, 150);
            btnLocation.TabIndex = 2;
            btnLocation.Text = "ĐỊA ĐIỂM  ";
            btnLocation.TextAlign = ContentAlignment.MiddleRight;
            btnLocation.UseVisualStyleBackColor = false;
            btnLocation.Click += btnLocation_Click;
            // 
            // btnAccount
            // 
            btnAccount.BackColor = Color.LightCoral;
            btnAccount.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAccount.ForeColor = Color.White;
            btnAccount.Image = (Image)resources.GetObject("btnAccount.Image");
            btnAccount.ImageAlign = ContentAlignment.MiddleLeft;
            btnAccount.Location = new Point(990, 568);
            btnAccount.Name = "btnAccount";
            btnAccount.Padding = new Padding(5, 0, 0, 0);
            btnAccount.Size = new Size(195, 150);
            btnAccount.TabIndex = 3;
            btnAccount.Text = "TÀI KHOẢN ";
            btnAccount.TextAlign = ContentAlignment.MiddleRight;
            btnAccount.UseVisualStyleBackColor = false;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnTopic
            // 
            btnTopic.BackColor = Color.LightCoral;
            btnTopic.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTopic.ForeColor = Color.White;
            btnTopic.Image = (Image)resources.GetObject("btnTopic.Image");
            btnTopic.ImageAlign = ContentAlignment.MiddleLeft;
            btnTopic.Location = new Point(175, 568);
            btnTopic.Name = "btnTopic";
            btnTopic.Padding = new Padding(5, 0, 0, 0);
            btnTopic.Size = new Size(195, 150);
            btnTopic.TabIndex = 4;
            btnTopic.Text = "CHỦ ĐỀ    ";
            btnTopic.TextAlign = ContentAlignment.MiddleRight;
            btnTopic.UseVisualStyleBackColor = false;
            btnTopic.Click += btnTopic_Click;
            // 
            // btnStudent
            // 
            btnStudent.BackColor = Color.LightCoral;
            btnStudent.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudent.ForeColor = Color.White;
            btnStudent.Image = Properties.Resources.icons8_graduation_cap_50;
            btnStudent.ImageAlign = ContentAlignment.MiddleLeft;
            btnStudent.Location = new Point(580, 228);
            btnStudent.Name = "btnStudent";
            btnStudent.Padding = new Padding(5, 0, 0, 0);
            btnStudent.Size = new Size(195, 150);
            btnStudent.TabIndex = 5;
            btnStudent.Text = "HỌC VIÊN  ";
            btnStudent.TextAlign = ContentAlignment.MiddleRight;
            btnStudent.UseVisualStyleBackColor = false;
            btnStudent.Click += btnStudent_Click;
            // 
            // PageCategory
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(251, 236, 240);
            Controls.Add(btnStudent);
            Controls.Add(btnTopic);
            Controls.Add(btnAccount);
            Controls.Add(btnLocation);
            Controls.Add(btnChef);
            Controls.Add(btnClassroom);
            Name = "PageCategory";
            Size = new Size(1360, 945);
            ResumeLayout(false);
        }

        #endregion

        private Button btnClassroom;
        private Button btnChef;
        private Button btnLocation;
        private Button btnAccount;
        private Button btnTopic;
        private Button btnStudent;
    }
}
