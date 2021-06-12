using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class THtHeatTreat
    {
        public THtHeatTreat()
        {
            THtCycle = new HashSet<THtCycle>();
        }

        public Guid SHeatTreatGuid { get; set; }
        public int? IHeatTreatNo { get; set; }
        public Guid? SHtmrguid { get; set; }
        public DateTime? DtCreation { get; set; }
        public string SCreatedByUserName { get; set; }
        public Guid? SCreatedByUserGuid { get; set; }
        public Guid? SApprovedByHeatTreatUserGuid { get; set; }
        public int? IRevNo { get; set; }
        public string SComments { get; set; }
        public bool BLocked { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUser { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TMrMasterRecipe SHtmrgu { get; set; }
        public ICollection<THtCycle> THtCycle { get; set; }
    }
}
