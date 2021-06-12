using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TForgeLoadMapTag
    {
        public Guid SRecGuid { get; set; }
        public Guid SFurnaceGuid { get; set; }
        public string STagName { get; set; }
        public string STagType { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TForgeLoadMapFurnace SFurnaceGu { get; set; }
    }
}
