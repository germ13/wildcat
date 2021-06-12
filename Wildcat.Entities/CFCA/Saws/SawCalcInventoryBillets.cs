using System;

namespace Wildcat.Entities.CFCA.Saws
{
    public partial class SawCalcInventoryBillets
    {
        public int InventoryBilletId { get; set; }
        public string HeatNumber { get; set; }
        public string BilletNumber { get; set; }
        public double OriginalWeight { get; set; }
        public bool IsConsigned { get; set; }
        public DateTime? DateReceived { get; set; }
        public string MaterialCode { get; set; }
        public double? CostPerPound { get; set; }
        public string Mill { get; set; }
    }
}
