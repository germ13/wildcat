﻿using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TLabImportMicroMetallurgy
    {
        public TLabImportMicroMetallurgy()
        {
            TLabImportMicroMetallurgyResult = new HashSet<TLabImportMicroMetallurgyResult>();
        }

        public Guid SMicroMetallurgyGuid { get; set; }
        public Guid STestGuid { get; set; }
        public string SDescription { get; set; }
        public string SSpecimenNumber { get; set; }
        public bool? BConforms { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TLabImportTest STestGu { get; set; }
        public ICollection<TLabImportMicroMetallurgyResult> TLabImportMicroMetallurgyResult { get; set; }
    }
}