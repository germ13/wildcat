using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TR7CaretJnl
    {
        public int IRecId { get; set; }
        public string SKey { get; set; }
        public string SOrderWriterInitials { get; set; }
        public string SInvoiceNumber { get; set; }
        public string SBackOrderIndex { get; set; }
        public string SNotUsed { get; set; }
        public string SCustomerNumber { get; set; }
        public string SCustomerName { get; set; }
        public string SInvoiceDate { get; set; }
        public decimal? DblInvoiceAmount { get; set; }
        public decimal? DblActualCost { get; set; }
        public string SMachineCode { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
