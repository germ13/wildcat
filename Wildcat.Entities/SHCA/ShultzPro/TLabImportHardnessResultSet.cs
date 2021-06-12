using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TLabImportHardnessResultSet
    {
        public Guid SHrguid { get; set; }
        public Guid SHardnessGuid { get; set; }
        public string SRecId { get; set; }
        public string SLocation { get; set; }
        public string SHardnessTypeReq { get; set; }
        public decimal? DblMinReq { get; set; }
        public decimal? DblMaxReq { get; set; }
        public decimal? DblHardnessNumber { get; set; }
        public string SHardnessType { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TLabImportHardness SHardnessGu { get; set; }
    }
}
