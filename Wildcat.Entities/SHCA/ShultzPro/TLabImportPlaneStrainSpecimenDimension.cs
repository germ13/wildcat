using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TLabImportPlaneStrainSpecimenDimension
    {
        public Guid SDimensionGuid { get; set; }
        public Guid SPlaneStrainGuid { get; set; }
        public decimal? DblWidth { get; set; }
        public decimal? DblThickness { get; set; }
        public decimal? DblSpan { get; set; }
        public decimal? DblInnerRadius { get; set; }
        public decimal? DblOuterRadius { get; set; }
        public decimal? DblLoadingHoleOffset { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TLabImportPlaneStrain SPlaneStrainGu { get; set; }
    }
}
