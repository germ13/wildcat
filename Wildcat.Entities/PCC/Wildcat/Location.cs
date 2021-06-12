using System;
using System.Collections.Generic;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class Location
    {
        public Location()
        {
            Customer = new HashSet<Customer>();
            EndUserToLocation = new HashSet<EndUserToLocation>();
            Furnace = new HashSet<Furnace>();
            NavigationMenuToLocation = new HashSet<NavigationMenuToLocation>();
        }

        public string LocationCode { get; set; }
        public string LocationName { get; set; }
        public string LocationAddress1 { get; set; }
        public string LocationAddress2 { get; set; }
        public string CountryCode { get; set; }
        public string PostalCode { get; set; }
        public bool Active { get; set; }
        public DateTime Added { get; set; }
        public DateTime? Updated { get; set; }
        public string AddedBy { get; set; }
        public string UpdatedBy { get; set; }

        public Country CountryCodeNavigation { get; set; }
        public ICollection<Customer> Customer { get; set; }
        public ICollection<EndUserToLocation> EndUserToLocation { get; set; }
        public ICollection<Furnace> Furnace { get; set; }
        public ICollection<NavigationMenuToLocation> NavigationMenuToLocation { get; set; }
    }
}
