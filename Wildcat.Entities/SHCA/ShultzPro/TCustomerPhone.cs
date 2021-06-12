using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TCustomerPhone
    {
        public Guid SPhoneGuid { get; set; }
        public Guid SCustomerGuid { get; set; }
        public string STypeCode { get; set; }
        public string SPhoneNumber { get; set; }
        public string SPhoneHash { get; set; }
        public bool BIsDefault { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TCustomer SCustomerGu { get; set; }
    }
}
