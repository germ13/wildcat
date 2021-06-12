using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TLabImportRevision
    {
        public Guid SRevisionGuid { get; set; }
        public Guid STestGuid { get; set; }
        public string SRecId { get; set; }
        public DateTime? DtRevision { get; set; }
        public string SRemarks { get; set; }
        public string SDescription { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TLabImportTest STestGu { get; set; }
    }
}
