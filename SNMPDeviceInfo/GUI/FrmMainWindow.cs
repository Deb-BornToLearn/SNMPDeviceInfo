using System;
using System.Windows.Forms;
using SNMPDeviceInfo.Controllers;

namespace SNMPDeviceInfo.GUI
{
    public partial class frmMainWindow : Form
    {
        public HostSettingsManager _hsm;

        public frmMainWindow(HostSettingsManager hsm)
        {
            InitializeComponent();
            _hsm = hsm;

            cmbDevices.DisplayMember = "DisplayName";
            cmbDevices.ValueMember = "Id";
            cmbDevices.DataSource = _hsm;
        }

        private void btnNewDevice_Click(object sender, EventArgs e)
        {
            frmSNMPSettings formSettings = new frmSNMPSettings(_hsm);
            formSettings.ShowDialog();
        }

        private void btnManageDevices_Click(object sender, EventArgs e)
        {
            frmManageDevices frmManage = new frmManageDevices(_hsm);
            frmManage.ShowDialog();
        }
    }
}
