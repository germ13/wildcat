using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TCellPhoneSummaryCharges
    {
        public Guid SSummaryGuid { get; set; }
        public int? IEccprofileId { get; set; }
        public DateTime? DtBillCycle { get; set; }
        public string SAccountNum { get; set; }
        public DateTime? DtDue { get; set; }
        public string SInvoiceNum { get; set; }
        public string SBillPeriod { get; set; }
        public string SBillName { get; set; }
        public decimal? CurPreviousBalance { get; set; }
        public decimal? CurPayments { get; set; }
        public decimal? CurAdjustments { get; set; }
        public decimal? CurBalanceForward { get; set; }
        public decimal? CurAccountCharges { get; set; }
        public decimal? CurThirdPartyAccount { get; set; }
        public decimal? CurMonthlyCharges { get; set; }
        public decimal? CurLateFee { get; set; }
        public decimal? CurUsageChargesVoice { get; set; }
        public decimal? CurUsageChargesMobile { get; set; }
        public decimal? CurUsageChargesData { get; set; }
        public decimal? CurUsageChargesRoaming { get; set; }
        public decimal? CurUsageChargesInternational { get; set; }
        public decimal? CurUsageChargesPurchases { get; set; }
        public decimal? CurUsageAndPurchaseCharges { get; set; }
        public decimal? CurEquipmentCharges { get; set; }
        public decimal? CurSurcharges { get; set; }
        public decimal? CurTaxesGovernment { get; set; }
        public decimal? CurThirdPartyLines { get; set; }
        public decimal? CurTotalCharges { get; set; }
        public decimal? CurTotalAmountDue { get; set; }
        public string SRemittanceAddress { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
