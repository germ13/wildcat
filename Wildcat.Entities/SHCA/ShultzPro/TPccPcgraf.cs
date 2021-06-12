using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TPccPcgraf
    {
        public Guid SPcgrafguid { get; set; }
        public string SKey { get; set; }
        public string SJobNumber { get; set; }
        public int? IStepNum { get; set; }
        public DateTime? DtEntry { get; set; }
        public decimal? DblPieces { get; set; }
        public decimal? DblTimeUsed { get; set; }
        public string SOperationNum { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
