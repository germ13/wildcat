using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class THtschedule
    {
        public THtschedule()
        {
            THtscheduleDetail = new HashSet<THtscheduleDetail>();
        }

        public Guid SHtscheduleGuid { get; set; }
        public DateTime? DtScheduled { get; set; }
        public string SScheduleNotes { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<THtscheduleDetail> THtscheduleDetail { get; set; }
    }
}
