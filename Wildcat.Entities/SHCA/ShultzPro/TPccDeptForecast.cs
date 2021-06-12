using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TPccDeptForecast
    {
        public Guid SForecastGuid { get; set; }
        public int IDeptNum { get; set; }
        public string SPlcategory { get; set; }
        public string SPlsubcategory { get; set; }
        public DateTime? DtPostingMonth { get; set; }
        public decimal DblAmount { get; set; }
        public string SGlcode { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
