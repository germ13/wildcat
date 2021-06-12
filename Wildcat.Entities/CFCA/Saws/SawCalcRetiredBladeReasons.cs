using System.Collections.Generic;

namespace Wildcat.Entities.CFCA.Saws
{
    public partial class SawCalcRetiredBladeReasons
    {
        public SawCalcRetiredBladeReasons()
        {
            SawCalcBlades = new HashSet<SawCalcBlades>();
        }

        public int RetiredBladeReasonId { get; set; }
        public string RetiredBladeReasonDescription { get; set; }
        public short SequenceNumber { get; set; }

        public ICollection<SawCalcBlades> SawCalcBlades { get; set; }
    }
}
