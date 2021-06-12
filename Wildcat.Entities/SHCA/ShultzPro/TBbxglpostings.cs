using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TBbxglpostings
    {
        public Guid SGlpostingsGuid { get; set; }
        public string SKey { get; set; }
        public decimal? CurPostingAmt { get; set; }
        public string SDescriptions { get; set; }
        public DateTime? DtPostingDate { get; set; }
        public int? IPeriodPostedTo { get; set; }
        public DateTime? DtBbxupdt { get; set; }
        public string SBbxupdtBy { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByuserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
