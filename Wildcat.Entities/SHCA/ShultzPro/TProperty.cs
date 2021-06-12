using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TProperty
    {
        public Guid SPropertyGuid { get; set; }
        public string SProperty { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
