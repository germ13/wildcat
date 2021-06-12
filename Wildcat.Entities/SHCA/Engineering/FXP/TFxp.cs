using System;

namespace Wildcat.Entities.SHCA.Engineering.FXP
{
    public partial class TFxp
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int? Numericid { get; set; }
        public string Value { get; set; }
        public DateTime? Timestamp { get; set; }
        public int? Quality { get; set; }
    }
}
