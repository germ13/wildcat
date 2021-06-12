using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TLabImportCreepElongationResult
    {
        public Guid SResultGuid { get; set; }
        public Guid SCreepGuid { get; set; }
        public decimal? DblMinReq4D { get; set; }
        public decimal? DblResult4D { get; set; }
        public bool? BConforms4D { get; set; }
        public decimal? DblMinReq5D { get; set; }
        public decimal? DblResult5D { get; set; }
        public bool? BConforms5D { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TLabImportCreep SCreepGu { get; set; }
    }
}
