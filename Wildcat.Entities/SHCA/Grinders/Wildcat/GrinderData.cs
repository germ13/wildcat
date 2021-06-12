﻿using System;

namespace Wildcat.Entities.SHCA.Grinders.Wildcat
{
    public partial class GrinderData
    {
        public Guid Id { get; set; }
        public long KepwareId { get; set; }
        public string Name { get; set; }
        public string Property { get; set; }
        public string Numericid { get; set; }
        public string Value { get; set; }
        public DateTime? Timestamp { get; set; }
        public int? Quality { get; set; }
        public bool Active { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Rowversion { get; set; }
    }
}