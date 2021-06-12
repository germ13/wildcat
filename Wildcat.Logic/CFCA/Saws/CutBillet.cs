using System.Collections.Generic;

namespace Wildcat.Logic.CFCA.Saws
{
    public class CutBillet
    {
        public string HeatNumber { get; set; }
        public string BilletNumber { get; set; }
        public double TotalWeightConsumed { get; set; }
        public List<CutPiece> CutPieces { get; set; }
    }
}
