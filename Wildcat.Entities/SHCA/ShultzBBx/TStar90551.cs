using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TStar90551
    {
        public int IRecId { get; set; }
        public string SKey { get; set; }
        public string SProgram { get; set; }
        public DateTime? DtUsed { get; set; }
        public int? ICounter { get; set; }
        public decimal? DblCounter2 { get; set; }
        public string SUser { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
