using System;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class BarShape
    {
        public string ShapeCode { get; set; }
        public string ShapeDescription { get; set; }
        public bool Active { get; set; }
        public DateTime Added { get; set; }
        public int? AddedByUserId { get; set; }
        public DateTime? Updated { get; set; }
        public int? UpdatedByUserId { get; set; }
    }
}
