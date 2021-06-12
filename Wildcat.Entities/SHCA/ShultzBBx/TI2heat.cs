using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TI2heat
    {
        public int IRecId { get; set; }
        public string SKey { get; set; }
        public string SAlloyCode { get; set; }
        public string SGrade { get; set; }
        public string SSize { get; set; }
        public string SCondition { get; set; }
        public string SSequence { get; set; }
        public string SHeatNumber { get; set; }
        public string SProducer { get; set; }
        public DateTime? DtAcquiredDate { get; set; }
        public DateTime? DtDepletedDate { get; set; }
        public string SUnitOfMeasureCode { get; set; }
        public decimal? DblCostPerUnitOfMeasureCode { get; set; }
        public int? IStatusCode { get; set; }
        public decimal? DblWeightOnHand { get; set; }
        public decimal? DblWeightReserved { get; set; }
        public int? ILength1Description { get; set; }
        public int? ILength1OnHand { get; set; }
        public int? ILength1Reserved { get; set; }
        public int? ILength2Description { get; set; }
        public int? ILength2OnHand { get; set; }
        public int? ILength2Reserved { get; set; }
        public int? ILength3OnHand { get; set; }
        public int? ILength3Reserved { get; set; }
        public int? ILength4OnHand { get; set; }
        public int? ILength4Reserved { get; set; }
        public int? ILength5OnHand { get; set; }
        public int? ILength5Reserved { get; set; }
        public string SNotUsed01 { get; set; }
        public string SNotUsed02 { get; set; }
        public string SLength345Description { get; set; }
        public string SHydra01 { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
