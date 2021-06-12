using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TForgeClampDetail
    {
        public Guid SDetailGuid { get; set; }
        public Guid SOpGuid { get; set; }
        public string STopBottom { get; set; }
        public string SSingleDouble { get; set; }
        public int? IPosition { get; set; }
        public string SClampOption { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TForgeClampOperation SOpGu { get; set; }
    }
}
