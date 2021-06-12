using System;
using System.Collections.Generic;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class MetadataValue
    {
        public MetadataValue()
        {
            MachinePropertyMetadataValue = new HashSet<MachinePropertyMetadataValue>();
        }

        public string Id { get; set; }
        public string MetadataDisplay { get; set; }
        public string MetadataValue1 { get; set; }
        public string LocationCode { get; set; }
        public bool? Active { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Rowversion { get; set; }

        public ICollection<MachinePropertyMetadataValue> MachinePropertyMetadataValue { get; set; }
    }
}
