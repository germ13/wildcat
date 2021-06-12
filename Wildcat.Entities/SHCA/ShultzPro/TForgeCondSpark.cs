using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TForgeCondSpark
    {
        public Guid SSparkGuid { get; set; }
        public Guid SPieceGuid { get; set; }
        public int ISparkTime { get; set; }
        public int ISparkMinValue { get; set; }
        public int ISparkMaxValue { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TForgeCondPiece SPieceGu { get; set; }
    }
}
