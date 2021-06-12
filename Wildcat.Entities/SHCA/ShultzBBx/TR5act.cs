using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TR5act
    {
        public int IRecId { get; set; }
        public string SKey { get; set; }
        public string SCustomerNumber { get; set; }
        public string SInvoiceNumberPlusSequence { get; set; }
        public string SCustomerName { get; set; }
        public string SPurchaseOrderNumber { get; set; }
        public DateTime? DtInvoiceDate { get; set; }
        public int? IInvoiceAmount { get; set; }
        public DateTime? DtPaymentDate { get; set; }
        public int? IPaymentAmount { get; set; }
        public int? IDiscountAmount { get; set; }
        public int? IMiscAmount { get; set; }
        public string SGlnumber { get; set; }
        public int? IGrossAmount { get; set; }
        public int? ICostAmountMaterial { get; set; }
        public int? ICostAmountTotal { get; set; }
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
