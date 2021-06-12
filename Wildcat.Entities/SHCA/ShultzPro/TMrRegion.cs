using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TMrRegion
    {
        public Guid SMrregionGuid { get; set; }
        public Guid SMrcycleGuid { get; set; }
        public int IRampHh { get; set; }
        public int IRampMm { get; set; }
        public int ISoakHh { get; set; }
        public int ISoakMm { get; set; }
        public int ITemperature { get; set; }
        public int IHiLimit { get; set; }
        public int ILoLimit { get; set; }
        public int IOtoffset { get; set; }
        public int? IRegionNo { get; set; }
        public int? ISoakTrigger { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUser { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TMrCycle SMrcycleGu { get; set; }
    }
}
