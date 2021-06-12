using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TSawBladeDetail
    {
        public Guid SDetailGuid { get; set; }
        public Guid SEntryGuid { get; set; }
        public Guid SBladeMasterGuid { get; set; }
        public decimal? DblBladeFeed { get; set; }
        public decimal? DblBladeSpeed { get; set; }
        public int IPercentageOfCut { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TSawBladeMaster SBladeMasterGu { get; set; }
        public TSawRunChartEntry SEntryGu { get; set; }
    }
}
