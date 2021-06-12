using System;

namespace Wildcat.Entities.CFCA.Saws
{
    public partial class SawCalcScheduleItems
    {
        public int ScheduleItemId { get; set; }
        public int? ShopOrderId { get; set; }
        public short? NumberOfPiecesScheduled { get; set; }
        public short? NumberOfPiecesCut { get; set; }
        public DateTime? DateScheduled { get; set; }
        public double EstimatedMinutes { get; set; }
        public int? SawId { get; set; }
        public int SequenceNumber { get; set; }
        public bool Hidden { get; set; }
        public int? OperatorId { get; set; }

        public SawCalcPersons Operator { get; set; }
        public SawCalcSaws Saw { get; set; }
        public SawCalcShopOrders ShopOrder { get; set; }
    }
}
