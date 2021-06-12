using System;

namespace Wildcat.Entities.MCNJ.SecureHeatTreatBatchBook
{
    public partial class TblHtacutal
    {
        public string OrderNo { get; set; }
        public DateTime? Date { get; set; }
        public int? NoPcs { get; set; }
        public string FceNo { get; set; }
        public string Operation { get; set; }
        public int? Temp { get; set; }
        public string HoldTime { get; set; }
        public string CoolRate { get; set; }
        public string AtTemp { get; set; }
        public string HoldComplete { get; set; }
        public string Bhn { get; set; }
        public int? QuenchTempStart { get; set; }
        public int? QuenchTempFinish { get; set; }
        public int RowId { get; set; }
        public int? QuenchRiseTemp { get; set; }
    }
}
