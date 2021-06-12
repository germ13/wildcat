using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TPccFlexDepartment
    {
        public Guid SDepartmentGuid { get; set; }
        public int IDeptNum { get; set; }
        public string SFlexDepartmentName { get; set; }
        public string SDepartmentCategory { get; set; }
        public bool BUseInFlex { get; set; }
        public int BOrderInFlex { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
