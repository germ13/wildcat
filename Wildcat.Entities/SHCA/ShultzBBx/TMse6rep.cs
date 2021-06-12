using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TMse6rep
    {
        public int IRecId { get; set; }
        public string SKey { get; set; }
        public string SJobNumber { get; set; }
        public int? INextRepeatNumber { get; set; }
        public int? ICustomerNumber { get; set; }
        public string SCustomerName { get; set; }
        public decimal? DblIncentiveRatePerHour { get; set; }
        public string SMachineProcessCode { get; set; }
        public string SMaterialProcessCode { get; set; }
        public string SDieNumber1CodeNumber { get; set; }
        public decimal? DblDieNumber1PurchaseCost { get; set; }
        public decimal? DblDieNumber1ResinkCost { get; set; }
        public decimal? DblDieNumber1EstimatedLife { get; set; }
        public decimal? DblDieNumber1PiecesToDate { get; set; }
        public int? IDieActivityCode { get; set; }
        public string SOpen1 { get; set; }
        public string SDieNumber2CodeNumber { get; set; }
        public decimal? DblDieNumber2PurchaseCost { get; set; }
        public decimal? DblDieNumber2ResinkCost { get; set; }
        public decimal? DblDieNumber2EstimatedLife { get; set; }
        public decimal? DblDieNumber2PiecesToDate { get; set; }
        public string SOpen2 { get; set; }
        public string SOpen3 { get; set; }
        public string SGradeCode { get; set; }
        public string SSpec { get; set; }
        public string SPartNumber { get; set; }
        public string SCondition { get; set; }
        public string STravelerString { get; set; }
        public decimal? DblTotalPiecesToDate { get; set; }
        public string SDateAndOriginalPonumber { get; set; }
        public decimal? DblStartingStockSize { get; set; }
        public decimal? DblWeight { get; set; }
        public decimal? DblRepeatQuantityLast { get; set; }
        public decimal? DblPvafield { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
