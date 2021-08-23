namespace WindowsFormsApp2
{
    partial class attendantPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(attendantPage));
            this.panel2 = new System.Windows.Forms.Panel();
            this.requestManagementPanel = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.AttendantLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.nameLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.aidLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dateLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel2.SuspendLayout();
            this.requestManagementPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(215)))));
            this.panel2.Controls.Add(this.requestManagementPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(920, 95);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 440);
            this.panel2.TabIndex = 7;
            // 
            // requestManagementPanel
            // 
            this.requestManagementPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.requestManagementPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.requestManagementPanel.Controls.Add(this.bunifuImageButton2);
            this.requestManagementPanel.Controls.Add(this.label8);
            this.requestManagementPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.requestManagementPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.requestManagementPanel.Location = new System.Drawing.Point(0, 0);
            this.requestManagementPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.requestManagementPanel.Name = "requestManagementPanel";
            this.requestManagementPanel.Size = new System.Drawing.Size(283, 64);
            this.requestManagementPanel.TabIndex = 1;
            this.requestManagementPanel.Click += new System.EventHandler(this.requestManagementPanel_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(217, 2);
            this.bunifuImageButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(54, 51);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 0;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(31, 10);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(158, 32);
            this.label8.TabIndex = 4;
            this.label8.Text = "مدیریت درخواست‌ها";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.bunifuThinButton22);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.bunifuCustomLabel11);
            this.panel1.Controls.Add(this.AttendantLabel);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.aidLabel);
            this.panel1.Controls.Add(this.dateLabel);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1203, 95);
            this.panel1.TabIndex = 6;
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.Red;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuThinButton22.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.RoyalBlue;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "خروج";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuThinButton22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuThinButton22.Location = new System.Drawing.Point(0, 43);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(121, 48);
            this.bunifuThinButton22.TabIndex = 12;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(327, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 26);
            this.label7.TabIndex = 17;
            this.label7.Text = "time";
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel11.ForeColor = System.Drawing.Color.Linen;
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(380, 12);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(86, 26);
            this.bunifuCustomLabel11.TabIndex = 16;
            this.bunifuCustomLabel11.Text = "زمان باقیمانده:";
            // 
            // AttendantLabel
            // 
            this.AttendantLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AttendantLabel.AutoSize = true;
            this.AttendantLabel.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AttendantLabel.ForeColor = System.Drawing.Color.Linen;
            this.AttendantLabel.Location = new System.Drawing.Point(879, 43);
            this.AttendantLabel.Name = "AttendantLabel";
            this.AttendantLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AttendantLabel.Size = new System.Drawing.Size(100, 26);
            this.AttendantLabel.TabIndex = 11;
            this.AttendantLabel.Text = "شماره‌ی متصدی:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Linen;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(1117, 43);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(57, 26);
            this.bunifuCustomLabel2.TabIndex = 11;
            this.bunifuCustomLabel2.Text = "نام کاربر:";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.nameLabel.Location = new System.Drawing.Point(1020, 43);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nameLabel.Size = new System.Drawing.Size(63, 26);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "Name";
            // 
            // aidLabel
            // 
            this.aidLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.aidLabel.AutoSize = true;
            this.aidLabel.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.aidLabel.Location = new System.Drawing.Point(770, 43);
            this.aidLabel.Name = "aidLabel";
            this.aidLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.aidLabel.Size = new System.Drawing.Size(105, 26);
            this.aidLabel.TabIndex = 10;
            this.aidLabel.Text = "attendantID";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dateLabel.Location = new System.Drawing.Point(154, 11);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateLabel.Size = new System.Drawing.Size(48, 26);
            this.dateLabel.TabIndex = 10;
            this.dateLabel.Text = "date";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Linen;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(244, 11);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(42, 26);
            this.bunifuCustomLabel1.TabIndex = 9;
            this.bunifuCustomLabel1.Text = "تاریخ:";
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.closeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.closeBtn.Location = new System.Drawing.Point(0, 2);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(46, 40);
            this.closeBtn.TabIndex = 6;
            this.closeBtn.Tag = "";
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("2  Titr", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Linen;
            this.label2.Location = new System.Drawing.Point(715, 1);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(459, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "پنل اصلی سامانه‌ی مدیریت درخواست‌های دانشجویی";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(260, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button1.Location = new System.Drawing.Point(84, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button2.Location = new System.Drawing.Point(42, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 40);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // attendantPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 535);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "attendantPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "attendantPage";
            this.Load += new System.EventHandler(this.attendantPage_Load);
            this.Click += new System.EventHandler(this.attendantPage_Click);
            this.panel2.ResumeLayout(false);
            this.requestManagementPanel.ResumeLayout(false);
            this.requestManagementPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel requestManagementPanel;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuCustomLabel AttendantLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel nameLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel aidLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel dateLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
    }
}