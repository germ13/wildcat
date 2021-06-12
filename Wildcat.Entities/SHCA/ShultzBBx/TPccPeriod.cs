using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TPccPeriod
    {
        public int IRecId { get; set; }
        public string SKey { get; set; }
        public DateTime? DtDayOfTheYear { get; set; }
        public int? IYear { get; set; }
        public int? IPeriod { get; set; }
        public int? IWeek { get; set; }
        public int? IWorkingDayOfYear { get; set; }
        public int? IWorkingDayOfPeriod { get; set; }
        public int? IWorkingDayOfWeek { get; set; }
        public DateTime? DtDateOfFirstMondayOfWeek { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
