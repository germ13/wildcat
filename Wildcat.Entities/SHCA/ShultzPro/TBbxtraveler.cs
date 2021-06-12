using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TBbxtraveler
    {
        public Guid STravelerGuid { get; set; }
        public string STravelerId { get; set; }
        public string SOpCode { get; set; }
        public string SDesc1 { get; set; }
        public string SDesc2 { get; set; }
        public int? ISchedDays { get; set; }
        public decimal? DblMacHrsEst { get; set; }
        public decimal? DblMachHrsAct { get; set; }
        public int? IPiecesEst { get; set; }
        public int? IPiecesAct { get; set; }
        public decimal? CurCostEst { get; set; }
        public decimal? CurCostAct { get; set; }
        public string SStatus { get; set; }
        public int? IMachCode { get; set; }
        public DateTime? DtCalcDueDate { get; set; }
        public string SDateString { get; set; }
        public DateTime? DtLastProdDate { get; set; }
        public string SLastManUpdate { get; set; }
        public DateTime? DtBbxupdt { get; set; }
        public string SBbxupdtBy { get; set; }
        public bool BClosed { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
