using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TControlledDocumentDetail
    {
        public TControlledDocumentDetail()
        {
            TControlledDocumentAction = new HashSet<TControlledDocumentAction>();
            TControlledDocumentContent = new HashSet<TControlledDocumentContent>();
        }

        public Guid SDetailGuid { get; set; }
        public Guid SDocumentGuid { get; set; }
        public string SRevisionNum { get; set; }
        public Guid SAttachmentGuid { get; set; }
        public bool BPublishedRev { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TControlledDocument SDocumentGu { get; set; }
        public ICollection<TControlledDocumentAction> TControlledDocumentAction { get; set; }
        public ICollection<TControlledDocumentContent> TControlledDocumentContent { get; set; }
    }
}
