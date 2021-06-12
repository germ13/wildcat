using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TLabImportNote
    {
        public Guid SNoteGuid { get; set; }
        public Guid STestGuid { get; set; }
        public string SNote { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TLabImportTest STestGu { get; set; }
    }
}
