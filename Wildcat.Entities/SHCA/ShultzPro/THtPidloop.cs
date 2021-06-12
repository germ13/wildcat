using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class THtPidloop
    {
        public Guid SLoopGuid { get; set; }
        public int IZone { get; set; }
        public int ISetpoint { get; set; }
        public int IOutput { get; set; }
        public int ITemp { get; set; }
        public int ILoopUpdate { get; set; }
        public decimal DblGain { get; set; }
        public int IReset { get; set; }
        public int IRate { get; set; }
        public int IMaxOutput { get; set; }
        public DateTime? DtDate { get; set; }
        public string SUserName { get; set; }
        public int? IRevision { get; set; }
        public string STempDiff { get; set; }
        public string SFurnace { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUser { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
