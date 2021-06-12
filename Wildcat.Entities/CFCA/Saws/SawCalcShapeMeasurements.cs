using System.Collections.Generic;

namespace Wildcat.Entities.CFCA.Saws
{
    public partial class SawCalcShapeMeasurements
    {
        public SawCalcShapeMeasurements()
        {
            SawCalcPieces = new HashSet<SawCalcPieces>();
            SawCalcShapeDimensionSets = new HashSet<SawCalcShapeDimensionSets>();
            SawCalcShopOrderSavedStates = new HashSet<SawCalcShopOrderSavedStates>();
        }

        public int ShapeMeasurementId { get; set; }
        public string CrossSectionShape { get; set; }

        public ICollection<SawCalcPieces> SawCalcPieces { get; set; }
        public ICollection<SawCalcShapeDimensionSets> SawCalcShapeDimensionSets { get; set; }
        public ICollection<SawCalcShopOrderSavedStates> SawCalcShopOrderSavedStates { get; set; }
    }
}
