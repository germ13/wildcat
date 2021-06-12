using System;

namespace Wildcat.Entities.SHCA.Grinders.FGA
{
    public partial class TFga
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int? Numericid { get; set; }
        public string Value { get; set; }
        public DateTime? Timestamp { get; set; }
        public int? Quality { get; set; }
    }
}
