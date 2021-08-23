namespace WindowsFormsApp2
{
    partial class msgBoxWrong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(msgBoxWrong));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.wronglabel = new System.Windows.Forms.Label();
            this.okbtn2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(176, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // wronglabel
            // 
            this.wronglabel.AutoSize = true;
            this.wronglabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wronglabel.Font = new System.Drawing.Font("2  Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.wronglabel.Location = new System.Drawing.Point(80, 84);
            this.wronglabel.Name = "wronglabel";
            this.wronglabel.Size = new System.Drawing.Size(302, 37);
            this.wronglabel.TabIndex = 2;
            this.wronglabel.Text = "!شناسه کاربری یا رمز عبور اشتباه است";
            this.wronglabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // okbtn2
            // 
            this.okbtn2.Font = new System.Drawing.Font("2  Nazanin", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.okbtn2.ForeColor = System.Drawing.Color.Firebrick;
            this.okbtn2.Location = new System.Drawing.Point(186, 133);
            this.okbtn2.Name = "okbtn2";
            this.okbtn2.Size = new System.Drawing.Size(84, 50);
            this.okbtn2.TabIndex = 3;
            this.okbtn2.Text = "باشه";
            this.okbtn2.UseVisualStyleBackColor = true;
            this.okbtn2.Click += new System.EventHandler(this.okbtn2_Click);
            // 
            // msgBoxWrong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 195);
            this.Controls.Add(this.okbtn2);
            this.Controls.Add(this.wronglabel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "msgBoxWrong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label wronglabel;
        private System.Windows.Forms.Button okbtn2;
    }
}