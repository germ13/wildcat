using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class THelpDeskProjectTemplateDetail
    {
        public THelpDeskProjectTemplateDetail()
        {
            THelpDeskProjectTemplateResource = new HashSet<THelpDeskProjectTemplateResource>();
        }

        public Guid SDetailGuid { get; set; }
        public Guid SMasterGuid { get; set; }
        public Guid? SParentDetailGuid { get; set; }
        public string STaskName { get; set; }
        public string ISortOrderHidden { get; set; }
        public string SPredecessors { get; set; }
        public string STimeEstimate { get; set; }
        public decimal DblHourEstimateHidden { get; set; }
        public int ITaskNumHidden { get; set; }
        public int IIndentLevelHidden { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public THelpDeskProjectTemplateMaster SMasterGu { get; set; }
        public ICollection<THelpDeskProjectTemplateResource> THelpDeskProjectTemplateResource { get; set; }
    }
}
