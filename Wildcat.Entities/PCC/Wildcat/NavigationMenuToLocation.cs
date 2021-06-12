using System;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class NavigationMenuToLocation
    {
        public Guid NavigationMenu { get; set; }
        public string LocationCode { get; set; }
        public bool Active { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }

        public Location LocationCodeNavigation { get; set; }
        public NavigationMenu NavigationMenuNavigation { get; set; }
    }
}
