using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TJ3mach
    {
        public int IRecId { get; set; }
        public string SKey { get; set; }
        public string SMachineMaster { get; set; }
        public string SMachineDescription { get; set; }
        public decimal? DblCostPerHour { get; set; }
        public decimal? DblHoursOperatedMtd { get; set; }
        public decimal? DblHoursOperatedYtd { get; set; }
        public decimal? DblHoursMaintenanceMtd { get; set; }
        public decimal? DblHoursMaintenanceYtd { get; set; }
        public decimal? DblPartsExpenseMtd { get; set; }
        public decimal? DblPartsExpenseYtd { get; set; }
        public decimal? DblShipWeightMtd { get; set; }
        public decimal? DblShipWeightYtd { get; set; }
        public decimal? DblShippingCostLbs { get; set; }
        public string SMaxUsagePerDay { get; set; }
        public string SVendorReferenceNumber { get; set; }
        public string SShultzPonumber { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
