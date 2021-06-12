using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class FiscalCalendar1
    {
        public DateTime FiscalDate { get; set; }
        public string PlantCode { get; set; }
        public int? FiscalYear { get; set; }
        public int? FiscalQuarter { get; set; }
        public int? FiscalMonth { get; set; }
        public int? FiscalWeek { get; set; }
        public string FiscalWeekday { get; set; }
        public bool? IsWorkday { get; set; }
        public bool? IsHoliday { get; set; }
        public bool? Active { get; set; }
        public DateTime? Added { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Versioning { get; set; }
    }
}
