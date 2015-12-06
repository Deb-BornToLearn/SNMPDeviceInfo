using System.Collections.Generic;
using System.ComponentModel;
using System.Collections.Specialized;
using System.Xml;
using System.Xml.Linq;
using System;
using System.Linq;
using System.Collections;

namespace SNMPDeviceInfo.Controllers
{
    public class HostSettingsManager : IListSource
    {
        #region Members
        private BindingList<SNMPHostSettings> hostSettings;

        #endregion Members

        #region Constructors

        public HostSettingsManager()
        {
            hostSettings = new BindingList<SNMPHostSettings>();
        }

        public HostSettingsManager(string hostSettingsFile)
        {
            hostSettings = new BindingList<SNMPHostSettings>();
            LoadSettingsFromXMLFile(hostSettingsFile);
        }

        #endregion Constructors

        public ISNMPHostSettings Addv12Settings(SNMPConstants.SNMPVersion version, string ipOrHostname, string dispName, string readCommunity, string writeCommunity)
        {
            SNMPHostSettings hs = new SNMPHostSettings();
            hs.IpOrHostname = ipOrHostname;
            hs.SnmpVersion = version;
            hs.DisplayName = dispName;
            hs.ReadCommunity = readCommunity;
            hs.WriteCommunity = writeCommunity;
            string id = Guid.NewGuid().ToString();

            hostSettings.Add(hs);

            return hs;
        }

        public ISNMPHostSettings Addv3Settings(string ipOrHostname, string dispName, SNMPConstants.v3EncryptionMode USMmode, SNMPConstants.v3AuthMode authMode, string authKey, SNMPConstants.v3PrivMode privMode, string privKey)
        {
            SNMPHostSettings hs = new SNMPHostSettings();

            hs.IpOrHostname = ipOrHostname;
            hs.SnmpVersion = SNMPConstants.SNMPVersion.v3;
            hs.DisplayName = dispName;
            hs.SnmpV3EncryptionMode = USMmode;
            hs.SnmpV3AuthMode = authMode;
            hs.SnmpV3PrivMode = privMode;

            hostSettings.Add(hs);

            return hs;
        }

        public void LoadSettingsFromXMLFile(string hostSettingsFile)
        {
            XmlReaderSettings xmlsettings = new XmlReaderSettings();
            xmlsettings.IgnoreWhitespace = true;

            using (XmlReader reader = XmlReader.Create(hostSettingsFile, xmlsettings))
            {
                reader.MoveToContent();

                reader.ReadStartElement("SNMPHostSettings");

                while (reader.Name == "Host")
                {
                    XElement el = (XElement)XNode.ReadFrom(reader);
                    SNMPHostSettings hs = SNMPHostSettings.fromXElement(el);
                    hostSettings.Add(hs);
                }

                reader.ReadEndElement();
            }
        }

        public IList GetList()
        {
            return hostSettings;
        }

        public bool ContainsListCollection
        {
            get
            {
                return false;
            }
        }
    }
}
