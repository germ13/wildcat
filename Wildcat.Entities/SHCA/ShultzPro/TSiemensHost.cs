using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TSiemensHost
    {
        public Guid SHostGuid { get; set; }
        public string SHostName { get; set; }
        public string SIpaddress { get; set; }
        public string SComment { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
