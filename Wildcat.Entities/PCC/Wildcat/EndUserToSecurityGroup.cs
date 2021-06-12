using System;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class EndUserToSecurityGroup
    {
        public string EndUserAppLoginName { get; set; }
        public string SecurityName { get; set; }
        public bool Active { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime Updated { get; set; }

        public EndUser EndUserAppLoginNameNavigation { get; set; }
        public SecurityGroup SecurityNameNavigation { get; set; }
    }
}
