using System;
using System.Windows.Forms;
using SNMPDeviceInfo.Controllers;
using SNMPDeviceInfo.GUI;

namespace SNMPDeviceInfo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            HostSettingsManager hsm = new HostSettingsManager("hostsettings.xml");

            Application.Run(new frmMainWindow(hsm));
        }
    }
}
