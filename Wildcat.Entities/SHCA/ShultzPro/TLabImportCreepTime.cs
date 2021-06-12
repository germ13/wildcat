using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TLabImportCreepTime
    {
        public Guid SCreepTimeGuid { get; set; }
        public Guid SCreepGuid { get; set; }
        public string SRecId { get; set; }
        public decimal? DblCreepMin { get; set; }
        public decimal? DblCreepMax { get; set; }
        public decimal? DblTimeMin { get; set; }
        public decimal? DblTimeMax { get; set; }
        public decimal? DblActualCreep { get; set; }
        public decimal? DblActualTime { get; set; }
        public bool? BConforms { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TLabImportCreep SCreepGu { get; set; }
    }
}
