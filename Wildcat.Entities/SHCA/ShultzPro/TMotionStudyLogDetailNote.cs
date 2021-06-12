using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TMotionStudyLogDetailNote
    {
        public Guid SNoteGuid { get; set; }
        public Guid SDetailGuid { get; set; }
        public string SNote { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TMotionStudyLogDetail SDetailGu { get; set; }
    }
}
