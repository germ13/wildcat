using System;
using System.Collections.Generic;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class Subscription
    {
        public Subscription()
        {
            SubscriptionWorker = new HashSet<SubscriptionWorker>();
        }

        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string NameCode { get; set; }
        public string DisplayName { get; set; }
        public bool Active { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }

        public SubscriptionCategory Category { get; set; }
        public ICollection<SubscriptionWorker> SubscriptionWorker { get; set; }
    }
}
