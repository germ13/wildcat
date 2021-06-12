using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TForgeLoadMapSnapshot
    {
        public TForgeLoadMapSnapshot()
        {
            TForgeLoadMapSnapshotDetail = new HashSet<TForgeLoadMapSnapshotDetail>();
        }

        public Guid SSnapshotGuid { get; set; }
        public Guid SAttachmentGuid { get; set; }
        public Guid SFurnaceGuid { get; set; }
        public DateTime DtAdded { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SAddedBy { get; set; }
        public string SUpdatedBy { get; set; }

        public ICollection<TForgeLoadMapSnapshotDetail> TForgeLoadMapSnapshotDetail { get; set; }
    }
}
