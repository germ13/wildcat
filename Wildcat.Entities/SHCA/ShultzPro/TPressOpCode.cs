using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TPressOpCode
    {
        public Guid SOpCodeGuid { get; set; }
        public string SMachineName { get; set; }
        public string SJobNum { get; set; }
        public string SOperation { get; set; }
        public bool BRequiresSerial { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
