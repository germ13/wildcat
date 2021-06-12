using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TAccount
    {
        public Guid SAccountGuid { get; set; }
        public int? IAccountId { get; set; }
        public string SDescription { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
