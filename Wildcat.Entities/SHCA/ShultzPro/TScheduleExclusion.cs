using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TScheduleExclusion
    {
        public Guid SScheduleExclusionGuid { get; set; }
        public int ISortOrder { get; set; }
        public string SCode { get; set; }
        public string SDescription { get; set; }
        public bool BInActive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
