using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TStar91260
    {
        public int IRecId { get; set; }
        public string SKey { get; set; }
        public string SEmployeeNumber { get; set; }
        public string SJobNumber { get; set; }
        public string SOperationCode { get; set; }
        public DateTime? DtEventDate { get; set; }
        public string SMachineCode { get; set; }
        public int? ITravelerStep { get; set; }
        public int? IProcedureStep { get; set; }
        public string SEmployeeName { get; set; }
        public string SShift { get; set; }
        public decimal? DblEmployeeHours { get; set; }
        public decimal? DblMachineHours { get; set; }
        public int? ITravelerStepNumber { get; set; }
        public int? IHolder01 { get; set; }
        public int? IHolder02 { get; set; }
        public int? IHolder03 { get; set; }
        public int? IHolder04 { get; set; }
        public decimal? DblFinishedPieces { get; set; }
        public string SOperationStatus { get; set; }
        public decimal? DblMachineRateDollars { get; set; }
        public int? IDepartment { get; set; }
        public decimal? DblProcedureStepNumber { get; set; }
        public string STravellerPrintedCode { get; set; }
        public string SMachineCode2 { get; set; }
        public int? IHydra01 { get; set; }
        public int? IHydra02 { get; set; }
        public int? IHydra03 { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
