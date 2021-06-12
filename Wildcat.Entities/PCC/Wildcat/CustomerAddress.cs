using System;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class CustomerAddress
    {
        public string Id { get; set; }
        public string CustomerId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string PostalCode { get; set; }
        public string CountryCode { get; set; }
        public string Notes { get; set; }
        public bool Active { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Rowversion { get; set; }

        public Country CountryCodeNavigation { get; set; }
        public Customer Customer { get; set; }
    }
}
