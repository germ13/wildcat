using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TMillImportProductChemistryTests
    {
        public Guid SProductChemTestGuid { get; set; }
        public Guid SProductGuid { get; set; }
        public string SChemTestId { get; set; }
        public decimal? DblMinLimit { get; set; }
        public decimal? DblMaxLimit { get; set; }
        public decimal? DblTop { get; set; }
        public decimal? DblBottom { get; set; }
        public decimal? DblResult { get; set; }
        public bool? BPass { get; set; }
        public string SMinLimitSymbol { get; set; }
        public string SMaxLimitSymbol { get; set; }
        public string STopSymbol { get; set; }
        public string SBottomSymbol { get; set; }
        public string SResultSymbol { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TMillImportProducts SProductGu { get; set; }
    }
}
