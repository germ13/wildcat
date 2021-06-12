using System;

namespace Wildcat.Entities.PCC.PCC03Integration
{
    public partial class MasterTable
    {
        public Guid Id { get; set; }
        public long OracleId { get; set; }
        public long Pcc03Id { get; set; }
        public string Note { get; set; }
        public bool Active { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Rowversion { get; set; }
    }
}
