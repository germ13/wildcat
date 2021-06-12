using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TLabImportTensileSystemData
    {
        public Guid SDataGuid { get; set; }
        public Guid STensileGuid { get; set; }
        public string SRecId { get; set; }
        public string SData { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TLabImportTensile STensileGu { get; set; }
    }
}
