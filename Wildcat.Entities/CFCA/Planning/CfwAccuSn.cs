namespace Wildcat.Entities.CFCA.Planning
{
    public partial class CfwAccuSn
    {
        public int TableKey { get; set; }
        public int? WipEntityId { get; set; }
        public string CustomerSerialNumber { get; set; }
        public string SerialNumber { get; set; }
        public int? SnAssignmentId { get; set; }
        public string WipEntityName { get; set; }
    }
}
