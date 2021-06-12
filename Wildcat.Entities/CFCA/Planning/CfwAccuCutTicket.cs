namespace Wildcat.Entities.CFCA.Planning
{
    public partial class CfwAccuCutTicket
    {
        public int TableKey { get; set; }
        public int WipEntityId { get; set; }
        public string Stocksize1 { get; set; }
        public string Stockshape { get; set; }
        public string WgHeatNumber { get; set; }
        public string BarIngotNumber { get; set; }
        public int? StartingBarWeight { get; set; }
        public string CutWeight { get; set; }
        public int? BarIngotNumberId { get; set; }
        public int? PieceCount { get; set; }
    }
}
