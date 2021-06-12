using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TDepartmentSupervisor
    {
        public Guid SSupervisorGuid { get; set; }
        public Guid SDepartmentGuid { get; set; }
        public Guid SUserGuid { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
