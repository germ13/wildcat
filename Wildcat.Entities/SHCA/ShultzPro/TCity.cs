using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TCity
    {
        public Guid SCityGuid { get; set; }
        public string SCityName { get; set; }
        public Guid SStateGuid { get; set; }
        public Guid SZipGuid { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TState SStateGu { get; set; }
        public TZipCode SZipGu { get; set; }
    }
}
