using System;
using System.Collections.Generic;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class EndUser
    {
        public EndUser()
        {
            EndUserToLocation = new HashSet<EndUserToLocation>();
            EndUserToSecurityGroup = new HashSet<EndUserToSecurityGroup>();
        }

        public string AppLoginName { get; set; }
        public string DisplayName { get; set; }
        public string Password { get; set; }
        public string Domain { get; set; }
        public string Email { get; set; }
        public bool Locked { get; set; }
        public bool Active { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }

        public ICollection<EndUserToLocation> EndUserToLocation { get; set; }
        public ICollection<EndUserToSecurityGroup> EndUserToSecurityGroup { get; set; }
    }
}
