using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TSawSession
    {
        public Guid SSessionGuid { get; set; }
        public string SSawName { get; set; }
        public string SSawDesc { get; set; }
        public string SJobNum { get; set; }
        public string SConversionNum { get; set; }
        public string SHeatNum { get; set; }
        public string SHeatCode { get; set; }
        public string SOperator { get; set; }
        public string SBilletNum { get; set; }
        public int? ITravelerStepNum { get; set; }
        public string SCutType { get; set; }
        public Guid? SDetailGuid { get; set; }
        public Guid? SBladeGuid { get; set; }
        public DateTime? DtLastAccess { get; set; }
        public int ISortOrder { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
