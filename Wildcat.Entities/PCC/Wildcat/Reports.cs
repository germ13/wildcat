using System.Collections.Generic;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class Reports
    {
        public Reports()
        {
            ReportToTeam = new HashSet<ReportToTeam>();
        }

        public int ReportId { get; set; }
        public string DisplayName { get; set; }
        public byte[] LayoutData { get; set; }

        public ICollection<ReportToTeam> ReportToTeam { get; set; }
    }
}
