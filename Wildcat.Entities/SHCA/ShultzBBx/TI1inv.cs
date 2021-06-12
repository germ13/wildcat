using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TI1inv
    {
        public int IRecId { get; set; }
        public string SKey { get; set; }
        public string SAlloyCode { get; set; }
        public string SGrade { get; set; }
        public string SSize { get; set; }
        public string SCondition { get; set; }
        public string SDescription { get; set; }
        public int? INumberOfTimesSold { get; set; }
        public decimal? DblTotalWeightOnHand { get; set; }
        public decimal? DblTotalWeightOnHandReserved { get; set; }
        public decimal? DblTotalWeightOnOrder { get; set; }
        public decimal? DblTotalWeightOnOrderReserved { get; set; }
        public decimal? DblLastProcurementCost { get; set; }
        public int? IProcurementPriceCode { get; set; }
        public decimal? DblReorderPointWeight { get; set; }
        public decimal? DblLeadTimeInWeeks { get; set; }
        public decimal? DblSalesInWeightMtd { get; set; }
        public decimal? DblSalesInWeightYtd { get; set; }
        public decimal? DblSalesInWeightLastYear { get; set; }
        public string SOpen01 { get; set; }
        public decimal? DblBasePriceIn1973 { get; set; }
        public string SOpen02 { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
