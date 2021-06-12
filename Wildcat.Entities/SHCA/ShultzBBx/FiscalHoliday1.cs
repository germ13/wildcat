using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class FiscalHoliday1
    {
        public DateTime FiscalDate { get; set; }
        public string PlantCode { get; set; }
        public string DisplayName { get; set; }
        public string Detail { get; set; }
        public bool? Active { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Added { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public byte[] Versioning { get; set; }
    }
}
