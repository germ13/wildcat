using System;

namespace Wildcat.Entities.SHCA.EngineeringData
{
    public partial class ConditioningThreshold
    {
        public Guid Id { get; set; }
        public long KepwareId { get; set; }
        public double DblValue { get; set; }
        public string Property { get; set; }
        public bool? Active { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Rowversion { get; set; }
    }
}
