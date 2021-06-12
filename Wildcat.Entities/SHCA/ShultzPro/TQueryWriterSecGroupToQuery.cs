using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TQueryWriterSecGroupToQuery
    {
        public Guid SLinkGuid { get; set; }
        public Guid? SGroupGuid { get; set; }
        public Guid SQueryGuid { get; set; }
        public Guid? SUserGuid { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TQueryWriterSecGroup SGroupGu { get; set; }
        public TQueryWriterSecQuery SQueryGu { get; set; }
    }
}
