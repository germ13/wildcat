using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class THtscheduleDetail
    {
        public Guid SHtdetailGuid { get; set; }
        public Guid SHtscheduleGuid { get; set; }
        public Guid? SFurnaceKeyGuid { get; set; }
        public string SWorkShift { get; set; }
        public string SNotes { get; set; }
        public string SShiftOperators { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public THtschedule SHtscheduleGu { get; set; }
    }
}
