using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TGasMeterLog
    {
        public Guid SRecGuid { get; set; }
        public Guid SMeterGuid { get; set; }
        public DateTime DtLog { get; set; }
        public int ICorrectedVolume { get; set; }
        public int IUncorrectedVolume { get; set; }
        public decimal DblCorrectionFactor { get; set; }
        public decimal IUncorrectedVolUnderFault { get; set; }
        public decimal DblAveragePressure { get; set; }
        public decimal DblAverageTemperature { get; set; }
        public decimal DblAvgCorrectedFlowRate { get; set; }
        public decimal DblPeakCorrectedFlowRate { get; set; }
        public decimal DblSupperCompressibility { get; set; }
        public decimal DblMinimumPressure { get; set; }
        public decimal DblMaxPressure { get; set; }
        public decimal DblEndingPressure { get; set; }
        public decimal DblMinTemperature { get; set; }
        public decimal DblMaxTemperature { get; set; }
        public decimal DblEndingTemperature { get; set; }
        public decimal DblBatteryVoltage { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowVersion { get; set; }
    }
}
