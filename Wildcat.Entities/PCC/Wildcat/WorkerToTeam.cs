using System;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class WorkerToTeam
    {
        public int WorkerToTeamId { get; set; }
        public int WorkerId { get; set; }
        public int TeamId { get; set; }
        public bool Active { get; set; }
        public DateTime Added { get; set; }
        public DateTime? Updated { get; set; }
        public string AddedBy { get; set; }
        public string UpdatedBy { get; set; }

        public DeleteTeam Team { get; set; }
        public Worker Worker { get; set; }
    }
}
