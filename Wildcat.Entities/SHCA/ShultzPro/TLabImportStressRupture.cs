using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TLabImportStressRupture
    {
        public TLabImportStressRupture()
        {
            TLabImportStressRuptureAreaReduction = new HashSet<TLabImportStressRuptureAreaReduction>();
            TLabImportStressRuptureDurationStress = new HashSet<TLabImportStressRuptureDurationStress>();
            TLabImportStressRuptureDurationStressStep = new HashSet<TLabImportStressRuptureDurationStressStep>();
            TLabImportStressRuptureElongationResult = new HashSet<TLabImportStressRuptureElongationResult>();
        }

        public Guid SSrguid { get; set; }
        public Guid STestGuid { get; set; }
        public string SSpecimenNumber { get; set; }
        public string SSpecimenDirection { get; set; }
        public string SSpecimenLocation { get; set; }
        public string SSpecimenType { get; set; }
        public string SRemarks { get; set; }
        public string SReqUom { get; set; }
        public string STestTemp { get; set; }
        public decimal? DblTestTempF { get; set; }
        public decimal? DblTestTempC { get; set; }
        public decimal? DblShoulderDiameter { get; set; }
        public decimal? DblShoulderWidth { get; set; }
        public decimal? DblShoulderThickness { get; set; }
        public decimal? DblNotchDiameter { get; set; }
        public decimal? DblNotchWidth { get; set; }
        public decimal? DblNotchRootRadius { get; set; }
        public decimal? DblInitialGageLength4D { get; set; }
        public decimal? DblInitialGageLength5D { get; set; }
        public decimal? DblInitialGageDiameter { get; set; }
        public decimal? DblInitialGageWidth { get; set; }
        public decimal? DblInitialGageThickness { get; set; }
        public decimal? DblFinalGageLength4D { get; set; }
        public decimal? DblFinalGageLength5D { get; set; }
        public decimal? DblFinalGageDiameter { get; set; }
        public decimal? DblFinalGageWidth { get; set; }
        public decimal? DblFinalGageThickness { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TLabImportTest STestGu { get; set; }
        public ICollection<TLabImportStressRuptureAreaReduction> TLabImportStressRuptureAreaReduction { get; set; }
        public ICollection<TLabImportStressRuptureDurationStress> TLabImportStressRuptureDurationStress { get; set; }
        public ICollection<TLabImportStressRuptureDurationStressStep> TLabImportStressRuptureDurationStressStep { get; set; }
        public ICollection<TLabImportStressRuptureElongationResult> TLabImportStressRuptureElongationResult { get; set; }
    }
}
