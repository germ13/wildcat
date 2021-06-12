using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TLabImportTensileOffset
    {
        public Guid SOffsetGuid { get; set; }
        public Guid STensileGuid { get; set; }
        public string SRecId { get; set; }
        public decimal? DblPercent { get; set; }
        public decimal? DblMinReqKsi { get; set; }
        public decimal? DblMaxReqKsi { get; set; }
        public decimal? DblMinReqMpa { get; set; }
        public decimal? DblMaxReqMpa { get; set; }
        public decimal? DblYieldLoad { get; set; }
        public decimal? DblYieldStrengthKsi { get; set; }
        public decimal? DblYieldStrengthMpa { get; set; }
        public bool? BConforms { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TLabImportTensile STensileGu { get; set; }
    }
}
