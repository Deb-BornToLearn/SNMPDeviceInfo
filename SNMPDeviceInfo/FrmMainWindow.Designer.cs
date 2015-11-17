namespace SNMPDeviceInfo
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabRoutingTable = new System.Windows.Forms.TabPage();
            this.tabARPTable = new System.Windows.Forms.TabPage();
            this.tabIfInfo = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IfIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IfDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IfType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IfMtu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IfSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IfPhysAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IfAdminStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabIfInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabIfInfo);
            this.tabControl1.Controls.Add(this.tabRoutingTable);
            this.tabControl1.Controls.Add(this.tabARPTable);
            this.tabControl1.Location = new System.Drawing.Point(2, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(761, 395);
            this.tabControl1.TabIndex = 0;
            // 
            // tabRoutingTable
            // 
            this.tabRoutingTable.Location = new System.Drawing.Point(4, 22);
            this.tabRoutingTable.Name = "tabRoutingTable";
            this.tabRoutingTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabRoutingTable.Size = new System.Drawing.Size(753, 369);
            this.tabRoutingTable.TabIndex = 0;
            this.tabRoutingTable.Text = "ARP Table";
            this.tabRoutingTable.UseVisualStyleBackColor = true;
            // 
            // tabARPTable
            // 
            this.tabARPTable.Location = new System.Drawing.Point(4, 22);
            this.tabARPTable.Name = "tabARPTable";
            this.tabARPTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabARPTable.Size = new System.Drawing.Size(753, 369);
            this.tabARPTable.TabIndex = 1;
            this.tabARPTable.Text = "Routing Table";
            this.tabARPTable.UseVisualStyleBackColor = true;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 21);
            this.button1.TabIndex = 2;
            this.button1.Text = "New Device";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(584, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 21);
            this.button2.TabIndex = 3;
            this.button2.Text = "Telnet";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(673, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 21);
            this.button3.TabIndex = 4;
            this.button3.Text = "SSH";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMainWindow";
            this.Text = "SNMP Device Info";
            this.tabControl1.ResumeLayout(false);
            this.tabIfInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabIfInfo;
        private System.Windows.Forms.TabPage tabRoutingTable;
        private System.Windows.Forms.TabPage tabARPTable;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IfIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn IfDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IfType;
        private System.Windows.Forms.DataGridViewTextBoxColumn IfMtu;
        private System.Windows.Forms.DataGridViewTextBoxColumn IfSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn IfPhysAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn IfAdminStatus;
    }
}

