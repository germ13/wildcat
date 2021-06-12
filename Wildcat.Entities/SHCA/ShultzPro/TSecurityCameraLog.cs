using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TSecurityCameraLog
    {
        public TSecurityCameraLog()
        {
            TSecurityCameraLogDetail = new HashSet<TSecurityCameraLogDetail>();
        }

        public Guid SLogGuid { get; set; }
        public DateTime DtEntered { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TSecurityCameraLogDetail> TSecurityCameraLogDetail { get; set; }
    }
}
