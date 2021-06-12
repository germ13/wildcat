using System;

namespace Wildcat.Entities.MCNJ.SecureHeatCards
{
    public partial class TblHeatCard
    {
        public int Hcn { get; set; }
        public string DieNumber { get; set; }
        public DateTime? Date { get; set; }
        public string NucPrefix { get; set; }
        public string HeatCode { get; set; }
        public string HeatNumber { get; set; }
        public string ShopOrderNumber { get; set; }
        public short? QuantityOrderedCut { get; set; }
        public string Range { get; set; }
        public string Notes { get; set; }
    }
}
