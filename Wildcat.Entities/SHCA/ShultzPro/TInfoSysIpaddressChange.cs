using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TInfoSysIpaddressChange
    {
        public Guid SIplogGuid { get; set; }
        public Guid SIpaddressGuid { get; set; }
        public DateTime DtTransaction { get; set; }
        public string SMachineName { get; set; }
        public string SExtDesc { get; set; }
        public string SBackupIp { get; set; }
        public string SReasonForChange { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TInfoSysIpaddress SIpaddressGu { get; set; }
    }
}
