using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TSawBladeChange
    {
        public Guid SChangeGuid { get; set; }
        public DateTime DtChange { get; set; }
        public string SSawName { get; set; }
        public Guid SOldBladeGuid { get; set; }
        public Guid SNewBladeGuid { get; set; }
        public string SReason { get; set; }
        public string SNotes { get; set; }
        public bool BReuse { get; set; }
        public bool BScrapped { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
