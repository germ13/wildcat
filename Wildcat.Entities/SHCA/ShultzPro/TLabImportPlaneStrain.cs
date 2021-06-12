using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TLabImportPlaneStrain
    {
        public TLabImportPlaneStrain()
        {
            TLabImportPlaneStrainCrackLength = new HashSet<TLabImportPlaneStrainCrackLength>();
            TLabImportPlaneStrainInvalidity = new HashSet<TLabImportPlaneStrainInvalidity>();
            TLabImportPlaneStrainSpecimenDimension = new HashSet<TLabImportPlaneStrainSpecimenDimension>();
            TLabImportPrecrack = new HashSet<TLabImportPrecrack>();
        }

        public Guid SPlaneStrainGuid { get; set; }
        public Guid STestGuid { get; set; }
        public string SSpecimenNumber { get; set; }
        public string SSpecimenDirection { get; set; }
        public string SSpecimenGeometry { get; set; }
        public string SReqUom { get; set; }
        public string SStrengthRatio { get; set; }
        public string SObliqueFracture { get; set; }
        public string SRemarks { get; set; }
        public int? IInvaliditiesPresent { get; set; }
        public decimal? DblMinReqKsi { get; set; }
        public decimal? DblMinReqMpam { get; set; }
        public decimal? DblMaxMpam { get; set; }
        public decimal? DblMinReqNmm { get; set; }
        public decimal? DblMaxReqNmm { get; set; }
        public decimal? DblResultKsi { get; set; }
        public decimal? DblResultMpam { get; set; }
        public decimal? DblResultNmm { get; set; }
        public bool? BConforms { get; set; }
        public decimal? DblCandidateLoad { get; set; }
        public decimal? DblMaxLoad { get; set; }
        public decimal? DblKrate { get; set; }
        public decimal? DblOffsetYield2TenthsKsi { get; set; }
        public decimal? DblOffsetYield2TenthsMpa { get; set; }
        public decimal? DblInitialPrecracking { get; set; }
        public decimal? DblFinalPrecracking { get; set; }
        public decimal? DblAmbientRoomTemp { get; set; }
        public decimal? DblAmbientRelativeHumidity { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TLabImportTest STestGu { get; set; }
        public ICollection<TLabImportPlaneStrainCrackLength> TLabImportPlaneStrainCrackLength { get; set; }
        public ICollection<TLabImportPlaneStrainInvalidity> TLabImportPlaneStrainInvalidity { get; set; }
        public ICollection<TLabImportPlaneStrainSpecimenDimension> TLabImportPlaneStrainSpecimenDimension { get; set; }
        public ICollection<TLabImportPrecrack> TLabImportPrecrack { get; set; }
    }
}
