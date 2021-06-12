using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TLabImportMicroMetallurgyResult
    {
        public Guid SResultGuid { get; set; }
        public Guid SMicroMetallurgyGuid { get; set; }
        public string SRecId { get; set; }
        public string SResult { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TLabImportMicroMetallurgy SMicroMetallurgyGu { get; set; }
    }
}
