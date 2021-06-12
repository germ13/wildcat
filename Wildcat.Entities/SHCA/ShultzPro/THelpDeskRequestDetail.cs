using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class THelpDeskRequestDetail
    {
        public THelpDeskRequestDetail()
        {
            THelpDeskRequestAttachment = new HashSet<THelpDeskRequestAttachment>();
        }

        public Guid SDetailGuid { get; set; }
        public Guid SRequestGuid { get; set; }
        public Guid? SWorkedByUserGuid { get; set; }
        public DateTime DtLogged { get; set; }
        public int? INumSecondsWorked { get; set; }
        public DateTime? DtWorked { get; set; }
        public bool BPrivateMemo { get; set; }
        public string SMemoRtf { get; set; }
        public string SMemoText { get; set; }
        public string STraceInfo { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public THelpDeskRequest SRequestGu { get; set; }
        public ICollection<THelpDeskRequestAttachment> THelpDeskRequestAttachment { get; set; }
    }
}
