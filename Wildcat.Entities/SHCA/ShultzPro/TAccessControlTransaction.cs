using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TAccessControlTransaction
    {
        public Guid SAcguid { get; set; }
        public string SEnterValue { get; set; }
        public string SComputerName { get; set; }
        public DateTime? DtEvent { get; set; }
        public string SObjectName { get; set; }
        public string SOperationName { get; set; }
        public string SFirstName { get; set; }
        public string SLastName { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
