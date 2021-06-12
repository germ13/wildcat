using System;

namespace Wildcat.Entities.SHCA.Engineering.FUP
{
    public partial class TFup
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int? Numericid { get; set; }
        public string Value { get; set; }
        public DateTime? Timestamp { get; set; }
        public int? Quality { get; set; }
    }
}
