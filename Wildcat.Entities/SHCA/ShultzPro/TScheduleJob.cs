using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TScheduleJob
    {
        public Guid SScheduleJobGuid { get; set; }
        public Guid? SScheduleManagerGuid { get; set; }
        public string SNumber { get; set; }
        public string SMetalName { get; set; }
        public string SOperationSummary { get; set; }
        public Guid? SForgeGroup { get; set; }
        public string SShapeSizeKey { get; set; }
        public Guid? SMachineGuid { get; set; }
        public DateTime? DtForgeEnd { get; set; }
        public DateTime? DtForgeEndPushedBack { get; set; }
        public int? IItemCount { get; set; }
        public decimal? DblForgeTimePerItem { get; set; }
        public decimal? DblCrossSection { get; set; }
        public bool? BIsConversion { get; set; }
        public DateTime? DtStart { get; set; }
        public DateTime? DtEnd { get; set; }
        public string SFactors { get; set; }
        public decimal? DblTotalForgeTimeInMinutes { get; set; }
        public decimal? DblTotalForgeTimeRemaining { get; set; }
        public string SStartDateString { get; set; }
        public string SScheduleSymbol { get; set; }
        public int? IForgeStep { get; set; }
        public int? IPreFurnaceStep { get; set; }
        public DateTime? DtPreFurnace { get; set; }
        public int? IFurnaceGroup { get; set; }
        public bool? BMondayTuesdayOnly { get; set; }
        public bool? BIsRework { get; set; }
        public bool? BOverTimeScheduled { get; set; }
        public bool? BTimeLocked { get; set; }
        public bool? BTimespanUpdated { get; set; }
        public bool? BTemperatureUpdated { get; set; }
        public bool? BMetalUpdated { get; set; }
        public bool? BCrossSectionBeforeUpdated { get; set; }
        public bool? BDescriptionUpdated { get; set; }
        public string STravelerDescriptionLine1 { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TMachine SMachineGu { get; set; }
    }
}
