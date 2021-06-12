using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TMrMasterRecipe
    {
        public TMrMasterRecipe()
        {
            THtHeatTreat = new HashSet<THtHeatTreat>();
            TMrCycle = new HashSet<TMrCycle>();
        }

        public Guid SHtmrguid { get; set; }
        public string SMrno { get; set; }
        public string SRevision { get; set; }
        public DateTime? DtCreation { get; set; }
        public bool? BQuenchRequired { get; set; }
        public string SStatus { get; set; }
        public Guid? SCreatedByUserGuid { get; set; }
        public string SCreatedByUserName { get; set; }
        public Guid? SApprovedByMetallurgyUserGuid { get; set; }
        public Guid? SApprovedByHeatTreatUserGuid { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUser { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<THtHeatTreat> THtHeatTreat { get; set; }
        public ICollection<TMrCycle> TMrCycle { get; set; }
    }
}
