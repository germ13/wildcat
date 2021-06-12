using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TScheduleJobPlan
    {
        public Guid SPlanGuid { get; set; }
        public int IUniqueId { get; set; }
        public int? IType { get; set; }
        public DateTime? DtStart { get; set; }
        public DateTime? DtEnd { get; set; }
        public bool? BTimespanUpdated { get; set; }
        public string SSubject { get; set; }
        public string SOperationSummary { get; set; }
        public Guid? SForgeGroup { get; set; }
        public string SShapeSizeKey { get; set; }
        public int? IItemCount { get; set; }
        public decimal? DblForgeTimePerItem { get; set; }
        public bool? BIsConversion { get; set; }
        public bool? BIsRework { get; set; }
        public string SScheduleSymbol { get; set; }
        public int? IForgeStep { get; set; }
        public DateTime? DtForgeEnd { get; set; }
        public DateTime? DtForgeEndPushedBack { get; set; }
        public DateTime? DtPreFurnace { get; set; }
        public int? ITemperature { get; set; }
        public bool? BTemperatureUpdated { get; set; }
        public string SMetal { get; set; }
        public bool? BMetalUpdated { get; set; }
        public decimal? DblCrossSectionBefore { get; set; }
        public bool? BCrossSectionBeforeUpdated { get; set; }
        public string SDescription { get; set; }
        public bool? BDescriptionUpdated { get; set; }
        public string STravelerDescriptionLine1 { get; set; }
        public int? IResourceId { get; set; }
        public string SResourceIds { get; set; }
        public bool BLocked { get; set; }
        public byte IRed { get; set; }
        public byte IGreen { get; set; }
        public byte IBlue { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
