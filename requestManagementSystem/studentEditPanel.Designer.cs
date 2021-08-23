namespace WindowsFormsApp2
{
    partial class studentEditPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentEditPanel));
            this.editPanel = new System.Windows.Forms.Panel();
            this.editPassword = new System.Windows.Forms.Label();
            this.editEduFieldLabel = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.submitBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.confirmPassTB = new System.Windows.Forms.TextBox();
            this.passTB = new System.Windows.Forms.TextBox();
            this.editPhoneMasked = new System.Windows.Forms.MaskedTextBox();
            this.editBirthday = new System.Windows.Forms.MaskedTextBox();
            this.fatherNameTB = new System.Windows.Forms.TextBox();
            this.educationFieldTB = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.fatherNameLabel = new System.Windows.Forms.Label();
            this.educationFieldLabel = new System.Windows.Forms.Label();
            this.confirmPassLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.editPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // editPanel
            // 
            this.editPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editPanel.Controls.Add(this.editPassword);
            this.editPanel.Controls.Add(this.editEduFieldLabel);
            this.editPanel.Controls.Add(this.headerPanel);
            this.editPanel.Controls.Add(this.submitBtn);
            this.editPanel.Controls.Add(this.label17);
            this.editPanel.Controls.Add(this.label16);
            this.editPanel.Controls.Add(this.confirmPassTB);
            this.editPanel.Controls.Add(this.passTB);
            this.editPanel.Controls.Add(this.editPhoneMasked);
            this.editPanel.Controls.Add(this.editBirthday);
            this.editPanel.Controls.Add(this.fatherNameTB);
            this.editPanel.Controls.Add(this.educationFieldTB);
            this.editPanel.Controls.Add(this.label15);
            this.editPanel.Controls.Add(this.fatherNameLabel);
            this.editPanel.Controls.Add(this.educationFieldLabel);
            this.editPanel.Controls.Add(this.confirmPassLabel);
            this.editPanel.Controls.Add(this.passLabel);
            this.editPanel.Controls.Add(this.birthdayLabel);
            this.editPanel.Controls.Add(this.label5);
            this.editPanel.Controls.Add(this.phoneNumberLabel);
            this.editPanel.Location = new System.Drawing.Point(0, 0);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(1183, 490);
            this.editPanel.TabIndex = 68;
            // 
            // editPassword
            // 
            this.editPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editPassword.AutoSize = true;
            this.editPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPassword.ForeColor = System.Drawing.Color.OrangeRed;
            this.editPassword.Location = new System.Drawing.Point(641, 306);
            this.editPassword.Name = "editPassword";
            this.editPassword.Size = new System.Drawing.Size(24, 29);
            this.editPassword.TabIndex = 89;
            this.editPassword.Text = "*";
            this.editPassword.Visible = false;
            this.editPassword.MouseHover += new System.EventHandler(this.editPassword_MouseHover);
            // 
            // editEduFieldLabel
            // 
            this.editEduFieldLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editEduFieldLabel.AutoSize = true;
            this.editEduFieldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editEduFieldLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.editEduFieldLabel.Location = new System.Drawing.Point(455, 172);
            this.editEduFieldLabel.Name = "editEduFieldLabel";
            this.editEduFieldLabel.Size = new System.Drawing.Size(24, 29);
            this.editEduFieldLabel.TabIndex = 89;
            this.editEduFieldLabel.Text = "*";
            this.editEduFieldLabel.Visible = false;
            this.editEduFieldLabel.MouseHover += new System.EventHandler(this.editEduFieldLabel_MouseHover);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.DarkBlue;
            this.headerPanel.Controls.Add(this.bunifuCustomLabel1);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1183, 49);
            this.headerPanel.TabIndex = 88;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.MintCream;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(990, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(181, 35);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "ویرایش حساب کاربری";
            // 
            // submitBtn
            // 
            this.submitBtn.ActiveBorderThickness = 1;
            this.submitBtn.ActiveCornerRadius = 20;
            this.submitBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.submitBtn.ActiveForecolor = System.Drawing.Color.White;
            this.submitBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.submitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.submitBtn.BackColor = System.Drawing.SystemColors.Control;
            this.submitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("submitBtn.BackgroundImage")));
            this.submitBtn.ButtonText = "ثبت ویرایش ";
            this.submitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitBtn.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.submitBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.submitBtn.IdleBorderThickness = 1;
            this.submitBtn.IdleCornerRadius = 20;
            this.submitBtn.IdleFillColor = System.Drawing.Color.Transparent;
            this.submitBtn.IdleForecolor = System.Drawing.SystemColors.ActiveCaptionText;
            this.submitBtn.IdleLineColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.submitBtn.Location = new System.Drawing.Point(284, 400);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(142, 52);
            this.submitBtn.TabIndex = 86;
            this.submitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label17.Location = new System.Drawing.Point(242, 388);
            this.label17.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(919, 2);
            this.label17.TabIndex = 85;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label16.Location = new System.Drawing.Point(242, 248);
            this.label16.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(919, 2);
            this.label16.TabIndex = 84;
            // 
            // confirmPassTB
            // 
            this.confirmPassTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmPassTB.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.confirmPassTB.Location = new System.Drawing.Point(674, 341);
            this.confirmPassTB.MaxLength = 63;
            this.confirmPassTB.Name = "confirmPassTB";
            this.confirmPassTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.confirmPassTB.Size = new System.Drawing.Size(316, 32);
            this.confirmPassTB.TabIndex = 83;
            // 
            // passTB
            // 
            this.passTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passTB.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.passTB.Location = new System.Drawing.Point(674, 303);
            this.passTB.MaxLength = 63;
            this.passTB.Name = "passTB";
            this.passTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.passTB.Size = new System.Drawing.Size(316, 32);
            this.passTB.TabIndex = 82;
            // 
            // editPhoneMasked
            // 
            this.editPhoneMasked.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editPhoneMasked.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.editPhoneMasked.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.editPhoneMasked.Location = new System.Drawing.Point(814, 164);
            this.editPhoneMasked.Mask = "000-00000000";
            this.editPhoneMasked.Name = "editPhoneMasked";
            this.editPhoneMasked.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.editPhoneMasked.Size = new System.Drawing.Size(180, 37);
            this.editPhoneMasked.TabIndex = 81;
            this.editPhoneMasked.MouseClick += new System.Windows.Forms.MouseEventHandler(this.editPhoneMasked_MouseClick);
            // 
            // editBirthday
            // 
            this.editBirthday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editBirthday.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.editBirthday.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.editBirthday.Location = new System.Drawing.Point(814, 125);
            this.editBirthday.Mask = "0000-00-00";
            this.editBirthday.Name = "editBirthday";
            this.editBirthday.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.editBirthday.Size = new System.Drawing.Size(180, 37);
            this.editBirthday.TabIndex = 81;
            this.editBirthday.MouseClick += new System.Windows.Forms.MouseEventHandler(this.editBirthday_MouseClick);
            // 
            // fatherNameTB
            // 
            this.fatherNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fatherNameTB.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.fatherNameTB.Location = new System.Drawing.Point(485, 127);
            this.fatherNameTB.MaxLength = 50;
            this.fatherNameTB.Name = "fatherNameTB";
            this.fatherNameTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fatherNameTB.Size = new System.Drawing.Size(180, 32);
            this.fatherNameTB.TabIndex = 77;
            // 
            // educationFieldTB
            // 
            this.educationFieldTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.educationFieldTB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.educationFieldTB.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.educationFieldTB.FormattingEnabled = true;
            this.educationFieldTB.IntegralHeight = false;
            this.educationFieldTB.Items.AddRange(new object[] {
            "دیپلم",
            "لیسانس",
            "فوق‌لیسانس",
            "دکتری",
            "فوق دکتری"});
            this.educationFieldTB.Location = new System.Drawing.Point(485, 164);
            this.educationFieldTB.Name = "educationFieldTB";
            this.educationFieldTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.educationFieldTB.Size = new System.Drawing.Size(180, 37);
            this.educationFieldTB.TabIndex = 76;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("B Koodak", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label15.Location = new System.Drawing.Point(994, 87);
            this.label15.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(147, 42);
            this.label15.TabIndex = 75;
            this.label15.Text = "مشخصات فردی";
            // 
            // fatherNameLabel
            // 
            this.fatherNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fatherNameLabel.AutoSize = true;
            this.fatherNameLabel.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.fatherNameLabel.Location = new System.Drawing.Point(669, 127);
            this.fatherNameLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fatherNameLabel.Name = "fatherNameLabel";
            this.fatherNameLabel.Size = new System.Drawing.Size(56, 29);
            this.fatherNameLabel.TabIndex = 74;
            this.fatherNameLabel.Text = ":نام پدر";
            // 
            // educationFieldLabel
            // 
            this.educationFieldLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.educationFieldLabel.AutoSize = true;
            this.educationFieldLabel.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.educationFieldLabel.Location = new System.Drawing.Point(669, 167);
            this.educationFieldLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.educationFieldLabel.Name = "educationFieldLabel";
            this.educationFieldLabel.Size = new System.Drawing.Size(105, 29);
            this.educationFieldLabel.TabIndex = 73;
            this.educationFieldLabel.Text = ":مقطع تحصیلی";
            // 
            // confirmPassLabel
            // 
            this.confirmPassLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmPassLabel.AutoSize = true;
            this.confirmPassLabel.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.confirmPassLabel.Location = new System.Drawing.Point(996, 342);
            this.confirmPassLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.confirmPassLabel.Name = "confirmPassLabel";
            this.confirmPassLabel.Size = new System.Drawing.Size(129, 29);
            this.confirmPassLabel.TabIndex = 72;
            this.confirmPassLabel.Text = ":تایید گذرواژه جدید";
            // 
            // passLabel
            // 
            this.passLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.passLabel.Location = new System.Drawing.Point(996, 304);
            this.passLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(96, 29);
            this.passLabel.TabIndex = 71;
            this.passLabel.Text = ":گذرواژه جدید";
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.birthdayLabel.Location = new System.Drawing.Point(999, 128);
            this.birthdayLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(75, 29);
            this.birthdayLabel.TabIndex = 70;
            this.birthdayLabel.Text = ":تاریخ تولد";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Koodak", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(996, 257);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 42);
            this.label5.TabIndex = 68;
            this.label5.Text = "تغییر گذرواژه";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.phoneNumberLabel.Location = new System.Drawing.Point(999, 164);
            this.phoneNumberLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(169, 29);
            this.phoneNumberLabel.TabIndex = 67;
            this.phoneNumberLabel.Text = ":شماره تلفن محل سکونت";
            // 
            // studentEditPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 490);
            this.Controls.Add(this.editPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "studentEditPanel";
            this.Text = "studentEditPanel";
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel editPanel;
        private Bunifu.Framework.UI.BunifuThinButton2 submitBtn;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox confirmPassTB;
        private System.Windows.Forms.TextBox passTB;
        private System.Windows.Forms.MaskedTextBox editPhoneMasked;
        private System.Windows.Forms.MaskedTextBox editBirthday;
        private System.Windows.Forms.TextBox fatherNameTB;
        private System.Windows.Forms.ComboBox educationFieldTB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label fatherNameLabel;
        private System.Windows.Forms.Label educationFieldLabel;
        private System.Windows.Forms.Label confirmPassLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Panel headerPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Label editEduFieldLabel;
        private System.Windows.Forms.Label editPassword;
    }
}