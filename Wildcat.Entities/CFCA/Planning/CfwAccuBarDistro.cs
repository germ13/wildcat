namespace Wildcat.Entities.CFCA.Planning
{
    public partial class CfwAccuBarDistro
    {
        public int TableKey { get; set; }
        public int WipEntityId { get; set; }
        public string WgHeatNumber { get; set; }
        public string BarIngotNumber { get; set; }
        public int? StartingBarWeight { get; set; }
        public string OneEquals { get; set; }
        public string MultCount { get; set; }
        public string GrossWeight { get; set; }
        public int? TotalWeight { get; set; }
        public string JobNumber { get; set; }
    }
}
