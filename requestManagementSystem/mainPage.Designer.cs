namespace WindowsFormsApp2
{
    partial class mainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainPage));
            this.sessionTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.studentBackBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.studentExitBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.studentSessionLabel = new System.Windows.Forms.Label();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.StudentNameLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.studentIdLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.studentDateLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dropDownTimer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.editProfilePanel = new System.Windows.Forms.Panel();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label9 = new System.Windows.Forms.Label();
            this.requestManagementPanel = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label8 = new System.Windows.Forms.Label();
            this.dropDownPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.eshteghalBtn = new System.Windows.Forms.Button();
            this.transBtn = new System.Windows.Forms.Button();
            this.sendRequestPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.mainStudentPanel = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.editProfilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            this.requestManagementPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.dropDownPanel.SuspendLayout();
            this.sendRequestPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // sessionTimer
            // 
            this.sessionTimer.Interval = 1000;
            this.sessionTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.studentBackBtn);
            this.panel1.Controls.Add(this.studentExitBtn);
            this.panel1.Controls.Add(this.studentSessionLabel);
            this.panel1.Controls.Add(this.bunifuCustomLabel11);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.StudentNameLabel);
            this.panel1.Controls.Add(this.studentIdLabel);
            this.panel1.Controls.Add(this.studentDateLabel);
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
            this.panel1.Size = new System.Drawing.Size(1487, 95);
            this.panel1.TabIndex = 4;
            // 
            // studentBackBtn
            // 
            this.studentBackBtn.ActiveBorderThickness = 1;
            this.studentBackBtn.ActiveCornerRadius = 20;
            this.studentBackBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.studentBackBtn.ActiveForecolor = System.Drawing.Color.White;
            this.studentBackBtn.ActiveLineColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.studentBackBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.studentBackBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.studentBackBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("studentBackBtn.BackgroundImage")));
            this.studentBackBtn.ButtonText = "بازگشت";
            this.studentBackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.studentBackBtn.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.studentBackBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.studentBackBtn.IdleBorderThickness = 1;
            this.studentBackBtn.IdleCornerRadius = 20;
            this.studentBackBtn.IdleFillColor = System.Drawing.Color.White;
            this.studentBackBtn.IdleForecolor = System.Drawing.SystemColors.ActiveCaptionText;
            this.studentBackBtn.IdleLineColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.studentBackBtn.Location = new System.Drawing.Point(139, 43);
            this.studentBackBtn.Margin = new System.Windows.Forms.Padding(7);
            this.studentBackBtn.Name = "studentBackBtn";
            this.studentBackBtn.Size = new System.Drawing.Size(121, 48);
            this.studentBackBtn.TabIndex = 18;
            this.studentBackBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.studentBackBtn.Visible = false;
            this.studentBackBtn.Click += new System.EventHandler(this.studentBackBtn_Click);
            // 
            // studentExitBtn
            // 
            this.studentExitBtn.ActiveBorderThickness = 1;
            this.studentExitBtn.ActiveCornerRadius = 20;
            this.studentExitBtn.ActiveFillColor = System.Drawing.Color.Red;
            this.studentExitBtn.ActiveForecolor = System.Drawing.Color.White;
            this.studentExitBtn.ActiveLineColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.studentExitBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.studentExitBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.studentExitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("studentExitBtn.BackgroundImage")));
            this.studentExitBtn.ButtonText = "خروج";
            this.studentExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.studentExitBtn.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.studentExitBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.studentExitBtn.IdleBorderThickness = 1;
            this.studentExitBtn.IdleCornerRadius = 20;
            this.studentExitBtn.IdleFillColor = System.Drawing.Color.White;
            this.studentExitBtn.IdleForecolor = System.Drawing.SystemColors.ActiveCaptionText;
            this.studentExitBtn.IdleLineColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.studentExitBtn.Location = new System.Drawing.Point(5, 44);
            this.studentExitBtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.studentExitBtn.Name = "studentExitBtn";
            this.studentExitBtn.Size = new System.Drawing.Size(121, 48);
            this.studentExitBtn.TabIndex = 11;
            this.studentExitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.studentExitBtn.Click += new System.EventHandler(this.studentExitBtn_Click);
            // 
            // studentSessionLabel
            // 
            this.studentSessionLabel.AutoSize = true;
            this.studentSessionLabel.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.studentSessionLabel.Location = new System.Drawing.Point(327, 11);
            this.studentSessionLabel.Name = "studentSessionLabel";
            this.studentSessionLabel.Size = new System.Drawing.Size(47, 26);
            this.studentSessionLabel.TabIndex = 17;
            this.studentSessionLabel.Text = "time";
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
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Linen;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(1163, 43);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(112, 26);
            this.bunifuCustomLabel3.TabIndex = 11;
            this.bunifuCustomLabel3.Text = "شماره‌ی دانشجویی:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Linen;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(1401, 43);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(57, 26);
            this.bunifuCustomLabel2.TabIndex = 11;
            this.bunifuCustomLabel2.Text = "نام کاربر:";
            // 
            // StudentNameLabel
            // 
            this.StudentNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.StudentNameLabel.AutoSize = true;
            this.StudentNameLabel.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.StudentNameLabel.Location = new System.Drawing.Point(1294, 43);
            this.StudentNameLabel.Name = "StudentNameLabel";
            this.StudentNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StudentNameLabel.Size = new System.Drawing.Size(63, 26);
            this.StudentNameLabel.TabIndex = 10;
            this.StudentNameLabel.Text = "Name";
            // 
            // studentIdLabel
            // 
            this.studentIdLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.studentIdLabel.AutoSize = true;
            this.studentIdLabel.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.studentIdLabel.Location = new System.Drawing.Point(1043, 43);
            this.studentIdLabel.Name = "studentIdLabel";
            this.studentIdLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.studentIdLabel.Size = new System.Drawing.Size(90, 26);
            this.studentIdLabel.TabIndex = 10;
            this.studentIdLabel.Text = "studentID";
            // 
            // studentDateLabel
            // 
            this.studentDateLabel.AutoSize = true;
            this.studentDateLabel.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.studentDateLabel.Location = new System.Drawing.Point(154, 11);
            this.studentDateLabel.Name = "studentDateLabel";
            this.studentDateLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.studentDateLabel.Size = new System.Drawing.Size(48, 26);
            this.studentDateLabel.TabIndex = 10;
            this.studentDateLabel.Text = "date";
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
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click_1);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("2  Titr", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Linen;
            this.label2.Location = new System.Drawing.Point(999, 1);
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
            // dropDownTimer
            // 
            this.dropDownTimer.Interval = 1;
            this.dropDownTimer.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(215)))));
            this.panel2.Controls.Add(this.editProfilePanel);
            this.panel2.Controls.Add(this.requestManagementPanel);
            this.panel2.Controls.Add(this.dropDownPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(1204, 95);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 501);
            this.panel2.TabIndex = 5;
            // 
            // editProfilePanel
            // 
            this.editProfilePanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.editProfilePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.editProfilePanel.Controls.Add(this.bunifuImageButton3);
            this.editProfilePanel.Controls.Add(this.label9);
            this.editProfilePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editProfilePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.editProfilePanel.Location = new System.Drawing.Point(0, 127);
            this.editProfilePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editProfilePanel.Name = "editProfilePanel";
            this.editProfilePanel.Size = new System.Drawing.Size(283, 64);
            this.editProfilePanel.TabIndex = 3;
            this.editProfilePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPage_MouseDown);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(217, 2);
            this.bunifuImageButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(54, 51);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 0;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPage_MouseDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(14, 12);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(168, 32);
            this.label9.TabIndex = 4;
            this.label9.Text = "ویرایش حساب کاربری";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPage_MouseDown);
            // 
            // requestManagementPanel
            // 
            this.requestManagementPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.requestManagementPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.requestManagementPanel.Controls.Add(this.bunifuImageButton2);
            this.requestManagementPanel.Controls.Add(this.label8);
            this.requestManagementPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.requestManagementPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.requestManagementPanel.Location = new System.Drawing.Point(0, 63);
            this.requestManagementPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.requestManagementPanel.Name = "requestManagementPanel";
            this.requestManagementPanel.Size = new System.Drawing.Size(283, 64);
            this.requestManagementPanel.TabIndex = 1;
            this.requestManagementPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.requestManagementPanel_MouseDown);
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
            this.bunifuImageButton2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.requestManagementPanel_MouseDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(24, 10);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(158, 32);
            this.label8.TabIndex = 4;
            this.label8.Text = "مدیریت درخواست‌ها";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.requestManagementPanel_MouseDown);
            // 
            // dropDownPanel
            // 
            this.dropDownPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dropDownPanel.BackgroundImage")));
            this.dropDownPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dropDownPanel.Controls.Add(this.eshteghalBtn);
            this.dropDownPanel.Controls.Add(this.transBtn);
            this.dropDownPanel.Controls.Add(this.sendRequestPanel);
            this.dropDownPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dropDownPanel.GradientBottomLeft = System.Drawing.Color.White;
            this.dropDownPanel.GradientBottomRight = System.Drawing.Color.White;
            this.dropDownPanel.GradientTopLeft = System.Drawing.Color.White;
            this.dropDownPanel.GradientTopRight = System.Drawing.Color.White;
            this.dropDownPanel.Location = new System.Drawing.Point(0, 0);
            this.dropDownPanel.Name = "dropDownPanel";
            this.dropDownPanel.Quality = 10;
            this.dropDownPanel.Size = new System.Drawing.Size(283, 63);
            this.dropDownPanel.TabIndex = 1;
            // 
            // eshteghalBtn
            // 
            this.eshteghalBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(215)))));
            this.eshteghalBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.eshteghalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eshteghalBtn.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.eshteghalBtn.Location = new System.Drawing.Point(0, 107);
            this.eshteghalBtn.Name = "eshteghalBtn";
            this.eshteghalBtn.Size = new System.Drawing.Size(283, 44);
            this.eshteghalBtn.TabIndex = 1;
            this.eshteghalBtn.Text = "درخواست اشتغال به تحصیل";
            this.eshteghalBtn.UseVisualStyleBackColor = false;
            this.eshteghalBtn.Click += new System.EventHandler(this.eshteghalBtn_Click);
            // 
            // transBtn
            // 
            this.transBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(215)))));
            this.transBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.transBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transBtn.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.transBtn.Location = new System.Drawing.Point(0, 63);
            this.transBtn.Name = "transBtn";
            this.transBtn.Size = new System.Drawing.Size(283, 44);
            this.transBtn.TabIndex = 1;
            this.transBtn.Text = "درخواست انتقالی";
            this.transBtn.UseVisualStyleBackColor = false;
            this.transBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.transBtn_MouseClick);
            // 
            // sendRequestPanel
            // 
            this.sendRequestPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.sendRequestPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sendRequestPanel.Controls.Add(this.label3);
            this.sendRequestPanel.Controls.Add(this.bunifuImageButton1);
            this.sendRequestPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendRequestPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.sendRequestPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(215)))));
            this.sendRequestPanel.Location = new System.Drawing.Point(0, 0);
            this.sendRequestPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sendRequestPanel.Name = "sendRequestPanel";
            this.sendRequestPanel.Size = new System.Drawing.Size(283, 63);
            this.sendRequestPanel.TabIndex = 0;
            this.sendRequestPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sendRequestPanel_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(48, 11);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(131, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "ارسال درخواست";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sendRequestPanel_MouseDown);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(217, 2);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(54, 51);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 3;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sendRequestPanel_MouseDown);
            // 
            // mainStudentPanel
            // 
            this.mainStudentPanel.Location = new System.Drawing.Point(0, 95);
            this.mainStudentPanel.Name = "mainStudentPanel";
            this.mainStudentPanel.Size = new System.Drawing.Size(1204, 501);
            this.mainStudentPanel.TabIndex = 6;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 596);
            this.Controls.Add(this.mainStudentPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.mainPage_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mainPage_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainPage_MouseClick);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.editProfilePanel.ResumeLayout(false);
            this.editProfilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            this.requestManagementPanel.ResumeLayout(false);
            this.requestManagementPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.dropDownPanel.ResumeLayout(false);
            this.sendRequestPanel.ResumeLayout(false);
            this.sendRequestPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer sessionTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer dropDownTimer;
        private Bunifu.Framework.UI.BunifuCustomLabel studentDateLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel StudentNameLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel studentIdLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel editProfilePanel;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel requestManagementPanel;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuGradientPanel dropDownPanel;
        private System.Windows.Forms.Button eshteghalBtn;
        private System.Windows.Forms.Button transBtn;
        private System.Windows.Forms.Panel sendRequestPanel;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label studentSessionLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuThinButton2 studentExitBtn;
        private System.Windows.Forms.Panel mainStudentPanel;
        private Bunifu.Framework.UI.BunifuThinButton2 studentBackBtn;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}