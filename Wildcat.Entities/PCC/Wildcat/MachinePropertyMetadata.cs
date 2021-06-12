using System;
using System.Collections.Generic;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class MachinePropertyMetadata
    {
        public MachinePropertyMetadata()
        {
            MachineProperty = new HashSet<MachineProperty>();
            MachinePropertyMetadataValue = new HashSet<MachinePropertyMetadataValue>();
        }

        public string Id { get; set; }
        public string PropertyName { get; set; }
        public string DisplayName { get; set; }
        public string LocationCode { get; set; }
        public bool IsRequired { get; set; }
        public string Definition { get; set; }
        public string Datatype { get; set; }
        public bool Active { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Rowversion { get; set; }

        public ICollection<MachineProperty> MachineProperty { get; set; }
        public ICollection<MachinePropertyMetadataValue> MachinePropertyMetadataValue { get; set; }
    }
}
