using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TScheduleManager
    {
        public Guid SScheduleManagerGuid { get; set; }
        public Guid? SScheduleBreak1Guid { get; set; }
        public int? IDaysInWeek { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
        public Guid? SScheduleBreak2Guid { get; set; }
    }
}
