using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TQueryWriterSecUserToGroup
    {
        public Guid SLinkGuid { get; set; }
        public Guid SGroupGuid { get; set; }
        public Guid SUserGuid { get; set; }
        public DateTime DtAdded { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SAddedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
        public bool BInactive { get; set; }
        public string SUpdatedByUserId { get; set; }

        public TQueryWriterSecGroup SGroupGu { get; set; }
    }
}
