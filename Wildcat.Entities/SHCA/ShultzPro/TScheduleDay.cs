using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TScheduleDay
    {
        public Guid SScheduleDayGuid { get; set; }
        public Guid? SScheduleManagerGuid { get; set; }
        public Guid? SMachineGuid { get; set; }
        public DateTime DtCalendar { get; set; }
        public string SCharacters { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TMachine SMachineGu { get; set; }
    }
}
