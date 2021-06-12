using System;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class Metal
    {
        public int MetalId { get; set; }
        public string MetalName { get; set; }
        public bool Active { get; set; }
        public DateTime Added { get; set; }
        public DateTime? Updated { get; set; }
        public string AddedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
