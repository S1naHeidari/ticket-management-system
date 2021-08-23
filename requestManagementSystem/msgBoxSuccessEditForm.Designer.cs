namespace WindowsFormsApp2
{
    partial class msgBoxEditOK
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
            this.SuspendLayout();
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.exitLabel.ForeColor = System.Drawing.Color.Green;
            this.exitLabel.Location = new System.Drawing.Point(23, 7);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Padding = new System.Windows.Forms.Padding(44, 40, 44, 40);
            this.exitLabel.Size = new System.Drawing.Size(364, 105);
            this.exitLabel.TabIndex = 4;
            this.exitLabel.Text = "!عملیات ویرایش با موفقیت انجام شد";
            this.exitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // msgBoxEditOK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(416, 134);
            this.Controls.Add(this.exitLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "msgBoxEditOK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label exitLabel;
    }
}