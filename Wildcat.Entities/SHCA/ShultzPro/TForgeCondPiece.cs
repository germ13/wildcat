using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TForgeCondPiece
    {
        public TForgeCondPiece()
        {
            TForgeCondSpark = new HashSet<TForgeCondSpark>();
        }

        public Guid SJobGuid { get; set; }
        public Guid? SRateGuid { get; set; }
        public int? IStepNum { get; set; }
        public string SMachine { get; set; }
        public string SSerialNumber { get; set; }
        public bool? BDyePenUsed { get; set; }
        public DateTime? DtStartTime { get; set; }
        public DateTime? DtStopTime { get; set; }
        public DateTime? DtCompletion { get; set; }
        public string SComments { get; set; }
        public int IStarterBadgeId { get; set; }
        public int? IFinisherBadgeId { get; set; }
        public string SShift { get; set; }
        public decimal? DblMeterStartRead { get; set; }
        public decimal? DblMeterFinishRead { get; set; }
        public string SReason { get; set; }
        public bool BRework { get; set; }
        public bool BInprogress { get; set; }
        public bool BInactive { get; set; }
        public DateTime? DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TForgeCondRate SRateGu { get; set; }
        public ICollection<TForgeCondSpark> TForgeCondSpark { get; set; }
    }
}
