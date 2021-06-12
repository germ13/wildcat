using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TSiemensUser
    {
        public TSiemensUser()
        {
            TSiemensSecUserToGroup = new HashSet<TSiemensSecUserToGroup>();
        }

        public Guid SUserGuid { get; set; }
        public string SUserName { get; set; }
        public string SEmployeeName { get; set; }
        public string SPassword { get; set; }
        public int ILoginAttempts { get; set; }
        public DateTime? DtLastLogin { get; set; }
        public int? IAccessControlEmpId { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUser { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TSiemensSecUserToGroup> TSiemensSecUserToGroup { get; set; }
    }
}
