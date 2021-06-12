using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TDprarchiveDetail
    {
        public Guid SArchiveGuid { get; set; }
        public Guid SFileGuid { get; set; }
        public string SDepartment { get; set; }
        public string SOperationNum { get; set; }
        public string SStepNum { get; set; }
        public string SJobNum { get; set; }
        public string SEmployeeNum { get; set; }
        public string SEmployeeName { get; set; }
        public string SMachine { get; set; }
        public decimal? DblHours { get; set; }
        public string SGlcode { get; set; }
        public int? IPieces { get; set; }
        public string SStatus { get; set; }
        public string STravelerLineDesc { get; set; }
        public int? IOriginalLineNum { get; set; }
        public DateTime? DtLogged { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TDprarchiveFile SFileGu { get; set; }
    }
}
