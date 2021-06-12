using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TLabImportStressRuptureDurationStress
    {
        public Guid SStressGuid { get; set; }
        public Guid SSrguid { get; set; }
        public decimal? DblMinReqDuration { get; set; }
        public decimal? DblMinReqStressKsi { get; set; }
        public decimal? DblMinReqStressMpa { get; set; }
        public decimal? DblDuration { get; set; }
        public decimal? DblStressKsi { get; set; }
        public decimal? DblStressMpa { get; set; }
        public bool? BConforms { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TLabImportStressRupture SSrgu { get; set; }
    }
}
