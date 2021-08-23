namespace WindowsFormsApp2
{
    partial class EnteghalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnteghalForm));
            this.efPanel = new System.Windows.Forms.Panel();
            this.destDateLabel = new System.Windows.Forms.Label();
            this.destNumberLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.transferHeader = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.transferDestinationDate = new System.Windows.Forms.MaskedTextBox();
            this.editReject = new Bunifu.Framework.UI.BunifuThinButton2();
            this.transferSend = new Bunifu.Framework.UI.BunifuThinButton2();
            this.transferUnitCount = new System.Windows.Forms.ComboBox();
            this.transferTrmNumber = new System.Windows.Forms.ComboBox();
            this.transferDestinationNumber = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.transferDestination = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.efPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // efPanel
            // 
            this.efPanel.Controls.Add(this.destDateLabel);
            this.efPanel.Controls.Add(this.destNumberLabel);
            this.efPanel.Controls.Add(this.panel1);
            this.efPanel.Controls.Add(this.transferDestinationDate);
            this.efPanel.Controls.Add(this.editReject);
            this.efPanel.Controls.Add(this.transferSend);
            this.efPanel.Controls.Add(this.transferUnitCount);
            this.efPanel.Controls.Add(this.transferTrmNumber);
            this.efPanel.Controls.Add(this.transferDestinationNumber);
            this.efPanel.Controls.Add(this.transferDestination);
            this.efPanel.Controls.Add(this.bunifuCustomLabel6);
            this.efPanel.Controls.Add(this.bunifuCustomLabel9);
            this.efPanel.Controls.Add(this.bunifuCustomLabel5);
            this.efPanel.Controls.Add(this.bunifuCustomLabel7);
            this.efPanel.Controls.Add(this.bunifuCustomLabel8);
            this.efPanel.Controls.Add(this.bunifuCustomLabel4);
            this.efPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.efPanel.Location = new System.Drawing.Point(0, 0);
            this.efPanel.Name = "efPanel";
            this.efPanel.Size = new System.Drawing.Size(994, 469);
            this.efPanel.TabIndex = 12;
            // 
            // destDateLabel
            // 
            this.destDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.destDateLabel.AutoSize = true;
            this.destDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destDateLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.destDateLabel.Location = new System.Drawing.Point(165, 162);
            this.destDateLabel.Name = "destDateLabel";
            this.destDateLabel.Size = new System.Drawing.Size(24, 29);
            this.destDateLabel.TabIndex = 66;
            this.destDateLabel.Text = "*";
            this.destDateLabel.Visible = false;
            this.destDateLabel.MouseHover += new System.EventHandler(this.destDateLabel_MouseHover);
            // 
            // destNumberLabel
            // 
            this.destNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.destNumberLabel.AutoSize = true;
            this.destNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destNumberLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.destNumberLabel.Location = new System.Drawing.Point(94, 119);
            this.destNumberLabel.Name = "destNumberLabel";
            this.destNumberLabel.Size = new System.Drawing.Size(24, 29);
            this.destNumberLabel.TabIndex = 66;
            this.destNumberLabel.Text = "*";
            this.destNumberLabel.Visible = false;
            this.destNumberLabel.MouseHover += new System.EventHandler(this.destNumberLabel_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.transferHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 49);
            this.panel1.TabIndex = 21;
            // 
            // transferHeader
            // 
            this.transferHeader.AutoSize = true;
            this.transferHeader.Dock = System.Windows.Forms.DockStyle.Right;
            this.transferHeader.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.transferHeader.ForeColor = System.Drawing.Color.MintCream;
            this.transferHeader.Location = new System.Drawing.Point(853, 0);
            this.transferHeader.Name = "transferHeader";
            this.transferHeader.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.transferHeader.Size = new System.Drawing.Size(141, 35);
            this.transferHeader.TabIndex = 1;
            this.transferHeader.Text = "درخواست انتقالی";
            // 
            // transferDestinationDate
            // 
            this.transferDestinationDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.transferDestinationDate.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.transferDestinationDate.Location = new System.Drawing.Point(195, 154);
            this.transferDestinationDate.Mask = "0000-00-00";
            this.transferDestinationDate.Name = "transferDestinationDate";
            this.transferDestinationDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.transferDestinationDate.Size = new System.Drawing.Size(117, 37);
            this.transferDestinationDate.TabIndex = 19;
            this.transferDestinationDate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.transferDestinationDate_MouseClick);
            // 
            // editReject
            // 
            this.editReject.ActiveBorderThickness = 1;
            this.editReject.ActiveCornerRadius = 20;
            this.editReject.ActiveFillColor = System.Drawing.Color.Red;
            this.editReject.ActiveForecolor = System.Drawing.Color.White;
            this.editReject.ActiveLineColor = System.Drawing.Color.OrangeRed;
            this.editReject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editReject.BackColor = System.Drawing.SystemColors.Control;
            this.editReject.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editReject.BackgroundImage")));
            this.editReject.ButtonText = "لغو";
            this.editReject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editReject.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.editReject.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editReject.IdleBorderThickness = 1;
            this.editReject.IdleCornerRadius = 20;
            this.editReject.IdleFillColor = System.Drawing.Color.Transparent;
            this.editReject.IdleForecolor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editReject.IdleLineColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editReject.Location = new System.Drawing.Point(276, 270);
            this.editReject.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.editReject.Name = "editReject";
            this.editReject.Size = new System.Drawing.Size(142, 52);
            this.editReject.TabIndex = 20;
            this.editReject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.editReject.Visible = false;
            this.editReject.MouseDown += new System.EventHandler(this.editReject_MouseDown);
            // 
            // transferSend
            // 
            this.transferSend.ActiveBorderThickness = 1;
            this.transferSend.ActiveCornerRadius = 20;
            this.transferSend.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.transferSend.ActiveForecolor = System.Drawing.Color.White;
            this.transferSend.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.transferSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.transferSend.BackColor = System.Drawing.SystemColors.Control;
            this.transferSend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("transferSend.BackgroundImage")));
            this.transferSend.ButtonText = "ارسال";
            this.transferSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transferSend.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.transferSend.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.transferSend.IdleBorderThickness = 1;
            this.transferSend.IdleCornerRadius = 20;
            this.transferSend.IdleFillColor = System.Drawing.Color.Transparent;
            this.transferSend.IdleForecolor = System.Drawing.SystemColors.ActiveCaptionText;
            this.transferSend.IdleLineColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.transferSend.Location = new System.Drawing.Point(124, 270);
            this.transferSend.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.transferSend.Name = "transferSend";
            this.transferSend.Size = new System.Drawing.Size(142, 52);
            this.transferSend.TabIndex = 20;
            this.transferSend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.transferSend.Click += new System.EventHandler(this.transferSend_MouseClick);
            this.transferSend.MouseClick += new System.Windows.Forms.MouseEventHandler(this.transferSend_MouseClick);
            // 
            // transferUnitCount
            // 
            this.transferUnitCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.transferUnitCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transferUnitCount.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.transferUnitCount.FormattingEnabled = true;
            this.transferUnitCount.Items.AddRange(new object[] {
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.transferUnitCount.Location = new System.Drawing.Point(191, 67);
            this.transferUnitCount.Name = "transferUnitCount";
            this.transferUnitCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.transferUnitCount.Size = new System.Drawing.Size(121, 37);
            this.transferUnitCount.TabIndex = 15;
            // 
            // transferTrmNumber
            // 
            this.transferTrmNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.transferTrmNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transferTrmNumber.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.transferTrmNumber.FormattingEnabled = true;
            this.transferTrmNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.transferTrmNumber.Location = new System.Drawing.Point(690, 67);
            this.transferTrmNumber.Name = "transferTrmNumber";
            this.transferTrmNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.transferTrmNumber.Size = new System.Drawing.Size(121, 37);
            this.transferTrmNumber.TabIndex = 7;
            // 
            // transferDestinationNumber
            // 
            this.transferDestinationNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.transferDestinationNumber.BorderColor = System.Drawing.Color.SeaGreen;
            this.transferDestinationNumber.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.transferDestinationNumber.Location = new System.Drawing.Point(124, 111);
            this.transferDestinationNumber.MaxLength = 10;
            this.transferDestinationNumber.Name = "transferDestinationNumber";
            this.transferDestinationNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.transferDestinationNumber.Size = new System.Drawing.Size(188, 37);
            this.transferDestinationNumber.TabIndex = 17;
            // 
            // transferDestination
            // 
            this.transferDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.transferDestination.BorderColor = System.Drawing.Color.SeaGreen;
            this.transferDestination.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.transferDestination.Location = new System.Drawing.Point(623, 111);
            this.transferDestination.MaxLength = 30;
            this.transferDestination.Name = "transferDestination";
            this.transferDestination.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.transferDestination.Size = new System.Drawing.Size(188, 37);
            this.transferDestination.TabIndex = 16;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(314, 114);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(243, 29);
            this.bunifuCustomLabel6.TabIndex = 8;
            this.bunifuCustomLabel6.Text = "شماره‌ی نامه‌ی موافقت دانشگاه مقصد:";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(314, 71);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(140, 29);
            this.bunifuCustomLabel9.TabIndex = 9;
            this.bunifuCustomLabel9.Text = "تعداد واحد مورد نظر:";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(817, 114);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(100, 29);
            this.bunifuCustomLabel5.TabIndex = 10;
            this.bunifuCustomLabel5.Text = "دانشگاه مقصد:";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(775, 14);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(184, 38);
            this.bunifuCustomLabel7.TabIndex = 11;
            this.bunifuCustomLabel7.Text = "مشخصات درخواست";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(817, 70);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(91, 29);
            this.bunifuCustomLabel8.TabIndex = 12;
            this.bunifuCustomLabel8.Text = "ترم تحصیلی:";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(314, 157);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(224, 29);
            this.bunifuCustomLabel4.TabIndex = 14;
            this.bunifuCustomLabel4.Text = "تاریخ نامه‌ی موافقت دانشگاه مقصد:";
            // 
            // EnteghalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 469);
            this.Controls.Add(this.efPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EnteghalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.efPanel.ResumeLayout(false);
            this.efPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel efPanel;
        private System.Windows.Forms.MaskedTextBox transferDestinationDate;
        private Bunifu.Framework.UI.BunifuThinButton2 transferSend;
        private System.Windows.Forms.ComboBox transferUnitCount;
        private System.Windows.Forms.ComboBox transferTrmNumber;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox transferDestinationNumber;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox transferDestination;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel transferHeader;
        private System.Windows.Forms.Label destDateLabel;
        private System.Windows.Forms.Label destNumberLabel;
        private Bunifu.Framework.UI.BunifuThinButton2 editReject;
    }
}