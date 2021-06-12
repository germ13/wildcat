using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TRssweatherMaster
    {
        public Guid SWeatherGuid { get; set; }
        public DateTime? DtLastBuilt { get; set; }
        public string SCity { get; set; }
        public string SState { get; set; }
        public string SCountry { get; set; }
        public string SConditionText { get; set; }
        public int? ICode { get; set; }
        public decimal? DblTemp { get; set; }
        public DateTime? DtSunrise { get; set; }
        public DateTime? DtSunset { get; set; }
        public string IWindChill { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
