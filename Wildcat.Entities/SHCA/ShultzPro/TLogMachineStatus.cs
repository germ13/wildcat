using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TLogMachineStatus
    {
        public Guid SMachineStatusGuid { get; set; }
        public string SAction { get; set; }
        public string SActionType { get; set; }
        public string SObjectName { get; set; }
        public DateTime DtLogged { get; set; }
        public string SDesc { get; set; }
        public string SUserName { get; set; }
        public string SObjectXml { get; set; }
        public Guid? SObjectGuid { get; set; }
        public string SMachineName { get; set; }
        public string SMachineIp { get; set; }
        public int? IMachinePort { get; set; }
        public string SAppVersion { get; set; }
    }
}
