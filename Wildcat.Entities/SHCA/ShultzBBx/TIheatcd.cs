﻿using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TIheatcd
    {
        public int IRecId { get; set; }
        public string Skey { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}