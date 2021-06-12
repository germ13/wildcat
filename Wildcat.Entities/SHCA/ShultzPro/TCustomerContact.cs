using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TCustomerContact
    {
        public TCustomerContact()
        {
            TCustomerContactAddress = new HashSet<TCustomerContactAddress>();
            TCustomerContactPhone = new HashSet<TCustomerContactPhone>();
        }

        public Guid SContactGuid { get; set; }
        public Guid SCustomerGuid { get; set; }
        public string STitle { get; set; }
        public string SFirstName { get; set; }
        public string SMiddleName { get; set; }
        public string SLastName { get; set; }
        public string SSuffix { get; set; }
        public string SEmail { get; set; }
        public string SPositionTitle { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TCustomer SCustomerGu { get; set; }
        public ICollection<TCustomerContactAddress> TCustomerContactAddress { get; set; }
        public ICollection<TCustomerContactPhone> TCustomerContactPhone { get; set; }
    }
}
