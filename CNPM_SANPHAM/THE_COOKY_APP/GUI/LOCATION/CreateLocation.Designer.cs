namespace THE_COOKY_APP.GUI.LOCATION
{
    partial class CreateLocation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateLocation));
            btnAdd = new CLASSROOM.RoundedButton();
            pnFormAddLocation = new CHEF.RoundedPanel1();
            pnLocation = new LOGIN.RoundedPanel();
            txtDiscription = new LOGIN.RoundedTextBox();
            txtQuantity = new LOGIN.RoundedTextBox();
            txtAddress = new LOGIN.RoundedTextBox();
            txtNameLocation = new LOGIN.RoundedTextBox();
            lblDiscription = new Label();
            lblQuantity = new Label();
            lblAddress = new Label();
            lblNameLocation = new Label();
            lblLocation = new Label();
            pnFormAddLocation.SuspendLayout();
            pnLocation.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BorderRadius = 40;
            btnAdd.ButtonColor = Color.DarkRed;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(458, 708);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 39);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Thêm";
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // pnFormAddLocation
            // 
            pnFormAddLocation.BorderRadius = 40;
            pnFormAddLocation.Controls.Add(pnLocation);
            pnFormAddLocation.Controls.Add(lblLocation);
            pnFormAddLocation.Location = new Point(80, 50);
            pnFormAddLocation.Margin = new Padding(2);
            pnFormAddLocation.Name = "pnFormAddLocation";
            pnFormAddLocation.Size = new Size(490, 628);
            pnFormAddLocation.TabIndex = 0;
            // 
            // pnLocation
            // 
            pnLocation.BorderRadius = 40;
            pnLocation.Controls.Add(txtDiscription);
            pnLocation.Controls.Add(txtQuantity);
            pnLocation.Controls.Add(txtAddress);
            pnLocation.Controls.Add(txtNameLocation);
            pnLocation.Controls.Add(lblDiscription);
            pnLocation.Controls.Add(lblQuantity);
            pnLocation.Controls.Add(lblAddress);
            pnLocation.Controls.Add(lblNameLocation);
            pnLocation.Location = new Point(65, 90);
            pnLocation.Margin = new Padding(2);
            pnLocation.Name = "pnLocation";
            pnLocation.Size = new Size(360, 508);
            pnLocation.TabIndex = 2;
            // 
            // txtDiscription
            // 
            txtDiscription.BackColor = Color.FromArgb(255, 227, 232);
            txtDiscription.BackgroundColor = Color.FromArgb(255, 227, 232);
            txtDiscription.BorderRadius = 15;
            txtDiscription.BorderStyle = BorderStyle.None;
            txtDiscription.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDiscription.Location = new Point(38, 405);
            txtDiscription.Margin = new Padding(2);
            txtDiscription.Multiline = true;
            txtDiscription.Name = "txtDiscription";
            txtDiscription.Size = new Size(284, 72);
            txtDiscription.TabIndex = 4;
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = Color.FromArgb(255, 227, 232);
            txtQuantity.BackgroundColor = Color.FromArgb(255, 227, 232);
            txtQuantity.BorderRadius = 15;
            txtQuantity.BorderStyle = BorderStyle.None;
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
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.BackColor = Color.FromArgb(255, 227, 232);
            lblLocation.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocation.ForeColor = Color.DarkRed;
            lblLocation.Location = new Point(90, 30);
            lblLocation.Margin = new Padding(2, 0, 2, 0);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(310, 38);
            lblLocation.TabIndex = 1;
            lblLocation.Text = "THÔNG TIN ĐỊA ĐIỂM";
            // 
            // CreateLocation
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(251, 236, 240);
            ClientSize = new Size(648, 778);
            Controls.Add(pnFormAddLocation);
            Controls.Add(btnAdd);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "CreateLocation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tạo địa điểm ";
            pnFormAddLocation.ResumeLayout(false);
            pnFormAddLocation.PerformLayout();
            pnLocation.ResumeLayout(false);
            pnLocation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private CLASSROOM.RoundedButton btnAdd;
        private CHEF.RoundedPanel1 pnFormAddLocation;
        private Label lblLocation;
        private LOGIN.RoundedPanel pnLocation;
        private LOGIN.RoundedTextBox txtNameLocation;
        private Label lblDiscription;
        private Label lblQuantity;
        private Label lblAddress;
        private Label lblNameLocation;
        private LOGIN.RoundedTextBox txtDiscription;
        private LOGIN.RoundedTextBox txtQuantity;
        private LOGIN.RoundedTextBox txtAddress;
    }
}