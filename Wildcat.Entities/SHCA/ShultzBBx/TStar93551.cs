using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TStar93551
    {
        public int IRecId { get; set; }
        public string SKey { get; set; }
        public string SProgram { get; set; }
        public DateTime? DtEntry { get; set; }
        public decimal? DblDigit02 { get; set; }
        public string SUser { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
