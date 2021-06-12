using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TOperationCategoryDetail
    {
        public Guid SOperationCategoryDetailGuid { get; set; }
        public Guid SJobDetailGuid { get; set; }
        public Guid SOperationCategoryMasterGuid { get; set; }
        public bool? BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowVersion { get; set; }

        public TOperationCategoryMaster SOperationCategoryMasterGu { get; set; }
    }
}
