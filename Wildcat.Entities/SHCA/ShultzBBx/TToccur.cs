using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TToccur
    {
        public int IRecId { get; set; }
        public string SKey { get; set; }
        public string SJobNumber { get; set; }
        public string SNewLocation { get; set; }
        public DateTime? DtMoved { get; set; }
        public int? IQuantityMoved { get; set; }
        public string SSplit { get; set; }
        public string SReword { get; set; }
        public DateTime? DtLastMoved { get; set; }
        public string SPriorLocation { get; set; }
        public int? IPriorQuantity { get; set; }
        public string SEnteredBy { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
