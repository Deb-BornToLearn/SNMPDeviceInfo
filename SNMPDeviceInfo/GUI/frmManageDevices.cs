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
    public partial class frmManageDevices : Form
    {
        HostSettingsManager _hsm;

        public frmManageDevices(HostSettingsManager hsm)
        {
            InitializeComponent();
            _hsm = hsm;
        }
    }
}
