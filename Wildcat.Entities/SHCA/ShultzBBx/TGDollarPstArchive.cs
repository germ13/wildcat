using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TGDollarPstArchive
    {
        public int IRecId { get; set; }
        public string SKey { get; set; }
        public string SGlcode { get; set; }
        public string SSourceCode { get; set; }
        public string SInvoiceNumber { get; set; }
        public DateTime? DtPosting { get; set; }
        public string SOverwriteProtection { get; set; }
        public decimal? DblAmount { get; set; }
        public string SDescription { get; set; }
        public DateTime? DtPosting2 { get; set; }
        public string SYear { get; set; }
        public string SMonth { get; set; }
        public string SHydra01 { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
