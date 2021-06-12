using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TAlarmSubscriptionDetail
    {
        public Guid SAlarmSubscriptionDetailGuid { get; set; }
        public Guid SAlarmSubscriptionMasterGuid { get; set; }
        public Guid SEmployeeGuid { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TAlarmSubscriptionMaster SAlarmSubscriptionMasterGu { get; set; }
    }
}
