using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TSiemensSecObject
    {
        public TSiemensSecObject()
        {
            TSiemensSecGroupToObject = new HashSet<TSiemensSecGroupToObject>();
        }

        public Guid SObjectGuid { get; set; }
        public Guid? SParentObjectGuid { get; set; }
        public string SType { get; set; }
        public string SScreenKey { get; set; }
        public string SScreenName { get; set; }
        public string SControlName { get; set; }
        public int? ISortOrder { get; set; }
        public string SLineage { get; set; }
        public string SLineageSort { get; set; }
        public string SNavBarKey { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUser { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TSiemensSecGroupToObject> TSiemensSecGroupToObject { get; set; }
    }
}
