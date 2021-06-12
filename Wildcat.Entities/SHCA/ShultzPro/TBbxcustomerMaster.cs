using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TBbxcustomerMaster
    {
        public Guid SCustomerGuid { get; set; }
        public string SCustNum { get; set; }
        public string SSoldToAddr1 { get; set; }
        public string SSoldToAddr2 { get; set; }
        public string SSoldToAddr3 { get; set; }
        public string SSoldToAddr4 { get; set; }
        public string SShipToAddr1 { get; set; }
        public string SShipToAddr2 { get; set; }
        public string SShipToAddr3 { get; set; }
        public string SShipToAddr4 { get; set; }
        public int? ITerritory { get; set; }
        public int? ICertMaterial { get; set; }
        public string SCertMailed { get; set; }
        public string SCodeStr { get; set; }
        public decimal? DblArcontrol { get; set; }
        public string STelNum { get; set; }
        public string SContact { get; set; }
        public decimal? CurHighBalance { get; set; }
        public string SResaleNum { get; set; }
        public decimal? CurMtdsales { get; set; }
        public decimal? CurMtdcosts { get; set; }
        public decimal? CurYtdsales { get; set; }
        public decimal? CurYtdcosts { get; set; }
        public string SMailToAddr1 { get; set; }
        public string SMailToAddr2 { get; set; }
        public string SPayHist { get; set; }
        public int? IEstimatedDays { get; set; }
        public int? ICustBackoffDays { get; set; }
        public DateTime? DtBbxupdt { get; set; }
        public string SBbxupdtBy { get; set; }
        public string SCreditHoldFlag { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
