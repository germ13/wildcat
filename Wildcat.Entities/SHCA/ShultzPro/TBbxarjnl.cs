using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TBbxarjnl
    {
        public Guid SArjnlguid { get; set; }
        public string SInvoiceNumber { get; set; }
        public string SCustNumber { get; set; }
        public string SCustName { get; set; }
        public decimal? CurGrossAmt { get; set; }
        public decimal? CurTaxAmt { get; set; }
        public decimal? CurFreightAmt { get; set; }
        public decimal? CurMiscAmt { get; set; }
        public decimal? CurInvoiceAmt { get; set; }
        public string SOpen9 { get; set; }
        public string STerritoryNumber { get; set; }
        public decimal? CurCommissionPct { get; set; }
        public string SCommRenogCode { get; set; }
        public string SClassification { get; set; }
        public string SMachineCode { get; set; }
        public string SMaterialCode { get; set; }
        public int? IActWeightPulled { get; set; }
        public string SCustPonumber { get; set; }
        public int? IActShipWeight { get; set; }
        public string STermsCode { get; set; }
        public string SFinalInvoiceCode { get; set; }
        public DateTime? DtBbxupdt { get; set; }
        public string SBbxupdtBy { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByuserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
