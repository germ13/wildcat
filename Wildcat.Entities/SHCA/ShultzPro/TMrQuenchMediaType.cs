using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TMrQuenchMediaType
    {
        public TMrQuenchMediaType()
        {
            TMrCycle = new HashSet<TMrCycle>();
        }

        public Guid SQuenchMediaTypeGuid { get; set; }
        public string SName { get; set; }
        public bool? BQuenchRequired { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUser { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TMrCycle> TMrCycle { get; set; }
    }
}
