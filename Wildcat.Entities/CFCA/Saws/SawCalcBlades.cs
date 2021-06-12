using System.Collections.Generic;

namespace Wildcat.Entities.CFCA.Saws
{
    public partial class SawCalcBlades
    {
        public SawCalcBlades()
        {
            SawCalcMaintenanceRequests = new HashSet<SawCalcMaintenanceRequests>();
            SawCalcPieces = new HashSet<SawCalcPieces>();
        }

        public int BladeId { get; set; }
        public string BladeType { get; set; }
        public string BladeName { get; set; }
        public bool IsActive { get; set; }
        public int? RetiredBladeReasonId { get; set; }
        public string RetiredBladeNotes { get; set; }
        public int Length { get; set; }
        public double Width { get; set; }
        public string SerialNumber { get; set; }
        public double Kerf { get; set; }
        public string TpiDescription { get; set; }
        public double AverageTpi { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }

        public SawCalcRetiredBladeReasons RetiredBladeReason { get; set; }
        public ICollection<SawCalcMaintenanceRequests> SawCalcMaintenanceRequests { get; set; }
        public ICollection<SawCalcPieces> SawCalcPieces { get; set; }
    }
}
