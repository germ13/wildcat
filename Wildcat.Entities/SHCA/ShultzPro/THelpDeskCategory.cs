using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class THelpDeskCategory
    {
        public Guid SCategoryGuid { get; set; }
        public Guid? SParentGuid { get; set; }
        public string SName { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
