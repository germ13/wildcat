using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TForgeLoadMapSnapshotDetail
    {
        public Guid SSnapshotDetailGuid { get; set; }
        public Guid SSnapShotMainGuid { get; set; }
        public Guid SDetailGuid { get; set; }
        public Guid SBatchGuid { get; set; }
        public Guid SFurnaceGuid { get; set; }
        public int IFurnaceAngle { get; set; }
        public string SJobNum { get; set; }
        public string SSerialNum { get; set; }
        public decimal? DblPercFromRadius { get; set; }
        public decimal? DblAngleOnFurnace { get; set; }
        public decimal? DblPerctWidthOfCanvas { get; set; }
        public decimal? DblPerctHeightOfCanvas { get; set; }
        public Guid? SAttachmentGuid { get; set; }
        public Guid SItemGuid { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TForgeLoadMapSnapshot SSnapShotMainGu { get; set; }
    }
}
