using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TMasterToolInventoryLink
    {
        public Guid SLinkGuid { get; set; }
        public Guid SPart1Guid { get; set; }
        public Guid SPart2Guid { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
