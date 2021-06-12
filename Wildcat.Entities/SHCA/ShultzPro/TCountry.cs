using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TCountry
    {
        public Guid SCountryGuid { get; set; }
        public string SCountryName { get; set; }
        public int ISort { get; set; }
        public bool BIsDefault { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
