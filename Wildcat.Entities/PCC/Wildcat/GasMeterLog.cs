using System;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class GasMeterLog
    {
        public int GasMeterLogId { get; set; }
        public string MeterName { get; set; }
        public DateTime Timestamp { get; set; }
        public int CorrectedVolume { get; set; }
        public int UncorrectedVolume { get; set; }
        public decimal CorrectionFactor { get; set; }
        public decimal UncorrectedVolUnderFault { get; set; }
        public decimal AveragePressure { get; set; }
        public decimal AverageTemperature { get; set; }
        public decimal AvgCorrectedFlowRate { get; set; }
        public decimal PeakCorrectedFlowRate { get; set; }
        public decimal SupperCompressibility { get; set; }
        public decimal MinimumPressure { get; set; }
        public decimal MaxPressure { get; set; }
        public decimal EndingPressure { get; set; }
        public decimal MinTemperature { get; set; }
        public decimal MaxTemperature { get; set; }
        public decimal EndingTemperature { get; set; }
        public decimal BatteryVoltage { get; set; }
        public bool Active { get; set; }
        public DateTime Added { get; set; }
        public DateTime? Updated { get; set; }
        public string AddedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
