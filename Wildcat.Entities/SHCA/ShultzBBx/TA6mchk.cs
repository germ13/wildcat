using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TA6mchk
    {
        public int IRecId { get; set; }
        public string SKey { get; set; }
        public string SCheckNumber { get; set; }
        public string STime { get; set; }
        public decimal? DblNet { get; set; }
        public string SVendorNumber { get; set; }
        public string SVendorName { get; set; }
        public string SReturnCode { get; set; }
        public decimal? DblGross { get; set; }
        public decimal? DblDiscount { get; set; }
        public DateTime? DtDue { get; set; }
        public string SVendorAndInvoiceNumber { get; set; }
        public string SPreIssuedCheckCode { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
