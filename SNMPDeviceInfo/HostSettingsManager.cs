using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNMPDeviceInfo
{
    public class HostSettingsManager
    {
        List<SNMPHostSettings> hostSettings;

        public HostSettingsManager()
        {

        }

        public HostSettingsManager(string hostSsettingsFile)
        {
            using (XmlReader reader = XmlReader.Create(hostSsettingsFile))
            {
                reader.ReadStartElement("SNMPHostSettings");

                while (reader.Name == "Host")
                {
                    XElement el = (XElement)XNode.ReadFrom(reader);
                    hostSettings.Add(SNMPHostSettings.fromXElement(el));
                }

                reader.ReadEndElement();
            }
        }

        public IEnumerable<ISNMPHostSettings> getSettings()
        {
            return hostSettings;
        }
    }
}
