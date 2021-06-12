namespace Wildcat.Entities.CFCA.Planning
{
    public partial class CfwAccuMultCount
    {
        public int TableKey { get; set; }
        public int WipEntityId { get; set; }
        public string MultCount { get; set; }
        public string CutWeight { get; set; }
        public string GrossWeight { get; set; }
        public string OneEquals { get; set; }
    }
}
