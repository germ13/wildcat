using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TPccHrAdp
    {
        public Guid SAdpguid { get; set; }
        public DateTime DtFile { get; set; }
        public int IDepartmentNum { get; set; }
        public string SEarningsCode { get; set; }
        public decimal DblHours { get; set; }
        public decimal DblDollars { get; set; }
        public string SDescription { get; set; }
        public bool BIsTemp { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
