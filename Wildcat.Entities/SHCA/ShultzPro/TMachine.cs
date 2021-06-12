using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TMachine
    {
        public TMachine()
        {
            TScheduleDay = new HashSet<TScheduleDay>();
            TScheduleJob = new HashSet<TScheduleJob>();
        }

        public Guid SMachineGuid { get; set; }
        public string SCode { get; set; }
        public string SDescription { get; set; }
        public bool? BServiceRequested { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TScheduleDay> TScheduleDay { get; set; }
        public ICollection<TScheduleJob> TScheduleJob { get; set; }
    }
}
