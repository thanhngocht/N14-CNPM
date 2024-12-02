namespace THE_COOKY_APP.GUI.TIMELINE
{
    partial class CardClassroom
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
            pnCard = new LOGIN.RoundedPanel();
            btnPrice = new Button();
            lblNameChef = new Label();
            lblChef = new Label();
            lblDescription = new Label();
            lblNameClassroom = new Label();
            pnTemp = new Panel();
            rpbClassroom = new LOGIN.RoundedPictureBox();
            lblClassID = new Label();
            pnCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rpbClassroom).BeginInit();
            SuspendLayout();
            // 
            // pnCard
            // 
            pnCard.BorderRadius = 40;
            pnCard.Controls.Add(btnPrice);
            pnCard.Controls.Add(lblNameChef);
            pnCard.Controls.Add(lblChef);
            pnCard.Controls.Add(lblDescription);
            pnCard.Controls.Add(lblNameClassroom);
            pnCard.Controls.Add(pnTemp);
            pnCard.Controls.Add(rpbClassroom);
            pnCard.Location = new Point(40, 40);
            pnCard.Margin = new Padding(2);
            pnCard.Name = "pnCard";
            pnCard.Size = new Size(580, 580);
            pnCard.TabIndex = 0;
            // 
            // btnPrice
            // 
            btnPrice.BackColor = Color.IndianRed;
            btnPrice.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrice.ForeColor = Color.White;
            btnPrice.Location = new Point(402, 515);
            btnPrice.Margin = new Padding(2);
            btnPrice.Name = "btnPrice";
            btnPrice.Size = new Size(160, 52);
            btnPrice.TabIndex = 6;
            btnPrice.Text = "100,000";
            btnPrice.UseVisualStyleBackColor = false;
            btnPrice.Click += btnPrice_Click;
            // 
            // lblNameChef
            // 
            lblNameChef.AutoSize = true;
            lblNameChef.BackColor = Color.White;
            lblNameChef.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNameChef.ForeColor = Color.LightCoral;
            lblNameChef.Location = new Point(121, 529);
            lblNameChef.Margin = new Padding(2, 0, 2, 0);
            lblNameChef.Name = "lblNameChef";
            lblNameChef.Size = new Size(147, 30);
            lblNameChef.TabIndex = 5;
            lblNameChef.Text = "Võ Minh Duy";
            // 
            // lblChef
            // 
            lblChef.AutoSize = true;
            lblChef.BackColor = Color.White;
            lblChef.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblChef.Location = new Point(22, 529);
            lblChef.Margin = new Padding(2, 0, 2, 0);
            lblChef.Name = "lblChef";
            lblChef.Size = new Size(100, 30);
            lblChef.TabIndex = 4;
            lblChef.Text = "Đầu bếp:";
            // 
            // lblDescription
            // 
            lblDescription.BackColor = Color.White;
            lblDescription.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(72, 412);
            lblDescription.Margin = new Padding(2, 0, 2, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(508, 99);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Khởi động một mùa hè tràn đầy năng lượng và ý nghĩa cùng lớp học làm “Cake Pop\" của Cooky thôi nào các đầu bếp nhí ơi!";
            // 
            // lblNameClassroom
            // 
            lblNameClassroom.AutoSize = true;
            lblNameClassroom.BackColor = Color.White;
            lblNameClassroom.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblNameClassroom.ForeColor = Color.DarkRed;
            lblNameClassroom.Location = new Point(38, 370);
            lblNameClassroom.Margin = new Padding(2, 0, 2, 0);
            lblNameClassroom.Name = "lblNameClassroom";
            lblNameClassroom.Size = new Size(139, 36);
            lblNameClassroom.TabIndex = 2;
            lblNameClassroom.Text = "Bánh kem";
            // 
            // pnTemp
            // 
            pnTemp.BackColor = Color.White;
            pnTemp.Location = new Point(0, 334);
            pnTemp.Margin = new Padding(2);
            pnTemp.Name = "pnTemp";
            pnTemp.Size = new Size(580, 22);
            pnTemp.TabIndex = 1;
            // 
            // rpbClassroom
            // 
            rpbClassroom.BackgroundImageLayout = ImageLayout.Stretch;
            rpbClassroom.BorderRadius = 40;
            rpbClassroom.Location = new Point(0, -13);
            rpbClassroom.Margin = new Padding(2);
            rpbClassroom.Name = "rpbClassroom";
            rpbClassroom.Size = new Size(580, 356);
            rpbClassroom.TabIndex = 0;
            rpbClassroom.TabStop = false;
            // 
            // lblClassID
            // 
            lblClassID.AutoSize = true;
            lblClassID.Location = new Point(62, 622);
            lblClassID.Margin = new Padding(4, 0, 4, 0);
            lblClassID.Name = "lblClassID";
            lblClassID.Size = new Size(59, 25);
            lblClassID.TabIndex = 1;
            lblClassID.Text = "label1";
            // 
            // CardClassroom
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(251, 236, 240);
            Controls.Add(lblClassID);
            Controls.Add(pnCard);
            Margin = new Padding(2);
            Name = "CardClassroom";
            Size = new Size(660, 660);
            pnCard.ResumeLayout(false);
            pnCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)rpbClassroom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LOGIN.RoundedPanel pnCard;
        private Panel pnTemp;
        private LOGIN.RoundedPictureBox rpbClassroom;
        private Label lblNameClassroom;
        private Label lblDescription;
        private Label lblNameChef;
        private Label lblChef;
        private Button btnPrice;
        private Label lblClassID;
    }
}
