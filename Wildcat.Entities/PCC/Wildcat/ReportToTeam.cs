using System;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class ReportToTeam
    {
        public int LinkId { get; set; }
        public int ReportId { get; set; }
        public int? TeamId { get; set; }
        public int? EndUserId { get; set; }
        public bool Active { get; set; }
        public DateTime Added { get; set; }
        public int? AddedByEndUserId { get; set; }
        public DateTime Updated { get; set; }
        public int? UpdatedByEndUserId { get; set; }

        public Reports Report { get; set; }
    }
}
