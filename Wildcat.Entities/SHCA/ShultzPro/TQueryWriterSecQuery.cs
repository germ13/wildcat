using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TQueryWriterSecQuery
    {
        public TQueryWriterSecQuery()
        {
            TQueryWriterSecGroupToQuery = new HashSet<TQueryWriterSecGroupToQuery>();
        }

        public Guid SQueryGuid { get; set; }
        public string SName { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TQueryWriterSecGroupToQuery> TQueryWriterSecGroupToQuery { get; set; }
    }
}
