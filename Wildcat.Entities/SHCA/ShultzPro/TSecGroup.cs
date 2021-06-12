using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TSecGroup
    {
        public TSecGroup()
        {
            TReportToGroup = new HashSet<TReportToGroup>();
            TSecGroupToObject = new HashSet<TSecGroupToObject>();
            TSecUserToGroup = new HashSet<TSecUserToGroup>();
        }

        public Guid SGroupGuid { get; set; }
        public string SDesc { get; set; }
        public int? ISortOrder { get; set; }
        public bool BSystemGroup { get; set; }
        public DateTime DtAdded { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUser { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TReportToGroup> TReportToGroup { get; set; }
        public ICollection<TSecGroupToObject> TSecGroupToObject { get; set; }
        public ICollection<TSecUserToGroup> TSecUserToGroup { get; set; }
    }
}
