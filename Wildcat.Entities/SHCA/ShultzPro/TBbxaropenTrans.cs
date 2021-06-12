using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TBbxaropenTrans
    {
        public Guid SAropenTransGuid { get; set; }
        public string SKey { get; set; }
        public string STransCode { get; set; }
        public decimal? CurInvoiceAmt { get; set; }
        public DateTime? DinvoiceDate { get; set; }
        public DateTime? DAgeDate { get; set; }
        public string SCustSoldToName { get; set; }
        public string STermsCode { get; set; }
        public string SFinalInvoiceCode { get; set; }
        public string SReferenceNumber { get; set; }
        public string SCode { get; set; }
        public string SRemarks { get; set; }
        public DateTime? DEstRecDate { get; set; }
        public DateTime? DCallDate { get; set; }
        public string SPersonContacted { get; set; }
        public DateTime? DtBbxupdt { get; set; }
        public string SBbxupdtBy { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdateByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
