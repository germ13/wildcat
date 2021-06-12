namespace Wildcat.Entities.CFCA.Saws
{
    public partial class SawCalcShopOrderBillets
    {
        public int ShopOrderId { get; set; }
        public int BilletId { get; set; }
        public double NewBilletLength { get; set; }
        public double NewBilletWeight { get; set; }
        public bool BilletDirectionBottomToTop { get; set; }

        public SawCalcBillets Billet { get; set; }
        public SawCalcShopOrders ShopOrder { get; set; }
    }
}
