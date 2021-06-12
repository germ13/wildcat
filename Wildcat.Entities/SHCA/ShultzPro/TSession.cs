using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TSession
    {
        public Guid SSessionGuid { get; set; }
        public string SSessionKey { get; set; }
        public Guid SUserGuid { get; set; }
        public DateTime DtCreated { get; set; }
        public DateTime DtLastActivity { get; set; }
        public bool BExpired { get; set; }
    }
}
