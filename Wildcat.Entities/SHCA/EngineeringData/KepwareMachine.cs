using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.EngineeringData
{
    public partial class KepwareMachine
    {
        public KepwareMachine()
        {
            KepwareMachineValue = new HashSet<KepwareMachineValue>();
            KepwareTag = new HashSet<KepwareTag>();
        }

        public string KepwareMachineId { get; set; }
        public string DisplayName { get; set; }
        public bool? Active { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Rowversion { get; set; }

        public ICollection<KepwareMachineValue> KepwareMachineValue { get; set; }
        public ICollection<KepwareTag> KepwareTag { get; set; }
    }
}
