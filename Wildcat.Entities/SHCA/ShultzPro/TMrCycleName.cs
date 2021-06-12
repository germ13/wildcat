using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TMrCycleName
    {
        public TMrCycleName()
        {
            TMrCycle = new HashSet<TMrCycle>();
        }

        public Guid SCycleNameGuid { get; set; }
        public string SName { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUser { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TMrCycle> TMrCycle { get; set; }
    }
}
