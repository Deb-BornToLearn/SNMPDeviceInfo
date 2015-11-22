using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNMPDeviceInfo
{
    public interface ISNMPHostSettings
    {
        SNMPConstants.SNMPVersion SnmpVersion { get; set; }

        SNMPConstants.v3EncryptionMode SnmpV3EncryptionMode { get; set; }

        string ReadCommunity { get; set; }
        string WriteCommunity { get; set; }

        string IpOrHostname { get; set; }

        string DisplayName { get; set; }

        string Id { get; set; }
    }
}
