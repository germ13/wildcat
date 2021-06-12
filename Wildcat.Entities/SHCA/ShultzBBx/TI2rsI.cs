using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TI2rsI
    {
        public int IRecId { get; set; }
        public string SKey { get; set; }
        public string SInventoryMasterKey { get; set; }
        public string SHeatSequenceNumber { get; set; }
        public string SOrderNumber { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
