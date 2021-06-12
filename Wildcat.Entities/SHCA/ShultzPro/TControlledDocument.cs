using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TControlledDocument
    {
        public TControlledDocument()
        {
            TControlledDocumentApproval = new HashSet<TControlledDocumentApproval>();
            TControlledDocumentAuthoringUser = new HashSet<TControlledDocumentAuthoringUser>();
            TControlledDocumentDetail = new HashSet<TControlledDocumentDetail>();
        }

        public Guid SDocumentGuid { get; set; }
        public string SDocumentType { get; set; }
        public string SDocumentCode { get; set; }
        public Guid? SDepartmentGuid { get; set; }
        public string STitle { get; set; }
        public string SDescription { get; set; }
        public bool BAllUsersCanAuthor { get; set; }
        public bool BAllUsersMustApprove { get; set; }
        public bool BAnyUserCanApprove { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TControlledDocumentApproval> TControlledDocumentApproval { get; set; }
        public ICollection<TControlledDocumentAuthoringUser> TControlledDocumentAuthoringUser { get; set; }
        public ICollection<TControlledDocumentDetail> TControlledDocumentDetail { get; set; }
    }
}
