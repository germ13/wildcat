using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TUserBadge
    {
        public Guid SBadgeGuid { get; set; }
        public Guid SUserGuid { get; set; }
        public int IBadgeNum { get; set; }
        public bool? BSupervisor { get; set; }
        public bool? BLeadman { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUser { get; set; }
        public byte[] BRowversion { get; set; }

        public TEmployee SUserGu { get; set; }
    }
}
