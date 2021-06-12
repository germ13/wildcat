namespace Wildcat.Entities.MCNJ.SecureHeatTreatBatchBook
{
    public partial class TblHtoperations
    {
        public int OpKey { get; set; }
        public string DieNo { get; set; }
        public string Operation { get; set; }
        public string Furnace { get; set; }
        public string Zone { get; set; }
        public int? Temperature { get; set; }
        public string PushTime { get; set; }
        public string HoldTime { get; set; }
        public string Quench { get; set; }
    }
}
