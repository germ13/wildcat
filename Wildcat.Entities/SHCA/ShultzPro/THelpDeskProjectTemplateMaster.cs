using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class THelpDeskProjectTemplateMaster
    {
        public THelpDeskProjectTemplateMaster()
        {
            THelpDeskProjectTemplateDetail = new HashSet<THelpDeskProjectTemplateDetail>();
        }

        public Guid SMasterGuid { get; set; }
        public string STemplateName { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<THelpDeskProjectTemplateDetail> THelpDeskProjectTemplateDetail { get; set; }
    }
}
