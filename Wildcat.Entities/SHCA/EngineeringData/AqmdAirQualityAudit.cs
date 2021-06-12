using System;

namespace Wildcat.Entities.SHCA.EngineeringData
{
    public partial class AqmdAirQualityAudit
    {
        public Guid Id { get; set; }
        public Guid STagGuid { get; set; }
        public string STagName { get; set; }
        public string STableName { get; set; }
        public string SDescription { get; set; }
        public string Property { get; set; }
        public bool? Active { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Rowversion { get; set; }
    }
}
