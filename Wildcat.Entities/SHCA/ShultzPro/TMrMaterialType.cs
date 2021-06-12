using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TMrMaterialType
    {
        public TMrMaterialType()
        {
            TMrCycle = new HashSet<TMrCycle>();
            TMrMaterial = new HashSet<TMrMaterial>();
        }

        public Guid SMaterialTypeGuid { get; set; }
        public string SName { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUser { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TMrCycle> TMrCycle { get; set; }
        public ICollection<TMrMaterial> TMrMaterial { get; set; }
    }
}
