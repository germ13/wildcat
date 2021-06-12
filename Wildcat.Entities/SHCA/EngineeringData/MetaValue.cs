﻿using System;

namespace Wildcat.Entities.SHCA.EngineeringData
{
    public partial class MetaValue
    {
        public Guid Id { get; set; }
        public Guid MetaPropertyId { get; set; }
        public string MetaValue1 { get; set; }
        public bool? Active { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Rowversion { get; set; }
    }
}