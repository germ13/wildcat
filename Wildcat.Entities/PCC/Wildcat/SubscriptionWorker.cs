using System;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class SubscriptionWorker
    {
        public int Id { get; set; }
        public int WorkerId { get; set; }
        public int SubscriptionId { get; set; }
        public bool Active { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }

        public Subscription Subscription { get; set; }
        public Worker Worker { get; set; }
    }
}
