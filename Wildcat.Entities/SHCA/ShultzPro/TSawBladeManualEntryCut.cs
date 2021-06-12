using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TSawBladeManualEntryCut
    {
        public Guid SManualEntryGuid { get; set; }
        public Guid SBladeMasterGuid { get; set; }
        public string SJobNum { get; set; }
        public string SAlloyType { get; set; }
        public string SMaterialSize { get; set; }
        public string SSawName { get; set; }
        public decimal? DblBladeFeed { get; set; }
        public decimal? DblBladeSpeed { get; set; }
        public int IPercentageOfCut { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
