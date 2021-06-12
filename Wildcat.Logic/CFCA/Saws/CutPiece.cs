using System.Collections.Generic;

namespace Wildcat.Logic.CFCA.Saws
{
    public class CutPiece
    {
        public CutPieceType CutPieceType { get; set; }
        public List<string> SerialNumbers { get; set; }
        public double ActualWeight { get; set; }
        public double KerfWeight { get; set; }
    }
}
