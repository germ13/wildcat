using System;
using System.Collections.Generic;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class SecurityGroup
    {
        public SecurityGroup()
        {
            EndUserToSecurityGroup = new HashSet<EndUserToSecurityGroup>();
            NavigationMenuToSecurityGroup = new HashSet<NavigationMenuToSecurityGroup>();
        }

        public string SecurityName { get; set; }
        public bool Active { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? Updated { get; set; }

        public ICollection<EndUserToSecurityGroup> EndUserToSecurityGroup { get; set; }
        public ICollection<NavigationMenuToSecurityGroup> NavigationMenuToSecurityGroup { get; set; }
    }
}
