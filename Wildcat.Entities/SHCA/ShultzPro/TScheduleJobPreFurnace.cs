using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TScheduleJobPreFurnace
    {
        public Guid SPreFurnaceDateGuid { get; set; }
        public string SJobNumber { get; set; }
        public DateTime? DtMajorPreFurnace { get; set; }
        public int? IMajorPreFurnace { get; set; }
        public int? IForgeStep { get; set; }
        public Guid? SForgeGroup { get; set; }
        public decimal? DblTotalForgeTimeInHours { get; set; }
        public string SOperationNum { get; set; }
        public string SBeforeSizeDescLine { get; set; }
        public decimal? DblBeforeCrossSection { get; set; }
        public string STravelerDescriptionLine1 { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
