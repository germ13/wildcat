using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TR2aCaretR
    {
        public int IRecId { get; set; }
        public string SKey { get; set; }
        public string SCustomerNumber { get; set; }
        public string SInvoiceNumber { get; set; }
        public string SBackOrderNumber { get; set; }
        public string STransactionCode { get; set; }
        public string SInvoiceAmount { get; set; }
        public DateTime? DtInvoiceDate { get; set; }
        public DateTime? DtAgeingDate { get; set; }
        public string SCustomerSoldToName { get; set; }
        public string STermsCode { get; set; }
        public string SFinancialInvoiceCode { get; set; }
        public string SReferenceNumber { get; set; }
        public string SCode { get; set; }
        public string SRemarks { get; set; }
        public string SSalesmanNumber { get; set; }
        public DateTime? DtEstimatedReceiveDate { get; set; }
        public DateTime? DtCallDate { get; set; }
        public string SPersonContacted { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
