using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TEmployeeBank
    {
        public Guid SBankGuid { get; set; }
        public Guid SEmployeeGuid { get; set; }
        public string SBankType { get; set; }
        public DateTime DtTransaction { get; set; }
        public string STransDesc { get; set; }
        public decimal? DblHours { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TEmployee SEmployeeGu { get; set; }
    }
}
