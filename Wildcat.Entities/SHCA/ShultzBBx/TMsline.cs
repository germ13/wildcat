using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TMsline
    {
        public int IRecId { get; set; }
        public string SKey { get; set; }
        public string SOrderNumber { get; set; }
        public int? ISequenceNumber { get; set; }
        public string SDescript { get; set; }
        public int? IQuantityOrderEstimate { get; set; }
        public int? IQuantityOrderActual { get; set; }
        public decimal? DblUnitPrice { get; set; }
        public string SPriceCode { get; set; }
        public decimal? DblShippingWeightEstimated { get; set; }
        public decimal? DblShippingWeightActual { get; set; }
        public decimal? DblMaterialCostEstimated { get; set; }
        public decimal? DblMaterialCostActual { get; set; }
        public decimal? DblWeightPulledEstimated { get; set; }
        public decimal? DblWeightPulledActual { get; set; }
        public decimal? DblOrderValue { get; set; }
        public decimal? DblReplacementCosts { get; set; }
        public string SEmpty { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
