using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SNMPDeviceInfo.Controllers;

namespace SNMPDeviceInfo.GUI
{
    public partial class frmSNMPSettings : Form
    {

        HostSettingsManager _hsm;

        public frmSNMPSettings(HostSettingsManager hsm)
        {
            _hsm = hsm;
            InitializeComponent();
        }

        private void frmSNMPSettings_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _hsm.Addv12Settings(SNMPConstants.SNMPVersion.v2c, txtIpOrHostname.Text, txtDisplayName.Text, txtReadCommunity.Text, txtWriteCommunity.Text);
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
