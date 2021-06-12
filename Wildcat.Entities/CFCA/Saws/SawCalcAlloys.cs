using System.Collections.Generic;

namespace Wildcat.Entities.CFCA.Saws
{
    public partial class SawCalcAlloys
    {
        public SawCalcAlloys()
        {
            SawCalcMaterials = new HashSet<SawCalcMaterials>();
        }

        public int AlloyId { get; set; }
        public string AlloyName { get; set; }
        public double MinBladeSpeed { get; set; }
        public double MaxBladeSpeed { get; set; }

        public ICollection<SawCalcMaterials> SawCalcMaterials { get; set; }
    }
}
