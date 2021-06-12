using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TAlarmSubscriptionMaster
    {
        public TAlarmSubscriptionMaster()
        {
            TAlarmSubscriptionDetail = new HashSet<TAlarmSubscriptionDetail>();
        }

        public Guid SAlarmSubscriptionMasterGuid { get; set; }
        public string SGroupName { get; set; }
        public string SAlarmType { get; set; }
        public int IStartSubscriptionHour { get; set; }
        public int IStopSubscriptionHour { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TAlarmSubscriptionDetail> TAlarmSubscriptionDetail { get; set; }
    }
}
