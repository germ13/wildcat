using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TMasterToolInventoryDetail
    {
        public Guid SDetailGuid { get; set; }
        public Guid SPartGuid { get; set; }
        public int ISinkNumber { get; set; }
        public DateTime? DtRun { get; set; }
        public string SJobNum { get; set; }
        public int? INumStrikes { get; set; }
        public int? IPcsToDate { get; set; }
        public int ISortOrder { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TMasterToolInventory SPartGu { get; set; }
    }
}
