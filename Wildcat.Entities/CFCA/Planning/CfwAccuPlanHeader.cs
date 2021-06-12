namespace Wildcat.Entities.CFCA.Planning
{
    public partial class CfwAccuPlanHeader
    {
        public int TableKey { get; set; }
        public int WipEntityId { get; set; }
        public string JobStatus { get; set; }
        public int PrimaryItemId { get; set; }
        public int InventoryItemId { get; set; }
        public string MaterialCode { get; set; }
        public string Description { get; set; }
        public string MetalSpec1 { get; set; }
        public string Material1 { get; set; }
        public string Material2 { get; set; }
        public string Partnumber { get; set; }
        public string Materialnotes { get; set; }
        public string AltDescription { get; set; }
        public string Partdescription { get; set; }
        public string CustomerName { get; set; }
        public string CustomerNumber { get; set; }
        public string EngineProgram { get; set; }
        public string WipEntityName { get; set; }
        public string LotSize { get; set; }
        public string RmSize { get; set; }
        public string Stocksize1 { get; set; }
        public string Stockshape { get; set; }
        public string Primarymultweight { get; set; }
        public string Primarygrossweight { get; set; }
        public string Primarymultcount { get; set; }
        public int? Totalweight { get; set; }
        public string ShortText { get; set; }
    }
}
