using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TI2rsO
    {
        public int IRecId { get; set; }
        public string SKey { get; set; }
        public string SOrderNumber { get; set; }
        public string SInventoryMasterKey { get; set; }
        public string SHeatSequenceNumber { get; set; }
        public string SCustomerNumber { get; set; }
        public decimal? DblWeightReserved { get; set; }
        public decimal? DblLenghtReserverdL1 { get; set; }
        public decimal? DblLenghtReserverdL2 { get; set; }
        public decimal? DblLenghtReserverdL3 { get; set; }
        public decimal? DblLenghtReserverdL4 { get; set; }
        public decimal? DblLenghtReserverdL5 { get; set; }
        public DateTime? DtDateWeightReserved { get; set; }
        public decimal? DblWeightRelieved { get; set; }
        public decimal? DblWeightRelievedL1 { get; set; }
        public decimal? DblWeightRelievedL2 { get; set; }
        public decimal? DblWeightRelievedL3 { get; set; }
        public decimal? DblWeightRelievedL4 { get; set; }
        public decimal? DblWeightRelievedL5 { get; set; }
        public DateTime? DtDateWeightRelieved { get; set; }
        public string SUndefined1 { get; set; }
        public string SUndefined2 { get; set; }
        public string SUndefined3 { get; set; }
        public string SStatusCode { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
