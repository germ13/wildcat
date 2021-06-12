using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TLabImportCreep
    {
        public TLabImportCreep()
        {
            TLabImportCreepAreaReduction = new HashSet<TLabImportCreepAreaReduction>();
            TLabImportCreepElongationResult = new HashSet<TLabImportCreepElongationResult>();
            TLabImportCreepSystemData = new HashSet<TLabImportCreepSystemData>();
            TLabImportCreepTime = new HashSet<TLabImportCreepTime>();
        }

        public Guid SCreepGuid { get; set; }
        public Guid STestGuid { get; set; }
        public string SSpecimenNumber { get; set; }
        public string SSpecimenDirection { get; set; }
        public string SSpecimenLocation { get; set; }
        public string SRemarks { get; set; }
        public string SReqUom { get; set; }
        public decimal? DblTestTempF { get; set; }
        public decimal? DblTestTempC { get; set; }
        public decimal? DblRequiredStressKsi { get; set; }
        public decimal? DblRequiredStressMpa { get; set; }
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
        public ICollection<TLabImportCreepAreaReduction> TLabImportCreepAreaReduction { get; set; }
        public ICollection<TLabImportCreepElongationResult> TLabImportCreepElongationResult { get; set; }
        public ICollection<TLabImportCreepSystemData> TLabImportCreepSystemData { get; set; }
        public ICollection<TLabImportCreepTime> TLabImportCreepTime { get; set; }
    }
}
