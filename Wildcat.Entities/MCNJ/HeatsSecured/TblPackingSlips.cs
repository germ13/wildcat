using System;

namespace Wildcat.Entities.MCNJ.HeatsSecured
{
    public partial class TblPackingSlips
    {
        public int Psn { get; set; }
        public string McWCn { get; set; }
        public DateTime? Date { get; set; }
        public string Die { get; set; }
        public string WorkOrder { get; set; }
        public string CustPo { get; set; }
        public short? Quantity { get; set; }
        public string ProcessNo { get; set; }
        public string SerialNumber { get; set; }
        public int? ShipTo { get; set; }
        public int? SoldTo { get; set; }
        public string Freight { get; set; }
        public string ItemNumber { get; set; }
        public string ShipVia { get; set; }
        public int? NumberOfSkids { get; set; }
        public int? NumberOfBoxes { get; set; }
        public int? TotalWeight { get; set; }
        public string Notes { get; set; }
        public bool ShipAir { get; set; }
        public int? Crn2 { get; set; }
        public int? Crn { get; set; }
    }
}
