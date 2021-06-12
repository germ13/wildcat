using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TSawConversionDetail
    {
        public Guid SDetailGuid { get; set; }
        public Guid SConversionGuid { get; set; }
        public string SBilletNum { get; set; }
        public string SBilletSize { get; set; }
        public decimal? DblPlannedWeightAfterForge { get; set; }
        public decimal? DblLengthAfterForge { get; set; }
        public decimal? DblWeightAfterForge { get; set; }
        public decimal? DblPlannedSonicUsableLength { get; set; }
        public decimal? DblSonicUsableLength { get; set; }
        public decimal? DblInventoryLength { get; set; }
        public decimal? DblInventoryWeight { get; set; }
        public string SPlannedJobForBillet { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TSawConversionMaster SConversionGu { get; set; }
    }
}
