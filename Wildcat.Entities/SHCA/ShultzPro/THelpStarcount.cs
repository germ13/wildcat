using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class THelpStarcount
    {
        public Guid SLogGuid { get; set; }
        public DateTime DtCurrent { get; set; }
        public int ITotalCaseCount { get; set; }
        public int IDispatchCount { get; set; }
        public int IInQueueCount { get; set; }
        public int IInServiceCount { get; set; }
        public int IGreaterThan30Count { get; set; }
        public int IGreaterThan60Count { get; set; }
        public int ICountClosedInLast7Days { get; set; }
        public int ICountClosedInLast24Hours { get; set; }
        public int IAverageInSeconds { get; set; }
        public int IAverageInMinutes { get; set; }
        public int IAverageInHours { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
