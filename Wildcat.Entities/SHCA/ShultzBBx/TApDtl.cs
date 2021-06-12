using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TApDtl
    {
        public int IRecId { get; set; }
        public string SKey { get; set; }
        public string SVendorNumber { get; set; }
        public string SInvoiceNumber { get; set; }
        public DateTime? DtInvoiceDate { get; set; }
        public DateTime? DtPaidDate { get; set; }
        public DateTime? DtDueDate { get; set; }
        public decimal? DblGrossInvoiceAmount { get; set; }
        public decimal? DblDiscountAmount { get; set; }
        public decimal? DblFreightAmount { get; set; }
        public string SHoldPayCode { get; set; }
        public string SUnknown00 { get; set; }
        public string SVendorName { get; set; }
        public string SVoidCode { get; set; }
        public string SRemarks { get; set; }
        public string SPaidOnCheck { get; set; }
        public string SGlnumDistributedOn { get; set; }
        public string SOpen01 { get; set; }
        public string SOpen02 { get; set; }
        public string SVendorAndInvoice { get; set; }
        public string SHydra01 { get; set; }
        public string SHydra02 { get; set; }
        public string SHydra03 { get; set; }
        public string SHydra04 { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
