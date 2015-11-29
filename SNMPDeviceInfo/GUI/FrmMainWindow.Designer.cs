namespace SNMPDeviceInfo.GUI
{
    partial class frmMainWindow
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
            this.tbfResults = new System.Windows.Forms.TabControl();
            this.tabIfInfo = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IfIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IfDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IfType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IfMtu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IfSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IfPhysAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IfAdminStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabRoutingTable = new System.Windows.Forms.TabPage();
            this.tabARPTable = new System.Windows.Forms.TabPage();
            this.cmbDevices = new System.Windows.Forms.ComboBox();
            this.btnNewDevice = new System.Windows.Forms.Button();
            this.btnConnectTelnet = new System.Windows.Forms.Button();
            this.btnConnectSSH = new System.Windows.Forms.Button();
            this.btnManageDevices = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.tbfResults.SuspendLayout();
            this.tabIfInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbfResults
            // 
            this.tbfResults.Controls.Add(this.tabIfInfo);
            this.tbfResults.Controls.Add(this.tabARPTable);
            this.tbfResults.Controls.Add(this.tabRoutingTable);
            this.tbfResults.Location = new System.Drawing.Point(2, 43);
            this.tbfResults.Name = "tbfResults";
            this.tbfResults.SelectedIndex = 0;
            this.tbfResults.Size = new System.Drawing.Size(761, 395);
            this.tbfResults.TabIndex = 0;
            // 
            // tabIfInfo
            // 
            this.tabIfInfo.Controls.Add(this.dataGridView1);
            this.tabIfInfo.Location = new System.Drawing.Point(4, 22);
            this.tabIfInfo.Name = "tabIfInfo";
            this.tabIfInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabIfInfo.Size = new System.Drawing.Size(753, 369);
            this.tabIfInfo.TabIndex = 2;
            this.tabIfInfo.Text = "Interface Info";
            this.tabIfInfo.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IfIndex,
            this.IfDesc,
            this.IfType,
            this.IfMtu,
            this.IfSpeed,
            this.IfPhysAddress,
            this.IfAdminStatus});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(747, 363);
            this.dataGridView1.TabIndex = 0;
            // 
            // IfIndex
            // 
            this.IfIndex.HeaderText = "Index";
            this.IfIndex.Name = "IfIndex";
            this.IfIndex.ReadOnly = true;
            // 
            // IfDesc
            // 
            this.IfDesc.HeaderText = "Description";
            this.IfDesc.Name = "IfDesc";
            this.IfDesc.ReadOnly = true;
            // 
            // IfType
            // 
            this.IfType.HeaderText = "Type";
            this.IfType.Name = "IfType";
            this.IfType.ReadOnly = true;
            // 
            // IfMtu
            // 
            this.IfMtu.HeaderText = "MTU";
            this.IfMtu.Name = "IfMtu";
            this.IfMtu.ReadOnly = true;
            // 
            // IfSpeed
            // 
            this.IfSpeed.HeaderText = "Speed";
            this.IfSpeed.Name = "IfSpeed";
            this.IfSpeed.ReadOnly = true;
            // 
            // IfPhysAddress
            // 
            this.IfPhysAddress.HeaderText = "Phys Address";
            this.IfPhysAddress.Name = "IfPhysAddress";
            this.IfPhysAddress.ReadOnly = true;
            // 
            // IfAdminStatus
            // 
            this.IfAdminStatus.HeaderText = "Admin Status";
            this.IfAdminStatus.Name = "IfAdminStatus";
            this.IfAdminStatus.ReadOnly = true;
            // 
            // tabRoutingTable
            // 
            this.tabRoutingTable.Location = new System.Drawing.Point(4, 22);
            this.tabRoutingTable.Name = "tabRoutingTable";
            this.tabRoutingTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabRoutingTable.Size = new System.Drawing.Size(753, 369);
            this.tabRoutingTable.TabIndex = 0;
            this.tabRoutingTable.Text = "Routing Table";
            this.tabRoutingTable.UseVisualStyleBackColor = true;
            // 
            // tabARPTable
            // 
            this.tabARPTable.Location = new System.Drawing.Point(4, 22);
            this.tabARPTable.Name = "tabARPTable";
            this.tabARPTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabARPTable.Size = new System.Drawing.Size(753, 369);
            this.tabARPTable.TabIndex = 1;
            this.tabARPTable.Text = "ARP Table";
            this.tabARPTable.UseVisualStyleBackColor = true;
            // 
            // cmbDevices
            // 
            this.cmbDevices.FormattingEnabled = true;
            this.cmbDevices.Location = new System.Drawing.Point(6, 12);
            this.cmbDevices.Name = "cmbDevices";
            this.cmbDevices.Size = new System.Drawing.Size(204, 21);
            this.cmbDevices.TabIndex = 1;
            // 
            // btnNewDevice
            // 
            this.btnNewDevice.Location = new System.Drawing.Point(224, 12);
            this.btnNewDevice.Name = "btnNewDevice";
            this.btnNewDevice.Size = new System.Drawing.Size(83, 21);
            this.btnNewDevice.TabIndex = 2;
            this.btnNewDevice.Text = "New Device";
            this.btnNewDevice.UseVisualStyleBackColor = true;
            this.btnNewDevice.Click += new System.EventHandler(this.btnNewDevice_Click);
            // 
            // btnConnectTelnet
            // 
            this.btnConnectTelnet.Location = new System.Drawing.Point(584, 11);
            this.btnConnectTelnet.Name = "btnConnectTelnet";
            this.btnConnectTelnet.Size = new System.Drawing.Size(83, 21);
            this.btnConnectTelnet.TabIndex = 3;
            this.btnConnectTelnet.Text = "Telnet";
            this.btnConnectTelnet.UseVisualStyleBackColor = true;
            // 
            // btnConnectSSH
            // 
            this.btnConnectSSH.Location = new System.Drawing.Point(673, 11);
            this.btnConnectSSH.Name = "btnConnectSSH";
            this.btnConnectSSH.Size = new System.Drawing.Size(83, 21);
            this.btnConnectSSH.TabIndex = 4;
            this.btnConnectSSH.Text = "SSH";
            this.btnConnectSSH.UseVisualStyleBackColor = true;
            // 
            // btnManageDevices
            // 
            this.btnManageDevices.Location = new System.Drawing.Point(313, 12);
            this.btnManageDevices.Name = "btnManageDevices";
            this.btnManageDevices.Size = new System.Drawing.Size(104, 21);
            this.btnManageDevices.TabIndex = 5;
            this.btnManageDevices.Text = "Manage Devices";
            this.btnManageDevices.UseVisualStyleBackColor = true;
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(463, 11);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(83, 21);
            this.btnOptions.TabIndex = 6;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnManageDevices);
            this.Controls.Add(this.btnConnectSSH);
            this.Controls.Add(this.btnConnectTelnet);
            this.Controls.Add(this.btnNewDevice);
            this.Controls.Add(this.cmbDevices);
            this.Controls.Add(this.tbfResults);
            this.Name = "frmMainWindow";
            this.Text = "SNMP Device Info";
            this.tbfResults.ResumeLayout(false);
            this.tabIfInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbfResults;
        private System.Windows.Forms.TabPage tabIfInfo;
        private System.Windows.Forms.TabPage tabRoutingTable;
        private System.Windows.Forms.TabPage tabARPTable;
        private System.Windows.Forms.ComboBox cmbDevices;
        private System.Windows.Forms.Button btnNewDevice;
        private System.Windows.Forms.Button btnConnectTelnet;
        private System.Windows.Forms.Button btnConnectSSH;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IfIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn IfDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IfType;
        private System.Windows.Forms.DataGridViewTextBoxColumn IfMtu;
        private System.Windows.Forms.DataGridViewTextBoxColumn IfSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn IfPhysAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn IfAdminStatus;
        private System.Windows.Forms.Button btnManageDevices;
        private System.Windows.Forms.Button btnOptions;
    }
}

