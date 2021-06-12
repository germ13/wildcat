using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TNonConformingMetal
    {
        public Guid SNonConformingMetalGuid { get; set; }
        public string SNonConformingName { get; set; }
        public string SConformingName { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowVersion { get; set; }
    }
}
