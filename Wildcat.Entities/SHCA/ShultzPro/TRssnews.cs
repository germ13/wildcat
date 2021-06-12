using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TRssnews
    {
        public Guid SNewsGuid { get; set; }
        public string STitle { get; set; }
        public string SDescription { get; set; }
        public DateTime DtPublication { get; set; }
        public string SImagePath { get; set; }
        public int ISortOrder { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
