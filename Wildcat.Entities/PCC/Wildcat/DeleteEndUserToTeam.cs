using System;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class DeleteEndUserToTeam
    {
        public int EndUserToTeamId { get; set; }
        public int EndUserId { get; set; }
        public int TeamId { get; set; }
        public bool Active { get; set; }
        public DateTime Added { get; set; }
        public DateTime? Updated { get; set; }
        public string AddedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
