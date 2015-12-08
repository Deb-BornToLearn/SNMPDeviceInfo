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

        private void btnSaveAndClose_Click(object sender, EventArgs e)
        {
            if(ValidateTextNotEmpty(txtDisplayName))
            {
                _hsm.Addv12Settings(SNMPConstants.SNMPVersion.v2c, txtIpOrHostname.Text, txtDisplayName.Text, txtReadCommunity.Text, txtWriteCommunity.Text);
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private bool ValidateTextNotEmpty(TextBox c)
        {
            if(String.IsNullOrEmpty(c.Text))
            {
                errProvSNMPSettings.SetError(c, "Value may not be empty.");
                return false;
            }
            else
            {
                errProvSNMPSettings.SetError(c, "");
                return true;
            }
        }

        private bool ValidateFormContents()
        {
            return this.ValidateChildren(ValidationConstraints.ImmediateChildren);
        }

        private void txtIpOrHostname_Validating(object sender, CancelEventArgs e)
        {
            if(!(ValidateTextNotEmpty(txtIpOrHostname))) {
                e.Cancel = true;
            }
        }
    }
}
