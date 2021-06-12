namespace Wildcat.Entities.CFCA.Saws
{
    public partial class SawCalcShopOrderHeatAndBilletNumbers
    {
        public int ShopOrderId { get; set; }
        public string HeatNumber { get; set; }
        public string BilletNumber { get; set; }
        public double OriginalWeight { get; set; }
        public short SequenceNumber { get; set; }

        public SawCalcShopOrders ShopOrder { get; set; }
    }
}
