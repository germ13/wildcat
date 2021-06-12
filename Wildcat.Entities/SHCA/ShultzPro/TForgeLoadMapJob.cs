using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TForgeLoadMapJob
    {
        public TForgeLoadMapJob()
        {
            TForgeLoadMapDetail = new HashSet<TForgeLoadMapDetail>();
        }

        public Guid SLoadMapGuid { get; set; }
        public Guid SBatchGuid { get; set; }
        public string SJobNum { get; set; }
        public string SJobType { get; set; }
        public string SMaterial { get; set; }
        public string SSize { get; set; }
        public string SCoating { get; set; }
        public string SSupport { get; set; }
        public string SMaintSheetName { get; set; }
        public string SFurnaceSheetName { get; set; }
        public string STravelerName { get; set; }
        public string SSourceFurnace { get; set; }
        public string STargetFurnace { get; set; }
        public string SNoteText { get; set; }
        public string SNoteRtf { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TForgeLoadMapBatch SBatchGu { get; set; }
        public ICollection<TForgeLoadMapDetail> TForgeLoadMapDetail { get; set; }
    }
}
