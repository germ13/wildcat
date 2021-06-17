using System.Collections.Generic;
using Wildcat.Entities.PCC.Wildcat;

namespace Wildcat.App.SHCA.ViewModels.Engineering
{
    public class FurnaceAlarmSubscriptions
    {
        public List<FurnaceAlarmSubscription> FurnaceAlarmSubscription { get; set; }
        public List<Worker> WorkersAll { get; set; }

        public FurnaceAlarmSubscriptions()
        {
        }
    }

    public class FurnaceAlarmSubscription
    {
        public Subscription Subscription { get; set; }
        public List<Worker> Worker { get; set; }

        public FurnaceAlarmSubscription()
        {
        }
    }
}