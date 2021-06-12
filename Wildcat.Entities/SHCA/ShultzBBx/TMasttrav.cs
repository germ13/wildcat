using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TMasttrav
    {
        public int IRecId { get; set; }
        public string SKey { get; set; }
        public string SJobNumber { get; set; }
        public string SConvOrMast { get; set; }
        public string SStepNumber { get; set; }
        public string SOpCode { get; set; }
        public string SDescription1 { get; set; }
        public string SDescription2 { get; set; }
        public int? IStepDurationDays { get; set; }
        public decimal? DblMachineHoursEst { get; set; }
        public decimal? DblMachineHoursAct { get; set; }
        public decimal? DblPiecesEst { get; set; }
        public decimal? DblPiecesAct { get; set; }
        public decimal? DblCostEst { get; set; }
        public decimal? DblCostAct { get; set; }
        public string SStatus { get; set; }
        public string SMachineCode { get; set; }
        public DateTime? DtCalculatedDueDate { get; set; }
        public string SOpen { get; set; }
        public DateTime? DtLastDailyProductionDate { get; set; }
        public string SRevisionId { get; set; }
        public string SHydra01 { get; set; }
        public string SHydra02 { get; set; }
        public string SHydra03 { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
