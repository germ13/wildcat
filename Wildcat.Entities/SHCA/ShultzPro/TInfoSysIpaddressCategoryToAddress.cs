using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TInfoSysIpaddressCategoryToAddress
    {
        public Guid SLinkGuid { get; set; }
        public Guid SIpcategoryGuid { get; set; }
        public Guid SIpaddressGuid { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TInfoSysIpaddress SIpaddressGu { get; set; }
        public TInfoSysIpaddressCategory SIpcategoryGu { get; set; }
    }
}
