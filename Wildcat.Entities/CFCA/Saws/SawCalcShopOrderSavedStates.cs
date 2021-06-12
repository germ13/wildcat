namespace Wildcat.Entities.CFCA.Saws
{
    public partial class SawCalcShopOrderSavedStates
    {
        public int ShopOrderId { get; set; }
        public int ComputerId { get; set; }
        public string CrossSectionShape { get; set; }
        public int? MaterialId { get; set; }
        public short? NumberOfPiecesLeft { get; set; }
        public string HeatNumber { get; set; }
        public string BilletNumber { get; set; }
        public double? NewBilletWeight { get; set; }
        public double? TargetWeight { get; set; }
        public string MultSerialNumber { get; set; }
        public string SawName { get; set; }
        public string BladeName { get; set; }
        public double? Kerf { get; set; }
        public double? Tpi { get; set; }
        public double? CutRate { get; set; }
        public double? CrookedEndAngle { get; set; }
        public double? CrookedEndProtrusionAngle { get; set; }
        public double? CrookedEndViceContactAngle { get; set; }
        public double? DensityCorrectionFactor { get; set; }
        public double? SawCalibrationOffset { get; set; }
        public int? ShapeMeasurementId { get; set; }
        public bool? BilletDirectionBottomToTop { get; set; }

        public SawCalcComputers Computer { get; set; }
        public SawCalcMaterials Material { get; set; }
        public SawCalcShapeMeasurements ShapeMeasurement { get; set; }
        public SawCalcShopOrders ShopOrder { get; set; }
    }
}
