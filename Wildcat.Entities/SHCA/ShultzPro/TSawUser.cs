using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TSawUser
    {
        public Guid SUserGuid { get; set; }
        public string SUserName { get; set; }
        public string SFullName { get; set; }
        public string SShift { get; set; }
        public string SPassword { get; set; }
        public int ILoginAttempts { get; set; }
        public string SPinNum { get; set; }
        public DateTime? DtLastLogin { get; set; }
        public bool BAdminUser { get; set; }
        public bool BFixJobsUser { get; set; }
        public string SLastOpenSection { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
