using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TP2opo
    {
        public int IRecId { get; set; }
        public string SKey { get; set; }
        public string SInventoryKey { get; set; }
        public string SPurchaseOrderNumber { get; set; }
        public string SAbbreviatedProducerName { get; set; }
        public int? IWeightOnOrder { get; set; }
        public decimal? DblUnitCost { get; set; }
        public int? ICostCode { get; set; }
        public int? IVendorNumber { get; set; }
        public string SOpen01 { get; set; }
        public string SConfirming { get; set; }
        public string SMillNumber { get; set; }
        public string SOpen02 { get; set; }
        public string SPurchaseOrder { get; set; }
        public string SDeliveryRequested { get; set; }
        public string SEta { get; set; }
        public string SShipped { get; set; }
        public string SOpen03 { get; set; }
        public string SOpen04 { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
