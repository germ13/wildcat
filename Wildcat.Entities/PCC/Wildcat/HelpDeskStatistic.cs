using System;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class HelpDeskStatistic
    {
        public int StatisticId { get; set; }
        public DateTime SnapshotDate { get; set; }
        public int? TotalCaseCount { get; set; }
        public int? Dispatch { get; set; }
        public int? InQueue { get; set; }
        public int? InService { get; set; }
        public int? Over30Count { get; set; }
        public int? Over60Count { get; set; }
        public int? AverageHoursToClose { get; set; }
        public int? ClosedLast24Hours { get; set; }
        public int? ClosedLast7Days { get; set; }
        public bool Active { get; set; }
        public DateTime Added { get; set; }
        public DateTime? Updated { get; set; }
        public string AddedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
