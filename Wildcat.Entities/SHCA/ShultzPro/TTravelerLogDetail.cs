using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TTravelerLogDetail
    {
        public Guid STravLogDetailId { get; set; }
        public Guid? STravLogMasterId { get; set; }
        public int? IStepNumber { get; set; }
        public int? IStepShopRoutingRecord { get; set; }
        public string SMachine { get; set; }
        public string SSerialNumber { get; set; }
        public bool? BDyePenUsed { get; set; }
        public DateTime? DtStartTime { get; set; }
        public DateTime? DtStopTime { get; set; }
        public DateTime? DtCompletion { get; set; }
        public string SComments { get; set; }
        public int? IJobNumberCardId { get; set; }
        public int? ISerialNumberCardId { get; set; }
        public int? IWarehouseId { get; set; }
        public int IStarterBadgeId { get; set; }
        public int? IFinisherBadgeId { get; set; }
        public string SShift { get; set; }
        public decimal? DblMeterStartRead { get; set; }
        public decimal? DblMeterFinishRead { get; set; }
        public string SReason { get; set; }
        public bool BRework { get; set; }
        public bool BInProgress { get; set; }
        public bool BInactive { get; set; }
        public DateTime? DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TTravelerLogMaster STravLogMaster { get; set; }
    }
}
