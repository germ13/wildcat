using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class THelpDeskAssetNote
    {
        public Guid SNoteGuid { get; set; }
        public Guid SAssetGuid { get; set; }
        public string SNoteRtf { get; set; }
        public string SNoteText { get; set; }
        public DateTime? DtNote { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public THelpDeskAsset SAssetGu { get; set; }
    }
}
