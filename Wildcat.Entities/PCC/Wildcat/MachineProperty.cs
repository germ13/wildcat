using System;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class MachineProperty
    {
        public string Id { get; set; }
        public string MachineId { get; set; }
        public string PropertyId { get; set; }
        public string Value { get; set; }
        public bool Active { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Rowversion { get; set; }

        public Machine Machine { get; set; }
        public MachinePropertyMetadata Property { get; set; }
    }
}
