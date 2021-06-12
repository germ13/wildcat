using System;
using System.Collections.Generic;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class DeleteTeam
    {
        public DeleteTeam()
        {
            DeleteNavigationMenuToTeam = new HashSet<DeleteNavigationMenuToTeam>();
            WorkerToTeam = new HashSet<WorkerToTeam>();
        }

        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public bool Active { get; set; }
        public DateTime Added { get; set; }
        public DateTime? Updated { get; set; }
        public string AddedBy { get; set; }
        public string UpdatedBy { get; set; }

        public ICollection<DeleteNavigationMenuToTeam> DeleteNavigationMenuToTeam { get; set; }
        public ICollection<WorkerToTeam> WorkerToTeam { get; set; }
    }
}
