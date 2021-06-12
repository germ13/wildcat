using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TPccChartOfAccounts
    {
        public Guid SCoaguid { get; set; }
        public string SGlcode { get; set; }
        public string SPlcategory { get; set; }
        public string SPlsubCategory { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
