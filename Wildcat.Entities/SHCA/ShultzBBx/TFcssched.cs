using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TFcssched
    {
        public int IRecId { get; set; }
        public string SKey { get; set; }
        public string SOpCode { get; set; }
        public DateTime? DtScheduledDate { get; set; }
        public string SJobNumber { get; set; }
        public int? IHours { get; set; }
        public int? IQuantities { get; set; }
        public int? ISteps { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
