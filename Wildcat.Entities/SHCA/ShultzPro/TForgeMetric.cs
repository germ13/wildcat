using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TForgeMetric
    {
        public TForgeMetric()
        {
            TForgeMetricNote = new HashSet<TForgeMetricNote>();
        }

        public Guid SMetricGuid { get; set; }
        public string SJobNum { get; set; }
        public int IQty { get; set; }
        public DateTime? DtRun { get; set; }
        public string SUnit { get; set; }
        public string SOperation { get; set; }
        public decimal DblActualRate { get; set; }
        public string SShift { get; set; }
        public decimal DblPrevTarget { get; set; }
        public int INumRestrikes { get; set; }
        public string SReason { get; set; }
        public string SDieSet { get; set; }
        public int? IDieSetCount { get; set; }
        public int? IMinutesToSetup { get; set; }
        public int? IMinutesToRemove { get; set; }
        public int? IDelayMinSetup { get; set; }
        public int? IDelayMinRun { get; set; }
        public int? IDelayMinRemoval { get; set; }
        public string SDelayReasonSetup { get; set; }
        public string SDelayReasonRun { get; set; }
        public string SDelayReasonRemoval { get; set; }
        public bool BRework { get; set; }
        public string SCalculationNotes { get; set; }
        public decimal? DblOldTarget { get; set; }
        public decimal? DblActual { get; set; }
        public decimal? DblPrev { get; set; }
        public decimal? DblNewTarget { get; set; }
        public decimal? DblToPrev { get; set; }
        public decimal? DblToTarget { get; set; }
        public decimal? DblAmount { get; set; }
        public decimal? DblPercentTimeSetup { get; set; }
        public decimal? DblPercentTimeRemove { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TForgeMetricNote> TForgeMetricNote { get; set; }
    }
}
