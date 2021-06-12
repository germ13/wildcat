using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TPccGlposting
    {
        public Guid SPostingGuid { get; set; }
        public string SKey { get; set; }
        public string SGlcode { get; set; }
        public string SSourceCode { get; set; }
        public string SInvoiceNumber { get; set; }
        public decimal? DblAmount { get; set; }
        public string SDescription { get; set; }
        public DateTime? DtPosting { get; set; }
        public int? IPeriod { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
        public string SRemarks { get; set; }
    }
}
