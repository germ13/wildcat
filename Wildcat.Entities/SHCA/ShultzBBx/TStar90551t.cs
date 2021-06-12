using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TStar90551t
    {
        public int IRecId { get; set; }
        public string SKey { get; set; }
        public string SSession { get; set; }
        public string SProgramName { get; set; }
        public string SUser { get; set; }
        public DateTime? DtUsed { get; set; }
        public string SUser2 { get; set; }
        public string SOpen01 { get; set; }
        public string SOpen02 { get; set; }
        public string SOpen03 { get; set; }
        public string SOpen04 { get; set; }
        public string SOpen05 { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
