using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TPcgraf
    {
        public int IRecId { get; set; }
        public string SKey { get; set; }
        public string SJobNumber { get; set; }
        public int? IStepNumber { get; set; }
        public DateTime? DtTimeEntry { get; set; }
        public decimal? DblPieces { get; set; }
        public decimal? DblTimeUsed { get; set; }
        public DateTime? DtActual { get; set; }
        public string SReportRanBy { get; set; }
        public string SStepC { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
