using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TInventoryCount
    {
        public Guid SInventoryGuid { get; set; }
        public string SType { get; set; }
        public string STagNum { get; set; }
        public string SJobNum { get; set; }
        public int? IQty { get; set; }
        public string SLocation { get; set; }
        public string SCountedBy { get; set; }
        public string SHeatNum { get; set; }
        public string SBilletNum { get; set; }
        public string SAlloy { get; set; }
        public string SSize { get; set; }
        public decimal? DblWeight { get; set; }
        public decimal? DblLength { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
