using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TStar90008
    {
        public int IRecId { get; set; }
        public string SKey { get; set; }
        public string SJobOrderNumber { get; set; }
        public string SMachineProcessCode { get; set; }
        public string SMaterialProcessCode { get; set; }
        public DateTime? DtProcessDate { get; set; }
        public string SCustomerNumber { get; set; }
        public decimal? DblInvoiceCmToDate { get; set; }
        public decimal? DblMaterialCostAdditional { get; set; }
        public decimal? DblMaterialCostActualTotal { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
