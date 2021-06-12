using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TSiemensSecGroup
    {
        public TSiemensSecGroup()
        {
            TSiemensSecGroupToObject = new HashSet<TSiemensSecGroupToObject>();
            TSiemensSecUserToGroup = new HashSet<TSiemensSecUserToGroup>();
        }

        public Guid SGroupGuid { get; set; }
        public string SDesc { get; set; }
        public int? ISortOrder { get; set; }
        public bool BSystemGroup { get; set; }
        public DateTime DtAdded { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUser { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TSiemensSecGroupToObject> TSiemensSecGroupToObject { get; set; }
        public ICollection<TSiemensSecUserToGroup> TSiemensSecUserToGroup { get; set; }
    }
}
