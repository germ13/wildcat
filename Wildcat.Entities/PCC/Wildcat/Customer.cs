using System;
using System.Collections.Generic;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class Customer
    {
        public Customer()
        {
            CustomerAddress = new HashSet<CustomerAddress>();
            CustomerContact = new HashSet<CustomerContact>();
        }

        public string Id { get; set; }
        public string CustomerName { get; set; }
        public string LocationCode { get; set; }
        public string Notes { get; set; }
        public bool Active { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Rowversion { get; set; }

        public Location LocationCodeNavigation { get; set; }
        public ICollection<CustomerAddress> CustomerAddress { get; set; }
        public ICollection<CustomerContact> CustomerContact { get; set; }
    }
}
