using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TQueryWriterSecObject
    {
        public TQueryWriterSecObject()
        {
            TQueryWriterSecGroupToObject = new HashSet<TQueryWriterSecGroupToObject>();
        }

        public Guid SObjectGuid { get; set; }
        public string STableName { get; set; }
        public string SFieldName { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TQueryWriterSecGroupToObject> TQueryWriterSecGroupToObject { get; set; }
    }
}
