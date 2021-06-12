using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TStar91325
    {
        public int IRecId { get; set; }
        public string SKey { get; set; }
        public string SJobNumber { get; set; }
        public int? IStepNumber { get; set; }
        public string SOpCode { get; set; }
        public string SMachiningDescription { get; set; }
        public string SAuthorization { get; set; }
        public DateTime? DtAuthorized { get; set; }
        public string SApprovedBy { get; set; }
        public DateTime? DtApproved { get; set; }
        public string SRevision { get; set; }
        public string SIdealMachineCode { get; set; }
        public decimal? DblHoursPerPiece { get; set; }
        public string SDescription { get; set; }
        public string SOpen01 { get; set; }
        public string SOpen02 { get; set; }
        public string SOpen03 { get; set; }
        public string SOpen04 { get; set; }
        public string SOpen05 { get; set; }
        public string SOpen06 { get; set; }
        public string SOpen07 { get; set; }
        public string SOpen08 { get; set; }
        public string SOpen09 { get; set; }
        public string SOpen10 { get; set; }
        public string SOpen11 { get; set; }
        public string SOpen12 { get; set; }
        public string SOpen13 { get; set; }
        public string SOpen14 { get; set; }
        public decimal? DblTotalPieces { get; set; }
        public decimal? DblFinishedPieces { get; set; }
        public int? ITravelerChargeStep { get; set; }
        public int? ITravelerReferenceStep { get; set; }
        public string SHydra01 { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
