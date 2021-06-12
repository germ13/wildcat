using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TBbxaractivity
    {
        public Guid SAractGuid { get; set; }
        public string SKey { get; set; }
        public string SCustName { get; set; }
        public string SCustPoid { get; set; }
        public DateTime? DInvoiceDate { get; set; }
        public decimal? CurInvoiceAmt { get; set; }
        public DateTime? DPaymentDate { get; set; }
        public decimal? CurPaymentAmt { get; set; }
        public decimal? CurDiscAmt { get; set; }
        public decimal? CurMiscAmt { get; set; }
        public string SGlnumber { get; set; }
        public decimal? CurGrossAmt { get; set; }
        public decimal? CurMaterialCostAmt { get; set; }
        public decimal? CurTotalCostAmt { get; set; }
        public string SOrderStatusCode { get; set; }
        public string SMachNumber { get; set; }
        public DateTime? DtBbxupdt { get; set; }
        public string SBbxupdtBy { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
