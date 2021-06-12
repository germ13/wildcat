using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.EngineeringData
{
    public partial class KepwareMachineProperty
    {
        public KepwareMachineProperty()
        {
            KepwareMachineValue = new HashSet<KepwareMachineValue>();
        }

        public string MachinePropertyId { get; set; }
        public string Description { get; set; }
        public string PropertyType { get; set; }
        public bool? Active { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Rowversion { get; set; }

        public ICollection<KepwareMachineValue> KepwareMachineValue { get; set; }
    }
}
