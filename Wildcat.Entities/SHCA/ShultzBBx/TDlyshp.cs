using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TDlyshp
    {
        public int IRecId { get; set; }
        public string SKey { get; set; }
        public DateTime? DtShipDate { get; set; }
        public string SJobNumber { get; set; }
        public string SCustomerNumber { get; set; }
        public string SShippingCompany { get; set; }
        public string SPartialCompleteShipment { get; set; }
        public int? INumberPiecesShipped { get; set; }
        public decimal? DblWeightShipment { get; set; }
        public string SBackorderSuffix { get; set; }
        public string SBillCode { get; set; }
        public decimal? DblShipValue { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
