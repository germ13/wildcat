using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TTravelerOperation
    {
        public int IMstmopnid { get; set; }
        public string SOpCode { get; set; }
        public string SDeptName { get; set; }
        public string SDesc1 { get; set; }
        public string SDesc2 { get; set; }
        public string SMachine { get; set; }
        public decimal? DblYtdhoursEstimated { get; set; }
        public decimal? DblYtdhoursActual { get; set; }
        public decimal? DblYtdcostEstimated { get; set; }
        public decimal? DblYtdcostActual { get; set; }
        public decimal? DblMtdhoursEstimated { get; set; }
        public decimal? DblMtdhoursActual { get; set; }
        public decimal? DblMtdcostEstimated { get; set; }
        public decimal? DblMtdcostActual { get; set; }
        public decimal? DblDefaultScheduledDays { get; set; }
        public decimal? DblCapacityHours { get; set; }
        public decimal? DblOverCapacityHours { get; set; }
        public decimal? DblScheduledHours { get; set; }
        public decimal? DblConvCapacityPerCwt { get; set; }
        public DateTime DtAdded { get; set; }
        public DateTime DtUpdated { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
