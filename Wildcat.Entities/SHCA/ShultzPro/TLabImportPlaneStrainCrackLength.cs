using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TLabImportPlaneStrainCrackLength
    {
        public Guid SCrackLengthGuid { get; set; }
        public Guid SPlaneStrainGuid { get; set; }
        public decimal? DblSide1A4 { get; set; }
        public decimal? DblQuarterPoint1A2 { get; set; }
        public decimal? DblCenterA1 { get; set; }
        public decimal? DblQuarterPoint2A3 { get; set; }
        public decimal? DblSide2A5 { get; set; }
        public decimal? DblAverageA { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TLabImportPlaneStrain SPlaneStrainGu { get; set; }
    }
}
