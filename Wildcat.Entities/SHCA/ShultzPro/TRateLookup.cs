using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TRateLookup
    {
        public Guid SRateGuid { get; set; }
        public string SKey { get; set; }
        public decimal DblBottomRate { get; set; }
        public decimal DblTopRate { get; set; }
        public decimal DblReturnRate { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
