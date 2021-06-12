using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TE1cust
    {
        public int IRecId { get; set; }
        public string SKey { get; set; }
        public string SCustomerNumber { get; set; }
        public string SCustomerName { get; set; }
        public string SStreetAddress { get; set; }
        public string SCityStateZip { get; set; }
        public string SSuiteNum { get; set; }
        public string SShipToAddress1 { get; set; }
        public string SShiptToAddress2 { get; set; }
        public string SShipToAddressCityStateZip { get; set; }
        public string SShipToAddressCityStateZip2 { get; set; }
        public string STerritory { get; set; }
        public string SCertificationMaterial { get; set; }
        public string SCertificationMailed { get; set; }
        public string SCreditHoldFlag { get; set; }
        public int? IArcontrol { get; set; }
        public string STelephoneNumber { get; set; }
        public string SContact { get; set; }
        public decimal? DblCurrentHighBalance { get; set; }
        public string SResaleNumber { get; set; }
        public decimal? DblSalesMtd { get; set; }
        public decimal? DblCostMtd { get; set; }
        public decimal? DblSalesYtd { get; set; }
        public decimal? DblCostYtd { get; set; }
        public string SMailToLine1 { get; set; }
        public string SMailToLine2 { get; set; }
        public string SPayHist { get; set; }
        public string SBlank00 { get; set; }
        public string SEstimateDays { get; set; }
        public int? ICustomerBackoffDays { get; set; }
        public string SHydra01 { get; set; }
        public string SHydra02 { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
