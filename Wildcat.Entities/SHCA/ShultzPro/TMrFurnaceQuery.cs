using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TMrFurnaceQuery
    {
        public Guid SLinkGuid { get; set; }
        public Guid SFurnaceGuid { get; set; }
        public Guid SQueryGuid { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUser { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TMrFurnace SFurnaceGu { get; set; }
        public TMrOperatorQuery SQueryGu { get; set; }
    }
}
