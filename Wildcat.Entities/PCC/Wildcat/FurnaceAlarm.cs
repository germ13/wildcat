using System;
using System.Collections.Generic;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class FurnaceAlarm
    {
        public FurnaceAlarm()
        {
            FurnaceAlarmToWorker = new HashSet<FurnaceAlarmToWorker>();
        }

        public int Id { get; set; }
        public string CodeName { get; set; }
        public string DisplayName { get; set; }
        public string AlarmType { get; set; }
        public bool Active { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }

        public ICollection<FurnaceAlarmToWorker> FurnaceAlarmToWorker { get; set; }
    }
}
