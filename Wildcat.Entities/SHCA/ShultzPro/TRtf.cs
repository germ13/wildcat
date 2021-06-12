using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TRtf
    {
        public Guid SRtfguid { get; set; }
        public string SKey { get; set; }
        public Guid SEntityGuid { get; set; }
        public string SRtf { get; set; }
        public string SText { get; set; }
        public string SExtendedType { get; set; }
        public DateTime DtAdded { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUser { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
