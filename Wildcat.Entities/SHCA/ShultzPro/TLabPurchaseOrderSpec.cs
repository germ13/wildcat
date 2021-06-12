using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TLabPurchaseOrderSpec
    {
        public Guid SSpecGuid { get; set; }
        public Guid SPoguid { get; set; }
        public string SSpecification { get; set; }
        public int ISortOrder { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TLabPurchaseOrder SPogu { get; set; }
    }
}
