using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TGasMeterReading
    {
        public Guid SRecGuid { get; set; }
        public Guid SMeterGuid { get; set; }
        public DateTime? DtLog { get; set; }
        public decimal? DblCorrectedVolume { get; set; }
        public decimal? DblUncorrectedVolume { get; set; }
        public decimal? DblCorrectedResidual { get; set; }
        public decimal? DblUncorrectedResidual { get; set; }
        public decimal? DblFlowRate { get; set; }
        public decimal? DblUncorrectedUnderFault { get; set; }
        public decimal? DblTemperature { get; set; }
        public decimal? DblRawTemperature { get; set; }
        public decimal? DblPressure { get; set; }
        public decimal? DblRawPressure { get; set; }
        public decimal? DblCorrectionFactor { get; set; }
        public decimal? DblZfactor { get; set; }
        public decimal? DblPresentFaults { get; set; }
        public decimal? DblOccurredFaults { get; set; }
        public decimal? DblPresentAlarms { get; set; }
        public decimal? DblOccurredAlarms { get; set; }
        public decimal? DblBatteryVoltage { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TGasMeter SMeterGu { get; set; }
    }
}
