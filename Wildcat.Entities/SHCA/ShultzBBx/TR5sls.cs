using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TR5sls
    {
        public int IRecId { get; set; }
        public string SKey { get; set; }
        public string SCustomerNumber { get; set; }
        public string SInvoiceNumber { get; set; }
        public string SCustomerName { get; set; }
        public string SPurchaseOrderNumber { get; set; }
        public DateTime? DtInvoiceDate { get; set; }
        public decimal? DblInvoiceAmount { get; set; }
        public DateTime? DtPaymentDate { get; set; }
        public decimal? DblPaymentAmount { get; set; }
        public decimal? DblDiscountAmount { get; set; }
        public decimal? DblMiscellaneousAmount { get; set; }
        public string SGlnumber { get; set; }
        public decimal? DblGrossAmount { get; set; }
        public decimal? DblCostAmountMaterial { get; set; }
        public decimal? DblCostAmountTotal { get; set; }
        public string SOrderStatusCode { get; set; }
        public string SMachineNumber { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
