using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TDepartment
    {
        public Guid SDepartmentGuid { get; set; }
        public int? IDeptId { get; set; }
        public string SDescription { get; set; }
        public string SBestPracticeAbbrev { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
