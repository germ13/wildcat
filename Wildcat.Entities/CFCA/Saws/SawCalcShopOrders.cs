using System;
using System.Collections.Generic;

namespace Wildcat.Entities.CFCA.Saws
{
    public partial class SawCalcShopOrders
    {
        public SawCalcShopOrders()
        {
            SawCalcMaintenanceRequests = new HashSet<SawCalcMaintenanceRequests>();
            SawCalcPieces = new HashSet<SawCalcPieces>();
            SawCalcScheduleItems = new HashSet<SawCalcScheduleItems>();
            SawCalcShopOrderBillets = new HashSet<SawCalcShopOrderBillets>();
            SawCalcShopOrderHeatAndBilletNumbers = new HashSet<SawCalcShopOrderHeatAndBilletNumbers>();
            SawCalcShopOrderMultRequests = new HashSet<SawCalcShopOrderMultRequests>();
            SawCalcShopOrderSavedStates = new HashSet<SawCalcShopOrderSavedStates>();
            SawCalcShopOrderSerialNumbers = new HashSet<SawCalcShopOrderSerialNumbers>();
        }

        public int ShopOrderId { get; set; }
        public string ShopOrderNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastCutDate { get; set; }
        public short NumberOfTotalPieces { get; set; }
        public short? NumberOfRemainingPieces { get; set; }
        public string Notes { get; set; }
        public string Customer { get; set; }
        public string Specification { get; set; }
        public string PartNumber { get; set; }
        public string BilletShape { get; set; }
        public string Mill { get; set; }
        public int? MaterialId { get; set; }
        public string TargetWeights { get; set; }
        public DateTime? ForgeDate { get; set; }
        public double? ShippingDollars { get; set; }
        public string CuttingTicketStatus { get; set; }

        public SawCalcMaterials Material { get; set; }
        public ICollection<SawCalcMaintenanceRequests> SawCalcMaintenanceRequests { get; set; }
        public ICollection<SawCalcPieces> SawCalcPieces { get; set; }
        public ICollection<SawCalcScheduleItems> SawCalcScheduleItems { get; set; }
        public ICollection<SawCalcShopOrderBillets> SawCalcShopOrderBillets { get; set; }
        public ICollection<SawCalcShopOrderHeatAndBilletNumbers> SawCalcShopOrderHeatAndBilletNumbers { get; set; }
        public ICollection<SawCalcShopOrderMultRequests> SawCalcShopOrderMultRequests { get; set; }
        public ICollection<SawCalcShopOrderSavedStates> SawCalcShopOrderSavedStates { get; set; }
        public ICollection<SawCalcShopOrderSerialNumbers> SawCalcShopOrderSerialNumbers { get; set; }
    }
}
