using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TPcc004
    {
        public Guid SDetailGuid { get; set; }
        public Guid SFileGuid { get; set; }
        public string SFileKey { get; set; }
        public string SVendorNumber { get; set; }
        public string SInvoiceNumber { get; set; }
        public bool? BTransmitVendorAddress { get; set; }
        public DateTime? DtPay { get; set; }
        public DateTime? DtDue { get; set; }
        public decimal? DblInvoiceAmt { get; set; }
        public string SHoldPayCode { get; set; }
        public string SVendorName { get; set; }
        public string SVoidCode { get; set; }
        public string SRemarks { get; set; }
        public string SCheckNumber { get; set; }
        public string SGlCode { get; set; }
        public DateTime? DtConnexionTransmit { get; set; }
        public DateTime? DtPositivePayTransmit { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TPcc004FileList SFileGu { get; set; }
    }
}
