using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TSawRunChartEntryException
    {
        public Guid SExceptionGuid { get; set; }
        public Guid SEntryGuid { get; set; }
        public string SCategory { get; set; }
        public string SReason { get; set; }
        public string SSystemDescription { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TSawRunChartEntry SEntryGu { get; set; }
    }
}
