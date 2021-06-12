using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TMrCycle
    {
        public TMrCycle()
        {
            THtCycle = new HashSet<THtCycle>();
            TMrCycleQuery = new HashSet<TMrCycleQuery>();
            TMrRegion = new HashSet<TMrRegion>();
        }

        public Guid SMrcycleGuid { get; set; }
        public Guid SHtmrguid { get; set; }
        public Guid SCycleNameGuid { get; set; }
        public bool BFurnaceControl { get; set; }
        public string SNotes { get; set; }
        public string SRacking { get; set; }
        public DateTime DtCreation { get; set; }
        public Guid SQuenchMediaTypeGuid { get; set; }
        public Guid SMaterialTypeGuid { get; set; }
        public Guid SMaterialGuid { get; set; }
        public Guid STestMaterialTypeGuid { get; set; }
        public decimal DblMaxSectionSize { get; set; }
        public bool BHardnessRequired { get; set; }
        public string SSetTemprature { get; set; }
        public string SRequiredTime { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUser { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TMrCycleName SCycleNameGu { get; set; }
        public TMrMasterRecipe SHtmrgu { get; set; }
        public TMrMaterialType SMaterialTypeGu { get; set; }
        public TMrQuenchMediaType SQuenchMediaTypeGu { get; set; }
        public TMrTestMaterialType STestMaterialTypeGu { get; set; }
        public ICollection<THtCycle> THtCycle { get; set; }
        public ICollection<TMrCycleQuery> TMrCycleQuery { get; set; }
        public ICollection<TMrRegion> TMrRegion { get; set; }
    }
}
