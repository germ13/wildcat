using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TForgeClampMaster
    {
        public TForgeClampMaster()
        {
            TForgeClampOperation = new HashSet<TForgeClampOperation>();
        }

        public Guid SMasterGuid { get; set; }
        public string SJobNum { get; set; }
        public string SRevision { get; set; }
        public string SPress { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TForgeClampOperation> TForgeClampOperation { get; set; }
    }
}
