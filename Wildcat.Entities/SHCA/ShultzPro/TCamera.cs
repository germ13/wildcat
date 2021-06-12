using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TCamera
    {
        public Guid SCameraGuid { get; set; }
        public string SCameraName { get; set; }
        public string SIpaddress { get; set; }
        public int? IImageWidth { get; set; }
        public int? IImageHeight { get; set; }
        public string SImageUrlpage { get; set; }
        public string SUserName { get; set; }
        public string SPassword { get; set; }
        public bool BShowDateTimestamp { get; set; }
        public int IChannel { get; set; }
        public bool BNoSignal { get; set; }
        public bool BBlurry { get; set; }
        public bool BBoschLogo { get; set; }
        public bool BNoPing { get; set; }
        public bool BNeedsToBeCleaned { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
