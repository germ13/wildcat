using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TMetal
    {
        public TMetal()
        {
            TLabPurchaseOrder = new HashSet<TLabPurchaseOrder>();
        }

        public Guid SMetalGuid { get; set; }
        public string SMetalName { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TLabPurchaseOrder> TLabPurchaseOrder { get; set; }
    }
}
