using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class THtJobPiece
    {
        public Guid SHtpieceGuid { get; set; }
        public Guid SPieceGuid { get; set; }
        public Guid SJobGuid { get; set; }
        public string SSerialNo { get; set; }
        public string STestedByUserName { get; set; }
        public Guid? STestedByUserGuid { get; set; }
        public DateTime? DtTesting { get; set; }
        public bool BCertified { get; set; }
        public string SCertifiedByUserName { get; set; }
        public Guid? SCertifiedByUserGuid { get; set; }
        public decimal? DblHardnessResult { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUser { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public THtJob SJobGu { get; set; }
        public TMrPiece SPieceGu { get; set; }
    }
}
