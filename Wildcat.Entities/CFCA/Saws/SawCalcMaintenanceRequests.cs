using System;

namespace Wildcat.Entities.CFCA.Saws
{
    public partial class SawCalcMaintenanceRequests
    {
        public int MaintenanceRequestId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ShopOrderId { get; set; }
        public int? OperatorId { get; set; }
        public int? SawId { get; set; }
        public int? BladeId { get; set; }
        public int? ComputerId { get; set; }
        public string Message { get; set; }
        public DateTime? ResponseDate { get; set; }
        public string Responder { get; set; }
        public string ResponseMessage { get; set; }
        public string ResponseType { get; set; }

        public SawCalcBlades Blade { get; set; }
        public SawCalcComputers Computer { get; set; }
        public SawCalcPersons Operator { get; set; }
        public SawCalcSaws Saw { get; set; }
        public SawCalcShopOrders ShopOrder { get; set; }
    }
}
