using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TScheduleJobOpenTraveler
    {
        public Guid SOpenTravelerGuid { get; set; }
        public string SJobNumber { get; set; }
        public string SDescLine { get; set; }
        public string SDescLine1Only { get; set; }
        public decimal? DblMachineHoursEstimated { get; set; }
        public int? IStepNumber { get; set; }
        public string SOperationNum { get; set; }
        public string SStatus { get; set; }
        public DateTime? DtComplete { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
