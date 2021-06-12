using System.Collections.Generic;

namespace Wildcat.Entities.CFCA.Saws
{
    public partial class SawCalcMaterialReserves
    {
        public SawCalcMaterialReserves()
        {
            SawCalcMaterialMultReserves = new HashSet<SawCalcMaterialMultReserves>();
        }

        public int MaterialReserveId { get; set; }
        public string HeatNumber { get; set; }
        public string BilletNumber { get; set; }
        public string ShopOrderNumber { get; set; }
        public double WeightReserved { get; set; }
        public bool RemnantShouldReturnToStock { get; set; }

        public ICollection<SawCalcMaterialMultReserves> SawCalcMaterialMultReserves { get; set; }
    }
}
