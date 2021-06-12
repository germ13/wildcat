using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class THelpDeskInvolvedUser
    {
        public Guid SLinkGuid { get; set; }
        public Guid SRequestGuid { get; set; }
        public Guid SUserGuid { get; set; }
        public bool BProjectComplete { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TUser SUserGu { get; set; }
    }
}
