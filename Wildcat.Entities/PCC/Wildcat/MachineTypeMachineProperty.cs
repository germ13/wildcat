using System;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class MachineTypeMachineProperty
    {
        public string MachineId { get; set; }
        public string PropertyTypeId { get; set; }
        public bool IsRequired { get; set; }
        public int SortOrder { get; set; }
        public bool Active { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Rowversion { get; set; }
    }
}
