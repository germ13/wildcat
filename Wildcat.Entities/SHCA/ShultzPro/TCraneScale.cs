using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TCraneScale
    {
        public Guid SScaleGuid { get; set; }
        public string SScaleModel { get; set; }
        public string SScaleLocation { get; set; }
        public string SScaleIpaddress { get; set; }
        public string SScaleSerialNumber { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
