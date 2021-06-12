namespace Wildcat.Entities.CFCA.Saws
{
    public partial class SawCalcShopOrderSerialNumbers
    {
        public int ShopOrderId { get; set; }
        public string MultSerialNumber { get; set; }
        public short SequenceNumber { get; set; }

        public SawCalcShopOrders ShopOrder { get; set; }
    }
}
