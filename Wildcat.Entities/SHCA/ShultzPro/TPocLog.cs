using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TPocLog
    {
        public Guid SRecGuid { get; set; }
        public DateTime DtTransaction { get; set; }
        public string SValue { get; set; }
    }
}
