using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TTmopn
    {
        public int IRecId { get; set; }
        public string SKey { get; set; }
        public string SOperationMaster { get; set; }
        public string SDepartmentName { get; set; }
        public string SDescription01 { get; set; }
        public string SDescription02 { get; set; }
        public string SMachine { get; set; }
        public int? IHoursEstimatedYtd { get; set; }
        public int? IHoursActualYtd { get; set; }
        public int? ICostEstimatedYtd { get; set; }
        public int? ICostActualYtd { get; set; }
        public int? IHoursEstimatedMtd { get; set; }
        public int? IHoursActualMtd { get; set; }
        public int? ICostEstimatedMtd { get; set; }
        public int? ICostActualMtd { get; set; }
        public string SScheduledDays { get; set; }
        public decimal? DblCapacityHours { get; set; }
        public decimal? DblOverCapacityHours { get; set; }
        public decimal? DblScheduledHours { get; set; }
        public decimal? DblConversionHours { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
