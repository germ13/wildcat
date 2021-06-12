using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TCustomer
    {
        public TCustomer()
        {
            TCustomerAddress = new HashSet<TCustomerAddress>();
            TCustomerContact = new HashSet<TCustomerContact>();
            TCustomerPhone = new HashSet<TCustomerPhone>();
        }

        public Guid SCustomerGuid { get; set; }
        public string SAccountNumber { get; set; }
        public string SCompanyName { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TCustomerAddress> TCustomerAddress { get; set; }
        public ICollection<TCustomerContact> TCustomerContact { get; set; }
        public ICollection<TCustomerPhone> TCustomerPhone { get; set; }
    }
}
