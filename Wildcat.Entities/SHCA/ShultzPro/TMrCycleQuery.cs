using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TMrCycleQuery
    {
        public Guid SLinkGuid { get; set; }
        public Guid SMrcycleGuid { get; set; }
        public Guid SQueryGuid { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUser { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TMrCycle SMrcycleGu { get; set; }
        public TMrOperatorQuery SQueryGu { get; set; }
    }
}
