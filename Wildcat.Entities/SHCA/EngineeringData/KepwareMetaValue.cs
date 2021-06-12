using System;

namespace Wildcat.Entities.SHCA.EngineeringData
{
    public partial class KepwareMetaValue
    {
        public Guid Id { get; set; }
        public string KepwareTagId { get; set; }
        public string MetaPropertyId { get; set; }
        public string Value { get; set; }
        public bool? Active { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Rowversion { get; set; }

        public KepwareTag KepwareTag { get; set; }
        public KepwareTagOld KepwareTagNavigation { get; set; }
        public KepwareMetaProperty MetaProperty { get; set; }
    }
}
