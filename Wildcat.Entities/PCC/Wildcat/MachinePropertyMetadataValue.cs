using System;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class MachinePropertyMetadataValue
    {
        public string MachinePropertyId { get; set; }
        public string MetadataValueId { get; set; }
        public bool IsRequired { get; set; }
        public int SortOrder { get; set; }
        public bool Active { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Rowversion { get; set; }

        public MachinePropertyMetadata MachineProperty { get; set; }
        public MetadataValue MetadataValue { get; set; }
    }
}
