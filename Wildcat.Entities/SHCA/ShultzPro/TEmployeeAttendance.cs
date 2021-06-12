using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TEmployeeAttendance
    {
        public Guid SReasonGuid { get; set; }
        public Guid SEmployeeGuid { get; set; }
        public DateTime DtEntry { get; set; }
        public decimal DblHours { get; set; }
        public string SReason { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TEmployee SEmployeeGu { get; set; }
    }
}
