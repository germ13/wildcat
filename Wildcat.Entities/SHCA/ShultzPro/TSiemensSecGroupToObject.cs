using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TSiemensSecGroupToObject
    {
        public Guid SLinkGuid { get; set; }
        public Guid? SGroupGuid { get; set; }
        public Guid? SUserGuid { get; set; }
        public Guid SObjectGuid { get; set; }
        public int? IAccessLevel { get; set; }
        public DateTime DtAdded { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUser { get; set; }
        public byte[] BRowversion { get; set; }

        public TSiemensSecGroup SGroupGu { get; set; }
        public TSiemensSecObject SObjectGu { get; set; }
    }
}
