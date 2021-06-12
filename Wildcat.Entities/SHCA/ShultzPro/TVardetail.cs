using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TVardetail
    {
        public Guid SDetailGuid { get; set; }
        public Guid SMasterGuid { get; set; }
        public int? IId { get; set; }
        public decimal? DblElapsedTime { get; set; }
        public decimal? DblElectrodeWeight { get; set; }
        public decimal? DblCurrentSetpoint { get; set; }
        public decimal? DblVoltageSetpoint { get; set; }
        public decimal? DblDrivespeedSetpoint { get; set; }
        public decimal? DblBaseSpeed { get; set; }
        public decimal? DblBlowerInletPressure { get; set; }
        public decimal? DblBlowerPressure { get; set; }
        public decimal? DblBlower615Speed { get; set; }
        public decimal? DblBlower1024Speed { get; set; }
        public decimal? DblTrimSpeed { get; set; }
        public decimal? DblDripshortSetpoint { get; set; }
        public decimal? DblDripshortTime { get; set; }
        public decimal? DblDripshort { get; set; }
        public decimal? DblVacuumSetpoint { get; set; }
        public decimal? DblCoolingGasSetpoint { get; set; }
        public decimal? DblMeltRateSetpoint { get; set; }
        public decimal? DblMeltRate { get; set; }
        public decimal? DblDspterm { get; set; }
        public decimal? DblDsiterm { get; set; }
        public decimal? DblDsdterm { get; set; }
        public decimal? DblMrpterm { get; set; }
        public decimal? DblMriterm { get; set; }
        public decimal? DblMrdterm { get; set; }
        public decimal? DblPscurrent { get; set; }
        public decimal? DblSupplyTemperature { get; set; }
        public decimal? DblPhaseAcurrent { get; set; }
        public decimal? DblPhaseBcurrent { get; set; }
        public decimal? DblPhaseCcurrent { get; set; }
        public decimal? DblRamPosition { get; set; }
        public decimal? DblRamSpeed { get; set; }
        public decimal? DblVoltage { get; set; }
        public decimal? DblCrucible1Temp { get; set; }
        public decimal? DblCrucible2Temp { get; set; }
        public decimal? DblCrucible1Flow { get; set; }
        public decimal? DblCrucible2Flow { get; set; }
        public decimal? DblCrucible1Wv1position { get; set; }
        public decimal? DblCrucible2Wv2position { get; set; }
        public decimal? DblCoolingPressure { get; set; }
        public decimal? DblChamberPressure { get; set; }
        public decimal? DblChamberPressureLv { get; set; }
        public decimal? DblSmallBlowerPressure { get; set; }
        public decimal? DblMechanicalPumpPressure { get; set; }
        public decimal? DblGroundFaultCurrent { get; set; }
        public decimal? DblLargeBlowerPressure { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TVarmaster SMasterGu { get; set; }
    }
}
