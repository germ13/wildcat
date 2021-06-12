using System;

namespace Wildcat.Entities.MCNJ.SecureHeatTreatBatchBook
{
    public partial class TblHtbatchInfo
    {
        public int RunKey { get; set; }
        public string DieNo { get; set; }
        public string WorkOrder { get; set; }
        public DateTime? Date { get; set; }
        public int? Qty { get; set; }
        public int? Weight { get; set; }
        public string BatchNo { get; set; }
        public int? Customer { get; set; }
        public string HeatCode { get; set; }
        public string Htno { get; set; }
        public string MatL { get; set; }
        public string Furnace { get; set; }
        public string Cycle { get; set; }
        public string RunTemp { get; set; }
        public float? TimeAtTemp { get; set; }
    }
}
