using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TRssweatherDetail
    {
        public Guid SDetailGuid { get; set; }
        public string SDay { get; set; }
        public DateTime? DtDate { get; set; }
        public int? ILow { get; set; }
        public int? IHigh { get; set; }
        public string SText { get; set; }
        public int? ICode { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
