using System;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class SerialNumber
    {
        public long SerialNumberId { get; set; }
        public string JobNumber { get; set; }
        public string Alphanumeric { get; set; }
        public string LocationCode { get; set; }
        public string Notes { get; set; }
        public bool Active { get; set; }
        public DateTime Added { get; set; }
        public DateTime? Updated { get; set; }
        public string AddedBy { get; set; }
        public string UpdatedBy { get; set; }

        public Job JobNumberNavigation { get; set; }
    }
}
