using System;

namespace Wildcat.Entities.SHCA.Grinders.FGQ
{
    public partial class GrinderDTOQ
    {
        public string Name { get; set; }
        public int? Numericid { get; set; }
        public string Value { get; set; }
        public DateTime? Timestamp { get; set; }
        public int? Quality { get; set; }
    }
}
