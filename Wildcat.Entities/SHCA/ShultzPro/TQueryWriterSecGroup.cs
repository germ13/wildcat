using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TQueryWriterSecGroup
    {
        public TQueryWriterSecGroup()
        {
            TQueryWriterSecGroupToObject = new HashSet<TQueryWriterSecGroupToObject>();
            TQueryWriterSecGroupToQuery = new HashSet<TQueryWriterSecGroupToQuery>();
            TQueryWriterSecUserToGroup = new HashSet<TQueryWriterSecUserToGroup>();
        }

        public Guid SGroupGuid { get; set; }
        public string SDesc { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TQueryWriterSecGroupToObject> TQueryWriterSecGroupToObject { get; set; }
        public ICollection<TQueryWriterSecGroupToQuery> TQueryWriterSecGroupToQuery { get; set; }
        public ICollection<TQueryWriterSecUserToGroup> TQueryWriterSecUserToGroup { get; set; }
    }
}
