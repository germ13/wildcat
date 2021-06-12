using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TLabImportStressCorrosionResultSet
    {
        public Guid SScrguid { get; set; }
        public Guid SStressCorrosionGuid { get; set; }
        public string SRecId { get; set; }
        public decimal? DblMinReqDuration { get; set; }
        public decimal? DblActualDuration { get; set; }
        public bool? BIntergranularAttack { get; set; }
        public bool? BPittingCorrosion { get; set; }
        public bool? BTransgranularAttack { get; set; }
        public bool? BConforms { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TLabImportStressCorrosion SStressCorrosionGu { get; set; }
    }
}
