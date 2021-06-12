using System;

namespace Wildcat.Entities.SHCA.EngineeringData
{
    public partial class KepwareMachineValue
    {
        public Guid Id { get; set; }
        public string KepwareMachineId { get; set; }
        public string MachinePropertyId { get; set; }
        public string Value { get; set; }
        public bool? Active { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Rowversion { get; set; }

        public KepwareMachine KepwareMachine { get; set; }
        public KepwareMachineProperty MachineProperty { get; set; }
    }
}
