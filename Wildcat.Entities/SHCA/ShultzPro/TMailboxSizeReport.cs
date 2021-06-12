using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TMailboxSizeReport
    {
        public Guid SRecGuid { get; set; }
        public DateTime DtRecord { get; set; }
        public string SDisplayName { get; set; }
        public int ITotalItemSizeKb { get; set; }
        public int IItemCount { get; set; }
        public string SStorageGroup { get; set; }
        public bool BArchive { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
