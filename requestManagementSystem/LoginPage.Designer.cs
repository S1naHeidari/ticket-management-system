namespace WindowsFormsApp2
{
   
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.resetBtn = new System.Windows.Forms.Button();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtPassword = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtUsername = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rmsLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.minBtn = new System.Windows.Forms.Button();
            this.maxBtn = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.resetBtn);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(54, 51);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 474);
            this.panel1.TabIndex = 0;
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.resetBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.resetBtn.FlatAppearance.BorderSize = 3;
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.resetBtn.ForeColor = System.Drawing.Color.Ivory;
            this.resetBtn.Location = new System.Drawing.Point(323, 387);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(128, 34);
            this.resetBtn.TabIndex = 10;
            this.resetBtn.Text = "شروع مجدد";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(893, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(143, 36);
            this.bunifuCustomLabel1.TabIndex = 6;
            this.bunifuCustomLabel1.Text = "صفحه ورود";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPassword.BackgroundImage")));
            this.txtPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPassword.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtPassword.Icon = ((System.Drawing.Image)(resources.GetObject("txtPassword.Icon")));
            this.txtPassword.Location = new System.Drawing.Point(323, 266);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPassword.Size = new System.Drawing.Size(374, 45);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.text = "گذرواژه";
            this.txtPassword.KeyPress += new System.EventHandler(this.txtPassword_KeyPress);
            this.txtPassword.Load += new System.EventHandler(this.txtPassword_Load);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter_1);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave_1);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtUsername.BackgroundImage")));
            this.txtUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtUsername.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtUsername.Icon = ((System.Drawing.Image)(resources.GetObject("txtUsername.Icon")));
            this.txtUsername.Location = new System.Drawing.Point(323, 202);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUsername.Size = new System.Drawing.Size(374, 45);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.text = "شناسه کاربری ";
            this.txtUsername.Load += new System.EventHandler(this.txtUsername_Load);
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter_1);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave_1);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(323, 322);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(374, 51);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "ورود";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.user1;
            this.pictureBox1.Location = new System.Drawing.Point(420, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1143, 260);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rmsLabel);
            this.panel4.Controls.Add(this.closeBtn);
            this.panel4.Controls.Add(this.minBtn);
            this.panel4.Controls.Add(this.maxBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1143, 35);
            this.panel4.TabIndex = 13;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown_1);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseMove);
            this.panel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseUp);
            // 
            // rmsLabel
            // 
            this.rmsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rmsLabel.AutoSize = true;
            this.rmsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rmsLabel.ForeColor = System.Drawing.Color.Linen;
            this.rmsLabel.Location = new System.Drawing.Point(427, 0);
            this.rmsLabel.Name = "rmsLabel";
            this.rmsLabel.Size = new System.Drawing.Size(291, 29);
            this.rmsLabel.TabIndex = 11;
            this.rmsLabel.Text = "سامانه مدیریت درخواست دانشجویی";
            this.rmsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.closeBtn.Location = new System.Drawing.Point(0, 0);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(46, 33);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Tag = "";
            this.closeBtn.Text = "X";
            this.toolTip1.SetToolTip(this.closeBtn, "خروج");
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click_1);
            this.closeBtn.MouseLeave += new System.EventHandler(this.closeBtn_MouseLeave);
            this.closeBtn.MouseHover += new System.EventHandler(this.closeBtn_MouseHover);
            // 
            // minBtn
            // 
            this.minBtn.BackColor = System.Drawing.Color.Transparent;
            this.minBtn.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.minBtn.FlatAppearance.BorderSize = 0;
            this.minBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.minBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.minBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minBtn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.minBtn.Location = new System.Drawing.Point(87, 0);
            this.minBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(46, 33);
            this.minBtn.TabIndex = 0;
            this.minBtn.Text = "-";
            this.minBtn.UseVisualStyleBackColor = false;
            this.minBtn.Click += new System.EventHandler(this.minBtn_Click);
            // 
            // maxBtn
            // 
            this.maxBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("maxBtn.BackgroundImage")));
            this.maxBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.maxBtn.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.maxBtn.FlatAppearance.BorderSize = 0;
            this.maxBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.maxBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.maxBtn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.maxBtn.Location = new System.Drawing.Point(44, 0);
            this.maxBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maxBtn.Name = "maxBtn";
            this.maxBtn.Size = new System.Drawing.Size(46, 33);
            this.maxBtn.TabIndex = 0;
            this.maxBtn.UseVisualStyleBackColor = true;
            this.maxBtn.Click += new System.EventHandler(this.maxBtn_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // toolTip1
            // 
            this.toolTip1.ForeColor = System.Drawing.Color.Firebrick;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 549);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogin;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button minBtn;
        private System.Windows.Forms.Button maxBtn;
        private System.Windows.Forms.Button resetBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel rmsLabel;
        public Bunifu.Framework.UI.BunifuTextbox txtPassword;
        private Bunifu.Framework.UI.BunifuTextbox txtUsername;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

