using System.Collections.Generic;

namespace Wildcat.Entities.CFCA.Saws
{
    public partial class SawCalcPersons
    {
        public SawCalcPersons()
        {
            SawCalcMaintenanceRequests = new HashSet<SawCalcMaintenanceRequests>();
            SawCalcPiecesOperator = new HashSet<SawCalcPieces>();
            SawCalcPiecesPeerOverride = new HashSet<SawCalcPieces>();
            SawCalcScheduleItems = new HashSet<SawCalcScheduleItems>();
        }

        public int PersonId { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public string Email { get; set; }
        public bool SendMaintenanceAlert { get; set; }
        public bool IsOperator { get; set; }
        public bool IsSupervisor { get; set; }

        public ICollection<SawCalcMaintenanceRequests> SawCalcMaintenanceRequests { get; set; }
        public ICollection<SawCalcPieces> SawCalcPiecesOperator { get; set; }
        public ICollection<SawCalcPieces> SawCalcPiecesPeerOverride { get; set; }
        public ICollection<SawCalcScheduleItems> SawCalcScheduleItems { get; set; }
    }
}
