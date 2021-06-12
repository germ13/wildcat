using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class THtJob
    {
        public THtJob()
        {
            THtJobPiece = new HashSet<THtJobPiece>();
        }

        public Guid SJobGuid { get; set; }
        public Guid SHtcycleGuid { get; set; }
        public string SJobNo { get; set; }
        public string SJobExt { get; set; }
        public int? IStepNo { get; set; }
        public int? IOperationNo { get; set; }
        public string SHtno { get; set; }
        public string SHtcode { get; set; }
        public int? IHardnessTestSampleSize { get; set; }
        public int? IHardnessRangeHi { get; set; }
        public string SHardnessScale { get; set; }
        public int? IHardnessRangeLo { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUser { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public THtCycle SHtcycleGu { get; set; }
        public ICollection<THtJobPiece> THtJobPiece { get; set; }
    }
}
