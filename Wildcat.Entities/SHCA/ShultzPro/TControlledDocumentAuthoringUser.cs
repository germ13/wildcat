using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TControlledDocumentAuthoringUser
    {
        public Guid SLinkGuid { get; set; }
        public Guid SDocumentGuid { get; set; }
        public Guid SUserGuid { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TControlledDocument SDocumentGu { get; set; }
        public TUser SUserGu { get; set; }
    }
}
