using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TMillImportBadJobs
    {
        public Guid SBadJobGuid { get; set; }
        public string SImportFileNumber { get; set; }
        public string SCompany { get; set; }
        public string STimestampIdentifier { get; set; }
        public DateTime DtProcessed { get; set; }
        public DateTime? DtLastEmailed { get; set; }
        public string SMessage { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
