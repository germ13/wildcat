using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TSawRunChartEntry
    {
        public TSawRunChartEntry()
        {
            TSawBladeDetail = new HashSet<TSawBladeDetail>();
            TSawRunChartEntryException = new HashSet<TSawRunChartEntryException>();
        }

        public Guid SEntryGuid { get; set; }
        public Guid SDetailGuid { get; set; }
        public string SSawName { get; set; }
        public string SSerialNum { get; set; }
        public decimal? DblWeight { get; set; }
        public decimal? DblLength { get; set; }
        public DateTime? DtEntered { get; set; }
        public bool BBottomCrop { get; set; }
        public bool BTopCrop { get; set; }
        public bool BRem { get; set; }
        public int ISortOrder { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TSawRunChartDetail SDetailGu { get; set; }
        public ICollection<TSawBladeDetail> TSawBladeDetail { get; set; }
        public ICollection<TSawRunChartEntryException> TSawRunChartEntryException { get; set; }
    }
}
