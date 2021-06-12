using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TControlledDocumentContent
    {
        public Guid SContentGuid { get; set; }
        public Guid SDetailGuid { get; set; }
        public string SDocType { get; set; }
        public string SContent { get; set; }
        public int? IPageNum { get; set; }
        public int? ISlideIndex { get; set; }
        public int? ILineNum { get; set; }
        public string SSheetName { get; set; }
        public string SCellLocation { get; set; }
        public Guid SAttachmentGuid { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TControlledDocumentDetail SDetailGu { get; set; }
    }
}
