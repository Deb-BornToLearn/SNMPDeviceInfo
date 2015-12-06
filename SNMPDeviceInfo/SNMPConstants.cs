
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

        public enum v3AuthMode
        {
            MD5 = 0,
            SHA1
        }

        public enum v3PrivMode
        {
            DES = 0,
            AES
        }
    }
}
