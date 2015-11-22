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
                string read = el.Element("SNMPReadCommunity").Value;
                string write = el.Element("SNMPWriteCommunity").Value;

                if (String.IsNullOrEmpty(read) == false)
                    hs.ReadCommunity = read;
                else
                    hs.ReadCommunity = "";

                if (String.IsNullOrEmpty(write) == false)
                    hs.WriteCommunity = write;
                else
                    hs.WriteCommunity = "";
            }

            return hs;
        }
    }
}
