using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TIdr2009
    {
        public int IRecId { get; set; }
        public string SKey { get; set; }
        public string SIdrnumber { get; set; }
        public DateTime? DtIssueDate { get; set; }
        public string SJobNumber { get; set; }
        public string SJobNumberSuffix { get; set; }
        public string SAlloy { get; set; }
        public decimal? DblInspectedQuantity { get; set; }
        public decimal? DblAcceptedQuantity { get; set; }
        public decimal? DblRejectedQuantity { get; set; }
        public string SNonConformanceCode { get; set; }
        public string SDeviationDescription { get; set; }
        public string SSerialNumbers { get; set; }
        public string SDepartmentCode { get; set; }
        public string SDepartmentName { get; set; }
        public string SHeatCode { get; set; }
        public string SHeatNumber { get; set; }
        public string SCustomerName { get; set; }
        public string SPartNumber { get; set; }
        public string SPnrevision { get; set; }
        public string SUnitPrice { get; set; }
        public string SPrice { get; set; }
        public string SCustomerPo { get; set; }
        public string SPreliminaryDisplayCode { get; set; }
        public DateTime? DtPreliminaryDisplayDate { get; set; }
        public string SReworkInstructions { get; set; }
        public DateTime? DtReworkInstructionIssueDate { get; set; }
        public string SVdrnumber { get; set; }
        public decimal? DblVdrsubmittedQuantity { get; set; }
        public decimal? DblVdrquantityOnSubmittal { get; set; }
        public string SVdrwrittenBy { get; set; }
        public DateTime? DtVdrissueDate { get; set; }
        public string SCustomerTagNumber { get; set; }
        public string SSubmittedBySssalesRep { get; set; }
        public DateTime? DtVdrsubmittedDate { get; set; }
        public string SVdrdispositionCode { get; set; }
        public DateTime? DtVdrdispositionDate { get; set; }
        public decimal? DblDaysToClose { get; set; }
        public string SSalesStatusFeedback { get; set; }
        public string SStatusOf { get; set; }
        public string SFinalDispositionCode { get; set; }
        public DateTime? DtFinalDispositionDate { get; set; }
        public string SFinalDispositionBy { get; set; }
        public decimal? DblReworkCost { get; set; }
        public decimal? DblScrapCost { get; set; }
        public string SFinalReviewBy { get; set; }
        public DateTime? DtFindalCloseDate { get; set; }
        public decimal? DblClosingValue { get; set; }
        public string SComment { get; set; }
        public decimal? DblDaysToClose2 { get; set; }
        public string SFinalDispositionComments { get; set; }
        public string SCost { get; set; }
        public string STravelerStepKey { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
