using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TMrOperatorQuery
    {
        public TMrOperatorQuery()
        {
            TMrCycleQuery = new HashSet<TMrCycleQuery>();
            TMrFurnaceQuery = new HashSet<TMrFurnaceQuery>();
        }

        public Guid SQueryGuid { get; set; }
        public string SQueryText { get; set; }
        public int IQueryIndex { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUser { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TMrCycleQuery> TMrCycleQuery { get; set; }
        public ICollection<TMrFurnaceQuery> TMrFurnaceQuery { get; set; }
    }
}
