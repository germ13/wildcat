using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TDprmachineShopMaster
    {
        public TDprmachineShopMaster()
        {
            TDprmachineShopDetail = new HashSet<TDprmachineShopDetail>();
        }

        public Guid SDprguid { get; set; }
        public string SEmployeeId { get; set; }
        public string SJobNum { get; set; }
        public string SSerialNum { get; set; }
        public DateTime DtEntry { get; set; }
        public int? ITravelerStepNum { get; set; }
        public int? ISrrstepNum { get; set; }
        public bool BCompleted { get; set; }
        public int? IMinutes { get; set; }
        public string SMachineCode { get; set; }
        public string SNote { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TDprmachineShopDetail> TDprmachineShopDetail { get; set; }
    }
}
