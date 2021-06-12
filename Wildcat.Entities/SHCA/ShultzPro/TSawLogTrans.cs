using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TSawLogTrans
    {
        public Guid SLogGuid { get; set; }
        public string SAction { get; set; }
        public string SActionType { get; set; }
        public string SObjectName { get; set; }
        public DateTime DtLogged { get; set; }
        public string SDesc { get; set; }
        public string SUserName { get; set; }
        public string SAppVersion { get; set; }
        public string SMachineName { get; set; }
        public string SObjectXml { get; set; }
    }
}
