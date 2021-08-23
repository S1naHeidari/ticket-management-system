namespace WindowsFormsApp2
{
    partial class editWasSuccessful
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
            this.success_NO = new System.Windows.Forms.Button();
            this.success_YES = new System.Windows.Forms.Button();
            this.exitLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // success_NO
            // 
            this.success_NO.ForeColor = System.Drawing.Color.DarkBlue;
            this.success_NO.Location = new System.Drawing.Point(97, 113);
            this.success_NO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.success_NO.Name = "success_NO";
            this.success_NO.Size = new System.Drawing.Size(86, 30);
            this.success_NO.TabIndex = 6;
            this.success_NO.Text = "خیر";
            this.success_NO.UseVisualStyleBackColor = true;
            // 
            // success_YES
            // 
            this.success_YES.ForeColor = System.Drawing.Color.Crimson;
            this.success_YES.Location = new System.Drawing.Point(208, 113);
            this.success_YES.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.success_YES.Name = "success_YES";
            this.success_YES.Size = new System.Drawing.Size(85, 30);
            this.success_YES.TabIndex = 5;
            this.success_YES.Text = "بله";
            this.success_YES.UseVisualStyleBackColor = true;
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.exitLabel.Location = new System.Drawing.Point(18, 17);
            this.exitLabel.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Padding = new System.Windows.Forms.Padding(44, 40, 44, 40);
            this.exitLabel.Size = new System.Drawing.Size(357, 105);
            this.exitLabel.TabIndex = 4;
            this.exitLabel.Text = "آیا با اعمال تغییرات موافق هستید؟";
            this.exitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editWasSuccessful
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 199);
            this.Controls.Add(this.success_NO);
            this.Controls.Add(this.success_YES);
            this.Controls.Add(this.exitLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "editWasSuccessful";
            this.Text = "editWasSuccessful";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button success_NO;
        private System.Windows.Forms.Button success_YES;
        private System.Windows.Forms.Label exitLabel;
    }
}