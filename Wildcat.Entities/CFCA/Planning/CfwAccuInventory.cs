using System;

namespace Wildcat.Entities.CFCA.Planning
{
    public partial class CfwAccuInventory
    {
        public int TableKey { get; set; }
        public int InventoryItemId { get; set; }
        public string LotNumber { get; set; }
        public DateTime? DateReceived { get; set; }
        public int TransactionQuantity { get; set; }
        public string RmItemNumber { get; set; }
        public string MetalName { get; set; }
        public string MetalAlloy { get; set; }
        public string MetalShape { get; set; }
        public int? MetalSize { get; set; }
        public string MetalSpec1 { get; set; }
        public string MetalSpec2 { get; set; }
        public int? MaterialCost { get; set; }
    }
}
