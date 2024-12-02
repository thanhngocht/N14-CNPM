namespace THE_COOKY_APP.GUI.CLASSROOM
{
    partial class AIDescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AIDescription));
            pnDescriptionHint = new CHEF.RoundedPanel1();
            pnDetailDescription = new LOGIN.RoundedPanel();
            txtDescription = new LOGIN.RoundedTextBox();
            lblDescription = new Label();
            lblDescriptionHint = new Label();
            btnAdd = new RoundedButton();
            btnAnotherHint = new RoundedButton();
            pnDescriptionHint.SuspendLayout();
            pnDetailDescription.SuspendLayout();
            SuspendLayout();
            // 
            // pnDescriptionHint
            // 
            pnDescriptionHint.BorderRadius = 40;
            pnDescriptionHint.Controls.Add(pnDetailDescription);
            pnDescriptionHint.Location = new Point(90, 85);
            pnDescriptionHint.Margin = new Padding(2);
            pnDescriptionHint.Name = "pnDescriptionHint";
            pnDescriptionHint.Size = new Size(600, 360);
            pnDescriptionHint.TabIndex = 0;
            // 
            // pnDetailDescription
            // 
            pnDetailDescription.BorderRadius = 40;
            pnDetailDescription.Controls.Add(txtDescription);
            pnDetailDescription.Controls.Add(lblDescription);
            pnDetailDescription.Location = new Point(50, 40);
            pnDetailDescription.Margin = new Padding(2);
            pnDetailDescription.Name = "pnDetailDescription";
            pnDetailDescription.Size = new Size(500, 280);
            pnDetailDescription.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.FromArgb(255, 227, 232);
            txtDescription.BackgroundColor = Color.White;
            txtDescription.BorderRadius = 15;
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Enabled = false;
            txtDescription.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(38, 85);
            txtDescription.Margin = new Padding(2);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(422, 160);
            txtDescription.TabIndex = 26;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.White;
            lblDescription.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDescription.ForeColor = Color.DarkRed;
            lblDescription.Location = new Point(38, 30);
            lblDescription.Margin = new Padding(2, 0, 2, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(68, 28);
            lblDescription.TabIndex = 25;
            lblDescription.Text = "Mô tả";
            // 
            // lblDescriptionHint
            // 
            lblDescriptionHint.AutoSize = true;
            lblDescriptionHint.BackColor = Color.FromArgb(251, 236, 240);
            lblDescriptionHint.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescriptionHint.ForeColor = Color.DarkRed;
            lblDescriptionHint.Location = new Point(302, 30);
            lblDescriptionHint.Margin = new Padding(2, 0, 2, 0);
            lblDescriptionHint.Name = "lblDescriptionHint";
            lblDescriptionHint.Size = new Size(193, 38);
            lblDescriptionHint.TabIndex = 24;
            lblDescriptionHint.Text = "GỢI Ý MÔ TẢ";
            // 
            // btnAdd
            // 
            btnAdd.BorderRadius = 40;
            btnAdd.ButtonColor = Color.DarkRed;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.Location = new Point(578, 475);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 39);
            btnAdd.TabIndex = 25;
            btnAdd.Text = "Thêm";
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnAnotherHint
            // 
            btnAnotherHint.BorderRadius = 40;
            btnAnotherHint.ButtonColor = Color.White;
            btnAnotherHint.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAnotherHint.Location = new Point(416, 475);
            btnAnotherHint.Margin = new Padding(2);
            btnAnotherHint.Name = "btnAnotherHint";
            btnAnotherHint.Size = new Size(112, 39);
            btnAnotherHint.TabIndex = 26;
            btnAnotherHint.Text = "Gợi ý khác";
            btnAnotherHint.TextColor = Color.DarkRed;
            btnAnotherHint.UseVisualStyleBackColor = true;
            btnAnotherHint.Click += btnAnotherHint_Click;
            // 
            // AIDescription
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(251, 236, 240);
            ClientSize = new Size(778, 544);
            Controls.Add(btnAnotherHint);
            Controls.Add(btnAdd);
            Controls.Add(lblDescriptionHint);
            Controls.Add(pnDescriptionHint);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "AIDescription";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gợi ý mô tả";
            pnDescriptionHint.ResumeLayout(false);
            pnDetailDescription.ResumeLayout(false);
            pnDetailDescription.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CHEF.RoundedPanel1 pnDescriptionHint;
        private LOGIN.RoundedPanel pnDetailDescription;
        private Label lblDescriptionHint;
        private Label lblDescription;
        private LOGIN.RoundedTextBox txtDescription;
        private RoundedButton btnAdd;
        private RoundedButton btnAnotherHint;
    }
}