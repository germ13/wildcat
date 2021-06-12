using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TDeformlogStep
    {
        public Guid SStepGuid { get; set; }
        public Guid SLogGuid { get; set; }
        public int? ISteps { get; set; }
        public decimal? DblStepIncrement { get; set; }
        public int ISortOrder { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TDeformlog SLogGu { get; set; }
    }
}
