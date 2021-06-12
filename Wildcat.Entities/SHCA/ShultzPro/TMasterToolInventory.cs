using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TMasterToolInventory
    {
        public TMasterToolInventory()
        {
            TMasterToolInventoryDetail = new HashSet<TMasterToolInventoryDetail>();
            TMasterToolInventorySink = new HashSet<TMasterToolInventorySink>();
        }

        public Guid SPartGuid { get; set; }
        public string SMasterJobNum { get; set; }
        public string SOperation { get; set; }
        public int? ISetNum { get; set; }
        public string SCustomer { get; set; }
        public string SPartName { get; set; }
        public string SPartNum { get; set; }
        public string SStatusDesc { get; set; }
        public DateTime? DtStatus { get; set; }
        public string SStorageSite { get; set; }
        public string SOnsiteLocation { get; set; }
        public bool BCadmodel { get; set; }
        public bool BItar { get; set; }
        public string SProgramName { get; set; }
        public DateTime? DtApprovedScrap { get; set; }
        public string SApprovedScrap { get; set; }
        public string SScrapOrder { get; set; }
        public DateTime? DtScrapped { get; set; }
        public DateTime? DtLastJob { get; set; }
        public string SLastJobNum { get; set; }
        public int? ILastStrikeQty { get; set; }
        public int? ILastPieceCount { get; set; }
        public string SExcelSheetName { get; set; }
        public bool BMiscellaneousRecord { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TMasterToolInventoryDetail> TMasterToolInventoryDetail { get; set; }
        public ICollection<TMasterToolInventorySink> TMasterToolInventorySink { get; set; }
    }
}
