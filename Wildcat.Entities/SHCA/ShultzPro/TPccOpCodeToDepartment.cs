using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TPccOpCodeToDepartment
    {
        public Guid SPostingGuid { get; set; }
        public string SOpCode { get; set; }
        public int? IDeptNum { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
