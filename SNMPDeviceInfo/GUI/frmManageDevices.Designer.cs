namespace SNMPDeviceInfo.GUI
{
    partial class frmManageDevices
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtDisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIpOrHostname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnkDeleteDevice = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.txtDisplayName,
            this.txtIpOrHostname,
            this.lnkDeleteDevice});
            this.dataGridView1.Location = new System.Drawing.Point(0, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(504, 266);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Selected";
            this.Column1.Name = "Column1";
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.HeaderText = "Display Name";
            this.txtDisplayName.Name = "txtDisplayName";
            // 
            // txtIpOrHostname
            // 
            this.txtIpOrHostname.HeaderText = "IP or Hostname";
            this.txtIpOrHostname.Name = "txtIpOrHostname";
            this.txtIpOrHostname.Width = 200;
            // 
            // lnkDeleteDevice
            // 
            this.lnkDeleteDevice.HeaderText = "Click to remove";
            this.lnkDeleteDevice.Name = "lnkDeleteDevice";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(347, 303);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(132, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(28, 303);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // frmManageDevices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 332);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmManageDevices";
            this.Text = "frmManageDevices";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDisplayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtIpOrHostname;
        private System.Windows.Forms.DataGridViewLinkColumn lnkDeleteDevice;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
    }
}