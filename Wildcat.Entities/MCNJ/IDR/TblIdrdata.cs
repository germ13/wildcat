using System;

namespace Wildcat.Entities.MCNJ.IDR
{
    public partial class TblIdrdata
    {
        public int Idrnumber { get; set; }
        public DateTime? Date { get; set; }
        public string Initiator { get; set; }
        public string Operation { get; set; }
        public string Customer { get; set; }
        public string HeatCode { get; set; }
        public string DieNumber { get; set; }
        public string WorkOrderNumber { get; set; }
        public double? WorkOrderQuantity { get; set; }
        public double? DiscrepantQuantity { get; set; }
        public string SerialNumbers { get; set; }
        public string Required { get; set; }
        public string Actual { get; set; }
        public string DiscrepancyType1 { get; set; }
        public string DiscrepancyType2 { get; set; }
        public string PreDispositionStatus { get; set; }
        public string PreDispositionStatusNotes { get; set; }
        public double? ReworkQuantity { get; set; }
        public DateTime? MrbsubmittalDate { get; set; }
        public string MrbsubmittalNumber { get; set; }
        public double? MrbsubmittalQuantity { get; set; }
        public DateTime? MrbdispositionDate { get; set; }
        public double? FinalAcceptedQuantity { get; set; }
        public double? FinalRejectedQuantity { get; set; }
        public string FinalDisposition { get; set; }
        public string FinalDispositionBy { get; set; }
        public DateTime? FinalDispositionDate { get; set; }
        public string FinalDispositionSummary { get; set; }
        public string FinalDispositionSpecialHandlingInstructions { get; set; }
        public decimal? UnitCost { get; set; }
        public decimal? MaterialCost { get; set; }
        public decimal? LaborOverheadCost { get; set; }
        public decimal? UnitSellPrice { get; set; }
        public decimal? ReworkCost { get; set; }
        public decimal? RetestCost { get; set; }
        public decimal? ReplacementTestCost { get; set; }
        public decimal? AdditionalTestForInfo { get; set; }
        public decimal? ScrapCost { get; set; }
        public decimal? SubmittalCost { get; set; }
        public decimal? DollarsSubmitted { get; set; }
        public decimal? Idrcost { get; set; }
        public decimal? LostSales { get; set; }
        public decimal? TotalIdrcost { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
