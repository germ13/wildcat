using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TScheduleJobCandidate
    {
        public Guid SScheduleJobCandidateGuid { get; set; }
        public string SJobNumber { get; set; }
        public Guid? SForgeGroup { get; set; }
        public int? IForgeStep { get; set; }
        public string SOperationNum { get; set; }
        public int? INumPieces { get; set; }
        public bool? BIsConversion { get; set; }
        public string SList { get; set; }
        public string SNonConformingMaterial { get; set; }
        public bool BInActive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
