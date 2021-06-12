using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TLabImportTensile
    {
        public TLabImportTensile()
        {
            TLabImportTensileAreaReduction = new HashSet<TLabImportTensileAreaReduction>();
            TLabImportTensileElongationResult = new HashSet<TLabImportTensileElongationResult>();
            TLabImportTensileOffset = new HashSet<TLabImportTensileOffset>();
            TLabImportTensileSystemData = new HashSet<TLabImportTensileSystemData>();
            TLabImportTensileUltimate = new HashSet<TLabImportTensileUltimate>();
        }

        public Guid STensileGuid { get; set; }
        public Guid STestGuid { get; set; }
        public string SSpecimenNumber { get; set; }
        public string SSpecimenDirection { get; set; }
        public string SRemarks { get; set; }
        public string SReqUom { get; set; }
        public string STestTemp { get; set; }
        public decimal? DblTestTempF { get; set; }
        public decimal? DblTestTempC { get; set; }
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
        public ICollection<TLabImportTensileAreaReduction> TLabImportTensileAreaReduction { get; set; }
        public ICollection<TLabImportTensileElongationResult> TLabImportTensileElongationResult { get; set; }
        public ICollection<TLabImportTensileOffset> TLabImportTensileOffset { get; set; }
        public ICollection<TLabImportTensileSystemData> TLabImportTensileSystemData { get; set; }
        public ICollection<TLabImportTensileUltimate> TLabImportTensileUltimate { get; set; }
    }
}
