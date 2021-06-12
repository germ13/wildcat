using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TPccTstrav
    {
        public Guid STstravguid { get; set; }
        public string SKey { get; set; }
        public string SJobNumber { get; set; }
        public int? IStepNum { get; set; }
        public string SOperationNum { get; set; }
        public string SDesc1 { get; set; }
        public string SDesc2 { get; set; }
        public string IScheduledDays { get; set; }
        public decimal? DblMachineHoursEstimated { get; set; }
        public decimal? DblMachineHoursActual { get; set; }
        public decimal? DblPiecesEstimated { get; set; }
        public decimal? DblPiecesActual { get; set; }
        public decimal? DblCostEstimated { get; set; }
        public decimal? DblCostActual { get; set; }
        public string SStatus { get; set; }
        public string SMachineCode { get; set; }
        public DateTime? DtCalculatedDue { get; set; }
        public string SField15Holder { get; set; }
        public DateTime? DtLastDailyProductionDate { get; set; }
        public int? IParentStepNum { get; set; }
        public bool BAllSubStepsCompleted { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
