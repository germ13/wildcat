using System;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class GasMeter
    {
        public string MeterName { get; set; }
        public string MeterIp { get; set; }
        public bool Active { get; set; }
        public DateTime Added { get; set; }
        public DateTime? Updated { get; set; }
        public string AddedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
