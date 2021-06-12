using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class THtRegion
    {
        public Guid SHtregionGuid { get; set; }
        public int? IRevNo { get; set; }
        public Guid SHtcycleGuid { get; set; }
        public DateTime? DtRampStart { get; set; }
        public DateTime? DtRampStop { get; set; }
        public DateTime? DtSoakStart { get; set; }
        public DateTime? DtSoakStop { get; set; }
        public int? IRampHh { get; set; }
        public int? IRampMm { get; set; }
        public int? ISoakHh { get; set; }
        public int? ISoakMm { get; set; }
        public int? ITemperature { get; set; }
        public int? ILoLimit { get; set; }
        public int? IHiLimit { get; set; }
        public string SOperatorUserName { get; set; }
        public Guid? SOperatorUserGuid { get; set; }
        public bool BCertified { get; set; }
        public string SCertifiedByUserName { get; set; }
        public Guid? SCertifiedByUserGuid { get; set; }
        public int? IOtoffset { get; set; }
        public int? IRegionNo { get; set; }
        public int? IOvertemp { get; set; }
        public int? ISoakTrigger { get; set; }
        public bool BIsActual { get; set; }
        public int? ISetpointOffset { get; set; }
        public DateTime? DtBenchJobFinish { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUser { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public THtCycle SHtcycleGu { get; set; }
    }
}
