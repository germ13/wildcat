using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class THelpDeskRequest
    {
        public THelpDeskRequest()
        {
            THelpDeskAssetToRequest = new HashSet<THelpDeskAssetToRequest>();
            THelpDeskRequestDetail = new HashSet<THelpDeskRequestDetail>();
        }

        public Guid SRequestGuid { get; set; }
        public int IRefNo { get; set; }
        public Guid? SAssignedRepUserGuid { get; set; }
        public Guid? SRequestingUserGuid { get; set; }
        public Guid? SCategoryGuid { get; set; }
        public string SCaseType { get; set; }
        public string STitle { get; set; }
        public string SUserUrgency { get; set; }
        public string SInternalPriority { get; set; }
        public DateTime? DtDueBy { get; set; }
        public DateTime? DtBeginWork { get; set; }
        public bool BClosed { get; set; }
        public int? INumSecondsEstimate { get; set; }
        public DateTime? DtLogged { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<THelpDeskAssetToRequest> THelpDeskAssetToRequest { get; set; }
        public ICollection<THelpDeskRequestDetail> THelpDeskRequestDetail { get; set; }
    }
}
