using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TSawConversionMaster
    {
        public TSawConversionMaster()
        {
            TSawConversionDetail = new HashSet<TSawConversionDetail>();
        }

        public Guid SConversionGuid { get; set; }
        public string SConversionNum { get; set; }
        public string SMaterial { get; set; }
        public string SHeatNum { get; set; }
        public string SHeatCode { get; set; }
        public string SIngotSize { get; set; }
        public decimal DblIngotWeight { get; set; }
        public string SSupplier { get; set; }
        public string SPlannedBy { get; set; }
        public DateTime? DtPlanned { get; set; }
        public string SCompletedBy { get; set; }
        public DateTime? DtCompleted { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TSawConversionDetail> TSawConversionDetail { get; set; }
    }
}
