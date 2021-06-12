using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TControlledDocumentAction
    {
        public Guid SActionGuid { get; set; }
        public Guid SDetailGuid { get; set; }
        public string SAction { get; set; }
        public string SExtDesc { get; set; }
        public string SReason { get; set; }
        public DateTime DtAction { get; set; }
        public Guid? SUserGuid { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TControlledDocumentDetail SDetailGu { get; set; }
    }
}
