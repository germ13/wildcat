using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TTravelerLine
    {
        public int ITravId { get; set; }
        public string SJobNumber { get; set; }
        public string SBlankSpace { get; set; }
        public string SStepNum { get; set; }
        public string SOperationNum { get; set; }
        public string SDescLine1 { get; set; }
        public string SDescLine2 { get; set; }
        public int? IScheduledDays { get; set; }
        public decimal? DblMachineHoursEstimated { get; set; }
        public decimal? DblMachineHoursActual { get; set; }
        public int? IPiecesEstimated { get; set; }
        public int? IPiecesActual { get; set; }
        public decimal? CurCostEstimated { get; set; }
        public decimal? CurCostActual { get; set; }
        public string SStatus { get; set; }
        public string SMachineCode { get; set; }
        public DateTime? DtCalculatedDueDate { get; set; }
        public DateTime? DtLastDailyProduction { get; set; }
        public DateTime DtAdded { get; set; }
        public DateTime DtUpdated { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
