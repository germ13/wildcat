using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TStar901068
    {
        public int IRecId { get; set; }
        public string SKey { get; set; }
        public string SJobNumber { get; set; }
        public int? IWeeksFromCnv { get; set; }
        public int? IFromJobStartToFirestone { get; set; }
        public int? IFromFirestoneToDueDate { get; set; }
        public string SLastUpdated { get; set; }
        public string SLastUpdatedBy { get; set; }
        public int? IForgeMaxLotQuantity { get; set; }
        public int? IHeatTreatMaxLotQuantity { get; set; }
        public string SOpen01 { get; set; }
        public string SOpen02 { get; set; }
        public string SOpen03 { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
