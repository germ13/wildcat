using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TForgeLoadMapWorkBatch
    {
        public Guid SWorkGuid { get; set; }
        public Guid SDetailGuid { get; set; }
        public string SBatchInstance { get; set; }
        public DateTime? DtRunScheduled { get; set; }
        public int IFurnaceAngle { get; set; }
        public string SJobNum { get; set; }
        public string SMaterial { get; set; }
        public string SSize { get; set; }
        public string SCoating { get; set; }
        public string SSupport { get; set; }
        public DateTime? DtDoNotForgeBefore { get; set; }
        public string SSerialNum { get; set; }
        public decimal DblPerctRadiusFromCenter { get; set; }
        public decimal DblAngleOnFurnace { get; set; }
        public decimal DblPerctWidthOfCanvas { get; set; }
        public decimal DblPerctHeightOfCanvas { get; set; }
        public decimal? DblPartLength { get; set; }
        public decimal? DblPartWidth { get; set; }
        public string SImagePathLarge { get; set; }
        public string SImagePathSmall { get; set; }
        public int? IImageHeight { get; set; }
        public int? IImageWidth { get; set; }
        public string SFurnaceName { get; set; }
        public int? IWidth { get; set; }
        public int? IHeight { get; set; }
        public string SFurnaceType { get; set; }
        public bool BCenterColumn { get; set; }
        public int? ICenterColumnWidth { get; set; }
        public int? ICenterColumnHeight { get; set; }
        public int? IFurnaceRotationAngle { get; set; }
        public bool BIsPartInFurnace { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TForgeLoadMapDetail SDetailGu { get; set; }
        public TForgeLoadMapWorkBatch SWorkGu { get; set; }
        public TForgeLoadMapWorkBatch InverseSWorkGu { get; set; }
    }
}
