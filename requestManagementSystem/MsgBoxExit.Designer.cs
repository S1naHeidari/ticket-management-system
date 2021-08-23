namespace WindowsFormsApp2
{
    partial class MsgBoxExit
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
            this.exitLabel.Font = new System.Drawing.Font("2  Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.exitLabel.Location = new System.Drawing.Point(124, 28);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(224, 38);
            this.exitLabel.TabIndex = 0;
            this.exitLabel.Text = "آیا مایل به خروج هستید؟";
            this.exitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_YES
            // 
            this.btn_YES.ForeColor = System.Drawing.Color.Red;
            this.btn_YES.Location = new System.Drawing.Point(252, 84);
            this.btn_YES.Name = "btn_YES";
            this.btn_YES.Size = new System.Drawing.Size(96, 37);
            this.btn_YES.TabIndex = 1;
            this.btn_YES.Text = "بله";
            this.btn_YES.UseVisualStyleBackColor = true;
            this.btn_YES.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_NO
            // 
            this.btn_NO.Location = new System.Drawing.Point(119, 84);
            this.btn_NO.Name = "btn_NO";
            this.btn_NO.Size = new System.Drawing.Size(97, 37);
            this.btn_NO.TabIndex = 2;
            this.btn_NO.Text = "خیر";
            this.btn_NO.UseVisualStyleBackColor = true;
            this.btn_NO.Click += new System.EventHandler(this.btn_NO_Click);
            // 
            // MsgBoxExit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 168);
            this.Controls.Add(this.btn_NO);
            this.Controls.Add(this.btn_YES);
            this.Controls.Add(this.exitLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MsgBoxExit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Button btn_YES;
        private System.Windows.Forms.Button btn_NO;
    }
}