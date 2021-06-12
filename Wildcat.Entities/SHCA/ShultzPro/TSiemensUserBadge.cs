using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TSiemensUserBadge
    {
        public Guid SBadgeGuid { get; set; }
        public Guid SUserGuid { get; set; }
        public int IBadgeNumber { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUser { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUser { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
