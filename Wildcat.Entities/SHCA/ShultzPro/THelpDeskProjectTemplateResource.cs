using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class THelpDeskProjectTemplateResource
    {
        public Guid SResourceGuid { get; set; }
        public Guid SDetailGuid { get; set; }
        public string SResourceName { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public THelpDeskProjectTemplateDetail SDetailGu { get; set; }
    }
}
