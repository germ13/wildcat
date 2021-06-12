using System;

namespace Wildcat.Entities.CFCA.Saws
{
    public partial class SawCalcPendingAlerts
    {
        public int PendingAlertId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UserId { get; set; }
        public string Message { get; set; }
    }
}
