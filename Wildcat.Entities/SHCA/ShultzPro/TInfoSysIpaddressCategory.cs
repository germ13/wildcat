using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TInfoSysIpaddressCategory
    {
        public TInfoSysIpaddressCategory()
        {
            TInfoSysIpaddressCategoryToAddress = new HashSet<TInfoSysIpaddressCategoryToAddress>();
        }

        public Guid SIpcategoryGuid { get; set; }
        public string SCategory { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TInfoSysIpaddressCategoryToAddress> TInfoSysIpaddressCategoryToAddress { get; set; }
    }
}
