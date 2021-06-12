using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TMshead
    {
        public int IRecId { get; set; }
        public string SKey { get; set; }
        public string SJobNumber { get; set; }
        public string SOrderStatusCode { get; set; }
        public string SBackOrderIndex { get; set; }
        public string STravelerPrinted { get; set; }
        public string SPriorityCode { get; set; }
        public string SShipByScheduled { get; set; }
        public string SLastScheduled { get; set; }
        public string SMaterialAvailable { get; set; }
        public string SPrepSize { get; set; }
        public int? ISplitOffNum { get; set; }
        public int? IConcurrentTravNum { get; set; }
        public bool? BSalesShipHold { get; set; }
        public string SCustomerNumber { get; set; }
        public string SShipToAddress1 { get; set; }
        public string SShipToAddress2 { get; set; }
        public string SShipToAddress3 { get; set; }
        public string SShipToAddress4 { get; set; }
        public string STerritory { get; set; }
        public string SOrderWriter { get; set; }
        public string SReceivedDate { get; set; }
        public string SShipByDate { get; set; }
        public string SDivisionCode { get; set; }
        public string SJobSummaryCodeNotUsed { get; set; }
        public int? IForgeWeek { get; set; }
        public string SPriceInEffectNotification { get; set; }
        public string SCustomerPonum { get; set; }
        public string SShipVia { get; set; }
        public string SCertificationWithMaterial { get; set; }
        public string SCertificationMailed { get; set; }
        public string SHeat1AndProducer { get; set; }
        public string SHeat2AndProducer { get; set; }
        public int? IOriginalQty { get; set; }
        public string SPricingCodeOriginalQty { get; set; }
        public string SPricingCodeMachine { get; set; }
        public string SPricingCodeMaterial { get; set; }
        public string SOpen01 { get; set; }
        public string SPriorityRating { get; set; }
        public string SContractNumber { get; set; }
        public string SCommissionPercent { get; set; }
        public string STermsCode { get; set; }
        public string SFreightCode { get; set; }
        public string SConversion { get; set; }
        public string SCreditMemo { get; set; }
        public string SBackOrder { get; set; }
        public string SStockReliefBackOrderFlag { get; set; }
        public string SOpen02 { get; set; }
        public decimal? DblTaxAmount { get; set; }
        public decimal? DblFreightAmount { get; set; }
        public decimal? DblMiscAmount { get; set; }
        public string SHeatTreatLotNumber { get; set; }
        public string SHardness { get; set; }
        public string SGradeCode { get; set; }
        public decimal? DblIncentiveRatePerHour { get; set; }
        public decimal? DblForgeHoursEstimated { get; set; }
        public decimal? DblForgeHoursActual { get; set; }
        public decimal? DblAmountInvoicedToDate { get; set; }
        public decimal? DblJobCostToDate { get; set; }
        public decimal? DblCreditMemosToDate { get; set; }
        public decimal? DblAdditionalMaterialCost { get; set; }
        public string SMaterialAvailableDatesString { get; set; }
        public string SOpen03 { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
