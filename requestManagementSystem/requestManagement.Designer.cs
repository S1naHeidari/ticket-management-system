namespace WindowsFormsApp2
{
    partial class requestManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rmLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.studentRequestManagementDgv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.typeRequest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.requestManagementDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestManagementDataSet = new WindowsFormsApp2.RequestManagementDataSet();
            this.rmPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentRequestManagementDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestManagementDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestManagementDataSet)).BeginInit();
            this.rmPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.rmLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 49);
            this.panel1.TabIndex = 1;
            // 
            // rmLabel
            // 
            this.rmLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rmLabel.AutoSize = true;
            this.rmLabel.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rmLabel.ForeColor = System.Drawing.Color.MintCream;
            this.rmLabel.Location = new System.Drawing.Point(783, 0);
            this.rmLabel.Name = "rmLabel";
            this.rmLabel.Size = new System.Drawing.Size(181, 35);
            this.rmLabel.TabIndex = 1;
            this.rmLabel.Text = "پنل مدیریت درخواست";
            // 
            // studentRequestManagementDgv
            // 
            this.studentRequestManagementDgv.AllowUserToAddRows = false;
            this.studentRequestManagementDgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.studentRequestManagementDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.studentRequestManagementDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentRequestManagementDgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.studentRequestManagementDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentRequestManagementDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentRequestManagementDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.studentRequestManagementDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentRequestManagementDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeRequest,
            this.dateColumn,
            this.status,
            this.editColumn,
            this.deleteColumn});
            this.studentRequestManagementDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentRequestManagementDgv.DoubleBuffered = true;
            this.studentRequestManagementDgv.EnableHeadersVisualStyles = false;
            this.studentRequestManagementDgv.GridColor = System.Drawing.Color.SeaShell;
            this.studentRequestManagementDgv.HeaderBgColor = System.Drawing.Color.CornflowerBlue;
            this.studentRequestManagementDgv.HeaderForeColor = System.Drawing.Color.Black;
            this.studentRequestManagementDgv.Location = new System.Drawing.Point(0, 0);
            this.studentRequestManagementDgv.Margin = new System.Windows.Forms.Padding(3, 40, 3, 60);
            this.studentRequestManagementDgv.Name = "studentRequestManagementDgv";
            this.studentRequestManagementDgv.ReadOnly = true;
            this.studentRequestManagementDgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.studentRequestManagementDgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentRequestManagementDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.studentRequestManagementDgv.RowHeadersWidth = 43;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.studentRequestManagementDgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.studentRequestManagementDgv.RowTemplate.Height = 24;
            this.studentRequestManagementDgv.Size = new System.Drawing.Size(976, 373);
            this.studentRequestManagementDgv.TabIndex = 3;
            this.studentRequestManagementDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick);
            // 
            // typeRequest
            // 
            this.typeRequest.DividerWidth = 2;
            this.typeRequest.FillWeight = 112.5402F;
            this.typeRequest.HeaderText = "نوع درخواست";
            this.typeRequest.Name = "typeRequest";
            this.typeRequest.ReadOnly = true;
            this.typeRequest.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dateColumn
            // 
            this.dateColumn.DividerWidth = 2;
            this.dateColumn.FillWeight = 111.8883F;
            this.dateColumn.HeaderText = "تاریخ درخواست";
            this.dateColumn.Name = "dateColumn";
            this.dateColumn.ReadOnly = true;
            // 
            // status
            // 
            this.status.DividerWidth = 2;
            this.status.FillWeight = 112.4439F;
            this.status.HeaderText = "وضعیت بررسی";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // editColumn
            // 
            this.editColumn.FillWeight = 79.10922F;
            this.editColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editColumn.HeaderText = "";
            this.editColumn.Name = "editColumn";
            this.editColumn.ReadOnly = true;
            this.editColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.editColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.editColumn.Text = "حذف درخواست";
            this.editColumn.UseColumnTextForButtonValue = true;
            // 
            // deleteColumn
            // 
            this.deleteColumn.FillWeight = 84.01834F;
            this.deleteColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteColumn.HeaderText = "";
            this.deleteColumn.Name = "deleteColumn";
            this.deleteColumn.ReadOnly = true;
            this.deleteColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deleteColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.deleteColumn.Text = "ویرایش درخواست";
            this.deleteColumn.UseColumnTextForButtonValue = true;
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
            // rmPanel
            // 
            this.rmPanel.Controls.Add(this.panel2);
            this.rmPanel.Controls.Add(this.panel1);
            this.rmPanel.Location = new System.Drawing.Point(0, 0);
            this.rmPanel.Name = "rmPanel";
            this.rmPanel.Size = new System.Drawing.Size(976, 422);
            this.rmPanel.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.studentRequestManagementDgv);
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(976, 373);
            this.panel2.TabIndex = 4;
            // 
            // requestManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 422);
            this.Controls.Add(this.rmPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "requestManagement";
            this.Text = "requestManagement";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentRequestManagementDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestManagementDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestManagementDataSet)).EndInit();
            this.rmPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid studentRequestManagementDgv;
        private Bunifu.Framework.UI.BunifuCustomLabel rmLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource requestManagementDataSetBindingSource;
        private RequestManagementDataSet requestManagementDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewButtonColumn editColumn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteColumn;
        private System.Windows.Forms.Panel rmPanel;
        private System.Windows.Forms.Panel panel2;
    }
}