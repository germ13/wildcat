using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TPccMonthDef
    {
        public Guid SQuarterGuid { get; set; }
        public DateTime DtStart { get; set; }
        public int IMonth { get; set; }
        public int IQuarter { get; set; }
        public int IYear { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
