using System.Collections.Generic;

namespace Wildcat.Entities.CFCA.Saws
{
    public partial class SawCalcExceptionReasons
    {
        public SawCalcExceptionReasons()
        {
            SawCalcPieces = new HashSet<SawCalcPieces>();
        }

        public int ExceptionReasonId { get; set; }
        public string ExceptionReasonDescription { get; set; }
        public bool AllowManualWeightEntry { get; set; }
        public short SequenceNumber { get; set; }

        public ICollection<SawCalcPieces> SawCalcPieces { get; set; }
    }
}
