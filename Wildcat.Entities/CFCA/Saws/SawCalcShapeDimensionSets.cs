namespace Wildcat.Entities.CFCA.Saws
{
    public partial class SawCalcShapeDimensionSets
    {
        public int ShapeMeasurementId { get; set; }
        public int SequenceNumber { get; set; }
        public double? Dimension1 { get; set; }
        public double? Dimension2 { get; set; }
        public double? Dimension3 { get; set; }
        public double? Dimension4 { get; set; }
        public double? Dimension5 { get; set; }

        public SawCalcShapeMeasurements ShapeMeasurement { get; set; }
    }
}
