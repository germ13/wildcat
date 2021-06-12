using System;
using System.Collections.Generic;

namespace Wildcat.Entities.CFCA.Saws
{
    public partial class SawCalcBillets
    {
        public SawCalcBillets()
        {
            SawCalcPieces = new HashSet<SawCalcPieces>();
            SawCalcShopOrderBillets = new HashSet<SawCalcShopOrderBillets>();
        }

        public int BilletId { get; set; }
        public string HeatNumber { get; set; }
        public string BilletNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        public int MaterialId { get; set; }
        public string CrossSectionShape { get; set; }

        public SawCalcMaterials Material { get; set; }
        public ICollection<SawCalcPieces> SawCalcPieces { get; set; }
        public ICollection<SawCalcShopOrderBillets> SawCalcShopOrderBillets { get; set; }
    }
}
