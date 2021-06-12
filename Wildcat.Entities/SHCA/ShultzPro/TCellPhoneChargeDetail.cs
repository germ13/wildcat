using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TCellPhoneChargeDetail
    {
        public Guid SDetailGuid { get; set; }
        public int? IEccprofileId { get; set; }
        public DateTime? DtBillCycle { get; set; }
        public string SAccountNum { get; set; }
        public string SInvoiceNum { get; set; }
        public string SWirelessNumber { get; set; }
        public string SUsername { get; set; }
        public string SCostCenter { get; set; }
        public string SUserId { get; set; }
        public string SItemCategory { get; set; }
        public string SDateRange { get; set; }
        public string SItemType { get; set; }
        public string SItemDescription { get; set; }
        public string SVendorName { get; set; }
        public string SShareDescription { get; set; }
        public string SShareVoice { get; set; }
        public string SShareMessaging { get; set; }
        public string SShareData { get; set; }
        public string SUsagePeriod { get; set; }
        public string SAllowance { get; set; }
        public decimal? DblUsed { get; set; }
        public decimal? DblBillable { get; set; }
        public decimal? CurCost { get; set; }
        public string SOrderDetails { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
