using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TControlledDocumentApproval
    {
        public Guid SApprovalGuid { get; set; }
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
