using System.Collections.Generic;
using SNMPDeviceInfo.Controllers;

namespace SNMPDeviceInfo
{
    interface ISNMPSessionManager
    {

        bool LoadSettingsByID(string id);

        bool TestConnection(string id);

        ISNMPResult SNMPGet(string oid);

        IEnumerable<ISNMPResult> SNMPWalk(string oid);

        ISNMPTable SNMPGetTable(string oid);


    }
}
