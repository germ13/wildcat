using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.EngineeringData
{
    public partial class KepwareTag
    {
        public KepwareTag()
        {
            KepwareMetaValue = new HashSet<KepwareMetaValue>();
        }

        public string KepwareTagId { get; set; }
        public string KepwareTagName { get; set; }
        public string KepwareTagDisplay { get; set; }
        public string KepwareMachineId { get; set; }
        public string KepwareTable { get; set; }
        public string KepwareProperty { get; set; }
        public bool? Active { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Rowversion { get; set; }

        public KepwareMachine KepwareMachine { get; set; }
        public ICollection<KepwareMetaValue> KepwareMetaValue { get; set; }
    }
}
