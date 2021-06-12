using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TGDollarGCaretL
    {
        public int IRecId { get; set; }
        public string SKey { get; set; }
        public string SAccountNumber { get; set; }
        public string SDescription { get; set; }
        public decimal? DblCashReceiptsDrCurrent { get; set; }
        public decimal? DblCashReceiptsCrCurrent { get; set; }
        public decimal? DblAccountsPayableDrCurrent { get; set; }
        public decimal? DblAccountsPayableCrCurrent { get; set; }
        public decimal? DblCashDisbursementsDrCurrent { get; set; }
        public decimal? DblCashDisbursementsCrCurrent { get; set; }
        public decimal? DblSalesJournalDrCurrent { get; set; }
        public decimal? DblSalesJournalCrCurrent { get; set; }
        public decimal? DblPayrollRegisterDrCurrent { get; set; }
        public decimal? DblPayrollRegisterCrCurrent { get; set; }
        public decimal? DblDailyProductionDrCurrent { get; set; }
        public decimal? DblDailyProductionCrCurrent { get; set; }
        public decimal? DblCashReceiptsDrFull { get; set; }
        public decimal? DblCashReceiptsCrFull { get; set; }
        public decimal? DblAccountsPayableDrFull { get; set; }
        public decimal? DblAccountsPayableCrFull { get; set; }
        public decimal? DblCashDisbursementsDrFull { get; set; }
        public decimal? DblCashDisbursementsCrFull { get; set; }
        public decimal? DblSalesJournalDrFull { get; set; }
        public decimal? DblSalesJournalCrFull { get; set; }
        public decimal? DblPayrollRegisterDrFull { get; set; }
        public decimal? DblPayrollRegisterCrFull { get; set; }
        public decimal? DblDailyProductionDrFull { get; set; }
        public decimal? DblDailyProductionCrFull { get; set; }
        public decimal? DblGeneralJournal01Dr { get; set; }
        public decimal? DblGeneralJournal01Cr { get; set; }
        public decimal? DblGeneralJournal02Dr { get; set; }
        public decimal? DblGeneralJournal02Cr { get; set; }
        public decimal? DblGeneralJournal03Dr { get; set; }
        public decimal? DblGeneralJournal03Cr { get; set; }
        public decimal? DblGeneralJournal04Dr { get; set; }
        public decimal? DblGeneralJournal04Cr { get; set; }
        public decimal? DblDitto01 { get; set; }
        public decimal? DblDitto02 { get; set; }
        public decimal? DblBalanceForward { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
