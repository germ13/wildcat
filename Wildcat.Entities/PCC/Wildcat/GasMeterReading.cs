using System;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class GasMeterReading
    {
        public int GasMeterReadingId { get; set; }
        public string MeterName { get; set; }
        public DateTime? Timestamp { get; set; }
        public int? CorrectedVolume { get; set; }
        public int? UncorrectedVolume { get; set; }
        public decimal? CorrectedResidual { get; set; }
        public decimal? UncorrectedResidual { get; set; }
        public decimal? FlowRate { get; set; }
        public decimal? UncorrectedUnderFault { get; set; }
        public decimal? Temperature { get; set; }
        public decimal? RawTemperature { get; set; }
        public decimal? Pressure { get; set; }
        public decimal? RawPressure { get; set; }
        public decimal? CorrectionFactor { get; set; }
        public decimal? Zfactor { get; set; }
        public decimal? PresentFaults { get; set; }
        public decimal? OccurredFaults { get; set; }
        public decimal? PresentAlarms { get; set; }
        public decimal? OccurredAlarms { get; set; }
        public decimal? BatteryVoltage { get; set; }
        public bool Active { get; set; }
        public DateTime Added { get; set; }
        public DateTime? Updated { get; set; }
        public string AddedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
