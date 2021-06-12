using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TAttachmentInventory
    {
        public Guid SAttachmentInventoryGuid { get; set; }
        public Guid? SAttachmentGuid { get; set; }
        public string SKey { get; set; }
        public string SOriginalFileName { get; set; }
        public string SFullFilePath1 { get; set; }
        public string SFullFilePath2 { get; set; }
        public bool? BIsFoundInSql { get; set; }
        public bool? BIsFoundOnPath1 { get; set; }
        public bool? BIsFoundOnPath2 { get; set; }
        public bool? BIsFileOrphan { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUser { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUser { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
