using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TCustomDictionary
    {
        public Guid SWordGuid { get; set; }
        public string SWord { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
