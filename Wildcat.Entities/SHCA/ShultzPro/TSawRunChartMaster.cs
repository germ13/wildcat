using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TSawRunChartMaster
    {
        public TSawRunChartMaster()
        {
            TSawRunChartDetail = new HashSet<TSawRunChartDetail>();
        }

        public Guid SMasterGuid { get; set; }
        public string SJobNum { get; set; }
        public string SCustomer { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TSawRunChartDetail> TSawRunChartDetail { get; set; }
    }
}
