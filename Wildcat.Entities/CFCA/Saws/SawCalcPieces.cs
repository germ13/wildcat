using System;

namespace Wildcat.Entities.CFCA.Saws
{
    public partial class SawCalcPieces
    {
        public int PieceId { get; set; }
        public int ShopOrderId { get; set; }
        public int BilletId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string MultSerialNumber { get; set; }
        public string LastMultSerialNumber { get; set; }
        public int OperatorId { get; set; }
        public int SawId { get; set; }
        public int BladeId { get; set; }
        public double TargetWeight { get; set; }
        public double ActualWeight { get; set; }
        public double IdealTargetLength { get; set; }
        public double AdjustedTargetLength { get; set; }
        public double AverageCrossSectionArea { get; set; }
        public bool IsMult { get; set; }
        public bool IsProlong { get; set; }
        public bool IsException { get; set; }
        public bool IsRemnant { get; set; }
        public double CrookedEndAngle { get; set; }
        public double CrookedEndProtrusionAngle { get; set; }
        public double CrookedEndViceContactAngle { get; set; }
        public double DensityCorrectionFactor { get; set; }
        public double SawCalibrationOffset { get; set; }
        public double Kerf { get; set; }
        public double Tpi { get; set; }
        public double CutRate { get; set; }
        public double? ActualCutTime { get; set; }
        public double BladeSpeed { get; set; }
        public int? ExceptionReasonId { get; set; }
        public string ExceptionNotes { get; set; }
        public int? ShapeMeasurementId { get; set; }
        public int ComputerId { get; set; }
        public string IssueOwner { get; set; }
        public DateTime? IssueCompletionDate { get; set; }
        public string IssueNotes { get; set; }
        public short IssueStatus { get; set; }
        public int? PeerOverrideId { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public bool IsDeleted { get; set; }

        public SawCalcBillets Billet { get; set; }
        public SawCalcBlades Blade { get; set; }
        public SawCalcComputers Computer { get; set; }
        public SawCalcExceptionReasons ExceptionReason { get; set; }
        public SawCalcPersons Operator { get; set; }
        public SawCalcPersons PeerOverride { get; set; }
        public SawCalcSaws Saw { get; set; }
        public SawCalcShapeMeasurements ShapeMeasurement { get; set; }
        public SawCalcShopOrders ShopOrder { get; set; }
    }
}
