using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class THtCycle
    {
        public THtCycle()
        {
            THtJob = new HashSet<THtJob>();
            THtQuenchData = new HashSet<THtQuenchData>();
            THtRegion = new HashSet<THtRegion>();
        }

        public Guid SHtcycleGuid { get; set; }
        public string SLotNo { get; set; }
        public Guid? SMrcycleGuid { get; set; }
        public Guid SHeatTreatGuid { get; set; }
        public Guid? SHearthGuid { get; set; }
        public DateTime? DtRun { get; set; }
        public string LoadMapImagePath { get; set; }
        public string SNotes { get; set; }
        public string SRacking { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUser { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TMrFurnaceHearth SHearthGu { get; set; }
        public THtHeatTreat SHeatTreatGu { get; set; }
        public TMrCycle SMrcycleGu { get; set; }
        public ICollection<THtJob> THtJob { get; set; }
        public ICollection<THtQuenchData> THtQuenchData { get; set; }
        public ICollection<THtRegion> THtRegion { get; set; }
    }
}
