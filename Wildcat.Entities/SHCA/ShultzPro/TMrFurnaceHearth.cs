using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TMrFurnaceHearth
    {
        public TMrFurnaceHearth()
        {
            THtCycle = new HashSet<THtCycle>();
        }

        public Guid SHearthGuid { get; set; }
        public Guid SFurnaceGuid { get; set; }
        public string SDescription { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUser { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TMrFurnace SFurnaceGu { get; set; }
        public ICollection<THtCycle> THtCycle { get; set; }
    }
}
