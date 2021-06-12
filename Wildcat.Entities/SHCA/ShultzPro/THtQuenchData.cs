using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class THtQuenchData
    {
        public Guid SHtquenchDataGuid { get; set; }
        public Guid SHtcycleGuid { get; set; }
        public int? IWaterTempBefore { get; set; }
        public int? IWaterTempAfter { get; set; }
        public int? IDelayMins { get; set; }
        public int? IAmps1 { get; set; }
        public int? IAmps2 { get; set; }
        public int? IAmps3 { get; set; }
        public int? IAmps4 { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUser { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public THtCycle SHtcycleGu { get; set; }
    }
}
