using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TForgeMetricNote
    {
        public Guid SNoteGuid { get; set; }
        public Guid SMetricGuid { get; set; }
        public Guid? SRtfguid { get; set; }
        public Guid? SAttachmentGuid { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TForgeMetric SMetricGu { get; set; }
    }
}
