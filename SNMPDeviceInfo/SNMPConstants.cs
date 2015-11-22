using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNMPDeviceInfo
{
    public class SNMPConstants
    {
        public enum SNMPVersion
        {
            v1 = 0,
            v2c,
            v3
        }

        public enum v3EncryptionMode
        {
            NoAuthNoPriv = 0,
            AuthNoPriv,
            AuthPriv
        }
    }
}
