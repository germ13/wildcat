using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TLabPurchaseOrderHistory
    {
        public Guid SLabPurchaseOrderHistoryGuid { get; set; }
        public Guid SPoguid { get; set; }
        public string SAction { get; set; }
        public Guid SUserGuid { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TLabPurchaseOrder SPogu { get; set; }
    }
}
