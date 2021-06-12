using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TSawRunChartDetail
    {
        public TSawRunChartDetail()
        {
            TSawRunChartEntry = new HashSet<TSawRunChartEntry>();
        }

        public Guid SDetailGuid { get; set; }
        public Guid SMasterGuid { get; set; }
        public string SMaterialSupplier { get; set; }
        public string SAlloyType { get; set; }
        public string SMaterialSize { get; set; }
        public decimal? DblTargetWeight { get; set; }
        public decimal? DblTargetLength { get; set; }
        public decimal DblPlusToleranceWeight { get; set; }
        public decimal DblMinusToleranceWeight { get; set; }
        public string SConversionNum { get; set; }
        public string SHeatNum { get; set; }
        public string SHeatCode { get; set; }
        public string SBilletNum { get; set; }
        public string SCutType { get; set; }
        public decimal? DblPlannedBilletWeight { get; set; }
        public decimal? DblPlannedBilletLength { get; set; }
        public decimal? DblActualBilletWeight { get; set; }
        public decimal? DblActualBilletLength { get; set; }
        public int? ITravelerStepNum { get; set; }
        public int INumPieces { get; set; }
        public bool BComplete { get; set; }
        public bool BHasBottomCrop { get; set; }
        public bool BHasTopCrop { get; set; }
        public bool BHasRem { get; set; }
        public bool BTestPiece { get; set; }
        public string SReason { get; set; }
        public decimal? DblBottomCropTarget { get; set; }
        public decimal? DblTopCropTarget { get; set; }
        public decimal? DblRemTarget { get; set; }
        public decimal DblKerfTarget { get; set; }
        public decimal DblKerfActual { get; set; }
        public decimal DblTargetCutRate { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
        public decimal DblPlusToleranceLength { get; set; }
        public decimal DblMinusToleranceLength { get; set; }
        public decimal? DblPoundsPerInch { get; set; }
        public decimal DblHighLimitWeight { get; set; }
        public decimal DblLowLimitWeight { get; set; }
        public decimal DblHighLimitLength { get; set; }
        public decimal DblLowLimitLength { get; set; }

        public TSawRunChartMaster SMasterGu { get; set; }
        public ICollection<TSawRunChartEntry> TSawRunChartEntry { get; set; }
    }
}
