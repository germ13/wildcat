using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TDprarchiveFile
    {
        public TDprarchiveFile()
        {
            TDprarchiveDetail = new HashSet<TDprarchiveDetail>();
        }

        public Guid SFileGuid { get; set; }
        public string SDirectoryName { get; set; }
        public string SFileName { get; set; }
        public DateTime? DtDateInFileName { get; set; }
        public DateTime? DtDprrun { get; set; }
        public DateTime? DtPostingsFor { get; set; }
        public string SUserInFileName { get; set; }
        public string SFileType { get; set; }
        public string SProgram { get; set; }
        public string SUserName { get; set; }
        public string SReportTitle { get; set; }
        public DateTime? DtDateInTitle { get; set; }
        public decimal? DblGrandTotalHours { get; set; }
        public decimal? DblTotalDirect { get; set; }
        public decimal? DblTotalIndirect { get; set; }
        public decimal? DblTotalWarehouse { get; set; }
        public decimal? DblGrandTotalCost { get; set; }
        public decimal? DblDebit0140 { get; set; }
        public decimal? DblCreditTotal { get; set; }
        public decimal? DblXx99 { get; set; }
        public decimal? Dbl0405 { get; set; }
        public decimal? Dbl0406 { get; set; }
        public decimal? DblOther { get; set; }
        public string SRawText { get; set; }
        public DateTime? DtLogged { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TDprarchiveDetail> TDprarchiveDetail { get; set; }
    }
}
