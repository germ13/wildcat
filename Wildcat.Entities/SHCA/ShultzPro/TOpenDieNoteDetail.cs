using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TOpenDieNoteDetail
    {
        public Guid SDetailGuid { get; set; }
        public Guid SNoteGuid { get; set; }
        public string SHeader { get; set; }
        public string SNoteRtf { get; set; }
        public string SNoteText { get; set; }
        public int ISortOrder { get; set; }
        public Guid? SAttachmentGuid { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TOpenDieNoteMaster SNoteGu { get; set; }
    }
}
