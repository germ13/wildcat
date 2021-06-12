using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TInfoSysIpaddress
    {
        public TInfoSysIpaddress()
        {
            TInfoSysIpaddressCategoryToAddress = new HashSet<TInfoSysIpaddressCategoryToAddress>();
            TInfoSysIpaddressChange = new HashSet<TInfoSysIpaddressChange>();
        }

        public Guid SIpaddressGuid { get; set; }
        public byte IOctet1 { get; set; }
        public byte IOctet2 { get; set; }
        public byte IOctet3 { get; set; }
        public byte IOctet4 { get; set; }
        public string SIpaddress { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TInfoSysIpaddressCategoryToAddress> TInfoSysIpaddressCategoryToAddress { get; set; }
        public ICollection<TInfoSysIpaddressChange> TInfoSysIpaddressChange { get; set; }
    }
}
