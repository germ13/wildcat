using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TA1vend
    {
        public int IRecId { get; set; }
        public string SKey { get; set; }
        public string SVendorNumber { get; set; }
        public string SVendorName { get; set; }
        public string SLine01 { get; set; }
        public string SLine02 { get; set; }
        public string SLine03 { get; set; }
        public string SEmpty01 { get; set; }
        public decimal? DblPurchaseYtd { get; set; }
        public string SDiscountPercentage { get; set; }
        public string STerms { get; set; }
        public string SEmpty02 { get; set; }
        public string STaxPayerIdNumber { get; set; }
        public bool? BIs1099 { get; set; }
        public string SContactName { get; set; }
        public string SContactPhoneNumber { get; set; }
        public string SContactFaxNumber { get; set; }
        public string SContactEmail { get; set; }
        public string SOpen01 { get; set; }
        public string SOpen02 { get; set; }
        public string SOpen03 { get; set; }
        public string SOpen04 { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
