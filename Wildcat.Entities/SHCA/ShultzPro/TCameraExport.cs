using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TCameraExport
    {
        public Guid SExportGuid { get; set; }
        public Guid SCameraGuid { get; set; }
        public string SCameraName { get; set; }
        public DateTime? DtStartTimeUtc { get; set; }
        public DateTime? DtEndTimeUtc { get; set; }
        public DateTime? DtStartTime { get; set; }
        public DateTime? DtEndTime { get; set; }
        public string SVideoFilePath1 { get; set; }
        public string SVideoFilePath2 { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
