﻿using System;

namespace Wildcat.Entities.SHCA.Grinders.FGX
{
    public partial class GrinderDTOX
    {
        public string Name { get; set; }
        public int? Numericid { get; set; }
        public string Value { get; set; }
        public DateTime? Timestamp { get; set; }
        public int? Quality { get; set; }
    }
}
