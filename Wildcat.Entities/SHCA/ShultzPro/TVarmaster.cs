using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TVarmaster
    {
        public TVarmaster()
        {
            TVardetail = new HashSet<TVardetail>();
        }

        public Guid SMasterGuid { get; set; }
        public string SFurnaceId { get; set; }
        public string SHeatNum { get; set; }
        public string SProfileNum { get; set; }
        public string SAlloy { get; set; }
        public string SGrade { get; set; }
        public string SElectrodeNum { get; set; }
        public string SCrucibleNum { get; set; }
        public int? IStationNum { get; set; }
        public string SStationName { get; set; }
        public string SOperatorMeltStart { get; set; }
        public string SOperatorMeltSecond { get; set; }
        public string SOperatorMeltThird { get; set; }
        public string SOperatorMeltEnd { get; set; }
        public DateTime? DtStart { get; set; }
        public decimal? DblStartWeight { get; set; }
        public DateTime? DtSteadyStateStart { get; set; }
        public decimal? DblSteadyStateStartWeight { get; set; }
        public decimal? DblSteadyStateElapsedTime { get; set; }
        public decimal? DblSteadyStateEndWeight { get; set; }
        public decimal? DblSteadyStateMeltRate { get; set; }
        public DateTime? DtHotTopStart { get; set; }
        public decimal? DblMeltEndWeight { get; set; }
        public decimal? DblIngotWeight { get; set; }
        public decimal? DblMeltAvgMeltRate { get; set; }
        public DateTime? DtMeltEnd { get; set; }
        public decimal? DblMeltElapsedTime { get; set; }
        public decimal? DblInletOrSysLowTemp { get; set; }
        public decimal? DblInletOrSysHighTemp { get; set; }
        public decimal? DblCrucibleLowTemp { get; set; }
        public decimal? DblCrucibleHighTemp { get; set; }
        public decimal? DblCrucibleLowFlow { get; set; }
        public decimal? DblCrucibleHighFlow { get; set; }
        public DateTime? DtPowerOffTime { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TVardetail> TVardetail { get; set; }
    }
}
