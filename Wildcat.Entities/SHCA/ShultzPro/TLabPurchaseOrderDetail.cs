using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TLabPurchaseOrderDetail
    {
        public Guid SDetailGuid { get; set; }
        public Guid SPoguid { get; set; }
        public int IId { get; set; }
        public int IQty { get; set; }
        public string SOperation { get; set; }
        public string STestLocation { get; set; }
        public string SRequirement { get; set; }
        public decimal? CurUnitPrice { get; set; }
        public decimal? CurExtension { get; set; }
        public bool BFooterLineItem { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TLabPurchaseOrder SPogu { get; set; }
    }
}
