using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TForgeMetricGreenhouseGasTarget
    {
        public Guid STargetGuid { get; set; }
        public string SJobNumMaster { get; set; }
        public string SUnit { get; set; }
        public string SOperation { get; set; }
        public decimal? DblTarget2009 { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
