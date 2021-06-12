using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TReportToGroup
    {
        public Guid SLinkGuid { get; set; }
        public Guid SReportGuid { get; set; }
        public Guid? SGroupGuid { get; set; }
        public Guid? SUserGuid { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUser { get; set; }
        public byte[] BRowversion { get; set; }

        public TSecGroup SGroupGu { get; set; }
        public TReport SReportGu { get; set; }
    }
}
