using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TDprmachineShopDetail
    {
        public Guid SDetailGuid { get; set; }
        public Guid SDprguid { get; set; }
        public string SReason { get; set; }
        public int IMinutes { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TDprmachineShopMaster SDprgu { get; set; }
    }
}
