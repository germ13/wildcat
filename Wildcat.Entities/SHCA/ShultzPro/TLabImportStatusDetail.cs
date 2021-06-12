using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TLabImportStatusDetail
    {
        public Guid SDetailGuid { get; set; }
        public Guid SLabGuid { get; set; }
        public string STestType { get; set; }
        public int ICut { get; set; }
        public int IMachined { get; set; }
        public int ILoaded { get; set; }
        public int IIncomplete { get; set; }
        public int ITotal { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TLabImportStatusLab SLabGu { get; set; }
    }
}
