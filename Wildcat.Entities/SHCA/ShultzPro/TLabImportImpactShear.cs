﻿using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TLabImportImpactShear
    {
        public Guid SShearGuid { get; set; }
        public Guid SImpactGuid { get; set; }
        public string SRecId { get; set; }
        public decimal? DblMinReq { get; set; }
        public decimal? DblMaxReq { get; set; }
        public decimal? DblShear { get; set; }
        public bool? BConforms { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TLabImportImpact SImpactGu { get; set; }
    }
}
