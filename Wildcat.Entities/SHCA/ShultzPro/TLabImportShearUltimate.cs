using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TLabImportShearUltimate
    {
        public Guid SUltimateGuid { get; set; }
        public Guid SShearGuid { get; set; }
        public decimal? DblMinReqKsi { get; set; }
        public decimal? DblMaxReqKsi { get; set; }
        public decimal? DblMinReqMpa { get; set; }
        public decimal? DblMaxReqMpa { get; set; }
        public decimal? DblUltimateLoad { get; set; }
        public decimal? DblUltimateStrengthKsi { get; set; }
        public decimal? DblUltimateStrengthMpa { get; set; }
        public bool? BConforms { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TLabImportShear SShearGu { get; set; }
    }
}
