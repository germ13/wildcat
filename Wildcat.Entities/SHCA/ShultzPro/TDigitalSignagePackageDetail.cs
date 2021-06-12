using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TDigitalSignagePackageDetail
    {
        public Guid SDetailGuid { get; set; }
        public Guid SPackageGuid { get; set; }
        public int ISortOrder { get; set; }
        public int IRefreshInterval { get; set; }
        public string SHeaderText { get; set; }
        public string SFooterText { get; set; }
        public bool BHeaderTextFadeOut { get; set; }
        public bool BFooterTextFadeOut { get; set; }
        public Guid? SAttachmentGuid { get; set; }
        public string SFileChecksum { get; set; }
        public string SVideoPath { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TDigitalSignagePackage SPackageGu { get; set; }
    }
}
