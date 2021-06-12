using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TLabPurchaseOrderApproval
    {
        public Guid SApprovalLimitGuid { get; set; }
        public Guid SEmployeeGuid { get; set; }
        public string CurLimit { get; set; }
        public int ISortOrder { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TEmployee SEmployeeGu { get; set; }
    }
}
