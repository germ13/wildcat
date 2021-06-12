using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TTravelerLogMaster
    {
        public TTravelerLogMaster()
        {
            TTravelerLogDetail = new HashSet<TTravelerLogDetail>();
        }

        public Guid STravLogMasterId { get; set; }
        public string SJobNumber { get; set; }
        public int? IStepNumber { get; set; }
        public int? IStepShopRoutingRecord { get; set; }
        public string SDepartment { get; set; }
        public string SOperation { get; set; }
        public decimal? DblQuantityActual { get; set; }
        public decimal? DblQuantityExpected { get; set; }
        public decimal? DblHoursActual { get; set; }
        public decimal? DblHoursExpected { get; set; }
        public DateTime? DtLastDailyProduction { get; set; }
        public bool? BComplete { get; set; }
        public string SCardId { get; set; }
        public string SDescription { get; set; }
        public string SComment { get; set; }
        public bool BInactive { get; set; }
        public DateTime? DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TTravelerLogDetail> TTravelerLogDetail { get; set; }
    }
}
