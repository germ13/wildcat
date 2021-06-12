using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TCellPhoneUsage
    {
        public Guid SUsageGuid { get; set; }
        public int? IEccprofileId { get; set; }
        public DateTime? DtBillCycle { get; set; }
        public string SAccountNum { get; set; }
        public DateTime? DtDue { get; set; }
        public string SInvoiceNum { get; set; }
        public string SBillPeriod { get; set; }
        public string SWirelessNumber { get; set; }
        public string SUsername { get; set; }
        public string SCostCenter { get; set; }
        public string SUserId { get; set; }
        public string SCallingPlan { get; set; }
        public int? IAccountChargesCredits { get; set; }
        public decimal? DblMonthlyCharges { get; set; }
        public decimal? DblUsagePurchaseCharges { get; set; }
        public decimal? DblEquipmentCharges { get; set; }
        public decimal? DblTotalSurcharges { get; set; }
        public decimal? DblTaxes { get; set; }
        public decimal? DblThirdPartyCharges { get; set; }
        public decimal? DblTotalCharges { get; set; }
        public int? IVoicePlanUsage { get; set; }
        public int? IMessagingUsage { get; set; }
        public decimal? DblDataUsageKb { get; set; }
        public decimal? DblDataUsageMb { get; set; }
        public decimal? DblDataUsageGb { get; set; }
        public int? IVoiceRoaming { get; set; }
        public int? IMessagingRoaming { get; set; }
        public decimal? DblDataRoamingKb { get; set; }
        public decimal? DblDataRoamingMb { get; set; }
        public decimal? DblDataRoamingGb { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
