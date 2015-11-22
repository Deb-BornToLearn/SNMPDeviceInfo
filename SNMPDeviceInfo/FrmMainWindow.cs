using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SNMPDeviceInfo
{
    public partial class frmMainWindow : Form
    {
        HostSettingsManager _hsm;

        public frmMainWindow(HostSettingsManager hsm)
        {
            InitializeComponent();
            _hsm = hsm;
        }
    }
}
