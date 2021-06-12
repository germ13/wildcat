namespace Wildcat.Entities.CFCA.Saws
{
    public partial class SawCalcMaterialMultReserves
    {
        public int MaterialMultReserveId { get; set; }
        public int MaterialReserveId { get; set; }
        public int Quantity { get; set; }
        public double CutWeight { get; set; }
        public double ProcurementWeight { get; set; }
        public bool IsTestPiece { get; set; }

        public SawCalcMaterialReserves MaterialReserve { get; set; }
    }
}
