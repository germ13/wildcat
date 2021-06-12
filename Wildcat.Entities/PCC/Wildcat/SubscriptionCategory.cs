using System;
using System.Collections.Generic;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class SubscriptionCategory
    {
        public SubscriptionCategory()
        {
            Subscription = new HashSet<Subscription>();
        }

        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string DetailDescription { get; set; }
        public bool Active { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }

        public ICollection<Subscription> Subscription { get; set; }
    }
}
