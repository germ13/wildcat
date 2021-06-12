using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TEmployeeDate
    {
        public Guid SDateGuid { get; set; }
        public Guid SEmployeeGuid { get; set; }
        public string SDescription { get; set; }
        public DateTime DtEvent { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TEmployee SEmployeeGu { get; set; }
    }
}
