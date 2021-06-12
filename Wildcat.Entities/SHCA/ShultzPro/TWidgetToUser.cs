using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TWidgetToUser
    {
        public Guid SLinkGuid { get; set; }
        public Guid SWidgetGuid { get; set; }
        public Guid SUserGuid { get; set; }
        public int IRefreshIntervalInSeconds { get; set; }
        public string SDockColumn { get; set; }
        public int ISortOrder { get; set; }
        public bool BAllowOutOfZone { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TUser SUserGu { get; set; }
        public TWidget SWidgetGu { get; set; }
    }
}
