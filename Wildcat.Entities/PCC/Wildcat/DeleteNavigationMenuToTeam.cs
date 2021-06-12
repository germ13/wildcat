using System;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class DeleteNavigationMenuToTeam
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public int NavigationMenuId { get; set; }
        public bool Active { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }

        public DeleteTeam Team { get; set; }
    }
}
