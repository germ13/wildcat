using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TScheduleJobHistory
    {
        public Guid SScheduleJobHistoryGuid { get; set; }
        public string SJobNumber { get; set; }
        public bool? BIsConversion { get; set; }
        public string SShapeSizeKey { get; set; }
        public DateTime? DtLastUsed { get; set; }
        public int? ITemperature { get; set; }
        public int? IStep { get; set; }
        public decimal? DblMinutesPerPiece { get; set; }
        public string SMetalName { get; set; }
        public string SOperationSummary { get; set; }
        public decimal? DblCrossSection { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
