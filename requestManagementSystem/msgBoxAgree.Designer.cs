namespace WindowsFormsApp2
{
    partial class msgBoxAgree
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
            this.exitLabel = new System.Windows.Forms.Label();
            this.btn_YES = new System.Windows.Forms.Button();
            this.btn_NO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.exitLabel.Location = new System.Drawing.Point(28, 9);
            this.exitLabel.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Padding = new System.Windows.Forms.Padding(44, 40, 44, 40);
            this.exitLabel.Size = new System.Drawing.Size(357, 105);
            this.exitLabel.TabIndex = 1;
            this.exitLabel.Text = "آیا با اعمال تغییرات موافق هستید؟";
            this.exitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_YES
            // 
            this.btn_YES.ForeColor = System.Drawing.Color.Crimson;
            this.btn_YES.Location = new System.Drawing.Point(218, 90);
            this.btn_YES.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_YES.Name = "btn_YES";
            this.btn_YES.Size = new System.Drawing.Size(85, 30);
            this.btn_YES.TabIndex = 2;
            this.btn_YES.Text = "بله";
            this.btn_YES.UseVisualStyleBackColor = true;
            // 
            // btn_NO
            // 
            this.btn_NO.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_NO.Location = new System.Drawing.Point(107, 90);
            this.btn_NO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_NO.Name = "btn_NO";
            this.btn_NO.Size = new System.Drawing.Size(86, 30);
            this.btn_NO.TabIndex = 3;
            this.btn_NO.Text = "خیر";
            this.btn_NO.UseVisualStyleBackColor = true;
            // 
            // msgBoxAgree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(416, 134);
            this.Controls.Add(this.btn_NO);
            this.Controls.Add(this.btn_YES);
            this.Controls.Add(this.exitLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "msgBoxAgree";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "msgBoxAgree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Button btn_YES;
        private System.Windows.Forms.Button btn_NO;
    }
}