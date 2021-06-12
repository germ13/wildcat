﻿using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class THelpDeskRequestDependency
    {
        public Guid SLinkGuid { get; set; }
        public Guid SParentRequestGuid { get; set; }
        public Guid SChildRequestGuid { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}