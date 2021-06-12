using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TMstrav
    {
        public int IRecId { get; set; }
        public string SKey { get; set; }
        public string SJobNumber { get; set; }
        public int? IStepNumber { get; set; }
        public string SOpCode { get; set; }
        public string SDescriptionLine1 { get; set; }
        public string SDescriptionLine2 { get; set; }
        public int? IScheduledDays { get; set; }
        public decimal? DblMachineHoursEstimated { get; set; }
        public decimal? DblMachineHoursActual { get; set; }
        public decimal? DblPiecesEstimated { get; set; }
        public decimal? DblPiecesActual { get; set; }
        public decimal? DblCostEstimated { get; set; }
        public decimal? DblCostActual { get; set; }
        public string SStatusCode { get; set; }
        public string SMachineCode { get; set; }
        public DateTime? DtCalculatedDue { get; set; }
        public decimal? DblResPieces { get; set; }
        public DateTime? DtLastProduction { get; set; }
        public string SUserCompletingStep { get; set; }
        public string SHydra01 { get; set; }
        public string SHydra02 { get; set; }
        public string SHydra03 { get; set; }
        public string SHydra04 { get; set; }
        public string SHydra05 { get; set; }
        public string SHydra06 { get; set; }
        public string SHydra07 { get; set; }
        public string SHydra08 { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
