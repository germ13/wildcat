using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TLabImportTensileAreaReduction
    {
        public Guid SArguid { get; set; }
        public Guid STensileGuid { get; set; }
        public decimal? DblMinReq { get; set; }
        public decimal? DblResult { get; set; }
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
