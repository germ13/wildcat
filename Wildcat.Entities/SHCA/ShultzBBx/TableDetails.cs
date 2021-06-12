namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TableDetails
    {
        public string BbxName { get; set; }
        public string Details { get; set; }
        public string FileType { get; set; }
        public string DataType { get; set; }
        public string ResetStatus { get; set; }
        public string UpdateSources { get; set; }
        public bool? IsBeingMigrated { get; set; }
    }
}
