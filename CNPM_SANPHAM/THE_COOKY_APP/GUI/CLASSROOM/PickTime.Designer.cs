namespace THE_COOKY_APP.GUI.CLASSROOM
{
    partial class PickTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PickTime));
            pnAddFormExtraInformation = new CHEF.RoundedPanel1();
            lblExtra = new Label();
            pnExtra = new LOGIN.RoundedPanel();
            txtFee = new LOGIN.RoundedTextBox();
            lblFee = new Label();
            txtNote = new LOGIN.RoundedTextBox();
            txtAnotherCost = new LOGIN.RoundedTextBox();
            lblNote = new Label();
            lblAnotherCost = new Label();
            txtFreelancerCost = new LOGIN.RoundedTextBox();
            txtMaterialCost = new LOGIN.RoundedTextBox();
            lblFreelancerCost = new Label();
            lblMaterialCost = new Label();
            dtpOrganizationDay = new CHEF.RoundedDateTimePicker();
            lblOrganizationDay = new Label();
            lblEndHour = new Label();
            lblStartHour = new Label();
            ttbEndHour = new TimeTextBox();
            ttbStartHour = new TimeTextBox();
            btnAdd = new RoundedButton();
            pnAddFormExtraInformation.SuspendLayout();
            pnExtra.SuspendLayout();
            SuspendLayout();
            // 
            // pnAddFormExtraInformation
            // 
            pnAddFormExtraInformation.BorderRadius = 40;
            pnAddFormExtraInformation.Controls.Add(lblExtra);
            pnAddFormExtraInformation.Controls.Add(pnExtra);
            pnAddFormExtraInformation.Location = new Point(65, 50);
            pnAddFormExtraInformation.Margin = new Padding(2);
            pnAddFormExtraInformation.Name = "pnAddFormExtraInformation";
            pnAddFormExtraInformation.Size = new Size(850, 609);
            pnAddFormExtraInformation.TabIndex = 0;
            // 
            // lblExtra
            // 
            lblExtra.AutoSize = true;
            lblExtra.BackColor = Color.FromArgb(255, 227, 232);
            lblExtra.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExtra.ForeColor = Color.DarkRed;
            lblExtra.Location = new Point(264, 30);
            lblExtra.Margin = new Padding(2, 0, 2, 0);
            lblExtra.Name = "lblExtra";
            lblExtra.Size = new Size(321, 38);
            lblExtra.TabIndex = 0;
            lblExtra.Text = "THÔNG TIN ĐÍNH KÈM";
            // 
            // pnExtra
            // 
            pnExtra.BorderRadius = 40;
            pnExtra.Controls.Add(txtFee);
            pnExtra.Controls.Add(lblFee);
            pnExtra.Controls.Add(txtNote);
            pnExtra.Controls.Add(txtAnotherCost);
            pnExtra.Controls.Add(lblNote);
            pnExtra.Controls.Add(lblAnotherCost);
            pnExtra.Controls.Add(txtFreelancerCost);
            pnExtra.Controls.Add(txtMaterialCost);
            pnExtra.Controls.Add(lblFreelancerCost);
            pnExtra.Controls.Add(lblMaterialCost);
            pnExtra.Controls.Add(dtpOrganizationDay);
            pnExtra.Controls.Add(lblOrganizationDay);
            pnExtra.Controls.Add(lblEndHour);
            pnExtra.Controls.Add(lblStartHour);
            pnExtra.Controls.Add(ttbEndHour);
            pnExtra.Controls.Add(ttbStartHour);
            pnExtra.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnExtra.Location = new Point(50, 90);
            pnExtra.Margin = new Padding(2);
            pnExtra.Name = "pnExtra";
            pnExtra.Size = new Size(750, 481);
            pnExtra.TabIndex = 0;
            // 
            // txtFee
            // 
            txtFee.BackColor = Color.FromArgb(255, 227, 232);
            txtFee.BackgroundColor = Color.White;
            txtFee.BorderRadius = 15;
            txtFee.BorderStyle = BorderStyle.None;
            txtFee.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFee.Location = new Point(432, 85);
            txtFee.Margin = new Padding(2);
            txtFee.Multiline = true;
            txtFee.Name = "txtFee";
            txtFee.Size = new Size(284, 36);
            txtFee.TabIndex = 2;
            txtFee.TextChanged += txtFee_TextChanged;
            txtFee.KeyPress += txtFee_KeyPress;
            // 
            // lblFee
            // 
            lblFee.AutoSize = true;
            lblFee.BackColor = Color.White;
            lblFee.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFee.ForeColor = Color.DarkRed;
            lblFee.Location = new Point(432, 30);
            lblFee.Margin = new Padding(2, 0, 2, 0);
            lblFee.Name = "lblFee";
            lblFee.Size = new Size(94, 28);
            lblFee.TabIndex = 23;
            lblFee.Text = "*Học phí";
            // 
            // txtNote
            // 
            txtNote.BackColor = Color.FromArgb(255, 227, 232);
            txtNote.BackgroundColor = Color.White;
            txtNote.BorderRadius = 15;
            txtNote.BorderStyle = BorderStyle.None;
            txtNote.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNote.Location = new Point(432, 415);
            txtNote.Margin = new Padding(2);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(284, 36);
            txtNote.TabIndex = 8;
            // 
            // txtAnotherCost
            // 
            txtAnotherCost.BackColor = Color.FromArgb(255, 227, 232);
            txtAnotherCost.BackgroundColor = Color.White;
            txtAnotherCost.BorderRadius = 15;
            txtAnotherCost.BorderStyle = BorderStyle.None;
            txtAnotherCost.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAnotherCost.Location = new Point(38, 415);
            txtAnotherCost.Margin = new Padding(2);
            txtAnotherCost.Multiline = true;
            txtAnotherCost.Name = "txtAnotherCost";
            txtAnotherCost.Size = new Size(284, 36);
            txtAnotherCost.TabIndex = 7;
            txtAnotherCost.TextChanged += txtAnotherCost_TextChanged;
            txtAnotherCost.KeyPress += txtAnotherCost_KeyPress;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.BackColor = Color.White;
            lblNote.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNote.ForeColor = Color.DarkRed;
            lblNote.Location = new Point(432, 360);
            lblNote.Margin = new Padding(2, 0, 2, 0);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(84, 28);
            lblNote.TabIndex = 20;
            lblNote.Text = "Ghi chú";
            // 
            // lblAnotherCost
            // 
            lblAnotherCost.AutoSize = true;
            lblAnotherCost.BackColor = Color.White;
            lblAnotherCost.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAnotherCost.ForeColor = Color.DarkRed;
            lblAnotherCost.Location = new Point(38, 360);
            lblAnotherCost.Margin = new Padding(2, 0, 2, 0);
            lblAnotherCost.Name = "lblAnotherCost";
            lblAnotherCost.Size = new Size(128, 28);
            lblAnotherCost.TabIndex = 19;
            lblAnotherCost.Text = "Chi phí khác";
            // 
            // txtFreelancerCost
            // 
            txtFreelancerCost.BackColor = Color.FromArgb(255, 227, 232);
            txtFreelancerCost.BackgroundColor = Color.White;
            txtFreelancerCost.BorderRadius = 15;
            txtFreelancerCost.BorderStyle = BorderStyle.None;
            txtFreelancerCost.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFreelancerCost.Location = new Point(38, 305);
            txtFreelancerCost.Margin = new Padding(2);
            txtFreelancerCost.Multiline = true;
            txtFreelancerCost.Name = "txtFreelancerCost";
            txtFreelancerCost.Size = new Size(284, 36);
            txtFreelancerCost.TabIndex = 5;
            txtFreelancerCost.TextChanged += txtFreelancerCost_TextChanged;
            txtFreelancerCost.KeyPress += txtFreelancerCost_KeyPress;
            // 
            // txtMaterialCost
            // 
            txtMaterialCost.BackColor = Color.FromArgb(255, 227, 232);
            txtMaterialCost.BackgroundColor = Color.White;
            txtMaterialCost.BorderRadius = 15;
            txtMaterialCost.BorderStyle = BorderStyle.None;
            txtMaterialCost.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMaterialCost.Location = new Point(432, 305);
            txtMaterialCost.Margin = new Padding(2);
            txtMaterialCost.Multiline = true;
            txtMaterialCost.Name = "txtMaterialCost";
            txtMaterialCost.Size = new Size(284, 36);
            txtMaterialCost.TabIndex = 6;
            txtMaterialCost.TextChanged += txtMaterialCost_TextChanged;
            txtMaterialCost.KeyPress += txtMaterialCost_KeyPress;
            // 
            // lblFreelancerCost
            // 
            lblFreelancerCost.AutoSize = true;
            lblFreelancerCost.BackColor = Color.White;
            lblFreelancerCost.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFreelancerCost.ForeColor = Color.DarkRed;
            lblFreelancerCost.Location = new Point(38, 250);
            lblFreelancerCost.Margin = new Padding(2, 0, 2, 0);
            lblFreelancerCost.Name = "lblFreelancerCost";
            lblFreelancerCost.Size = new Size(155, 28);
            lblFreelancerCost.TabIndex = 19;
            lblFreelancerCost.Text = "Freelancer cost";
            // 
            // lblMaterialCost
            // 
            lblMaterialCost.AutoSize = true;
            lblMaterialCost.BackColor = Color.White;
            lblMaterialCost.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaterialCost.ForeColor = Color.DarkRed;
            lblMaterialCost.Location = new Point(432, 250);
            lblMaterialCost.Margin = new Padding(2, 0, 2, 0);
            lblMaterialCost.Name = "lblMaterialCost";
            lblMaterialCost.Size = new Size(170, 28);
            lblMaterialCost.TabIndex = 17;
            lblMaterialCost.Text = "Tiền nguyên liệu";
            // 
            // dtpOrganizationDay
            // 
            dtpOrganizationDay.BackgroundColor = Color.FromArgb(255, 227, 232);
            dtpOrganizationDay.BorderRadius = 15;
            dtpOrganizationDay.CustomFormat = "dd/MM/yyyy";
            dtpOrganizationDay.Format = DateTimePickerFormat.Custom;
            dtpOrganizationDay.Location = new Point(38, 85);
            dtpOrganizationDay.Margin = new Padding(2);
            dtpOrganizationDay.MinimumSize = new Size(4, 36);
            dtpOrganizationDay.Name = "dtpOrganizationDay";
            dtpOrganizationDay.Size = new Size(284, 36);
            dtpOrganizationDay.TabIndex = 1;
            // 
            // lblOrganizationDay
            // 
            lblOrganizationDay.AutoSize = true;
            lblOrganizationDay.BackColor = Color.White;
            lblOrganizationDay.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrganizationDay.ForeColor = Color.DarkRed;
            lblOrganizationDay.Location = new Point(38, 30);
            lblOrganizationDay.Margin = new Padding(2, 0, 2, 0);
            lblOrganizationDay.Name = "lblOrganizationDay";
            lblOrganizationDay.Size = new Size(148, 28);
            lblOrganizationDay.TabIndex = 1;
            lblOrganizationDay.Text = "*Ngày tổ chức";
            // 
            // lblEndHour
            // 
            lblEndHour.AutoSize = true;
            lblEndHour.BackColor = Color.White;
            lblEndHour.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEndHour.ForeColor = Color.DarkRed;
            lblEndHour.Location = new Point(432, 140);
            lblEndHour.Margin = new Padding(2, 0, 2, 0);
            lblEndHour.Name = "lblEndHour";
            lblEndHour.Size = new Size(195, 28);
            lblEndHour.TabIndex = 3;
            lblEndHour.Text = "*Thời gian kết thúc";
            // 
            // lblStartHour
            // 
            lblStartHour.AutoSize = true;
            lblStartHour.BackColor = Color.White;
            lblStartHour.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStartHour.ForeColor = Color.DarkRed;
            lblStartHour.Location = new Point(38, 140);
            lblStartHour.Margin = new Padding(2, 0, 2, 0);
            lblStartHour.Name = "lblStartHour";
            lblStartHour.Size = new Size(190, 28);
            lblStartHour.TabIndex = 2;
            lblStartHour.Text = "*Thời gian bắt đầu";
            // 
            // ttbEndHour
            // 
            ttbEndHour.BackColor = Color.FromArgb(255, 227, 232);
            ttbEndHour.BackgroundColor = Color.FromArgb(255, 227, 232);
            ttbEndHour.BorderRadius = 15;
            ttbEndHour.BorderStyle = BorderStyle.None;
            ttbEndHour.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ttbEndHour.Location = new Point(432, 195);
            ttbEndHour.Margin = new Padding(2);
            ttbEndHour.MaxLength = 5;
            ttbEndHour.Multiline = true;
            ttbEndHour.Name = "ttbEndHour";
            ttbEndHour.PlaceholderText = "00:00";
            ttbEndHour.Size = new Size(284, 36);
            ttbEndHour.TabIndex = 4;
            ttbEndHour.TextAlign = HorizontalAlignment.Center;
            // 
            // ttbStartHour
            // 
            ttbStartHour.BackColor = Color.FromArgb(255, 227, 232);
            ttbStartHour.BackgroundColor = Color.FromArgb(255, 227, 232);
            ttbStartHour.BorderRadius = 15;
            ttbStartHour.BorderStyle = BorderStyle.None;
            ttbStartHour.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ttbStartHour.Location = new Point(38, 195);
            ttbStartHour.Margin = new Padding(2);
            ttbStartHour.MaxLength = 5;
            ttbStartHour.Multiline = true;
            ttbStartHour.Name = "ttbStartHour";
            ttbStartHour.PlaceholderText = "00:00";
            ttbStartHour.Size = new Size(284, 36);
            ttbStartHour.TabIndex = 3;
            ttbStartHour.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAdd
            // 
            btnAdd.BorderRadius = 40;
            btnAdd.ButtonColor = Color.DarkRed;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.Location = new Point(802, 689);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 39);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Thêm";
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // PickTime
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(251, 236, 240);
            ClientSize = new Size(978, 764);
            Controls.Add(btnAdd);
            Controls.Add(pnAddFormExtraInformation);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "PickTime";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin đính kèm";
            pnAddFormExtraInformation.ResumeLayout(false);
            pnAddFormExtraInformation.PerformLayout();
            pnExtra.ResumeLayout(false);
            pnExtra.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CHEF.RoundedPanel1 pnAddFormExtraInformation;
        private LOGIN.RoundedPanel pnExtra;
        private Label lblExtra;
        private TimeTextBox ttbStartHour;
        private TimeTextBox ttbEndHour;
        private Label lblStartHour;
        private Label lblEndHour;
        private Label lblOrganizationDay;
        private CHEF.RoundedDateTimePicker dtpOrganizationDay;
        private RoundedButton btnAdd;
        private LOGIN.RoundedTextBox txtAnotherCost;
        private Label lblAnotherCost;
        private LOGIN.RoundedTextBox txtMaterialCost;
        private Label lblMaterialCost;
        private LOGIN.RoundedTextBox txtNote;
        private Label lblNote;
        private LOGIN.RoundedTextBox txtFreelancerCost;
        private Label lblFreelancerCost;
        private LOGIN.RoundedTextBox txtFee;
        private Label lblFee;
    }
}