using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TForgeCondRate
    {
        public TForgeCondRate()
        {
            TForgeCondPiece = new HashSet<TForgeCondPiece>();
        }

        public Guid SRateGuid { get; set; }
        public string SJobNumber { get; set; }
        public int? IStepNum { get; set; }
        public bool BAddStep { get; set; }
        public string SOperation { get; set; }
        public decimal? DblEstimatedHours { get; set; }
        public decimal? DblActualHours { get; set; }
        public int IQtyRequired { get; set; }
        public int IQtyDone { get; set; }
        public string SSizeStage { get; set; }
        public DateTime? DtReceived { get; set; }
        public DateTime? DtEstimatedCompletion { get; set; }
        public DateTime? DtCompletion { get; set; }
        public string SMaterialType { get; set; }
        public string SComments { get; set; }
        public string SCalculationNotes { get; set; }
        public string SReason { get; set; }
        public string SArea { get; set; }
        public decimal? DblEstimatedMinutes { get; set; }
        public decimal? DblActualMinutes { get; set; }
        public decimal? DblDeltaHours { get; set; }
        public decimal? DblDeltaMinutes { get; set; }
        public decimal? DblPcsHour { get; set; }
        public decimal? DblHoursPerPiece { get; set; }
        public int? IDays { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TForgeCondPiece> TForgeCondPiece { get; set; }
    }
}
