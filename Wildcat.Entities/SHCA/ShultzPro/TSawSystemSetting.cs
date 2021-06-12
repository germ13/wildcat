using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TSawSystemSetting
    {
        public Guid SRecGuid { get; set; }
        public string SListName { get; set; }
        public string SValue { get; set; }
        public string SValueDesc { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
        public int ISortOrder { get; set; }
        public bool BInactive { get; set; }
    }
}
