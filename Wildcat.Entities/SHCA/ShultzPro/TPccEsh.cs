using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TPccEsh
    {
        public Guid SEshguid { get; set; }
        public DateTime DtWeekStarting { get; set; }
        public int IDaysInWeek { get; set; }
        public string SDepartmentName { get; set; }
        public int IEshplanPerDay { get; set; }
        public decimal DblProdTarget { get; set; }
        public decimal DblRegHeadcount { get; set; }
        public decimal DblTempHeadcount { get; set; }
        public decimal DblAbsentVacation { get; set; }
        public decimal DblOtpercentage { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
