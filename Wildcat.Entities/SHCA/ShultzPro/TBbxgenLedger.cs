using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TBbxgenLedger
    {
        public Guid SGlguid { get; set; }
        public string SAcctNumber { get; set; }
        public string SDescription { get; set; }
        public decimal? CurCrntCashReceiptsDr { get; set; }
        public decimal? CurCrntCashReceiptsCr { get; set; }
        public decimal? CurCrntAcctPayDr { get; set; }
        public decimal? CurCrntAcctPayCr { get; set; }
        public decimal? CurCrntCashDisbDr { get; set; }
        public decimal? CurCrntCashDisbCr { get; set; }
        public decimal? CurCrntSalesJournalDr { get; set; }
        public decimal? CurCrntSalesJournalCr { get; set; }
        public decimal? CurCrntPayrollRegDr { get; set; }
        public decimal? CurCrntPayrollRegCr { get; set; }
        public decimal? CurCrntDprdr { get; set; }
        public decimal? CurCrntDprcr { get; set; }
        public decimal? CurFullCashReceiptsDr { get; set; }
        public decimal? CurFullCashReceiptsCr { get; set; }
        public decimal? CurFullAcctPayDr { get; set; }
        public decimal? CurFullAcctPayCr { get; set; }
        public decimal? CurFullCashDisbDr { get; set; }
        public decimal? CurFullCashDisbCr { get; set; }
        public decimal? CurFullSalesJournalDr { get; set; }
        public decimal? CurFullSalesJournalCr { get; set; }
        public decimal? CurFullPayrollRegDr { get; set; }
        public decimal? CurFullPayrollRegCr { get; set; }
        public decimal? CurFullDprdr { get; set; }
        public decimal? CurFullDprcr { get; set; }
        public decimal? CurGenJnl1Dr { get; set; }
        public decimal? CurGenJnl1Cr { get; set; }
        public decimal? CurGenJnl2Dr { get; set; }
        public decimal? CurGenJnl2Cr { get; set; }
        public decimal? CurGenJnl3Dr { get; set; }
        public decimal? CurGenJnl3Cr { get; set; }
        public decimal? CurGenJnl4Dr { get; set; }
        public decimal? CurGenJnl4Cr { get; set; }
        public decimal? CurGenJnl5Dr { get; set; }
        public decimal? CurGenJnl5Cr { get; set; }
        public decimal? CurBalForward { get; set; }
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
