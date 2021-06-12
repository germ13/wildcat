using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TStar90184
    {
        public int IRecId { get; set; }
        public string SKey { get; set; }
        public string SSpecificationNumberId { get; set; }
        public string SCustomerName { get; set; }
        public string SLatestRevisionApproved { get; set; }
        public DateTime? DtApprovedRevision { get; set; }
        public string SSpecTitleLine1 { get; set; }
        public string SSpecTitleLine2 { get; set; }
        public string SSpectTitleLine3 { get; set; }
        public DateTime? DtShultzSteelReview { get; set; }
        public string SCustomerLatestRevisionLetter { get; set; }
        public DateTime? DtCustomerLatestRevision { get; set; }
        public string SCommentExceptionLine1 { get; set; }
        public string SCommentExceptionLine2 { get; set; }
        public string SEmpty01 { get; set; }
        public string SEmpty02 { get; set; }
        public string SEmpty03 { get; set; }
        public string SEmpty04 { get; set; }
        public string SEmpty05 { get; set; }
        public string SEmpty06 { get; set; }
        public string SEmpty07 { get; set; }
        public string SEmpty08 { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
