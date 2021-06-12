using System.Collections.Generic;

namespace Wildcat.Entities.CFCA.Saws
{
    public partial class SawCalcComputers
    {
        public SawCalcComputers()
        {
            SawCalcMaintenanceRequests = new HashSet<SawCalcMaintenanceRequests>();
            SawCalcPieces = new HashSet<SawCalcPieces>();
            SawCalcShopOrderSavedStates = new HashSet<SawCalcShopOrderSavedStates>();
        }

        public int ComputerId { get; set; }
        public string ComputerName { get; set; }
        public int? SawId { get; set; }
        public bool AllowUnrestrictedOperation { get; set; }
        public bool AllowManualWeightEntry { get; set; }

        public SawCalcSaws Saw { get; set; }
        public ICollection<SawCalcMaintenanceRequests> SawCalcMaintenanceRequests { get; set; }
        public ICollection<SawCalcPieces> SawCalcPieces { get; set; }
        public ICollection<SawCalcShopOrderSavedStates> SawCalcShopOrderSavedStates { get; set; }
    }
}
