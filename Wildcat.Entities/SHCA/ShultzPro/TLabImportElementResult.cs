using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TLabImportElementResult
    {
        public Guid SResultGuid { get; set; }
        public Guid SChemGuid { get; set; }
        public string SRecId { get; set; }
        public string SUom { get; set; }
        public decimal? DblMinReq { get; set; }
        public decimal? DblMaxReq { get; set; }
        public decimal? DblElementAmt { get; set; }
        public string SAnalysisMethod { get; set; }
        public bool? BConforms { get; set; }
        public string SMinReqSymbol { get; set; }
        public string SMaxReqSymbol { get; set; }
        public string SElementAmtSymbol { get; set; }
        public string SRemarks { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TLabImportChem SChemGu { get; set; }
    }
}
