using System;
using System.Collections.Generic;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class Worker
    {
        public Worker()
        {
            FurnaceAlarmToWorker = new HashSet<FurnaceAlarmToWorker>();
            SubscriptionWorker = new HashSet<SubscriptionWorker>();
            WorkerToTeam = new HashSet<WorkerToTeam>();
        }

        public int Id { get; set; }
        public int? EndUserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool? IsSalary { get; set; }
        public string BadgeNumber { get; set; }
        public string MobileNumber { get; set; }
        public string DaysOfWeek { get; set; }
        public TimeSpan? ShiftStart { get; set; }
        public TimeSpan? ShiftEnd { get; set; }
        public bool Active { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }

        public ICollection<FurnaceAlarmToWorker> FurnaceAlarmToWorker { get; set; }
        public ICollection<SubscriptionWorker> SubscriptionWorker { get; set; }
        public ICollection<WorkerToTeam> WorkerToTeam { get; set; }
    }
}
