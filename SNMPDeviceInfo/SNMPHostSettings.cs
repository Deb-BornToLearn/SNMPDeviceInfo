using System;
using System.Xml.Linq;

namespace SNMPDeviceInfo
{
    class SNMPHostSettings : ISNMPHostSettings
    {
        public string Id { get; set; }

        public string IpOrHostname { get; set; }

        public string DisplayName { get; set; }

        public SNMPConstants.SNMPVersion SnmpVersion { get; set; }

        public string ReadCommunity { get; set; }

        public string WriteCommunity { get; set; }
        
        public SNMPConstants.v3EncryptionMode SnmpV3EncryptionMode { get; set; }

        public SNMPConstants.v3AuthMode SnmpV3AuthMode { get; set; }

        public SNMPConstants.v3PrivMode SnmpV3PrivMode { get; set; }

        public SNMPHostSettings()
        {

        }

        public static SNMPHostSettings fromXElement(XElement el)
        {
            SNMPHostSettings hs = new SNMPHostSettings();

            string dispName = el.Attribute("mnemonic").Value;
            if (String.IsNullOrEmpty(dispName))
                throw new ArgumentException("Missing display name");
            else
                hs.DisplayName = dispName;

            string id = el.Attribute("id").Value;
            if (String.IsNullOrEmpty(id))
                throw new ArgumentException("Missing id");
            else
                hs.Id = id;

            string ipOrHostname = el.Element("IpOrHostname").Value;
            if (String.IsNullOrEmpty(ipOrHostname))
                throw new ArgumentException("Missing IP or Hostname");
            else
                hs.IpOrHostname = ipOrHostname;

            SNMPConstants.SNMPVersion sv;
            if (Enum.TryParse(el.Element("SNMPVersion").Value, true, out sv))
                hs.SnmpVersion = sv;
            else
                throw new ArgumentException("Missing SNMPVersion");

            if (sv == SNMPConstants.SNMPVersion.v3)
            {
                //TODO:Read SNMPv3 information
            }
            else //SNMPConstants.SNMPVersion.v1 or v2c
            {
                XElement v12 = el.Element("v12Settings");
                XElement v12Read = v12.Element("ReadCommunity");
                if (v12Read != null)
                {
                    string read = v12Read.Value;
                    if (String.IsNullOrEmpty(read) == false)
                        hs.ReadCommunity = read;
                    else
                        hs.ReadCommunity = "";
                }
                XElement v12Write = v12.Element("WriteCommunity");
                if (v12Write != null)
                {
                    string write = v12Write.Value;
                    if (String.IsNullOrEmpty(write) == false)
                        hs.WriteCommunity = write;
                    else
                        hs.WriteCommunity = "";
                }                
            }

            return hs;
        }
    }
}
