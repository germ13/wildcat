using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TFcspriority
    {
        public int IRecId { get; set; }
        public string SKey { get; set; }
        public string SPriority { get; set; }
        public DateTime? DtDueDate { get; set; }
        public string SJobNumber { get; set; }
        public int? IQuantityRequiredOnDueDate { get; set; }
        public string SGrade { get; set; }
        public string SCreatedFromMasterOrder { get; set; }
        public int? IOriginalQuantityOnOrder { get; set; }
        public string SDeliveryNumber { get; set; }
        public string SForgeQuantity { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
