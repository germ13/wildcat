using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TSjDtl
    {
        public int IRecId { get; set; }
        public string SKey { get; set; }
        public string SJobNumCode { get; set; }
        public string SCustomerNumber { get; set; }
        public string SCustomerName { get; set; }
        public decimal? DblGrossAmount { get; set; }
        public decimal? DblSalesTaxAmount { get; set; }
        public decimal? DblFreightAmount { get; set; }
        public decimal? DblMiscellaneousAmount { get; set; }
        public decimal? DblInvoiceAmount { get; set; }
        public decimal? DblCommisionPercent { get; set; }
        public string STerritory { get; set; }
        public DateTime? DtInvoiceDate { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
