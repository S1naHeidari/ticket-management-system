namespace WindowsFormsApp2
{
    partial class requestManagementGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(requestManagementGrid));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.editProfilePanel = new System.Windows.Forms.Panel();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label9 = new System.Windows.Forms.Label();
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
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.s_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destination_uni_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.letter_conf_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_accept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestManagementDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestManagementDataSet = new WindowsFormsApp2.RequestManagementDataSet();
            this.transportformBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transport_formTableAdapter = new WindowsFormsApp2.RequestManagementDataSetTableAdapters.transport_formTableAdapter();
            this.panel2.SuspendLayout();
            this.editProfilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            this.requestManagementPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestManagementDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportformBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(215)))));
            this.panel2.Controls.Add(this.editProfilePanel);
            this.panel2.Controls.Add(this.requestManagementPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(902, 95);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 393);
            this.panel2.TabIndex = 9;
            // 
            // editProfilePanel
            // 
            this.editProfilePanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.editProfilePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.editProfilePanel.Controls.Add(this.bunifuImageButton3);
            this.editProfilePanel.Controls.Add(this.label9);
            this.editProfilePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.editProfilePanel.Location = new System.Drawing.Point(0, 64);
            this.editProfilePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editProfilePanel.Name = "editProfilePanel";
            this.editProfilePanel.Size = new System.Drawing.Size(283, 64);
            this.editProfilePanel.TabIndex = 3;
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
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(21, 12);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(168, 32);
            this.label9.TabIndex = 4;
            this.label9.Text = "ویرایش حساب کاربری";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // requestManagementPanel
            // 
            this.requestManagementPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.requestManagementPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.requestManagementPanel.Controls.Add(this.bunifuImageButton2);
            this.requestManagementPanel.Controls.Add(this.label8);
            this.requestManagementPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.requestManagementPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.requestManagementPanel.Location = new System.Drawing.Point(0, 0);
            this.requestManagementPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.requestManagementPanel.Name = "requestManagementPanel";
            this.requestManagementPanel.Size = new System.Drawing.Size(283, 64);
            this.requestManagementPanel.TabIndex = 1;
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
            this.panel1.Size = new System.Drawing.Size(1185, 95);
            this.panel1.TabIndex = 8;
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.RoyalBlue;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "صفحه‌ی اصلی";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuThinButton22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuThinButton22.Location = new System.Drawing.Point(600, 38);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(121, 48);
            this.bunifuThinButton22.TabIndex = 18;
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
            this.AttendantLabel.Location = new System.Drawing.Point(861, 43);
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
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(1099, 43);
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
            this.nameLabel.Location = new System.Drawing.Point(1002, 43);
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
            this.aidLabel.Location = new System.Drawing.Point(752, 43);
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
            this.label2.Location = new System.Drawing.Point(697, 1);
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
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.s_id,
            this.semesterNum,
            this.requestCode,
            this.destination_uni_name,
            this.course_num,
            this.letter_conf_num,
            this.s_accept});
            this.bunifuCustomDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.LightSkyBlue;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.Black;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(0, 95);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.RowHeadersWidth = 30;
            this.bunifuCustomDataGrid1.RowTemplate.Height = 24;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(902, 393);
            this.bunifuCustomDataGrid1.TabIndex = 10;
            this.bunifuCustomDataGrid1.Click += new System.EventHandler(this.bunifuCustomDataGrid1_Click);
            // 
            // s_id
            // 
            this.s_id.HeaderText = "شماره دانشجویی";
            this.s_id.Name = "s_id";
            this.s_id.ReadOnly = true;
            // 
            // semesterNum
            // 
            this.semesterNum.FillWeight = 80F;
            this.semesterNum.HeaderText = "ترم";
            this.semesterNum.Name = "semesterNum";
            this.semesterNum.ReadOnly = true;
            // 
            // requestCode
            // 
            this.requestCode.HeaderText = "کد درخواست";
            this.requestCode.Name = "requestCode";
            this.requestCode.ReadOnly = true;
            // 
            // destination_uni_name
            // 
            this.destination_uni_name.FillWeight = 110F;
            this.destination_uni_name.HeaderText = "نام دانشگاه مقصد";
            this.destination_uni_name.Name = "destination_uni_name";
            this.destination_uni_name.ReadOnly = true;
            // 
            // course_num
            // 
            this.course_num.HeaderText = "تعداد واحد";
            this.course_num.Name = "course_num";
            this.course_num.ReadOnly = true;
            // 
            // letter_conf_num
            // 
            this.letter_conf_num.FillWeight = 120F;
            this.letter_conf_num.HeaderText = "شماره نامه موافقت";
            this.letter_conf_num.Name = "letter_conf_num";
            this.letter_conf_num.ReadOnly = true;
            // 
            // s_accept
            // 
            this.s_accept.HeaderText = "تایید دانشجو";
            this.s_accept.Name = "s_accept";
            this.s_accept.ReadOnly = true;
            // 
            // requestManagementDataSetBindingSource
            // 
            this.requestManagementDataSetBindingSource.DataSource = this.requestManagementDataSet;
            this.requestManagementDataSetBindingSource.Position = 0;
            // 
            // requestManagementDataSet
            // 
            this.requestManagementDataSet.DataSetName = "RequestManagementDataSet";
            this.requestManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transportformBindingSource
            // 
            this.transportformBindingSource.DataMember = "transport_form";
            this.transportformBindingSource.DataSource = this.requestManagementDataSetBindingSource;
            // 
            // transport_formTableAdapter
            // 
            this.transport_formTableAdapter.ClearBeforeFill = true;
            // 
            // requestManagementGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 488);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "requestManagementGrid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "requestManagementGrid";
            this.Load += new System.EventHandler(this.requestManagementGrid_Load);
            this.panel2.ResumeLayout(false);
            this.editProfilePanel.ResumeLayout(false);
            this.editProfilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            this.requestManagementPanel.ResumeLayout(false);
            this.requestManagementPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestManagementDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportformBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel editProfilePanel;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private System.Windows.Forms.Label label9;
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
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.BindingSource requestManagementDataSetBindingSource;
        private RequestManagementDataSet requestManagementDataSet;
        private System.Windows.Forms.BindingSource transportformBindingSource;
        private RequestManagementDataSetTableAdapters.transport_formTableAdapter transport_formTableAdapter;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn destination_uni_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn course_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn letter_conf_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_accept;
    }
}