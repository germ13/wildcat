namespace Wildcat.Entities.MCNJ.SecureHeatTreatBatchBook
{
    public partial class TblMetRecords
    {
        public string DieNo { get; set; }
        public string OrderNo { get; set; }
        public int? QuantityRun { get; set; }
        public int? TestBars { get; set; }
        public string TotalFurnaceTime { get; set; }
        public int? QuenchTempStart { get; set; }
        public int? QuenchTempFinish { get; set; }
        public string Notes { get; set; }
        public string ApprovedBy { get; set; }
        public int RowId { get; set; }
        public string SectionSize { get; set; }
        public string Weight { get; set; }
    }
}
