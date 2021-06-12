using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TCellPhoneVoiceDetail
    {
        public Guid SDetailGuid { get; set; }
        public int? IEccprofileId { get; set; }
        public DateTime? DtBillCycle { get; set; }
        public string SAccountNum { get; set; }
        public string SInvoiceNum { get; set; }
        public string SWirelessNumber { get; set; }
        public string SUsername { get; set; }
        public string SUsageCategory { get; set; }
        public DateTime? DtCall { get; set; }
        public string SNumber { get; set; }
        public string SRate { get; set; }
        public string SUsageType { get; set; }
        public string SDescription { get; set; }
        public string SOrigination { get; set; }
        public string SDestination { get; set; }
        public string SInternationalCallType { get; set; }
        public int? IMinutes { get; set; }
        public decimal? DblCharge { get; set; }
        public decimal? DblLongDistance { get; set; }
        public decimal? DblTotal { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
