namespace Wildcat.Entities.CFCA.Saws
{
    public partial class SawCalcShopOrderMultRequests
    {
        public int ShopOrderMultRequestId { get; set; }
        public int ShopOrderId { get; set; }
        public double TargetWeight { get; set; }
        public int NumberOfMults { get; set; }
        public int CutQuantity { get; set; }
        public bool IsTestPiece { get; set; }
        public short SequenceNumber { get; set; }

        public SawCalcShopOrders ShopOrder { get; set; }
    }
}
