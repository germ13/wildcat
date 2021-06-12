using System;

namespace Wildcat.Entities.PCC.PCC03Integration
{
    public partial class TestOracle
    {
        public Guid Id { get; set; }
        public Guid? OracleId { get; set; }
        public Guid? Pcc03Id { get; set; }
        public bool ObjectSignal { get; set; }
        public int Status { get; set; }
        public bool InProcess { get; set; }
        public string Processor { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public bool? Active { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Rowversion { get; set; }
        public string Testcol { get; set; }
    }
}
