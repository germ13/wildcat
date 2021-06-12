using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class THelpDeskRequestAttachment
    {
        public Guid SLinkGuid { get; set; }
        public Guid SDetailGuid { get; set; }
        public string SDescription { get; set; }
        public Guid SAttachmentGuid { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public THelpDeskRequestDetail SDetailGu { get; set; }
    }
}
