using System;
using System.Collections.Generic;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class Country
    {
        public Country()
        {
            CustomerAddress = new HashSet<CustomerAddress>();
            Location = new HashSet<Location>();
        }

        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public bool Active { get; set; }
        public DateTime Added { get; set; }
        public DateTime? Updated { get; set; }
        public string AddedBy { get; set; }
        public string UpdatedBy { get; set; }

        public ICollection<CustomerAddress> CustomerAddress { get; set; }
        public ICollection<Location> Location { get; set; }
    }
}
