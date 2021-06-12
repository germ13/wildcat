using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TPccHoliday
    {
        public Guid SHolidayGuid { get; set; }
        public DateTime DtHoliday { get; set; }
        public string SDesc { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
