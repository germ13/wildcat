using System.Collections.Generic;

namespace Wildcat.Entities.CFCA.Saws
{
    public partial class SawCalcSaws
    {
        public SawCalcSaws()
        {
            SawCalcComputers = new HashSet<SawCalcComputers>();
            SawCalcMaintenanceRequests = new HashSet<SawCalcMaintenanceRequests>();
            SawCalcPieces = new HashSet<SawCalcPieces>();
            SawCalcScheduleItems = new HashSet<SawCalcScheduleItems>();
        }

        public int SawId { get; set; }
        public string SawType { get; set; }
        public string SawName { get; set; }
        public double PerformanceFactor { get; set; }
        public bool IsActive { get; set; }
        public int BladeLength { get; set; }
        public double BladeWidth { get; set; }
        public double MaxBarDiameter { get; set; }
        public double CuttingSpeedPerformance { get; set; }
        public string Manufacturer { get; set; }

        public ICollection<SawCalcComputers> SawCalcComputers { get; set; }
        public ICollection<SawCalcMaintenanceRequests> SawCalcMaintenanceRequests { get; set; }
        public ICollection<SawCalcPieces> SawCalcPieces { get; set; }
        public ICollection<SawCalcScheduleItems> SawCalcScheduleItems { get; set; }
    }
}
