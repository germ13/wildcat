using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TPccHeadcount
    {
        public Guid SHeadcountGuid { get; set; }
        public int IDeptId { get; set; }
        public int? IEmpId { get; set; }
        public string SName { get; set; }
        public string SJobTitle { get; set; }
        public bool BIsTemp { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
