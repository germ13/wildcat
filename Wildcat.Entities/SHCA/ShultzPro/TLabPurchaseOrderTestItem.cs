using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TLabPurchaseOrderTestItem
    {
        public Guid STestItemGuid { get; set; }
        public Guid SPoguid { get; set; }
        public int IId { get; set; }
        public string SSerialNum { get; set; }
        public string SHeatNum { get; set; }
        public string SProducer { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TLabPurchaseOrder SPogu { get; set; }
    }
}
