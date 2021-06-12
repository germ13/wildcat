using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TAttachment
    {
        public Guid SAttachmentGuid { get; set; }
        public string SKey { get; set; }
        public Guid SEntityGuid { get; set; }
        public Guid? SBatchGuid { get; set; }
        public string SDesc { get; set; }
        public byte[] BinAttachment { get; set; }
        public bool BIsPhoto { get; set; }
        public string SOriginalExtension { get; set; }
        public string SOriginalFileName { get; set; }
        public string SCurrentFilePath1 { get; set; }
        public string SCurrentFilePath2 { get; set; }
        public DateTime? DtLastAccessed { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SUaddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUser { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
