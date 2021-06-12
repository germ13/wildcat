using System.Collections.Generic;

namespace Wildcat.Entities.CFCA.Saws
{
    public partial class SawCalcMaterials
    {
        public SawCalcMaterials()
        {
            SawCalcBillets = new HashSet<SawCalcBillets>();
            SawCalcShopOrderSavedStates = new HashSet<SawCalcShopOrderSavedStates>();
            SawCalcShopOrders = new HashSet<SawCalcShopOrders>();
        }

        public int MaterialId { get; set; }
        public string MaterialType { get; set; }
        public int AlloyId { get; set; }
        public string MaterialName { get; set; }
        public double Density { get; set; }
        public double ChipLoad { get; set; }
        public double LowProductionCutRate { get; set; }
        public double MediumProductionCutRate { get; set; }
        public double HighProductionCutRate { get; set; }
        public double LowProductionBladeLife { get; set; }
        public double MediumProductionBladeLife { get; set; }
        public double HighProductionBladeLife { get; set; }

        public SawCalcAlloys Alloy { get; set; }
        public ICollection<SawCalcBillets> SawCalcBillets { get; set; }
        public ICollection<SawCalcShopOrderSavedStates> SawCalcShopOrderSavedStates { get; set; }
        public ICollection<SawCalcShopOrders> SawCalcShopOrders { get; set; }
    }
}
